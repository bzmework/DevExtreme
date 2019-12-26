using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>
	/// Autocomplete控件是一个文本框，当用户键入时，它提供建议。 
	/// The Autocomplete widget is a textbox that provides suggestions while a user types into it.
	/// </summary>
	public class AutocompleteBuilder : WidgetBuilder
	{
		[Obsolete("displayValue选项是只读的。调用此方法不会影响控件。The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AutocompleteBuilder DisplayValue(string value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Obsolete("displayValue选项是只读的。调用此方法不会影响控件。The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public AutocompleteBuilder DisplayValue(JS value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Generated]
		public AutocompleteBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>
		/// 指定控件根元素的HTML id。 
		/// Specifies an HTML id for the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>
		/// 指定一个JS表达式，该表达式计算模板中定义的控件根元素的HTML id。 
		/// Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>
		/// 按名称指定选项。 
		/// Specifies an option by its name.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>
		/// 指定设置小部件焦点的快捷键。 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// 指定设置小部件焦点的快捷键。 
		/// Specifies the shortcut key that sets focus on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件在与用户交互时是否更改其状态。 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件在与用户交互时是否更改其状态。 
		/// Specifies whether or not the widget changes its state when interacting with a user.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 允许您将自定义按钮添加到输入文本字段。 
		/// Allows you to add custom buttons to the input text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>
		/// 允许您将自定义按钮添加到输入文本字段。 
		/// Allows you to add custom buttons to the input text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>
		/// 将控件绑定到数据源。 
		/// Binds the widget to data.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>
		/// 指定显示下拉字段时是否呈现其内容。如果为false，则立即呈现内容。
		/// Specifies whether to render the drop-down field's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// 指定显示下拉字段时是否呈现其内容。如果为false，则立即呈现内容。
		/// Specifies whether to render the drop-down field's content when it is displayed. 
		/// If false, the content is rendered immediately.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否响应用户交互。
		/// Specifies whether the widget responds to user interaction.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定下拉按钮的自定义模板。 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 指定下拉按钮的自定义模板。 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 指定下拉按钮的自定义模板。 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>
		/// 指定下拉按钮的自定义模板。 
		/// Specifies a custom template for the drop-down button.
		/// </summary>
		[Generated]
		public AutocompleteBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(string attributeName, object value)
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
		public AutocompleteBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定要附加到控件根元素的属性。 
		/// Specifies the attributes to be attached to the widget's root element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以使用键盘导航来聚焦小控件。 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否可以使用键盘导航来聚焦小控件。 
		/// Specifies whether the widget can be focused using keyboard navigation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应对数据项进行分组。 
		/// Specifies whether data items should be grouped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应对数据项进行分组。 
		/// Specifies whether data items should be grouped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>
		/// 指定组标题的自定义模板。 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 指定组标题的自定义模板。 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 指定组标题的自定义模板。 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>
		/// 指定组标题的自定义模板。 
		/// Specifies a custom template for group captions.
		/// </summary>
		[Generated]
		public AutocompleteBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的高度。 
		/// Specifies the widget's height.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停控件时出现的提示文本。 
		/// Specifies text for a hint that appears when a user pauses on the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停时控件是否更改其状态。 
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定当用户暂停时控件是否更改其状态。
		/// Specifies whether the widget changes its state when a user pauses on it.
		/// </summary>
		[Generated]
		public AutocompleteBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定要传递给基础HTML元素的属性。 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(string attributeName, object value)
		{
			base.Options["inputAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>
		/// 指定要传递给基础HTML元素的属性。 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>
		/// 指定要传递给基础HTML元素的属性。 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定要传递给基础HTML元素的属性。 
		/// Specifies the attributes to be passed on to the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>
		/// 指定或指示编辑器的值是否有效。 
		/// Specifies or indicates whether the editor's value is valid.
		/// </summary>
		[Generated]
		public AutocompleteBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>
		/// 指定或指示编辑器的值是否有效。 
		/// Specifies or indicates whether the editor's value is valid.
		/// </summary>
		[Generated]
		public AutocompleteBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>
		/// 控件显示的项目数组。 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>
		/// 控件显示的项目数组。 
		/// An array of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Items(Action<CollectionFactory<AutocompleteItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>
		/// 为项目指定自定义模板。 
		/// Specifies a custom template for items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件显示的项的最大计数。 
		/// Specifies the maximum count of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxItemCount(int value)
		{
			base.Options["maxItemCount"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件显示的项的最大计数。 
		/// Specifies the maximum count of items displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxItemCount(JS value)
		{
			base.Options["maxItemCount"] = value;
			return this;
		}

		/// <summary>
		/// 指定可以在文本框中输入的最大字符数。 
		/// Specifies the maximum number of characters you can enter into the textbox.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxLength(int value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>
		/// 指定可以在文本框中输入的最大字符数。 
		/// Specifies the maximum number of characters you can enter into the textbox.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>
		/// 开始搜索时必须在文本框中输入的最小字符数。 
		/// The minimum number of characters that must be entered into the text box to begin a search.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>
		/// 开始搜索时必须在文本框中输入的最小字符数。 
		/// The minimum number of characters that must be entered into the text box to begin a search.
		/// </summary>
		[Generated]
		public AutocompleteBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>
		/// 要分配给基础HTML元素的"name"属性的值。 
		/// The value to be assigned to the `name` attribute of the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>
		/// 要分配给基础HTML元素的"name"属性的值。 
		/// The value to be assigned to the `name` attribute of the underlying HTML element.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>
		/// 使用键盘更改文本字段内容后，当小部件失去焦点时执行的函数。 
		/// A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>
		/// 使用键盘更改文本字段内容后，当小部件失去焦点时执行的函数。
		/// A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 关闭下拉编辑器后执行的函数。 
		/// A function that is executed once the drop-down editor is closed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>
		/// 关闭下拉编辑器后执行的函数。 
		/// A function that is executed once the drop-down editor is closed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件的内容准备好并每次更改内容时执行的函数。 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件的内容准备好并每次更改内容时执行的函数。 
		/// A function that is executed when the widget's content is ready and each time the content is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件的输入被复制时执行的函数。 
		/// A function that is executed when the widget's input has been copied.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCopy(string jsFunc)
		{
			AssignJS("onCopy", jsFunc);
			return this;
		}

		/// <summary>
		/// 当小部件的输入被复制时执行的函数。 
		/// A function that is executed when the widget's input has been copied.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCopy(RazorBlock jsFunc)
		{
			return OnCopy(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件的输入被剪切时执行的函数。 
		/// A function that is executed when the widget's input has been cut.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCut(string jsFunc)
		{
			AssignJS("onCut", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件的输入被剪切时执行的函数。 
		/// A function that is executed when the widget's input has been cut.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnCut(RazorBlock jsFunc)
		{
			return OnCut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在处理控件之前执行的函数。 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>
		/// 在处理控件之前执行的函数。 
		/// A function that is executed before the widget is disposed of.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件聚焦时按下回车键时执行的一种功能。 
		/// A function that is executed when the Enter key has been pressed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件聚焦时按下回车键时执行的一种功能。 
		/// A function that is executed when the Enter key has been pressed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件获得焦点时执行的函数。 
		/// A function that is executed when the widget gets focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件获得焦点时执行的函数。 
		/// A function that is executed when the widget gets focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当控件失去焦点时执行的函数。 
		/// A function that is executed when the widget loses focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>
		/// 当控件失去焦点时执行的函数。 
		/// A function that is executed when the widget loses focus.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>
		/// JavaScript框架中用于保存控件实例的函数。 
		/// A function used in JavaScript frameworks to save the widget instance.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在控件聚焦时，每次更改小部件的输入时执行的函数。 
		/// A function that is executed each time the widget's input is changed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>
		/// 在控件聚焦时，每次更改小部件的输入时执行的函数。 
		/// A function that is executed each time the widget's input is changed while the widget is focused.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 单击或点击列表项时执行的函数。 
		/// A function that is executed when a list item is clicked or tapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>
		/// 单击或点击列表项时执行的函数。 
		/// A function that is executed when a list item is clicked or tapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当用户按键盘上的键时执行的函数。 
		/// A function that is executed when a user is pressing a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>
		/// 当用户按键盘上的键时执行的函数。 
		/// A function that is executed when a user is pressing a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当用户按键盘上的键时执行的函数。 
		/// A function that is executed when a user presses a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>
		/// 当用户按键盘上的键时执行的函数。 
		/// A function that is executed when a user presses a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 当用户释放键盘上的键时执行的函数。 
		/// A function that is executed when a user releases a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>
		/// 当用户释放键盘上的键时执行的函数。 
		/// A function that is executed when a user releases a key on the keyboard.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 打开下拉编辑器后执行的函数。 
		/// A function that is executed once the drop-down editor is opened.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>
		/// 打开下拉编辑器后执行的函数。 
		/// A function that is executed once the drop-down editor is opened.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 在控件选项更改后执行的函数。 
		/// A function that is executed after a widget option is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 粘贴控件输入时执行的函数。 
		/// A function that is executed when the widget's input has been pasted.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnPaste(string jsFunc)
		{
			AssignJS("onPaste", jsFunc);
			return this;
		}

		/// <summary>
		/// 粘贴控件输入时执行的函数。
		/// A function that is executed when the widget's input has been pasted.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnPaste(RazorBlock jsFunc)
		{
			return OnPaste(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 选择列表项或取消选择时执行的函数。 
		/// A function that is executed when a list item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 选择列表项或取消选择时执行的函数。 
		/// A function that is executed when a list item is selected or selection is canceled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 更改控件值后执行的函数。 
		/// A function that is executed after the widget's value is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>
		/// 更改控件值后执行的函数。
		/// A function that is executed after the widget's value is changed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>
		/// 指定是否显示下拉编辑器。 
		/// Specifies whether or not the drop-down editor is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否显示下拉编辑器。 
		/// Specifies whether or not the drop-down editor is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>
		/// 指定用户是否可以通过单击文本字段打开下拉列表。 
		/// Specifies whether a user can open the drop-down list by clicking a text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>
		/// 指定用户是否可以通过单击文本字段打开下拉列表。 
		/// Specifies whether a user can open the drop-down list by clicking a text field.
		/// </summary>
		[Generated]
		public AutocompleteBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>
		/// 控件值为空时控件显示的文本。 
		/// The text displayed by the widget when the widget value is empty.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>
		/// 控件值为空时控件显示的文本。 
		/// The text displayed by the widget when the widget value is empty.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>
		/// 指定编辑器是否为只读。 
		/// Specifies whether the editor is read-only.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>
		/// 指定编辑器是否为只读。 
		/// Specifies whether the editor is read-only.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>
		/// 将控件切换为从右到左的表示。 
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 将控件切换为从右到左的表示。
		/// Switches the widget to a right-to-left representation.
		/// </summary>
		[Generated]
		public AutocompleteBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>
		/// 指定数据源项字段或其值与搜索条件相比较的表达式的名称。 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>
		/// 指定数据源项字段或其值与搜索条件相比较的表达式的名称。 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定数据源项字段或其值与搜索条件相比较的表达式的名称。 
		/// Specifies the name of a data source item field or an expression whose value is compared to the search criterion.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定用于搜索控件项的比较操作。 
		/// Specifies a comparison operation used to search widget items.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchMode(DropDownSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>
		/// 指定在执行搜索之前，输入最后一个字符后的时间延迟（毫秒）。 
		/// Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 指定在执行搜索之前，输入最后一个字符后的时间延迟（毫秒）。 
		/// Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在控件中显示清除按钮。 
		/// Specifies whether to display the Clear button in the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否在控件中显示清除按钮。 
		/// Specifies whether to display the Clear button in the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>
		/// 指定下拉按钮是否可见。 
		/// Specifies whether the drop-down button is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>
		/// 指定下拉按钮是否可见。 
		/// Specifies whether the drop-down button is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否检查内部文本的拼写错误。 
		/// Specifies whether or not the widget checks the inner text for spelling mistakes.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Spellcheck(bool value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否检查内部文本的拼写错误。 
		/// Specifies whether or not the widget checks the inner text for spelling mistakes.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Spellcheck(JS value)
		{
			base.Options["spellcheck"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的文本字段的样式。 
		/// Specifies how the widget's text field is styled.
		/// </summary>
		[Generated]
		public AutocompleteBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>
		/// 指定用于导航的制表键时元素的编号。 
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AutocompleteBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// 指定用于导航的制表键时元素的编号。 
		/// Specifies the number of the element when the Tab key is used for navigating.
		/// </summary>
		[Generated]
		public AutocompleteBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>
		/// 有关已破坏的验证规则的信息。包含validationErrors数组中的第一个项。 
		/// Information on the broken validation rule. Contains the first item from the validationErrors array.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>
		/// 失败的验证规则数组。 
		/// An array of the validation rules that failed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>
		/// 失败的验证规则数组。 
		/// An array of the validation rules that failed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>
		/// 指定如何显示有关此编辑器值不满足的验证规则的消息。 
		/// Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>
		/// 指示或指定当前验证状态。 
		/// Indicates or specifies the current validation status.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件显示的当前值。 
		/// Specifies the current value displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Value(string value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件显示的当前值。 
		/// Specifies the current value displayed by the widget.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>
		/// 指定更新控件值之后的DOM事件。 
		/// Specifies the DOM events after which the widget's value should be updated.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>
		/// 指定更新控值之后的DOM事件。 
		/// Specifies the DOM events after which the widget's value should be updated.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>
		/// 指定哪个数据字段为控件的值提供唯一值。 
		/// Specifies which data field provides unique values to the widget's value.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定哪个数据字段为控件的值提供唯一值。
		/// Specifies which data field provides unique values to the widget's value.
		/// </summary>
		[Generated]
		public AutocompleteBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否可见。 
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件是否可见。 
		/// Specifies whether the widget is visible.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。 
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定控件的宽度。
		/// Specifies the widget's width.
		/// </summary>
		[Generated]
		public AutocompleteBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应包装超出下拉列表宽度的文本。 
		/// Specifies whether text that exceeds the drop-down list width should be wrapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>
		/// 指定是否应包装超出下拉列表宽度的文本。 
		/// Specifies whether text that exceeds the drop-down list width should be wrapped.
		/// </summary>
		[Generated]
		public AutocompleteBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
