namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of major axis ticks.</summary>
	public class ChartArgumentAxisTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartArgumentAxisTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
