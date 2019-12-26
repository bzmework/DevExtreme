namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of objects representing ranges contained in the range container.</summary>
	public class LinearGaugeRangeContainerRangeBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public LinearGaugeRangeContainerRangeBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies an end value of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies an end value of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies a start value of a range.</summary>
		[Generated]
		public LinearGaugeRangeContainerRangeBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
