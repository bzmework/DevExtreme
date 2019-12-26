namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the options required to set the geometry of the CircularGauge widget.</summary>
	public class CircularGaugeGeometryBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeGeometryBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeGeometryBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the end angle of the circular gauge's arc.</summary>
		[Generated]
		public CircularGaugeGeometryBuilder EndAngle(double value)
		{
			base.Options["endAngle"] = value;
			return this;
		}

		/// <summary>Specifies the end angle of the circular gauge's arc.</summary>
		[Generated]
		public CircularGaugeGeometryBuilder EndAngle(JS value)
		{
			base.Options["endAngle"] = value;
			return this;
		}

		/// <summary>Specifies the start angle of the circular gauge's arc.</summary>
		[Generated]
		public CircularGaugeGeometryBuilder StartAngle(double value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Specifies the start angle of the circular gauge's arc.</summary>
		[Generated]
		public CircularGaugeGeometryBuilder StartAngle(JS value)
		{
			base.Options["startAngle"] = value;
			return this;
		}
	}
}
