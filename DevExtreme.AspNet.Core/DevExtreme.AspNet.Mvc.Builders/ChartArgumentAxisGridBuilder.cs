namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the grid.</summary>
	public class ChartArgumentAxisGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartArgumentAxisGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
