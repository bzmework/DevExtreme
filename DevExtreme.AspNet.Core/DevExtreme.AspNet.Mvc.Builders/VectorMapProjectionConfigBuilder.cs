namespace DevExtreme.AspNet.Mvc.Builders
{
	public class VectorMapProjectionConfigBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapProjectionConfigBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the projection's ratio of the width to the height.</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder AspectRatio(double value)
		{
			base.Options["aspectRatio"] = value;
			return this;
		}

		/// <summary>Specifies the projection's ratio of the width to the height.</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder AspectRatio(JS value)
		{
			base.Options["aspectRatio"] = value;
			return this;
		}

		/// <summary>Converts coordinates from [x, y] to [lon, lat].</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder From(string jsFunc)
		{
			AssignJS("from", jsFunc);
			return this;
		}

		/// <summary>Converts coordinates from [x, y] to [lon, lat].</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder From(RazorBlock jsFunc)
		{
			return From(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Converts coordinates from [lon, lat] to [x, y].</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder To(string jsFunc)
		{
			AssignJS("to", jsFunc);
			return this;
		}

		/// <summary>Converts coordinates from [lon, lat] to [x, y].</summary>
		[Generated]
		public VectorMapProjectionConfigBuilder To(RazorBlock jsFunc)
		{
			return To(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
