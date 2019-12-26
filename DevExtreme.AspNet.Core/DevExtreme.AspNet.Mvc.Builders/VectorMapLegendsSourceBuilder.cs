namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the source of data for the legend.</summary>
	public class VectorMapLegendsSourceBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapLegendsSourceBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLegendsSourceBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the type of the legend grouping.</summary>
		[Generated]
		public VectorMapLegendsSourceBuilder Grouping(string value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies the type of the legend grouping.</summary>
		[Generated]
		public VectorMapLegendsSourceBuilder Grouping(JS value)
		{
			base.Options["grouping"] = value;
			return this;
		}

		/// <summary>Specifies a layer to which the legend belongs.</summary>
		[Generated]
		public VectorMapLegendsSourceBuilder Layer(string value)
		{
			base.Options["layer"] = value;
			return this;
		}

		/// <summary>Specifies a layer to which the legend belongs.</summary>
		[Generated]
		public VectorMapLegendsSourceBuilder Layer(JS value)
		{
			base.Options["layer"] = value;
			return this;
		}
	}
}
