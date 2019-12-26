namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the borders of point labels.</summary>
	public class ChartCommonSeriesSettingsLabelBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the border.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the border.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the border.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Makes the border visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the border visible.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the border in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the border in pixels.</summary>
		[Generated]
		public ChartCommonSeriesSettingsLabelBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
