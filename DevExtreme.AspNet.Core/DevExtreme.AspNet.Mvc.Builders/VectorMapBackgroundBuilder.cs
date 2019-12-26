namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options for the map background.</summary>
	public class VectorMapBackgroundBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapBackgroundBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapBackgroundBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the background border.</summary>
		[Generated]
		public VectorMapBackgroundBuilder BorderColor(string value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the background border.</summary>
		[Generated]
		public VectorMapBackgroundBuilder BorderColor(JS value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the background.</summary>
		[Generated]
		public VectorMapBackgroundBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the background.</summary>
		[Generated]
		public VectorMapBackgroundBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}
	}
}
