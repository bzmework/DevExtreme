using DevExtreme.AspNet.Mvc.Internals;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public abstract class WidgetBuilder : OptionsOwnerBuilder, IHtmlContent
	{
		private string _currentValidationGroup;

		private bool _declaredInTemplate;

		private IEnumerable<IDictionary<string, object>> _validationRules;

		internal readonly ComponentID InternalID;

		internal IEnumerable<IDictionary<string, object>> ValidationRules
		{
			get
			{
				if (_validationRules == null && base.Options.ContainsKey("name"))
				{
					return DataAnnotationsHelper.GetValidationRulesByPropertyName(base.Options["name"] as string, base.ViewContext);
				}
				return _validationRules;
			}
			set
			{
				_validationRules = value;
			}
		}

		public WidgetBuilder(OptionsOwnerContext context)
			: base(context)
		{
			InternalID = new ComponentID(base.Globals.NextSerial());
			_currentValidationGroup = base.Globals.CurrentValidationGroup;
			_declaredInTemplate = base.Globals.InTemplate();
		}

		protected virtual void OnBeforeRendering()
		{
			if (!base.Options.ContainsKey("name"))
			{
				return;
			}
			string text = base.Options["name"] as string;
			if (text != null)
			{
				string fullHtmlFieldName = base.ViewContext.ViewData.TemplateInfo.GetFullHtmlFieldName(text);
				base.Options["name"] = fullHtmlFieldName;
				if (!base.Options.ContainsKey("inputAttr"))
				{
					base.Options["inputAttr"] = new Dictionary<string, object>();
				}
				IDictionary<string, object> dictionary = base.Options["inputAttr"] as IDictionary<string, object>;
				if (!dictionary.ContainsKey("id"))
				{
					dictionary["id"] = base.HtmlHelperAdapter.GenerateIdFromName(fullHtmlFieldName);
				}
				if (base.ViewContext.ViewData.ModelState.TryGetValue(fullHtmlFieldName, out ModelStateEntry value) && value.Errors.Count > 0)
				{
					base.Options["isValid"] = false;
					base.Options["validationError"] = new
					{
						message = value.Errors.First().ErrorMessage
					};
				}
			}
		}

		protected void AppendValidationGroup()
		{
			if (!base.Options.ContainsKey("validationGroup") && !string.IsNullOrEmpty(_currentValidationGroup))
			{
				base.Options["validationGroup"] = _currentValidationGroup;
			}
		}

		private string RenderCore()
		{
			bool flag = Portability.GetFormValue(base.ViewContext, "DXCallbackName") != null;
			Renderer renderer = new Renderer
			{
				PluginName = base.JsName,
				ElementID = InternalID,
				Options = base.Options,
				ViewContext = base.ViewContext,
				ValidationRules = ValidationRules,
				CurrentValidationGroup = _currentValidationGroup,
				TranscludedContent = base.TranscludedContent,
				RequireStartupScriptID = flag
			};
			StringBuilder stringBuilder = new StringBuilder();
			if (_declaredInTemplate)
			{
				renderer.RenderWithUnderscore(stringBuilder);
				return stringBuilder.ToString();
			}
			if (InternalID.IsExpr)
			{
				throw new ArgumentException("The ID of a widget defined outside of a template is specified as a JS expression.");
			}
			if (!base.Globals.ConfigScriptBlockRendered)
			{
				Renderer.RenderStartupScriptOpenTag(stringBuilder, flag ? "_devextreme_config_block" : null);
				stringBuilder.AppendFormat("DevExpress.config({0});DevExpress.aspnet.setTemplateEngine();</script>", JsonUtils.SafeSerialize(new Dictionary<string, object>
				{
					["serverDecimalSeparator"] = NumberFormatInfo.CurrentInfo.NumberDecimalSeparator
				}));
				base.Globals.ConfigScriptBlockRendered = true;
			}
			renderer.Templates = base.Globals.Templates.ToArray();
			base.Globals.Templates.Clear();
			renderer.RenderWithStaticMarkup(stringBuilder);
			return stringBuilder.ToString();
		}

		private string RenderComponent()
		{
			OnBeforeRendering();
			return RenderCore();
		}

		public override string ToString()
		{
			return RenderComponent();
		}

		public void Render()
		{
			base.ViewContext.Writer.Write(RenderComponent());
		}

		/// <summary>Renders the control as a template string for use in another control's template.</summary>
		public IHtmlContent ToTemplate()
		{
			_declaredInTemplate = true;
			return new HtmlString(RenderComponent());
		}

		void IHtmlContent.WriteTo(TextWriter writer, HtmlEncoder encoder)
		{
			writer.Write(RenderComponent());
		}
	}
}
