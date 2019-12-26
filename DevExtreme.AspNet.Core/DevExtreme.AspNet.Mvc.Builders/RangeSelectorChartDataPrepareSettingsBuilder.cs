namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object providing options for managing data from a data source.</summary>
	public class RangeSelectorChartDataPrepareSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not to validate values from a data source.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder CheckTypeForAllData(bool value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to validate values from a data source.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder CheckTypeForAllData(JS value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to convert the values from a data source into the data type of an axis.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder ConvertToAxisDataType(bool value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to convert the values from a data source into the data type of an axis.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder ConvertToAxisDataType(JS value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Specifies how to sort series points.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder SortingMethod(bool value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}

		/// <summary>Specifies how to sort series points.</summary>
		[Generated]
		public RangeSelectorChartDataPrepareSettingsBuilder SortingMethod(JS value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}
	}
}
