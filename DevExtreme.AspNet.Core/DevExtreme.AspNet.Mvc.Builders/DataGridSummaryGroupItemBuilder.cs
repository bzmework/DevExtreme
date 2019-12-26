using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies items of the group summary.</summary>
	public class DataGridSummaryGroupItemBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DataGridSummaryGroupItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Indicates whether to display group summary items in parentheses after the group row header or to align them by the corresponding columns within the group row.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> AlignByColumn(bool value)
		{
			base.Options["alignByColumn"] = value;
			return this;
		}

		/// <summary>Indicates whether to display group summary items in parentheses after the group row header or to align them by the corresponding columns within the group row.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> AlignByColumn(JS value)
		{
			base.Options["alignByColumn"] = value;
			return this;
		}

		/// <summary>Specifies the column that provides data for a group summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> Column(string value)
		{
			base.Options["column"] = value;
			return this;
		}

		/// <summary>Specifies the column that provides data for a group summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> Column(JS value)
		{
			base.Options["column"] = value;
			return this;
		}

		/// <summary>Customizes the text to be displayed in the summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the text to be displayed in the summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the summary item's text.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> DisplayFormat(string value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the summary item's text.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> DisplayFormat(JS value)
		{
			base.Options["displayFormat"] = value;
			return this;
		}

		/// <summary>Specifies the group summary item's identifier.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the group summary item's identifier.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the column that must hold the summary item when this item is displayed in the group footer or aligned by a column in the group row.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ShowInColumn(string value)
		{
			base.Options["showInColumn"] = value;
			return this;
		}

		/// <summary>Specifies the column that must hold the summary item when this item is displayed in the group footer or aligned by a column in the group row.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ShowInColumn(JS value)
		{
			base.Options["showInColumn"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a summary item must be displayed in the group footer.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ShowInGroupFooter(bool value)
		{
			base.Options["showInGroupFooter"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a summary item must be displayed in the group footer.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ShowInGroupFooter(JS value)
		{
			base.Options["showInGroupFooter"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> SkipEmptyValues(bool value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to skip empty strings, null and undefined values when calculating a summary.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> SkipEmptyValues(JS value)
		{
			base.Options["skipEmptyValues"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the group summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> SummaryType(SummaryType value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the group summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> SummaryType(string value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies how to aggregate data for the group summary item.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> SummaryType(JS value)
		{
			base.Options["summaryType"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ValueFormat(Format value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ValueFormat(string value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ValueFormat(JS value)
		{
			base.Options["valueFormat"] = value;
			return this;
		}

		/// <summary>Specifies a summary item value's display format.</summary>
		[Generated]
		public DataGridSummaryGroupItemBuilder<T> ValueFormat(Action<FormatBuilder> configurator)
		{
			NestedOptions("valueFormat", configurator);
			return this;
		}
	}
}
