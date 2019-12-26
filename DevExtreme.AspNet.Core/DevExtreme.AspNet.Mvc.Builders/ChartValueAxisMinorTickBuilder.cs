namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of minor axis ticks.</summary>
	public class ChartValueAxisMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of minor ticks.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of minor ticks.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of minor ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of minor ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies how transparent minor ticks should be.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent minor ticks should be.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts minor ticks from the reference position.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts minor ticks from the reference position.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Makes minor ticks visible.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes minor ticks visible.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of minor ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of minor ticks in pixels.</summary>
		[Generated]
		public ChartValueAxisMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
