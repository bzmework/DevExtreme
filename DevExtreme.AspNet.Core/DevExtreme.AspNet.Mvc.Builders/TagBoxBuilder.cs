using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The TagBox widget is an editor that allows an end user to select multiple items from a drop-down list.</summary>
	public class TagBoxBuilder : WidgetBuilder
	{
		[Generated]
		public TagBoxBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public TagBoxBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public TagBoxBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TagBoxBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value. Requires the onCustomItemCreating handler implementation.</summary>
		[Generated]
		public TagBoxBuilder AcceptCustomValue(bool value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget allows a user to enter a custom value. Requires the onCustomItemCreating handler implementation.</summary>
		[Generated]
		public TagBoxBuilder AcceptCustomValue(JS value)
		{
			base.Options["acceptCustomValue"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TagBoxBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public TagBoxBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TagBoxBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public TagBoxBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies how the widget applies values.</summary>
		[Generated]
		public TagBoxBuilder ApplyValueMode(EditorApplyValueMode value)
		{
			base.Options["applyValueMode"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public TagBoxBuilder Buttons(IEnumerable<DropDownEditorButtonName> value)
		{
			base.Options["buttons"] = value;
			return this;
		}

		/// <summary>Allows you to add custom buttons to the input text field.</summary>
		[Generated]
		public TagBoxBuilder Buttons(Action<CollectionFactory<TextEditorButtonBuilder>> configurator)
		{
			Collection("buttons", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TagBoxBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TagBoxBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TagBoxBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TagBoxBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public TagBoxBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public TagBoxBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public TagBoxBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TagBoxBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public TagBoxBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public TagBoxBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public TagBoxBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public TagBoxBuilder DropDownButtonTemplate(string templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public TagBoxBuilder DropDownButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownButtonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public TagBoxBuilder DropDownButtonTemplate(TemplateName name)
		{
			AssignTemplate("dropDownButtonTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the drop-down button.</summary>
		[Generated]
		public TagBoxBuilder DropDownButtonTemplate(JS value)
		{
			base.Options["dropDownButtonTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TagBoxBuilder ElementAttr(string attributeName, object value)
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

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TagBoxBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TagBoxBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public TagBoxBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public TagBoxBuilder FieldTemplate(string templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public TagBoxBuilder FieldTemplate(RazorBlock templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public TagBoxBuilder FieldTemplate(TemplateName name)
		{
			AssignTemplate("fieldTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the text field. Must contain the TextBox widget.</summary>
		[Generated]
		public TagBoxBuilder FieldTemplate(JS value)
		{
			base.Options["fieldTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TagBoxBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public TagBoxBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public TagBoxBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies whether data items should be grouped.</summary>
		[Generated]
		public TagBoxBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public TagBoxBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public TagBoxBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public TagBoxBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public TagBoxBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TagBoxBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TagBoxBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public TagBoxBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to hide selected items.</summary>
		[Generated]
		public TagBoxBuilder HideSelectedItems(bool value)
		{
			base.Options["hideSelectedItems"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to hide selected items.</summary>
		[Generated]
		public TagBoxBuilder HideSelectedItems(JS value)
		{
			base.Options["hideSelectedItems"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TagBoxBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public TagBoxBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TagBoxBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public TagBoxBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder InputAttr(string attributeName, object value)
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

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public TagBoxBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public TagBoxBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public TagBoxBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public TagBoxBuilder Items(Action<CollectionFactory<TagBoxItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TagBoxBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TagBoxBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TagBoxBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public TagBoxBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the limit on displayed tags. On exceeding it, the widget replaces all tags with a single multi-tag that displays the number of selected items.</summary>
		[Generated]
		public TagBoxBuilder MaxDisplayedTags(int value)
		{
			base.Options["maxDisplayedTags"] = value;
			return this;
		}

		/// <summary>Specifies the limit on displayed tags. On exceeding it, the widget replaces all tags with a single multi-tag that displays the number of selected items.</summary>
		[Generated]
		public TagBoxBuilder MaxDisplayedTags(JS value)
		{
			base.Options["maxDisplayedTags"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public TagBoxBuilder MaxLength(double value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public TagBoxBuilder MaxLength(string value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>Specifies the maximum number of characters you can enter into the textbox.</summary>
		[Generated]
		public TagBoxBuilder MaxLength(JS value)
		{
			base.Options["maxLength"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public TagBoxBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public TagBoxBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is multiline.</summary>
		[Generated]
		public TagBoxBuilder Multiline(bool value)
		{
			base.Options["multiline"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget is multiline.</summary>
		[Generated]
		public TagBoxBuilder Multiline(JS value)
		{
			base.Options["multiline"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public TagBoxBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TagBoxBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public TagBoxBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnChange(string jsFunc)
		{
			AssignJS("onChange", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus after the text field's content was changed using the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnChange(RazorBlock jsFunc)
		{
			return OnChange(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public TagBoxBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public TagBoxBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TagBoxBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public TagBoxBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user adds a custom item. Requires acceptCustomValue to be set to true.</summary>
		[Generated]
		public TagBoxBuilder OnCustomItemCreating(string jsFunc)
		{
			AssignJS("onCustomItemCreating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user adds a custom item. Requires acceptCustomValue to be set to true.</summary>
		[Generated]
		public TagBoxBuilder OnCustomItemCreating(RazorBlock jsFunc)
		{
			return OnCustomItemCreating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TagBoxBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public TagBoxBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public TagBoxBuilder OnEnterKey(string jsFunc)
		{
			AssignJS("onEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while the widget is focused.</summary>
		[Generated]
		public TagBoxBuilder OnEnterKey(RazorBlock jsFunc)
		{
			return OnEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public TagBoxBuilder OnFocusIn(string jsFunc)
		{
			AssignJS("onFocusIn", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget gets focus.</summary>
		[Generated]
		public TagBoxBuilder OnFocusIn(RazorBlock jsFunc)
		{
			return OnFocusIn(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public TagBoxBuilder OnFocusOut(string jsFunc)
		{
			AssignJS("onFocusOut", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget loses focus.</summary>
		[Generated]
		public TagBoxBuilder OnFocusOut(RazorBlock jsFunc)
		{
			return OnFocusOut(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TagBoxBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public TagBoxBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public TagBoxBuilder OnInput(string jsFunc)
		{
			AssignJS("onInput", jsFunc);
			return this;
		}

		/// <summary>A function that is executed each time the widget's input is changed while the widget is focused.</summary>
		[Generated]
		public TagBoxBuilder OnInput(RazorBlock jsFunc)
		{
			return OnInput(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public TagBoxBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public TagBoxBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyDown(string jsFunc)
		{
			AssignJS("onKeyDown", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user is pressing a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyDown(RazorBlock jsFunc)
		{
			return OnKeyDown(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyPress(string jsFunc)
		{
			AssignJS("onKeyPress", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user presses a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyPress(RazorBlock jsFunc)
		{
			return OnKeyPress(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyUp(string jsFunc)
		{
			AssignJS("onKeyUp", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user releases a key on the keyboard.</summary>
		[Generated]
		public TagBoxBuilder OnKeyUp(RazorBlock jsFunc)
		{
			return OnKeyUp(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the multi-tag is rendered.</summary>
		[Generated]
		public TagBoxBuilder OnMultiTagPreparing(string jsFunc)
		{
			AssignJS("onMultiTagPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the multi-tag is rendered.</summary>
		[Generated]
		public TagBoxBuilder OnMultiTagPreparing(RazorBlock jsFunc)
		{
			return OnMultiTagPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public TagBoxBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public TagBoxBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TagBoxBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public TagBoxBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if showSelectionControls is true.</summary>
		[Generated]
		public TagBoxBuilder OnSelectAllValueChanged(string jsFunc)
		{
			AssignJS("onSelectAllValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "Select All" check box value is changed. Applies only if showSelectionControls is true.</summary>
		[Generated]
		public TagBoxBuilder OnSelectAllValueChanged(RazorBlock jsFunc)
		{
			return OnSelectAllValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public TagBoxBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public TagBoxBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public TagBoxBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public TagBoxBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public TagBoxBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public TagBoxBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public TagBoxBuilder OpenOnFieldClick(bool value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can open the drop-down list by clicking a text field.</summary>
		[Generated]
		public TagBoxBuilder OpenOnFieldClick(JS value)
		{
			base.Options["openOnFieldClick"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the select box editor.</summary>
		[Generated]
		public TagBoxBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the select box editor.</summary>
		[Generated]
		public TagBoxBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public TagBoxBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the editor is read-only.</summary>
		[Generated]
		public TagBoxBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TagBoxBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public TagBoxBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow searching.</summary>
		[Generated]
		public TagBoxBuilder SearchEnabled(bool value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow searching.</summary>
		[Generated]
		public TagBoxBuilder SearchEnabled(JS value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public TagBoxBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public TagBoxBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public TagBoxBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search widget items.</summary>
		[Generated]
		public TagBoxBuilder SearchMode(DropDownSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public TagBoxBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public TagBoxBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the mode in which all items are selected.</summary>
		[Generated]
		public TagBoxBuilder SelectAllMode(SelectAllMode value)
		{
			base.Options["selectAllMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public TagBoxBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Clear button in the widget.</summary>
		[Generated]
		public TagBoxBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public TagBoxBuilder ShowDataBeforeSearch(bool value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public TagBoxBuilder ShowDataBeforeSearch(JS value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public TagBoxBuilder ShowDropDownButton(bool value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the drop-down button is visible.</summary>
		[Generated]
		public TagBoxBuilder ShowDropDownButton(JS value)
		{
			base.Options["showDropDownButton"] = value;
			return this;
		}

		/// <summary>Specifies whether the multi-tag is shown without ordinary tags.</summary>
		[Generated]
		public TagBoxBuilder ShowMultiTagOnly(bool value)
		{
			base.Options["showMultiTagOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the multi-tag is shown without ordinary tags.</summary>
		[Generated]
		public TagBoxBuilder ShowMultiTagOnly(JS value)
		{
			base.Options["showMultiTagOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display selection controls.</summary>
		[Generated]
		public TagBoxBuilder ShowSelectionControls(bool value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display selection controls.</summary>
		[Generated]
		public TagBoxBuilder ShowSelectionControls(JS value)
		{
			base.Options["showSelectionControls"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public TagBoxBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TagBoxBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public TagBoxBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for tags.</summary>
		[Generated]
		public TagBoxBuilder TagTemplate(string templateContent)
		{
			AssignTemplate("tagTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tags.</summary>
		[Generated]
		public TagBoxBuilder TagTemplate(RazorBlock templateContent)
		{
			AssignTemplate("tagTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tags.</summary>
		[Generated]
		public TagBoxBuilder TagTemplate(TemplateName name)
		{
			AssignTemplate("tagTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for tags.</summary>
		[Generated]
		public TagBoxBuilder TagTemplate(JS value)
		{
			base.Options["tagTemplate"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public TagBoxBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public TagBoxBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public TagBoxBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public TagBoxBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public TagBoxBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the selected items.</summary>
		[Generated]
		public TagBoxBuilder Value(IEnumerable value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the selected items.</summary>
		[Generated]
		public TagBoxBuilder Value(JS value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public TagBoxBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public TagBoxBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TagBoxBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public TagBoxBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TagBoxBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TagBoxBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public TagBoxBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public TagBoxBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public TagBoxBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
