namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the width of the range container's start and end boundaries in the LinearGauge widget.</summary>
	public class LinearGaugeRangeContainerWidthBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies an end width of a range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder End(double value)
		{
			base.Options["end"] = value;
			return this;
		}

		/// <summary>Specifies an end width of a range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder End(JS value)
		{
			base.Options["end"] = value;
			return this;
		}

		/// <summary>Specifies a start width of a range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder Start(double value)
		{
			base.Options["start"] = value;
			return this;
		}

		/// <summary>Specifies a start width of a range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerWidthBuilder Start(JS value)
		{
			base.Options["start"] = value;
			return this;
		}
	}
}
