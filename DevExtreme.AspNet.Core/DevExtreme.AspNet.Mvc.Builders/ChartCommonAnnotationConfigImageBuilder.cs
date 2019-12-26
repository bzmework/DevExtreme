namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
	public class ChartCommonAnnotationConfigImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the image's height in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the image's height in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the image's width in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the image's width in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigImageBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
