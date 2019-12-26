using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Substitutes the standard point symbols with an image.</summary>
	public class ChartCommonSeriesSettingsPointImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Height(Action<ChartCommonSeriesSettingsPointImageHeightBuilder> configurator)
		{
			NestedOptions("height", configurator);
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Url(Action<ChartCommonSeriesSettingsPointImageUrlBuilder> configurator)
		{
			NestedOptions("url", configurator);
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Width(Action<ChartCommonSeriesSettingsPointImageWidthBuilder> configurator)
		{
			NestedOptions("width", configurator);
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartCommonSeriesSettingsPointImageBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
