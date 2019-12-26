namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the grid.</summary>
	public class ChartValueAxisGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartValueAxisGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
