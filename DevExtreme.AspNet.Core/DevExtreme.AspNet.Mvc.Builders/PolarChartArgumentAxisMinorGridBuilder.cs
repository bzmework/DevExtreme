namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options of the minor grid.</summary>
	public class PolarChartArgumentAxisMinorGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies an opacity for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether the minor grid is visible or not.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether the minor grid is visible or not.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid.</summary>
		[Generated]
		public PolarChartArgumentAxisMinorGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
