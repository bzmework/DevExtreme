namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of objects representing ranges contained in the range container.</summary>
	public class CircularGaugeRangeContainerRangeBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public CircularGaugeRangeContainerRangeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an end value of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value of a range.</summary>
		[Generated]
		public CircularGaugeRangeContainerRangeBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
