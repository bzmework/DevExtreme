using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// Accordion控件件包含几个显示在另一个面板下的面板。
	/// 这些面板可以由最终用户折叠或展开，这使得这个小部件对于在有限的空间中显示信息非常有用。
	/// The Accordion widget contains several panels displayed one under another. 
	/// These panels can be collapsed or expanded by an end user, which makes this widget very useful for presenting information in a limited amount of space.
	/// </summary>
	public class AccordionBuilder : WidgetBuilder
	{
		/// <summary>
		/// 初始化
		/// </summary>
		/// <param name="context">控件可选项上下文</param>
		[Generated]
		public AccordionBuilder(OptionsOwnerContext context)
			: base(context)
		{
			//
		}

		/// <summary>
		/// 指定控件根元素的HTML id。
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// 指定一个JS表达式，该表达式计算模板中定义的小部件根元素的HTML id。 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public AccordionBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AccordionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 指定设置控件获得焦点的快捷键。
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// 指定设置控件获得焦点的快捷键。 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件在与用户交互时是否更改其状态。 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AccordionBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件在与用户交互时是否更改其状态。 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AccordionBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>A number specifying the time in milliseconds spent on the animation of the expanding or collapsing of a panel.</summary>
		[Generated]
		public AccordionBuilder AnimationDuration(double value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>
		/// 指定面板展开或折叠时，动画所用的时间（毫秒数）。 
		/// A number specifying the time in milliseconds spent on the animation of the expanding or collapsing of a panel.
		/// </summary>
		[Generated]
		public AccordionBuilder AnimationDuration(JS value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以折叠所有项，或者是否必须始终展开至少一个项。 
		/// Specifies whether all items can be collapsed or whether at least one item must always be expanded.
		/// </summary>
		[Generated]
		public AccordionBuilder Collapsible(bool value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以折叠所有项，或者是否必须始终展开至少一个项。 
		/// Specifies whether all items can be collapsed or whether at least one item must always be expanded.
		/// </summary>
		[Generated]
		public AccordionBuilder Collapsible(JS value)
		{
			base.Options["collapsible"] = value;
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AccordionBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。
		/// Binds the widget to data.
		/// </summary>
		/// <param name="staticJsonUrl">返回Json数据的Url</param>
		/// <param name="key">筛选指定key的数据</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。
		/// Binds the widget to data.
		/// </summary>
		/// <param name="data">数据，例如列表等</param>
		/// <param name="key">筛选指定key的数据</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。
		/// Binds the widget to data.
		/// </summary>
		/// <param name="js">Js脚本</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AccordionBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// 指定在显示面板内容时是否呈现该内容。如果为false，则立即呈现内容。 
		/// Specifies whether to render the panel's content when it is displayed. If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AccordionBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// 指定在显示面板内容时是否呈现该内容。如果为false，则立即呈现内容。
		/// Specifies whether to render the panel's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AccordionBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。 
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AccordionBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AccordionBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(string attributeName, object value)
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
		public AccordionBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AccordionBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以使用键盘导航来聚焦控件。 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AccordionBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以使用键盘导航来聚焦控件。 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AccordionBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AccordionBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停时控件是否更改其状态。 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AccordionBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停时控件是否更改其状态。 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AccordionBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 引发onItemHold事件之前的时间段（毫秒数）。 
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public AccordionBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 引发onItemHold事件之前的时间段（毫秒数）。
		/// The time period in milliseconds before the onItemHold event is raised.
		/// </summary>
		[Generated]
		public AccordionBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 控件显示的项目数组。 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AccordionBuilder Items(Action<CollectionFactory<AccordionItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// 为项指定自定义模板。 
		/// Specifies a custom template for items.
		/// <param name="templateContent">模板内容</param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项指定自定义模板。 
		/// Specifies a custom template for items.
		/// <param name="templateContent">模板内容，一个Razor Block</param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		/// <param name="name">模板名称</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// 为项指定自定义模板。 
		/// Specifies a custom template for items.
		/// <param name="value"></param>
		/// <returns></returns>
		/// </summary>
		[Generated]
		public AccordionBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 为项目标题指定自定义模板。 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="templateContent">模板内容</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(string templateContent)
		{
			AssignTemplate("itemTitleTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目标题指定自定义模板。 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="templateContent">模板内容，一个Razor Block</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTitleTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目标题指定自定义模板。 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="name">模板名称</param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(TemplateName name)
		{
			AssignTemplate("itemTitleTemplate", name);
			return this;
		}

		/// <summary>
		/// 为项目标题指定自定义模板。 
		/// Specifies a custom template for item titles.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder ItemTitleTemplate(JS value)
		{
			base.Options["itemTitleTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 指定哪个数据字段为控件项提供键。 
		/// Specifies which data field provides keys for widget items.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定哪个数据字段为控件项提供键。 
		/// Specifies which data field provides keys for widget items.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是可以同时展开多个项，还是只能展开单个项。
		/// Specifies whether the widget can expand several items or only a single item at once.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder Multiple(bool value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是可以同时展开多个项，还是只能展开单个项。
		/// Specifies whether the widget can expand several items or only a single item at once.
		/// </summary>
		/// <param name="value"></param>
		/// <returns></returns>
		[Generated]
		public AccordionBuilder Multiple(JS value)
		{
			base.Options["multiple"] = value;
			return this;
		}

		/// <summary>
		/// 如果项目集合为空，控件显示的文本或HTML标记。
		/// The text or HTML markup displayed by the widget if the item collection is empty.
		/// </summary>
		[Generated]
		public AccordionBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>
		/// 如果项目集合为空，控件显示的文本或HTML标记。
		/// The text or HTML markup displayed by the widget if the item collection is empty.
		/// </summary>
		[Generated]
		public AccordionBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>
		/// 一个函数，当控件的内容准备好并在每次内容更改时执行。
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// 一个函数，当控件的内容准备好并在每次内容更改时执行。
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在处理控件之前执行的函数。
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AccordionBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// 在处理控件之前执行的函数。
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AccordionBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AccordionBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AccordionBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在单击或轻击集合项时执行的函数。
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 在单击或轻击集合项时执行的函数。
		/// A function that is executed when a collection item is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 右击或按下集合项时执行的函数。
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>
		/// 右击或按下集合项时执行的函数。
		/// A function that is executed when a collection item is right-clicked or pressed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 一个函数，当一个集合项被保持一段指定的时间后执行。
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>
		/// 一个函数，当一个集合项被保持一段指定的时间后执行。
		/// A function that is executed when a collection item has been held for a specified period.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在呈现集合项后执行的函数。
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>
		/// 在呈现集合项后执行的函数。
		/// A function that is executed after a collection item is rendered.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在单击或轻击手风琴项的标题时执行的函数。
		/// A function that is executed when an accordion item's title is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemTitleClick(string jsFunc)
		{
			AssignJS("onItemTitleClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 在单击或轻击手风琴项的标题时执行的函数。
		/// A function that is executed when an accordion item's title is clicked or tapped.
		/// </summary>
		[Generated]
		public AccordionBuilder OnItemTitleClick(RazorBlock jsFunc)
		{
			return OnItemTitleClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AccordionBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在选择集合项或取消选择时执行的函数。
		/// A function that is executed when a collection item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AccordionBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 在选择集合项或取消选择时执行的函数。
		/// A function that is executed when a collection item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AccordionBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 指定是否仅重新绘制其数据已更改的元素。
		/// Specifies whether to repaint only those elements whose data changed.
		/// </summary>
		[Generated]
		public AccordionBuilder RepaintChangesOnly(bool value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否仅重新绘制其数据已更改的元素。
		/// Specifies whether to repaint only those elements whose data changed.
		/// </summary>
		[Generated]
		public AccordionBuilder RepaintChangesOnly(JS value)
		{
			base.Options["repaintChangesOnly"] = value;
			return this;
		}

		/// <summary>
		/// 将控件切换为从右到左的表示形式。
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AccordionBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 将控件切换为从右到左的表示形式。
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AccordionBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 当前选择项的索引号。
		/// The index number of the currently selected item.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>
		/// 当前选择项的索引号。
		/// The index number of the currently selected item.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>
		/// 选定的项目对象。
		/// The selected item object.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>
		/// 指定当前选定项目键的数组。
		/// Specifies an array of currently selected item keys.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>
		/// 指定当前选定项目键的数组。
		/// Specifies an array of currently selected item keys.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>
		/// 当前选择的项对象的数组。
		/// An array of currently selected item objects.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>
		/// 当前选择的项对象的数组。
		/// An array of currently selected item objects.
		/// </summary>
		[Generated]
		public AccordionBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>
		/// 指定使用Tab键进行导航时元素的索引。
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AccordionBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// 指定使用Tab键进行导航时元素的索引。
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AccordionBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否可见。
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AccordionBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否可见。
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AccordionBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AccordionBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
