namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object providing options for managing data from a data source.</summary>
	public class PolarChartDataPrepareSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartDataPrepareSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not to validate the values from a data source.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder CheckTypeForAllData(bool value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to validate the values from a data source.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder CheckTypeForAllData(JS value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to convert the values from a data source into the data type of an axis.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder ConvertToAxisDataType(bool value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to convert the values from a data source into the data type of an axis.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder ConvertToAxisDataType(JS value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Specifies how to sort the series points.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder SortingMethod(bool value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}

		/// <summary>Specifies how to sort the series points.</summary>
		[Generated]
		public PolarChartDataPrepareSettingsBuilder SortingMethod(JS value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}
	}
}
