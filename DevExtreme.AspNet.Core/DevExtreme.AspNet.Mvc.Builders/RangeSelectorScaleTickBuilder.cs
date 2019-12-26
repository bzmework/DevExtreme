namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options defining the appearance of scale ticks.</summary>
	public class RangeSelectorScaleTickBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorScaleTickBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of scale ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of scale ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of scale ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of scale ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scale's ticks (both major and minor ticks).</summary>
		[Generated]
		public RangeSelectorScaleTickBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
