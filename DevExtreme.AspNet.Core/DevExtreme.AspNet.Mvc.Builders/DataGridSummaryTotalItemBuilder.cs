using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies items of the total summary.</summary>
	public class DataGridSummaryTotalItemBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DataGridSummaryTotalItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the alignment of a summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies the column that provides data for a summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Column(string value)
		{
			base.Options["column"] = value;
			return this;
		}

		/// <summary>Specifies the column that provides data for a summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Column(JS value)
		{
			base.Options["column"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to a summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to a summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Customizes the text to be displayed in the summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text to be displayed in the summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the summary item's text.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> DisplayFormat(string value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the summary item's text.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> DisplayFormat(JS value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the total summary item's identifier.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the total summary item's identifier.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the column that must hold the summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ShowInColumn(string value)
		{
			base.Options["showInColumn"] = value;
			return this;
		}

		/// <summary>Specifies the column that must hold the summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ShowInColumn(JS value)
		{
			base.Options["showInColumn"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> SkipEmptyValues(bool value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> SkipEmptyValues(JS value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the total summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> SummaryType(SummaryType value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the total summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> SummaryType(string value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the total summary item.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> SummaryType(JS value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ValueFormat(Format value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ValueFormat(string value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ValueFormat(JS value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryTotalItemBuilder<T> ValueFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("valueFormat", configurator);
			return this;
		}
	}
}
