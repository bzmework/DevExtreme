namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options required to set the geometry of the LinearGauge widget.</summary>
	public class LinearGaugeGeometryBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeGeometryBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeGeometryBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Indicates whether to display the LinearGauge widget vertically or horizontally.</summary>
		[Generated]
		public LinearGaugeGeometryBuilder Orientation(Orientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}
	}
}
