namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the scale breaks' appearance.</summary>
	public class RangeSelectorScaleBreakStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' color.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' line style.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Line(ScaleBreakLineStyle value)
		{
			base.Options["line"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the scale breaks' width in pixels.</summary>
		[Generated]
		public RangeSelectorScaleBreakStyleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
