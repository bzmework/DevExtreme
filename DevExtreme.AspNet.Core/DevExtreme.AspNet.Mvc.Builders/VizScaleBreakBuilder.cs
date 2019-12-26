using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A class describing a scale break range. Inherited by scale breaks in the Chart and RangeSelector.</summary>
	public class VizScaleBreakBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public VizScaleBreakBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VizScaleBreakBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder EndValue(DateTime value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder EndValue(string value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the startValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder StartValue(DateTime value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder StartValue(string value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Along with the endValue option, limits the scale break.</summary>
		[Generated]
		public VizScaleBreakBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}
	}
}
