namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines options for the series template.</summary>
	public class RangeSelectorChartSeriesTemplateBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns a series object with individual series settings.</summary>
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder CustomizeSeries(string jsFunc)
		{
			AssignJS("customizeSeries", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns a series object with individual series settings.</summary>
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder CustomizeSeries(RazorBlock jsFunc)
		{
			return CustomizeSeries(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a data source field that represents the series name.</summary>
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder NameField(string value)
		{
			base.Options["nameField"] = value;
			return this;
		}

		/// <summary>Specifies a data source field that represents the series name.</summary>
		[Generated]
		public RangeSelectorChartSeriesTemplateBuilder NameField(JS value)
		{
			base.Options["nameField"] = value;
			return this;
		}
	}
}
