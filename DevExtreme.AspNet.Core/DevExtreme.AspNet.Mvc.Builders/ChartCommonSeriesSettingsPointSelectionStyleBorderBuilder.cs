namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the border of a selected point.</summary>
	public class ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is selected.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is selected.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the border of a selected point visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the border of a selected point visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is selected.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is selected.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
