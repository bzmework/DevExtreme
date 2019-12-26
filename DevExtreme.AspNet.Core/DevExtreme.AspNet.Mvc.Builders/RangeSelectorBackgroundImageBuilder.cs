namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies image options.</summary>
	public class RangeSelectorBackgroundImageBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorBackgroundImageBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorBackgroundImageBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a location for the image in the background of a range selector.</summary>
		[Generated]
		public RangeSelectorBackgroundImageBuilder Location(BackgroundImageLocation value)
		{
			base.Options["location"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public RangeSelectorBackgroundImageBuilder Url(string value)
		{
			base.Options["url"] = value;
			return this;
		}

		/// <summary>Specifies the image's URL.</summary>
		[Generated]
		public RangeSelectorBackgroundImageBuilder Url(JS value)
		{
			base.Options["url"] = value;
			return this;
		}
	}
}
