namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of the range selector's slider handles.</summary>
	public class RangeSelectorSliderHandleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorSliderHandleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the width of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the slider handles.</summary>
		[Generated]
		public RangeSelectorSliderHandleBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
