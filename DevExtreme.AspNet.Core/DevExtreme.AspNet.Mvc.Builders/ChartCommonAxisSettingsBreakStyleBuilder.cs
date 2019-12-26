namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the scale breaks' appearance.</summary>
	public class ChartCommonAxisSettingsBreakStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' line style.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Line(ScaleBreakLineStyle value)
		{
			base.Options["line"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public ChartCommonAxisSettingsBreakStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
