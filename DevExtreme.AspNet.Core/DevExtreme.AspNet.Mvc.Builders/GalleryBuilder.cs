using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Gallery is a widget that displays a collection of images in a carousel. The widget is supplied with various navigation controls that allow a user to switch between images.</summary>
	public class GalleryBuilder : WidgetBuilder
	{
		[Generated]
		public GalleryBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public GalleryBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public GalleryBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GalleryBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public GalleryBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public GalleryBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>The time, in milliseconds, spent on slide animation.</summary>
		[Generated]
		public GalleryBuilder AnimationDuration(double value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>The time, in milliseconds, spent on slide animation.</summary>
		[Generated]
		public GalleryBuilder AnimationDuration(JS value)
		{
			base.Options["animationDuration"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to animate the displayed item change.</summary>
		[Generated]
		public GalleryBuilder AnimationEnabled(bool value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to animate the displayed item change.</summary>
		[Generated]
		public GalleryBuilder AnimationEnabled(JS value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public GalleryBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public GalleryBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public GalleryBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public GalleryBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public GalleryBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public GalleryBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public GalleryBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GalleryBuilder ElementAttr(string attributeName, object value)
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
		public GalleryBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GalleryBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GalleryBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public GalleryBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public GalleryBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GalleryBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GalleryBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GalleryBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public GalleryBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public GalleryBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public GalleryBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public GalleryBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to allow users to switch between items by clicking an indicator.</summary>
		[Generated]
		public GalleryBuilder IndicatorEnabled(bool value)
		{
			base.Options["indicatorEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to allow users to switch between items by clicking an indicator.</summary>
		[Generated]
		public GalleryBuilder IndicatorEnabled(JS value)
		{
			base.Options["indicatorEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the width of an area used to display a single image.</summary>
		[Generated]
		public GalleryBuilder InitialItemWidth(double value)
		{
			base.Options["initialItemWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of an area used to display a single image.</summary>
		[Generated]
		public GalleryBuilder InitialItemWidth(JS value)
		{
			base.Options["initialItemWidth"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public GalleryBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public GalleryBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public GalleryBuilder Items(IEnumerable<string> value)
		{
			base.Options["items"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public GalleryBuilder Items(Action<CollectionFactory<GalleryItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public GalleryBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public GalleryBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public GalleryBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public GalleryBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to scroll back to the first item after the last item is swiped.</summary>
		[Generated]
		public GalleryBuilder Loop(bool value)
		{
			base.Options["loop"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to scroll back to the first item after the last item is swiped.</summary>
		[Generated]
		public GalleryBuilder Loop(JS value)
		{
			base.Options["loop"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public GalleryBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public GalleryBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public GalleryBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public GalleryBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public GalleryBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public GalleryBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public GalleryBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public GalleryBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public GalleryBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public GalleryBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public GalleryBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public GalleryBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public GalleryBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public GalleryBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public GalleryBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public GalleryBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public GalleryBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public GalleryBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public GalleryBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is selected or selection is canceled.</summary>
		[Generated]
		public GalleryBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public GalleryBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public GalleryBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>The index of the currently active gallery item.</summary>
		[Generated]
		public GalleryBuilder SelectedIndex(int value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The index of the currently active gallery item.</summary>
		[Generated]
		public GalleryBuilder SelectedIndex(JS value)
		{
			base.Options["selectedIndex"] = value;
			return this;
		}

		/// <summary>The selected item object.</summary>
		[Generated]
		public GalleryBuilder SelectedItem(object value)
		{
			base.Options["selectedItem"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display an indicator that points to the selected gallery item.</summary>
		[Generated]
		public GalleryBuilder ShowIndicator(bool value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to display an indicator that points to the selected gallery item.</summary>
		[Generated]
		public GalleryBuilder ShowIndicator(JS value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>A Boolean value that specifies the availability of the "Forward" and "Back" navigation buttons.</summary>
		[Generated]
		public GalleryBuilder ShowNavButtons(bool value)
		{
			base.Options["showNavButtons"] = value;
			return this;
		}

		/// <summary>A Boolean value that specifies the availability of the "Forward" and "Back" navigation buttons.</summary>
		[Generated]
		public GalleryBuilder ShowNavButtons(JS value)
		{
			base.Options["showNavButtons"] = value;
			return this;
		}

		/// <summary>The time interval in milliseconds, after which the gallery switches to the next item.</summary>
		[Generated]
		public GalleryBuilder SlideshowDelay(double value)
		{
			base.Options["slideshowDelay"] = value;
			return this;
		}

		/// <summary>The time interval in milliseconds, after which the gallery switches to the next item.</summary>
		[Generated]
		public GalleryBuilder SlideshowDelay(JS value)
		{
			base.Options["slideshowDelay"] = value;
			return this;
		}

		/// <summary>Specifies if the widget stretches images to fit the total gallery width.</summary>
		[Generated]
		public GalleryBuilder StretchImages(bool value)
		{
			base.Options["stretchImages"] = value;
			return this;
		}

		/// <summary>Specifies if the widget stretches images to fit the total gallery width.</summary>
		[Generated]
		public GalleryBuilder StretchImages(JS value)
		{
			base.Options["stretchImages"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to allow users to switch between items by swiping.</summary>
		[Generated]
		public GalleryBuilder SwipeEnabled(bool value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not to allow users to switch between items by swiping.</summary>
		[Generated]
		public GalleryBuilder SwipeEnabled(JS value)
		{
			base.Options["swipeEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public GalleryBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public GalleryBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public GalleryBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public GalleryBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GalleryBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GalleryBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GalleryBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display parts of previous and next images along the sides of the current image.</summary>
		[Generated]
		public GalleryBuilder WrapAround(bool value)
		{
			base.Options["wrapAround"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display parts of previous and next images along the sides of the current image.</summary>
		[Generated]
		public GalleryBuilder WrapAround(JS value)
		{
			base.Options["wrapAround"] = value;
			return this;
		}
	}
}
