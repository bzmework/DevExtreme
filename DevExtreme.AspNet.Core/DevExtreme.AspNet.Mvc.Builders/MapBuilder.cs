using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Map is an interactive widget that displays a geographic map with markers and routes.</summary>
	public class MapBuilder : WidgetBuilder
	{
		[Generated]
		public MapBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public MapBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public MapBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public MapBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public MapBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public MapBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public MapBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget automatically adjusts center and zoom option values when adding a new marker or route, or if a new widget contains markers or routes by default.</summary>
		[Generated]
		public MapBuilder AutoAdjust(bool value)
		{
			base.Options["autoAdjust"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget automatically adjusts center and zoom option values when adding a new marker or route, or if a new widget contains markers or routes by default.</summary>
		[Generated]
		public MapBuilder AutoAdjust(JS value)
		{
			base.Options["autoAdjust"] = value;
			return this;
		}

		/// <summary>Specifies whether or not map widget controls are available.</summary>
		[Generated]
		public MapBuilder Controls(bool value)
		{
			base.Options["controls"] = value;
			return this;
		}

		/// <summary>Specifies whether or not map widget controls are available.</summary>
		[Generated]
		public MapBuilder Controls(JS value)
		{
			base.Options["controls"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public MapBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public MapBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MapBuilder ElementAttr(string attributeName, object value)
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
		public MapBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MapBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public MapBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public MapBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public MapBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MapBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MapBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public MapBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public MapBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public MapBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public MapBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public MapBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the required map provider.</summary>
		[Generated]
		public MapBuilder Key(Action<MapKeyBuilder> configurator)
		{
			NestedOptions("key", configurator);
			return this;
		}

		/// <summary>A key used to authenticate the application within the required map provider.</summary>
		[Generated]
		public MapBuilder Key(string value)
		{
			base.Options["key"] = value;
			return this;
		}

		/// <summary>A key used to authenticate the application within the required map provider.</summary>
		[Generated]
		public MapBuilder Key(JS value)
		{
			base.Options["key"] = value;
			return this;
		}

		/// <summary>A URL pointing to the custom icon to be used for map markers.</summary>
		[Generated]
		public MapBuilder MarkerIconSrc(string value)
		{
			base.Options["markerIconSrc"] = value;
			return this;
		}

		/// <summary>A URL pointing to the custom icon to be used for map markers.</summary>
		[Generated]
		public MapBuilder MarkerIconSrc(JS value)
		{
			base.Options["markerIconSrc"] = value;
			return this;
		}

		/// <summary>An array of markers displayed on a map.</summary>
		[Generated]
		public MapBuilder Markers(Action<CollectionFactory<MapMarkerBuilder>> configurator)
		{
			Collection("markers", configurator);
			return this;
		}

		/// <summary>A function that is executed when any location on the map is clicked or tapped.</summary>
		[Generated]
		public MapBuilder OnClick(string jsFunc)
		{
			AssignJS("onClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when any location on the map is clicked or tapped.</summary>
		[Generated]
		public MapBuilder OnClick(RazorBlock jsFunc)
		{
			return OnClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public MapBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public MapBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public MapBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public MapBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a marker is created on the map.</summary>
		[Generated]
		public MapBuilder OnMarkerAdded(string jsFunc)
		{
			AssignJS("onMarkerAdded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a marker is created on the map.</summary>
		[Generated]
		public MapBuilder OnMarkerAdded(RazorBlock jsFunc)
		{
			return OnMarkerAdded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a marker is removed from the map.</summary>
		[Generated]
		public MapBuilder OnMarkerRemoved(string jsFunc)
		{
			AssignJS("onMarkerRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a marker is removed from the map.</summary>
		[Generated]
		public MapBuilder OnMarkerRemoved(RazorBlock jsFunc)
		{
			return OnMarkerRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public MapBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public MapBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the map is ready.</summary>
		[Generated]
		public MapBuilder OnReady(string jsFunc)
		{
			AssignJS("onReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the map is ready.</summary>
		[Generated]
		public MapBuilder OnReady(RazorBlock jsFunc)
		{
			return OnReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a route is created on the map.</summary>
		[Generated]
		public MapBuilder OnRouteAdded(string jsFunc)
		{
			AssignJS("onRouteAdded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a route is created on the map.</summary>
		[Generated]
		public MapBuilder OnRouteAdded(RazorBlock jsFunc)
		{
			return OnRouteAdded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a route is removed from the map.</summary>
		[Generated]
		public MapBuilder OnRouteRemoved(string jsFunc)
		{
			AssignJS("onRouteRemoved", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a route is removed from the map.</summary>
		[Generated]
		public MapBuilder OnRouteRemoved(RazorBlock jsFunc)
		{
			return OnRouteRemoved(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>The name of the current map data provider.</summary>
		[Generated]
		public MapBuilder Provider(GeoMapProvider value)
		{
			base.Options["provider"] = value;
			return this;
		}

		/// <summary>An array of routes shown on the map.</summary>
		[Generated]
		public MapBuilder Routes(Action<CollectionFactory<MapRouteBuilder>> configurator)
		{
			Collection("routes", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public MapBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public MapBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public MapBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public MapBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>The type of a map to display.</summary>
		[Generated]
		public MapBuilder Type(GeoMapType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public MapBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public MapBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MapBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MapBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public MapBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>The map's zoom level. The widget can change this value if autoAdjust is enabled.</summary>
		[Generated]
		public MapBuilder Zoom(double value)
		{
			base.Options["zoom"] = value;
			return this;
		}

		/// <summary>The map's zoom level. The widget can change this value if autoAdjust is enabled.</summary>
		[Generated]
		public MapBuilder Zoom(JS value)
		{
			base.Options["zoom"] = value;
			return this;
		}

		public MapBuilder Center(string address)
		{
			base.Options["center"] = address;
			return this;
		}

		public MapBuilder Center(double latitude, double longitude)
		{
			base.Options["center"] = new double[2]
			{
				latitude,
				longitude
			};
			return this;
		}
	}
}
