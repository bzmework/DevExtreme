using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The PivotGrid is a widget that allows you to display and analyze multi-dimensional data from a local storage or an OLAP cube.</summary>
	public class PivotGridBuilder<T> : WidgetBuilder
	{
		[Generated]
		public PivotGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public PivotGridBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public PivotGridBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Allows an end-user to expand/collapse all header items within a header level.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowExpandAll(bool value)
		{
			base.Options["allowExpandAll"] = value;
			return this;
		}

		/// <summary>Allows an end-user to expand/collapse all header items within a header level.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowExpandAll(JS value)
		{
			base.Options["allowExpandAll"] = value;
			return this;
		}

		/// <summary>Allows a user to filter fields by selecting or deselecting values in the popup menu.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowFiltering(bool value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Allows a user to filter fields by selecting or deselecting values in the popup menu.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowFiltering(JS value)
		{
			base.Options["allowFiltering"] = value;
			return this;
		}

		/// <summary>Allows an end-user to change sorting options.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowSorting(bool value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Allows an end-user to change sorting options.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowSorting(JS value)
		{
			base.Options["allowSorting"] = value;
			return this;
		}

		/// <summary>Allows an end-user to sort columns by summary values.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowSortingBySummary(bool value)
		{
			base.Options["allowSortingBySummary"] = value;
			return this;
		}

		/// <summary>Allows an end-user to sort columns by summary values.</summary>
		[Generated]
		public PivotGridBuilder<T> AllowSortingBySummary(JS value)
		{
			base.Options["allowSortingBySummary"] = value;
			return this;
		}

		/// <summary>Specifies the area to which data field headers must belong.</summary>
		[Generated]
		public PivotGridBuilder<T> DataFieldArea(PivotGridDataFieldArea value)
		{
			base.Options["dataFieldArea"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public PivotGridBuilder<T> DataSource(Action<PivotGridDataSourceBuilder<T>> configurator)
		{
			NestedOptions("dataSource", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PivotGridBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public PivotGridBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PivotGridBuilder<T> ElementAttr(string attributeName, object value)
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
		public PivotGridBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PivotGridBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public PivotGridBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures client-side exporting.</summary>
		[Generated]
		public PivotGridBuilder<T> Export(Action<PivotGridExportBuilder> configurator)
		{
			NestedOptions("export", configurator);
			return this;
		}

		/// <summary>The Field Chooser configuration options.</summary>
		[Generated]
		public PivotGridBuilder<T> FieldChooser(Action<PivotGridFieldChooserBuilder> configurator)
		{
			NestedOptions("fieldChooser", configurator);
			return this;
		}

		/// <summary>Configures the field panel.</summary>
		[Generated]
		public PivotGridBuilder<T> FieldPanel(Action<PivotGridFieldPanelBuilder> configurator)
		{
			NestedOptions("fieldPanel", configurator);
			return this;
		}

		/// <summary>Configures the header filter feature.</summary>
		[Generated]
		public PivotGridBuilder<T> HeaderFilter(Action<PivotGridHeaderFilterBuilder> configurator)
		{
			NestedOptions("headerFilter", configurator);
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PivotGridBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PivotGridBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public PivotGridBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to hide rows and columns with no data.</summary>
		[Generated]
		public PivotGridBuilder<T> HideEmptySummaryCells(bool value)
		{
			base.Options["hideEmptySummaryCells"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to hide rows and columns with no data.</summary>
		[Generated]
		public PivotGridBuilder<T> HideEmptySummaryCells(JS value)
		{
			base.Options["hideEmptySummaryCells"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PivotGridBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public PivotGridBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies options configuring the load panel.</summary>
		[Generated]
		public PivotGridBuilder<T> LoadPanel(Action<PivotGridLoadPanelBuilder> configurator)
		{
			NestedOptions("loadPanel", configurator);
			return this;
		}

		/// <summary>A function that is executed when a pivot grid cell is clicked or tapped.</summary>
		[Generated]
		public PivotGridBuilder<T> OnCellClick(string jsFunc)
		{
			AssignJS("onCellClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a pivot grid cell is clicked or tapped.</summary>
		[Generated]
		public PivotGridBuilder<T> OnCellClick(RazorBlock jsFunc)
		{
			return OnCellClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a pivot grid cell is created.</summary>
		[Generated]
		public PivotGridBuilder<T> OnCellPrepared(string jsFunc)
		{
			AssignJS("onCellPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a pivot grid cell is created.</summary>
		[Generated]
		public PivotGridBuilder<T> OnCellPrepared(RazorBlock jsFunc)
		{
			return OnCellPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PivotGridBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public PivotGridBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public PivotGridBuilder<T> OnContextMenuPreparing(string jsFunc)
		{
			AssignJS("onContextMenuPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the context menu is rendered.</summary>
		[Generated]
		public PivotGridBuilder<T> OnContextMenuPreparing(RazorBlock jsFunc)
		{
			return OnContextMenuPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PivotGridBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public PivotGridBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after data is exported.</summary>
		[Generated]
		public PivotGridBuilder<T> OnExported(string jsFunc)
		{
			AssignJS("onExported", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after data is exported.</summary>
		[Generated]
		public PivotGridBuilder<T> OnExported(RazorBlock jsFunc)
		{
			return OnExported(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before data is exported.</summary>
		[Generated]
		public PivotGridBuilder<T> OnExporting(string jsFunc)
		{
			AssignJS("onExporting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before data is exported.</summary>
		[Generated]
		public PivotGridBuilder<T> OnExporting(RazorBlock jsFunc)
		{
			return OnExporting(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before a file with exported data is saved to the user's local storage.</summary>
		[Generated]
		public PivotGridBuilder<T> OnFileSaving(string jsFunc)
		{
			AssignJS("onFileSaving", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before a file with exported data is saved to the user's local storage.</summary>
		[Generated]
		public PivotGridBuilder<T> OnFileSaving(RazorBlock jsFunc)
		{
			return OnFileSaving(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PivotGridBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public PivotGridBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PivotGridBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public PivotGridBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the layout of items in the row header.</summary>
		[Generated]
		public PivotGridBuilder<T> RowHeaderLayout(PivotGridRowHeadersLayout value)
		{
			base.Options["rowHeaderLayout"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PivotGridBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public PivotGridBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>A configuration object specifying scrolling options.</summary>
		[Generated]
		public PivotGridBuilder<T> Scrolling(Action<PivotGridScrollingBuilder> configurator)
		{
			NestedOptions("scrolling", configurator);
			return this;
		}

		/// <summary>Specifies whether the outer borders of the grid are visible or not.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowBorders(bool value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether the outer borders of the grid are visible or not.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowBorders(JS value)
		{
			base.Options["showBorders"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Grand Total column.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowColumnGrandTotals(bool value)
		{
			base.Options["showColumnGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Grand Total column.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowColumnGrandTotals(JS value)
		{
			base.Options["showColumnGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Total columns.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowColumnTotals(bool value)
		{
			base.Options["showColumnTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Total columns.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowColumnTotals(JS value)
		{
			base.Options["showColumnTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Grand Total row.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowRowGrandTotals(bool value)
		{
			base.Options["showRowGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Grand Total row.</summary>
		[Generated]
		public PivotGridBuilder<T> ShowRowGrandTotals(JS value)
		{
			base.Options["showRowGrandTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Total rows. Applies only if rowHeaderLayout is "standard".</summary>
		[Generated]
		public PivotGridBuilder<T> ShowRowTotals(bool value)
		{
			base.Options["showRowTotals"] = value;
			return this;
		}

		/// <summary>Specifies whether to display the Total rows. Applies only if rowHeaderLayout is "standard".</summary>
		[Generated]
		public PivotGridBuilder<T> ShowRowTotals(JS value)
		{
			base.Options["showRowTotals"] = value;
			return this;
		}

		/// <summary>Specifies where to show the total rows or columns. Applies only if rowHeaderLayout is "standard".</summary>
		[Generated]
		public PivotGridBuilder<T> ShowTotalsPrior(PivotGridTotalsDisplayMode value)
		{
			base.Options["showTotalsPrior"] = value;
			return this;
		}

		/// <summary>A configuration object specifying options related to state storing.</summary>
		[Generated]
		public PivotGridBuilder<T> StateStoring(Action<PivotGridStateStoringBuilder> configurator)
		{
			NestedOptions("stateStoring", configurator);
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public PivotGridBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public PivotGridBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Strings that can be changed or localized in the PivotGrid widget.</summary>
		[Generated]
		public PivotGridBuilder<T> Texts(Action<PivotGridTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public PivotGridBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public PivotGridBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PivotGridBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PivotGridBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public PivotGridBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies whether long text in header items should be wrapped.</summary>
		[Generated]
		public PivotGridBuilder<T> WordWrapEnabled(bool value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether long text in header items should be wrapped.</summary>
		[Generated]
		public PivotGridBuilder<T> WordWrapEnabled(JS value)
		{
			base.Options["wordWrapEnabled"] = value;
			return this;
		}
	}
}
