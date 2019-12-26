using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Substitutes the standard point symbols with an image.</summary>
	public class ChartSeriesPointImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Height(Action<ChartSeriesPointImageHeightBuilder> configurator)
		{
			NestedOptions("height", configurator);
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the image used instead of a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Url(Action<ChartSeriesPointImageUrlBuilder> configurator)
		{
			NestedOptions("url", configurator);
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the URL of the image to be used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Width(Action<ChartSeriesPointImageWidthBuilder> configurator)
		{
			NestedOptions("width", configurator);
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of an image that is used as a point marker.</summary>
		[Generated]
		public ChartSeriesPointImageBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
