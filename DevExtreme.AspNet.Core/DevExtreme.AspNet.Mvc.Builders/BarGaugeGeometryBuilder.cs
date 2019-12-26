namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines the shape of the gauge's arc.</summary>
	public class BarGaugeGeometryBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeGeometryBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeGeometryBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the end angle of the bar gauge's arc.</summary>
		[Generated]
		public BarGaugeGeometryBuilder EndAngle(double value)
		{
			base.Options["endAngle"] = value;
			return this;
		}

		/// <summary>Specifies the end angle of the bar gauge's arc.</summary>
		[Generated]
		public BarGaugeGeometryBuilder EndAngle(JS value)
		{
			base.Options["endAngle"] = value;
			return this;
		}

		/// <summary>Specifies the start angle of the bar gauge's arc.</summary>
		[Generated]
		public BarGaugeGeometryBuilder StartAngle(double value)
		{
			base.Options["startAngle"] = value;
			return this;
		}

		/// <summary>Specifies the start angle of the bar gauge's arc.</summary>
		[Generated]
		public BarGaugeGeometryBuilder StartAngle(JS value)
		{
			base.Options["startAngle"] = value;
			return this;
		}
	}
}
