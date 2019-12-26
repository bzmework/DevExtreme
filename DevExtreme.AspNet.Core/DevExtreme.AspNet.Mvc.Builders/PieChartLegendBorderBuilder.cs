namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend's border.</summary>
	public class PieChartLegendBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartLegendBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes all the legend's corners rounded.</summary>
		[Generated]
		public PieChartLegendBorderBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes all the legend's corners rounded.</summary>
		[Generated]
		public PieChartLegendBorderBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Sets a dash style for the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the transparency of the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shows the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the legend's border.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the legend's border in pixels.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the legend's border in pixels.</summary>
		[Generated]
		public PieChartLegendBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
