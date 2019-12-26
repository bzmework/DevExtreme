using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Toolbar is a widget containing items that usually manage screen content. Those items can be plain text or widgets.</summary>
	public class ToolbarBuilder : WidgetBuilder
	{
		[Generated]
		public ToolbarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ToolbarBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ToolbarBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ToolbarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ToolbarBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ToolbarBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ToolbarBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ToolbarBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public ToolbarBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ToolbarBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ToolbarBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToolbarBuilder ElementAttr(string attributeName, object value)
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
		public ToolbarBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToolbarBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ToolbarBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ToolbarBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ToolbarBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ToolbarBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ToolbarBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ToolbarBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ToolbarBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ToolbarBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public ToolbarBuilder ItemHoldTimeout(double value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>The time period in milliseconds before the onItemHold event is raised.</summary>
		[Generated]
		public ToolbarBuilder ItemHoldTimeout(JS value)
		{
			base.Options["itemHoldTimeout"] = value;
			return this;
		}

		/// <summary>An array of items displayed by the widget.</summary>
		[Generated]
		public ToolbarBuilder Items(Action<CollectionFactory<ToolbarItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ToolbarBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ToolbarBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ToolbarBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for items.</summary>
		[Generated]
		public ToolbarBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public ToolbarBuilder MenuItemTemplate(string templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public ToolbarBuilder MenuItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("menuItemTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public ToolbarBuilder MenuItemTemplate(TemplateName name)
		{
			AssignTemplate("menuItemTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for menu items.</summary>
		[Generated]
		public ToolbarBuilder MenuItemTemplate(JS value)
		{
			base.Options["menuItemTemplate"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public ToolbarBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty.</summary>
		[Generated]
		public ToolbarBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ToolbarBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ToolbarBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ToolbarBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ToolbarBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ToolbarBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ToolbarBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ToolbarBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is clicked or tapped.</summary>
		[Generated]
		public ToolbarBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ToolbarBuilder OnItemContextMenu(string jsFunc)
		{
			AssignJS("onItemContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item is right-clicked or pressed.</summary>
		[Generated]
		public ToolbarBuilder OnItemContextMenu(RazorBlock jsFunc)
		{
			return OnItemContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public ToolbarBuilder OnItemHold(string jsFunc)
		{
			AssignJS("onItemHold", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a collection item has been held for a specified period.</summary>
		[Generated]
		public ToolbarBuilder OnItemHold(RazorBlock jsFunc)
		{
			return OnItemHold(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ToolbarBuilder OnItemRendered(string jsFunc)
		{
			AssignJS("onItemRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a collection item is rendered.</summary>
		[Generated]
		public ToolbarBuilder OnItemRendered(RazorBlock jsFunc)
		{
			return OnItemRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ToolbarBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ToolbarBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Informs the widget about its location in a view HTML markup.</summary>
		[Generated]
		public ToolbarBuilder RenderAs(ToolbarRenderMode value)
		{
			base.Options["renderAs"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ToolbarBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ToolbarBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ToolbarBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ToolbarBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ToolbarBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ToolbarBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ToolbarBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
