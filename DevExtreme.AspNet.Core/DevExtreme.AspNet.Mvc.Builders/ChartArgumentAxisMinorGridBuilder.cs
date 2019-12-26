namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the minor grid.</summary>
	public class ChartArgumentAxisMinorGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisMinorGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartArgumentAxisMinorGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
