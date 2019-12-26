namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object specifying the parameters of an image that is used as a point marker.</summary>
	public class PolarChartCommonSeriesSettingsPointImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a URL leading to the image to be used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies a URL leading to the image to be used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public PolarChartCommonSeriesSettingsPointImageBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
