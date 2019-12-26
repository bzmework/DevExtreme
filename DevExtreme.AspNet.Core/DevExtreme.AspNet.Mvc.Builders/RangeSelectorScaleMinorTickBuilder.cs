namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of the range selector's minor ticks.</summary>
	public class RangeSelectorScaleMinorTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleMinorTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether scale minor ticks are visible or not.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's minor ticks.</summary>
		[Generated]
		public RangeSelectorScaleMinorTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
