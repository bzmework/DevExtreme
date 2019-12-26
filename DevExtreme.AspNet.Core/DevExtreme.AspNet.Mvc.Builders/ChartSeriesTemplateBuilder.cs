namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines options for the series template.</summary>
	public class ChartSeriesTemplateBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesTemplateBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesTemplateBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a callback function that returns a series object with individual series settings.</summary>
		[Generated]
		public ChartSeriesTemplateBuilder CustomizeSeries(string jsFunc)
		{
			AssignJS("customizeSeries", jsFunc);
			return this;
		}

		/// <summary>Specifies a callback function that returns a series object with individual series settings.</summary>
		[Generated]
		public ChartSeriesTemplateBuilder CustomizeSeries(RazorBlock jsFunc)
		{
			return CustomizeSeries(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a data source field that represents the series name.</summary>
		[Generated]
		public ChartSeriesTemplateBuilder NameField(string value)
		{
			base.Options["nameField"] = value;
			return this;
		}

		/// <summary>Specifies a data source field that represents the series name.</summary>
		[Generated]
		public ChartSeriesTemplateBuilder NameField(JS value)
		{
			base.Options["nameField"] = value;
			return this;
		}
	}
}
