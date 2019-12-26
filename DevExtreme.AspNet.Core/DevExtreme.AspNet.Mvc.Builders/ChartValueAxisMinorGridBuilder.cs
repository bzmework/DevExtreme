namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the minor grid.</summary>
	public class ChartValueAxisMinorGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisMinorGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
