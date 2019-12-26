using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// ActionSheet控件是一个包含一组按钮的工作表，这些按钮一个在另一个的下面。
	/// 这些按钮通常表示与单个任务相关的多个选择。
	/// The ActionSheet widget is a sheet containing a set of buttons located one under the other. 
	/// These buttons usually represent several choices relating to a single task.
	/// </summary>
	public class ActionSheetBuilder : WidgetBuilder
	{
		/// <summary>
		/// 初始话
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		[Generated]
		public ActionSheetBuilder(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// 指定控件根元素的HTML id。 
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// 指定一个JS表达式，该表达式计算模板中定义的控件根元素的HTML id。 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 关闭操作表的按钮中显示的文本。 
		/// The text displayed in the button that closes the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder CancelText(string value)
		{
			base.Options["cancelText"] = value;
			return this;
		}

		/// <summary>
		/// 关闭操作表的按钮中显示的文本。 
		/// The text displayed in the button that closes the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder CancelText(JS value)
		{
			base.Options["cancelText"] = value;
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public ActionSheetBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停时控件是否更改其状态。 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public ActionSheetBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		///  指定当用户暂停时控件是否更改其状态。 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public ActionSheetBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 引发onItemHold事件之前的时间段（毫秒）。 
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 引发onItemHold事件之前的时间段（毫秒）。
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 控件显示的项目数组。 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Items(Action<CollectionFactory<ActionSheetItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 单击或点击取消按钮时执行的一种功能。 
		/// A function that is executed when the Cancel button is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnCancelClick(string jsFunc)
		{
			AssignJS("onCancelClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 单击或点击取消按钮时执行的一种功能。 
		/// A function that is executed when the Cancel button is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnCancelClick(RazorBlock jsFunc)
		{
			return OnCancelClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件的内容准备好并每次更改内容时执行的函数。 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件的内容准备好并每次更改内容时执行的函数。 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在处理控件之前执行的函数。 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// 在处理控件之前执行的函数。 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 一种在点击或点击一个集合项时执行的函数。 
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 一种在点击或点击一个集合项时执行的函数。 
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 右键单击或按集合项时执行的函数。 
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>
		/// 右键单击或按集合项时执行的函数。 
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当集合项被保留了一段时间时执行的函数。 
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>
		/// 当集合项被保留了一段时间时执行的函数。 
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 呈现集合项后执行的函数。 
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>
		/// 呈现集合项后执行的函数。 
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public ActionSheetBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 将控件切换为从右到左的表示。 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public ActionSheetBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 将控件切换为从右到左的表示。 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public ActionSheetBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在操作表中显示"取消"按钮。 
		/// Specifies whether or not to display the Cancel button in action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowCancelButton(bool value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在操作表中显示"取消"按钮。
		/// Specifies whether or not to display the Cancel button in action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowCancelButton(JS value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>
		/// 一个布尔值，指定操作表的标题是否可见。 
		/// A Boolean value specifying whether or not the title of the action sheet is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowTitle(bool value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>
		/// 一个布尔值，指定操作表的标题是否可见。 
		/// A Boolean value specifying whether or not the title of the action sheet is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder ShowTitle(JS value)
		{
			base.Options["showTitle"] = value;
			return this;
		}

		/// <summary>
		/// 指定操作表弹出点所在的元素。仅当usePopover为真时才适用。 
		/// Specifies the element the action sheet popover points at. Applies only if usePopover is true.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Target(string value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>
		/// 指定操作表弹出点所在的元素。仅当usePopover为真时才适用。 
		/// Specifies the element the action sheet popover points at. Applies only if usePopover is true.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Target(JS value)
		{
			base.Options["target"] = value;
			return this;
		}

		/// <summary>
		/// 动作表的标题。 
		/// The title of the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// 动作表的标题。 
		/// The title of the action sheet.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在弹出窗口控件中显示操作表。 
		/// Specifies whether or not to show the action sheet within a Popover widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder UsePopover(bool value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在弹出窗口控件中显示操作表。 
		/// Specifies whether or not to show the action sheet within a Popover widget.
		/// </summary>
		[Generated]
		public ActionSheetBuilder UsePopover(JS value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>
		/// 一个布尔值，指定ActionSheet小部件是否可见。 
		/// A Boolean value specifying whether or not the ActionSheet widget is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 一个布尔值，指定ActionSheet小部件是否可见。 
		/// A Boolean value specifying whether or not the ActionSheet widget is visible.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public ActionSheetBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
