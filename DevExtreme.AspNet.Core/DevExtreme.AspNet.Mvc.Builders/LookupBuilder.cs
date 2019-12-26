using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Lookup is a widget that allows an end user to search for an item in a collection shown in a drop-down menu.</summary>
	public class LookupBuilder : WidgetBuilder
	{
		[Obsolete("The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LookupBuilder DisplayValue(string value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Obsolete("The displayValue option is read-only. Calling this method does not affect the widget.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public LookupBuilder DisplayValue(JS value)
		{
			base.Options["displayValue"] = value;
			return this;
		}

		[Generated]
		public LookupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public LookupBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public LookupBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LookupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public LookupBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public LookupBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public LookupBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public LookupBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures widget visibility animations. This object contains two fields: show and hide.</summary>
		[Generated]
		public LookupBuilder Animation(Action<LookupAnimationBuilder> configurator)
		{
			NestedOptions("animation", configurator);
			return this;
		}

		/// <summary>The text displayed on the Apply button.</summary>
		[Generated]
		public LookupBuilder ApplyButtonText(string value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the Apply button.</summary>
		[Generated]
		public LookupBuilder ApplyButtonText(JS value)
		{
			base.Options["applyButtonText"] = value;
			return this;
		}

		/// <summary>Specifies the way an end-user applies the selected value.</summary>
		[Generated]
		public LookupBuilder ApplyValueMode(EditorApplyValueMode value)
		{
			base.Options["applyValueMode"] = value;
			return this;
		}

		/// <summary>The text displayed on the Cancel button.</summary>
		[Generated]
		public LookupBuilder CancelButtonText(string value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the Cancel button.</summary>
		[Generated]
		public LookupBuilder CancelButtonText(JS value)
		{
			base.Options["cancelButtonText"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget cleans the search box when the popup window is displayed.</summary>
		[Generated]
		public LookupBuilder CleanSearchOnOpening(bool value)
		{
			base.Options["cleanSearchOnOpening"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget cleans the search box when the popup window is displayed.</summary>
		[Generated]
		public LookupBuilder CleanSearchOnOpening(JS value)
		{
			base.Options["cleanSearchOnOpening"] = value;
			return this;
		}

		/// <summary>The text displayed on the Clear button.</summary>
		[Generated]
		public LookupBuilder ClearButtonText(string value)
		{
			base.Options["clearButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the Clear button.</summary>
		[Generated]
		public LookupBuilder ClearButtonText(JS value)
		{
			base.Options["clearButtonText"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the drop-down menu if a user clicks outside it.</summary>
		[Generated]
		public LookupBuilder CloseOnOutsideClick(bool value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Specifies whether to close the drop-down menu if a user clicks outside it.</summary>
		[Generated]
		public LookupBuilder CloseOnOutsideClick(JS value)
		{
			base.Options["closeOnOutsideClick"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public LookupBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public LookupBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public LookupBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public LookupBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public LookupBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public LookupBuilder DeferRendering(bool value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether to render the drop-down field's content when it is displayed. If false, the content is rendered immediately.</summary>
		[Generated]
		public LookupBuilder DeferRendering(JS value)
		{
			base.Options["deferRendering"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public LookupBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public LookupBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public LookupBuilder DisplayExpr(string value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the data field whose values should be displayed.</summary>
		[Generated]
		public LookupBuilder DisplayExpr(JS value)
		{
			base.Options["displayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LookupBuilder ElementAttr(string attributeName, object value)
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
		public LookupBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LookupBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public LookupBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the input field.</summary>
		[Generated]
		public LookupBuilder FieldTemplate(string templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the input field.</summary>
		[Generated]
		public LookupBuilder FieldTemplate(RazorBlock templateContent)
		{
			AssignTemplate("fieldTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the input field.</summary>
		[Generated]
		public LookupBuilder FieldTemplate(TemplateName name)
		{
			AssignTemplate("fieldTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the input field.</summary>
		[Generated]
		public LookupBuilder FieldTemplate(JS value)
		{
			base.Options["fieldTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public LookupBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public LookupBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the lookup in full-screen mode.</summary>
		[Generated]
		public LookupBuilder FullScreen(bool value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the lookup in full-screen mode.</summary>
		[Generated]
		public LookupBuilder FullScreen(JS value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to group widget items.</summary>
		[Generated]
		public LookupBuilder Grouped(bool value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to group widget items.</summary>
		[Generated]
		public LookupBuilder Grouped(JS value)
		{
			base.Options["grouped"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public LookupBuilder GroupTemplate(string templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public LookupBuilder GroupTemplate(RazorBlock templateContent)
		{
			AssignTemplate("groupTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public LookupBuilder GroupTemplate(TemplateName name)
		{
			AssignTemplate("groupTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for group captions.</summary>
		[Generated]
		public LookupBuilder GroupTemplate(JS value)
		{
			base.Options["groupTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public LookupBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public LookupBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public LookupBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public LookupBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public LookupBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public LookupBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public LookupBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public LookupBuilder InputAttr(string attributeName, object value)
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
		public LookupBuilder InputAttr(object htmlAttributes)
		{
			base.Options["inputAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public LookupBuilder InputAttr(Dictionary<string, object> value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be passed on to the underlying HTML element.</summary>
		[Generated]
		public LookupBuilder InputAttr(JS value)
		{
			base.Options["inputAttr"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public LookupBuilder IsValid(bool value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>Specifies or indicates whether the editor's value is valid.</summary>
		[Generated]
		public LookupBuilder IsValid(JS value)
		{
			base.Options["isValid"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public LookupBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public LookupBuilder Items(Action<CollectionFactory<LookupItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public LookupBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public LookupBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public LookupBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public LookupBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public LookupBuilder MinSearchLength(int value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>The minimum number of characters that must be entered into the text box to begin a search. Applies only if searchEnabled is true.</summary>
		[Generated]
		public LookupBuilder MinSearchLength(JS value)
		{
			base.Options["minSearchLength"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public LookupBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The value to be assigned to the `name` attribute of the underlying HTML element.</summary>
		[Generated]
		public LookupBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>The text displayed on the button used to load the next page from the data source.</summary>
		[Generated]
		public LookupBuilder NextButtonText(string value)
		{
			base.Options["nextButtonText"] = value;
			return this;
		}

		/// <summary>The text displayed on the button used to load the next page from the data source.</summary>
		[Generated]
		public LookupBuilder NextButtonText(JS value)
		{
			base.Options["nextButtonText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public LookupBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public LookupBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public LookupBuilder OnClosed(string jsFunc)
		{
			AssignJS("onClosed", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is closed.</summary>
		[Generated]
		public LookupBuilder OnClosed(RazorBlock jsFunc)
		{
			return OnClosed(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public LookupBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public LookupBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public LookupBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public LookupBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public LookupBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public LookupBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public LookupBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is clicked or tapped.</summary>
		[Generated]
		public LookupBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public LookupBuilder OnOpened(string jsFunc)
		{
			AssignJS("onOpened", jsFunc);
			return this;
		}

		/// <summary>A function that is executed once the drop-down editor is opened.</summary>
		[Generated]
		public LookupBuilder OnOpened(RazorBlock jsFunc)
		{
			return OnOpened(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public LookupBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public LookupBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the next page is loaded.</summary>
		[Generated]
		public LookupBuilder OnPageLoading(string jsFunc)
		{
			AssignJS("onPageLoading", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the next page is loaded.</summary>
		[Generated]
		public LookupBuilder OnPageLoading(RazorBlock jsFunc)
		{
			return OnPageLoading(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed on the drop-down item list. Supported in mobile themes only.</summary>
		[Generated]
		public LookupBuilder OnPullRefresh(string jsFunc)
		{
			AssignJS("onPullRefresh", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the "pull to refresh" gesture is performed on the drop-down item list. Supported in mobile themes only.</summary>
		[Generated]
		public LookupBuilder OnPullRefresh(RazorBlock jsFunc)
		{
			return OnPullRefresh(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed on each scroll gesture performed on the drop-down item list.</summary>
		[Generated]
		public LookupBuilder OnScroll(string jsFunc)
		{
			AssignJS("onScroll", jsFunc);
			return this;
		}

		/// <summary>A function that is executed on each scroll gesture performed on the drop-down item list.</summary>
		[Generated]
		public LookupBuilder OnScroll(RazorBlock jsFunc)
		{
			return OnScroll(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public LookupBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a list item is selected or selection is canceled.</summary>
		[Generated]
		public LookupBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the drop-down list's title is rendered.</summary>
		[Generated]
		public LookupBuilder OnTitleRendered(string jsFunc)
		{
			AssignJS("onTitleRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the drop-down list's title is rendered.</summary>
		[Generated]
		public LookupBuilder OnTitleRendered(RazorBlock jsFunc)
		{
			return OnTitleRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public LookupBuilder OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public LookupBuilder OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public LookupBuilder Opened(bool value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the drop-down editor is displayed.</summary>
		[Generated]
		public LookupBuilder Opened(JS value)
		{
			base.Options["opened"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel, which is displayed when the widget is scrolled to the bottom.</summary>
		[Generated]
		public LookupBuilder PageLoadingText(string value)
		{
			base.Options["pageLoadingText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel, which is displayed when the widget is scrolled to the bottom.</summary>
		[Generated]
		public LookupBuilder PageLoadingText(JS value)
		{
			base.Options["pageLoadingText"] = value;
			return this;
		}

		/// <summary>Specifies whether the next page is loaded when a user scrolls the widget to the bottom or when the "next" button is clicked.</summary>
		[Generated]
		public LookupBuilder PageLoadMode(ListPageLoadMode value)
		{
			base.Options["pageLoadMode"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when nothing is selected.</summary>
		[Generated]
		public LookupBuilder Placeholder(string value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>The text displayed by the widget when nothing is selected.</summary>
		[Generated]
		public LookupBuilder Placeholder(JS value)
		{
			base.Options["placeholder"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's height. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupHeight(double value)
		{
			base.Options["popupHeight"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's height. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupHeight(string value)
		{
			base.Options["popupHeight"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's height. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupHeight(JS value)
		{
			base.Options["popupHeight"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's width. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupWidth(double value)
		{
			base.Options["popupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's width. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupWidth(string value)
		{
			base.Options["popupWidth"] = value;
			return this;
		}

		/// <summary>Specifies the popup element's width. Applies only if fullScreen is false.</summary>
		[Generated]
		public LookupBuilder PopupWidth(JS value)
		{
			base.Options["popupWidth"] = value;
			return this;
		}

		/// <summary>An object defining widget positioning options.</summary>
		[Generated]
		public LookupBuilder Position(Action<PositionConfigBuilder> configurator)
		{
			NestedOptions("position", configurator);
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel when the widget is pulled below the refresh threshold.</summary>
		[Generated]
		public LookupBuilder PulledDownText(string value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel when the widget is pulled below the refresh threshold.</summary>
		[Generated]
		public LookupBuilder PulledDownText(JS value)
		{
			base.Options["pulledDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while the list is being pulled down to the refresh threshold.</summary>
		[Generated]
		public LookupBuilder PullingDownText(string value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>Specifies the text shown in the pullDown panel while the list is being pulled down to the refresh threshold.</summary>
		[Generated]
		public LookupBuilder PullingDownText(JS value)
		{
			base.Options["pullingDownText"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget supports the "pull down to refresh" gesture.</summary>
		[Generated]
		public LookupBuilder PullRefreshEnabled(bool value)
		{
			base.Options["pullRefreshEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the widget supports the "pull down to refresh" gesture.</summary>
		[Generated]
		public LookupBuilder PullRefreshEnabled(JS value)
		{
			base.Options["pullRefreshEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel while the widget is being refreshed.</summary>
		[Generated]
		public LookupBuilder RefreshingText(string value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in the pullDown panel while the widget is being refreshed.</summary>
		[Generated]
		public LookupBuilder RefreshingText(JS value)
		{
			base.Options["refreshingText"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public LookupBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public LookupBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the search box is visible.</summary>
		[Generated]
		public LookupBuilder SearchEnabled(bool value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the search box is visible.</summary>
		[Generated]
		public LookupBuilder SearchEnabled(JS value)
		{
			base.Options["searchEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public LookupBuilder SearchExpr(params string[] values)
		{
			base.Options["searchExpr"] = values;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public LookupBuilder SearchExpr(IEnumerable<string> value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of a data source item field or an expression whose value is compared to the search criterion.</summary>
		[Generated]
		public LookupBuilder SearchExpr(JS value)
		{
			base.Options["searchExpr"] = value;
			return this;
		}

		/// <summary>Specifies a comparison operation used to search widget items.</summary>
		[Generated]
		public LookupBuilder SearchMode(DropDownSearchMode value)
		{
			base.Options["searchMode"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the lookup's search bar.</summary>
		[Generated]
		public LookupBuilder SearchPlaceholder(string value)
		{
			base.Options["searchPlaceholder"] = value;
			return this;
		}

		/// <summary>The text that is provided as a hint in the lookup's search bar.</summary>
		[Generated]
		public LookupBuilder SearchPlaceholder(JS value)
		{
			base.Options["searchPlaceholder"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public LookupBuilder SearchTimeout(double value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies the time delay, in milliseconds, after the last character has been typed in, before a search is executed.</summary>
		[Generated]
		public LookupBuilder SearchTimeout(JS value)
		{
			base.Options["searchTimeout"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the container when the lookup is active. Applies only if usePopover is false.</summary>
		[Generated]
		public LookupBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the container when the lookup is active. Applies only if usePopover is false.</summary>
		[Generated]
		public LookupBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Cancel button in the lookup window.</summary>
		[Generated]
		public LookupBuilder ShowCancelButton(bool value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Cancel button in the lookup window.</summary>
		[Generated]
		public LookupBuilder ShowCancelButton(JS value)
		{
			base.Options["showCancelButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the Clear button in the lookup window.</summary>
		[Generated]
		public LookupBuilder ShowClearButton(bool value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the Clear button in the lookup window.</summary>
		[Generated]
		public LookupBuilder ShowClearButton(JS value)
		{
			base.Options["showClearButton"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public LookupBuilder ShowDataBeforeSearch(bool value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget displays unfiltered values until a user types a number of characters exceeding the minSearchLength option value.</summary>
		[Generated]
		public LookupBuilder ShowDataBeforeSearch(JS value)
		{
			base.Options["showDataBeforeSearch"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the popup window.</summary>
		[Generated]
		public LookupBuilder ShowPopupTitle(bool value)
		{
			base.Options["showPopupTitle"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display the title in the popup window.</summary>
		[Generated]
		public LookupBuilder ShowPopupTitle(JS value)
		{
			base.Options["showPopupTitle"] = value;
			return this;
		}

		/// <summary>Specifies how the widget's text field is styled.</summary>
		[Generated]
		public LookupBuilder StylingMode(EditorStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public LookupBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public LookupBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>The title of the lookup window.</summary>
		[Generated]
		public LookupBuilder Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>The title of the lookup window.</summary>
		[Generated]
		public LookupBuilder Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for the title.</summary>
		[Generated]
		public LookupBuilder TitleTemplate(string templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the title.</summary>
		[Generated]
		public LookupBuilder TitleTemplate(RazorBlock templateContent)
		{
			AssignTemplate("titleTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for the title.</summary>
		[Generated]
		public LookupBuilder TitleTemplate(TemplateName name)
		{
			AssignTemplate("titleTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for the title.</summary>
		[Generated]
		public LookupBuilder TitleTemplate(JS value)
		{
			base.Options["titleTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public LookupBuilder UseNativeScrolling(bool value)
		{
			base.Options["useNativeScrolling"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget uses native scrolling.</summary>
		[Generated]
		public LookupBuilder UseNativeScrolling(JS value)
		{
			base.Options["useNativeScrolling"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show lookup contents in a Popover widget.</summary>
		[Generated]
		public LookupBuilder UsePopover(bool value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show lookup contents in a Popover widget.</summary>
		[Generated]
		public LookupBuilder UsePopover(JS value)
		{
			base.Options["usePopover"] = value;
			return this;
		}

		/// <summary>Information on the broken validation rule. Contains the first item from the validationErrors array.</summary>
		[Generated]
		public LookupBuilder ValidationError(object value)
		{
			base.Options["validationError"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public LookupBuilder ValidationErrors(IEnumerable value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>An array of the validation rules that failed.</summary>
		[Generated]
		public LookupBuilder ValidationErrors(JS value)
		{
			base.Options["validationErrors"] = value;
			return this;
		}

		/// <summary>Specifies how the message about the validation rules that are not satisfied by this editor's value is displayed.</summary>
		[Generated]
		public LookupBuilder ValidationMessageMode(ValidationMessageMode value)
		{
			base.Options["validationMessageMode"] = value;
			return this;
		}

		/// <summary>Indicates or specifies the current validation status.</summary>
		[Generated]
		public LookupBuilder ValidationStatus(ValidationStatus value)
		{
			base.Options["validationStatus"] = value;
			return this;
		}

		/// <summary>Specifies the currently selected value. May be an object if dataSource contains objects and valueExpr is not set.</summary>
		[Generated]
		public LookupBuilder Value(object value)
		{
			base.Options["value"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public LookupBuilder ValueChangeEvent(string value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies the DOM events after which the widget's value should be updated.</summary>
		[Generated]
		public LookupBuilder ValueChangeEvent(JS value)
		{
			base.Options["valueChangeEvent"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public LookupBuilder ValueExpr(string value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides unique values to the widget's value.</summary>
		[Generated]
		public LookupBuilder ValueExpr(JS value)
		{
			base.Options["valueExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public LookupBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public LookupBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public LookupBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public LookupBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public LookupBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public LookupBuilder WrapItemText(bool value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}

		/// <summary>Specifies whether text that exceeds the drop-down list width should be wrapped.</summary>
		[Generated]
		public LookupBuilder WrapItemText(JS value)
		{
			base.Options["wrapItemText"] = value;
			return this;
		}
	}
}
