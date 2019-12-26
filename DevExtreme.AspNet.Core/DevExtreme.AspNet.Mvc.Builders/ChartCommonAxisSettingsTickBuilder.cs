namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of major axis ticks.</summary>
	public class ChartCommonAxisSettingsTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of ticks.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the length of ticks in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent ticks should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Shift(double value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Shifts ticks from the reference position.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Shift(JS value)
		{
			base.Options["shift"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes ticks visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of ticks in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
