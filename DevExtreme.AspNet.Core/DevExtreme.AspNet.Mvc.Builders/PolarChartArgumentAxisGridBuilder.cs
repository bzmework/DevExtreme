namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining the configuration options for the grid lines of an axis in the PolarChart widget.</summary>
	public class PolarChartArgumentAxisGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the grid lines of an axis are visible.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not the grid lines of an axis are visible.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines.</summary>
		[Generated]
		public PolarChartArgumentAxisGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
