namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the image to be displayed in the annotation. Applies only if the type is "image".</summary>
	public class ChartAnnotationConfigImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartAnnotationConfigImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the image's height in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the image's height in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the image's width in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the image's width in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigImageBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
