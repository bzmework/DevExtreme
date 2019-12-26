using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>[tags] ctp The Diagram widget provides a visual interface to help you design new and modify existing diagrams. #include common-ctp-note with { component: "Diagram" }</summary>
	public class DiagramBuilder : WidgetBuilder
	{
		[Generated]
		public DiagramBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public DiagramBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public DiagramBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DiagramBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public DiagramBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DiagramBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public DiagramBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the Diagram widget automatically zooms the work area.</summary>
		[Generated]
		public DiagramBuilder AutoZoom(DiagramAutoZoom value)
		{
			base.Options["autoZoom"] = value;
			return this;
		}

		/// <summary>Configures the context menu's settings.</summary>
		[Generated]
		public DiagramBuilder ContextMenu(Action<DiagramContextMenuBuilder> configurator)
		{
			NestedOptions("contextMenu", configurator);
			return this;
		}

		/// <summary>Provide access to an array of custom shapes.</summary>
		[Generated]
		public DiagramBuilder CustomShapes(Action<CollectionFactory<DiagramCustomShapeBuilder>> configurator)
		{
			Collection("customShapes", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DiagramBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public DiagramBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Allows you to bind the collection of diagram edges to a data source.</summary>
		[Generated]
		public DiagramBuilder Edges(Action<DiagramEdgesBuilder> configurator)
		{
			NestedOptions("edges", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DiagramBuilder ElementAttr(string attributeName, object value)
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
		public DiagramBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DiagramBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public DiagramBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures export settings.</summary>
		[Generated]
		public DiagramBuilder Export(Action<DiagramExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DiagramBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public DiagramBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the widget in full-screen mode.</summary>
		[Generated]
		public DiagramBuilder FullScreen(bool value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the widget in full-screen mode.</summary>
		[Generated]
		public DiagramBuilder FullScreen(JS value)
		{
			base.Options["fullScreen"] = value;
			return this;
		}

		/// <summary>Specifies the grid pitch.</summary>
		[Generated]
		public DiagramBuilder GridSize(Action<DiagramGridSizeBuilder> configurator)
		{
			NestedOptions("gridSize", configurator);
			return this;
		}

		/// <summary>Specifies the grid pitch.</summary>
		[Generated]
		public DiagramBuilder GridSize(double value)
		{
			base.Options["gridSize"] = value;
			return this;
		}

		/// <summary>Specifies the grid pitch.</summary>
		[Generated]
		public DiagramBuilder GridSize(JS value)
		{
			base.Options["gridSize"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DiagramBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DiagramBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public DiagramBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DiagramBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public DiagramBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DiagramBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public DiagramBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Allows you to bind the collection of diagram nodes to a data source.</summary>
		[Generated]
		public DiagramBuilder Nodes(Action<DiagramNodesBuilder> configurator)
		{
			NestedOptions("nodes", configurator);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DiagramBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public DiagramBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the diagram's data changes.</summary>
		[Generated]
		public DiagramBuilder OnDataChanged(string jsFunc)
		{
			AssignJS("onDataChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the diagram's data changes.</summary>
		[Generated]
		public DiagramBuilder OnDataChanged(RazorBlock jsFunc)
		{
			return OnDataChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DiagramBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public DiagramBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DiagramBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public DiagramBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		[Generated]
		public DiagramBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		[Generated]
		public DiagramBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		[Generated]
		public DiagramBuilder OnItemDblClick(string jsFunc)
		{
			AssignJS("onItemDblClick", jsFunc);
			return this;
		}

		[Generated]
		public DiagramBuilder OnItemDblClick(RazorBlock jsFunc)
		{
			return OnItemDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DiagramBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public DiagramBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		[Generated]
		public DiagramBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		[Generated]
		public DiagramBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the color of a diagram page.</summary>
		[Generated]
		public DiagramBuilder PageColor(string value)
		{
			base.Options["pageColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of a diagram page.</summary>
		[Generated]
		public DiagramBuilder PageColor(JS value)
		{
			base.Options["pageColor"] = value;
			return this;
		}

		/// <summary>Specifies the page orientation.</summary>
		[Generated]
		public DiagramBuilder PageOrientation(DiagramPageOrientation value)
		{
			base.Options["pageOrientation"] = value;
			return this;
		}

		/// <summary>Specifies a size of pages.</summary>
		[Generated]
		public DiagramBuilder PageSize(Action<DiagramPageSizeBuilder> configurator)
		{
			NestedOptions("pageSize", configurator);
			return this;
		}

		/// <summary>Provides access to Properties panel settings.</summary>
		[Generated]
		public DiagramBuilder PropertiesPanel(Action<DiagramPropertiesPanelBuilder> configurator)
		{
			NestedOptions("propertiesPanel", configurator);
			return this;
		}

		/// <summary>Specifies whether the diagram is read-only.</summary>
		[Generated]
		public DiagramBuilder ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether the diagram is read-only.</summary>
		[Generated]
		public DiagramBuilder ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DiagramBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public DiagramBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether grid lines are visible.</summary>
		[Generated]
		public DiagramBuilder ShowGrid(bool value)
		{
			base.Options["showGrid"] = value;
			return this;
		}

		/// <summary>Specifies whether grid lines are visible.</summary>
		[Generated]
		public DiagramBuilder ShowGrid(JS value)
		{
			base.Options["showGrid"] = value;
			return this;
		}

		/// <summary>Switch the Diagram widget to simple view mode.</summary>
		[Generated]
		public DiagramBuilder SimpleView(bool value)
		{
			base.Options["simpleView"] = value;
			return this;
		}

		/// <summary>Switch the Diagram widget to simple view mode.</summary>
		[Generated]
		public DiagramBuilder SimpleView(JS value)
		{
			base.Options["simpleView"] = value;
			return this;
		}

		/// <summary>Specifies whether diagram elements should snap to grid lines.</summary>
		[Generated]
		public DiagramBuilder SnapToGrid(bool value)
		{
			base.Options["snapToGrid"] = value;
			return this;
		}

		/// <summary>Specifies whether diagram elements should snap to grid lines.</summary>
		[Generated]
		public DiagramBuilder SnapToGrid(JS value)
		{
			base.Options["snapToGrid"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DiagramBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public DiagramBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Provides access to toolbar settings.</summary>
		[Generated]
		public DiagramBuilder Toolbar(Action<DiagramToolbarBuilder> configurator)
		{
			NestedOptions("toolbar", configurator);
			return this;
		}

		/// <summary>Provides access to toolbox settings.</summary>
		[Generated]
		public DiagramBuilder Toolbox(Action<DiagramToolboxBuilder> configurator)
		{
			NestedOptions("toolbox", configurator);
			return this;
		}

		/// <summary>Specifies the unit for measurement options (for example, defaultHeight, gridSize, leftExpr).</summary>
		[Generated]
		public DiagramBuilder Units(DiagramUnits value)
		{
			base.Options["units"] = value;
			return this;
		}

		/// <summary>Specifies the measurement unit that is displayed in user interface elements.</summary>
		[Generated]
		public DiagramBuilder ViewUnits(DiagramUnits value)
		{
			base.Options["viewUnits"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DiagramBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public DiagramBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DiagramBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DiagramBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public DiagramBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the zoom level.</summary>
		[Generated]
		public DiagramBuilder ZoomLevel(Action<DiagramZoomLevelBuilder> configurator)
		{
			NestedOptions("zoomLevel", configurator);
			return this;
		}

		/// <summary>Specifies the zoom level.</summary>
		[Generated]
		public DiagramBuilder ZoomLevel(double value)
		{
			base.Options["zoomLevel"] = value;
			return this;
		}

		/// <summary>Specifies the zoom level.</summary>
		[Generated]
		public DiagramBuilder ZoomLevel(JS value)
		{
			base.Options["zoomLevel"] = value;
			return this;
		}
	}
}
