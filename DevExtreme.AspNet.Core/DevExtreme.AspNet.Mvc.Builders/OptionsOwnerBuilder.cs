using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Newtonsoft.Json.Linq;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// 控件可选项拥有者创建者
	/// </summary>
	public abstract class OptionsOwnerBuilder
	{
		private OptionsOwnerContext _context;

		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		public OptionsOwnerBuilder(OptionsOwnerContext context)
		{
			_context = context;
		}

		/// <summary>
		/// 对应的Js控件名称
		/// </summary>
		protected string JsName => _context.JsName;

		/// <summary>
		/// 拥有者
		/// </summary>
		private OptionsOwnerBuilder Owner => _context.Owner;

		/// <summary>
		/// Html适配器
		/// </summary>
		protected IHtmlHelperAdapter HtmlHelperAdapter => _context.Html;

		/// <summary>
		/// 视图上下文
		/// </summary>
		protected ViewContext ViewContext => _context.Html.ViewContext;

		/// <summary>
		/// 可选项字典
		/// </summary>
		internal IDictionary<string, object> Options
		{
			get;
			private set;
		} = new Dictionary<string, object>();

		/// <summary>
		/// 排除内容
		/// </summary>
		protected string TranscludedContent
		{
			get;
			private set;
		}

		/// <summary>
		/// 全局可选项
		/// </summary>
		protected GlobalOptions Globals => GlobalOptions.Get(ViewContext.HttpContext);

		/// <summary>
		/// 是否可合并
		/// </summary>
		protected virtual bool IsMergable => false;

		/// <summary>
		/// 创建子控件可选上下文
		/// </summary>
		/// <param name="jsName"></param>
		/// <returns></returns>
		protected OptionsOwnerContext CreateChildContext(string jsName)
		{
			return new OptionsOwnerContext(jsName, this, _context.Html);
		}

		protected internal virtual void AttachCollectionItemToParent(IDictionary<string, object> parentOptions)
		{
			this.AttachCollectionItem(parentOptions, JsName, Options);
		}

		protected internal virtual void AttachNestedOptionsToParent(IDictionary<string, object> parentOptions)
		{
			if (IsMergable)
			{
				if (!parentOptions.ContainsKey(JsName))
				{
					parentOptions[JsName] = new Dictionary<string, object>();
				}
				IDictionary<string, object> dictionary = (IDictionary<string, object>)parentOptions[JsName];
				foreach (string key in Options.Keys)
				{
					dictionary[key] = Options[key];
				}
			}
			else if (Options.Count > 0)
			{
				parentOptions[JsName] = Options;
			}
		}

		protected internal void NestedOptions<T>(string optionName, Action<T> childConfigurator) where T : OptionsOwnerBuilder
		{
			if (childConfigurator != null)
			{
				T val = New.Options<T>(CreateChildContext(optionName));
				childConfigurator(val);
				WidgetBuilder widgetBuilder = val as WidgetBuilder;
				if (widgetBuilder != null)
				{
					AssignNestedWidgetBuilderID(widgetBuilder.InternalID, widgetBuilder.Options);
				}
				val.AttachNestedOptionsToParent(Options);
			}
		}

		protected internal void CustomCollection<F>(string optionName, Action<F> configurator) where F : AbstractCollectionFactory
		{
			if (configurator != null)
			{
				F val = New.CollectionFactory<F>(CreateChildContext(optionName));
				configurator(val);
				val.AttachToParent(Options);
			}
		}

		protected internal void Collection<T>(string optionName, Action<CollectionFactory<T>> configurator) where T : OptionsOwnerBuilder, ICollectionItem
		{
			CustomCollection(optionName, configurator);
		}

		protected internal void NestedWidget<F>(Func<F, WidgetBuilder> configurator, string widgetOptionName, string optionsOptionName) where F : AbstractWidgetFactory
		{
			F arg = New.WidgetFactory<F>(this, _context.Html);
			WidgetBuilder widgetBuilder = configurator(arg);
			string jsName = widgetBuilder.JsName;
			AssignNestedWidgetBuilderID(widgetBuilder.InternalID, widgetBuilder.Options);
			Options[optionsOptionName] = widgetBuilder.Options;
			Options[widgetOptionName] = jsName;
		}

		private static void AssignNestedWidgetBuilderID(ComponentID id, IDictionary<string, object> options)
		{
			if (id.IsAssigned)
			{
				if (!options.ContainsKey("elementAttr"))
				{
					options["elementAttr"] = new Dictionary<string, object>();
				}
				(options["elementAttr"] as Dictionary<string, object>)["id"] = id.ToJS();
			}
		}

		protected internal void DataSource(string optionName, Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSourceFactory arg = new DataSourceFactory(CreateChildContext(optionName));
			configurator(arg).AttachNestedOptionsToParent(Options);
		}

		protected internal void AssignDataSourceOptions<T>(Action<T> configurator) where T : OptionsOwnerBuilder
		{
			if (Options.ContainsKey("dataSource") && Options["dataSource"] is JS)
			{
				throw new InvalidOperationException("DataSourceOptions cannot be defined if the DataSource is bound to a JS variable. Declare these options in an object assigned to this variable instead.");
			}
			NestedOptions("dataSource", configurator);
		}

		protected internal virtual void AssignTemplate(string optionName, string value)
		{
			if (value != null)
			{
				string fullTemplateName = GetFullTemplateName(optionName);
				Globals.Templates.RemoveAll((Tuple<string, string> i) => i.Item1 == fullTemplateName);
				Globals.Templates.Add(Tuple.Create(fullTemplateName, value));
				AssignTemplate(optionName, new TemplateName(fullTemplateName));
			}
		}

		protected internal void AssignTemplate(string optionName, RazorBlock block)
		{
			Globals.EnterTemplate();
			try
			{
				AssignTemplate(optionName, UnwrapRazorBlock(block));
			}
			finally
			{
				Globals.LeaveTemplate();
			}
		}

		protected internal virtual void AssignTemplate(string optionName, TemplateName name)
		{
			Options[optionName] = new JRaw(Renderer.FormatJQueryByID(name.Name));
		}

		protected internal void AssignContent(string content)
		{
			TranscludedContent = content;
		}

		protected internal void AssignContent(RazorBlock content)
		{
			AssignContent(UnwrapRazorBlock(content));
		}

		protected internal void AssignJS(string optionName, string optionValue)
		{
			if (optionValue != null)
			{
				Options[optionName] = new JS(optionValue);
			}
		}

		protected internal string UnwrapJavaScriptFunc(RazorBlock block)
		{
			return Regex.Replace(UnwrapRazorBlock(block).Trim(), "^\\<script.*?\\>|\\</script\\>$", "");
		}

		private string UnwrapRazorBlock(RazorBlock block)
		{
			return RunWithSingleWriter(delegate(TextWriter writer)
			{
				Portability.RenderHtmlString(block(null), writer);
			});
		}

		protected IDictionary<string, object> AnonymousObjectToHtmlAttributes(object htmlAttributes)
		{
			return HtmlHelper.AnonymousObjectToHtmlAttributes(htmlAttributes);
		}

		private string RunWithSingleWriter(Action<TextWriter> action)
		{
			Stack<TextWriter> outputStack = _context.Html.OutputStack;
			TextWriter writer = ViewContext.Writer;
			using (StringWriter stringWriter = new StringWriter())
			{
				ViewContext.Writer = stringWriter;
				outputStack?.Push(stringWriter);
				try
				{
					action(stringWriter);
					return stringWriter.ToString();
				}
				finally
				{
					ViewContext.Writer = writer;
					outputStack?.Pop();
				}
			}
		}

		private string GetFullTemplateName(string templateName)
		{
			List<string> list = new List<string>
			{
				templateName
			};
			OptionsOwnerBuilder optionsOwnerBuilder = this;
			while (optionsOwnerBuilder.Owner != null)
			{
				string text = optionsOwnerBuilder.JsName;
				ICollectionItem collectionItem = optionsOwnerBuilder as ICollectionItem;
				if (collectionItem != null)
				{
					int num = collectionItem.Index;
					IDictionary<string, object> options = optionsOwnerBuilder.Owner.Options;
					if (options.ContainsKey(text))
					{
						num += (options[text] as ICollection).Count;
					}
					text += num.ToString();
				}
				list.Insert(0, text);
				optionsOwnerBuilder = optionsOwnerBuilder.Owner;
			}
			WidgetBuilder widgetBuilder = (WidgetBuilder)optionsOwnerBuilder;
			list.Insert(0, widgetBuilder.InternalID.GetStatic());
			return string.Join("-", list);
		}

		internal bool HasParentOwner(string[] names)
		{
			return HasParentOwner(Owner, names);
		}

		private bool HasParentOwner(OptionsOwnerBuilder owner, string[] names)
		{
			if (owner == null)
			{
				return false;
			}
			if (names.Contains(owner.JsName))
			{
				return true;
			}
			return HasParentOwner(owner.Owner, names);
		}

		internal static IDictionary<string, object> GetNestedOptions(IDictionary<string, object> options, string name)
		{
			if (!options.ContainsKey(name))
			{
				options.Add(name, new Dictionary<string, object>());
			}
			return options[name] as IDictionary<string, object>;
		}
	}
}
