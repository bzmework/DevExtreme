namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the minor grid.</summary>
	public class ChartCommonAxisSettingsMinorGridBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the lines of the minor grid.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the lines of the minor grid should be.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the minor grid visible.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies a width for the lines of the minor grid in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsMinorGridBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
