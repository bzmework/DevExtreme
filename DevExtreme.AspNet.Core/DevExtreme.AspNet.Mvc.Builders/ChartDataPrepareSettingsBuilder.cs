namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Processes data before visualizing it.</summary>
	public class ChartDataPrepareSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartDataPrepareSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Validates the type of each value coming from the data source.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder CheckTypeForAllData(bool value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Validates the type of each value coming from the data source.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder CheckTypeForAllData(JS value)
		{
			base.Options["checkTypeForAllData"] = value;
			return this;
		}

		/// <summary>Converts data coming from a data source into a data type supported by the axis.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder ConvertToAxisDataType(bool value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Converts data coming from a data source into a data type supported by the axis.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder ConvertToAxisDataType(JS value)
		{
			base.Options["convertToAxisDataType"] = value;
			return this;
		}

		/// <summary>Specifies the sorting order in which series points should be drawn.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder SortingMethod(bool value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}

		/// <summary>Specifies the sorting order in which series points should be drawn.</summary>
		[Generated]
		public ChartDataPrepareSettingsBuilder SortingMethod(JS value)
		{
			base.Options["sortingMethod"] = value;
			return this;
		}
	}
}
