namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the grid.</summary>
	public class ChartCommonAxisSettingsGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of grid lines.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent grid lines should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes grid lines visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of grid lines in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
