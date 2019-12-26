namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of major axis ticks.</summary>
	public class ChartValueAxisTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
