namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the border options for a hovered point.</summary>
	public class PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets a border color for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets border visibility for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Sets a border width for a hovered point.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
