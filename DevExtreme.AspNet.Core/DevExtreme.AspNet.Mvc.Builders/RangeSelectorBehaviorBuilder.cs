namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the RangeSelector's behavior options.</summary>
	public class RangeSelectorBehaviorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public RangeSelectorBehaviorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Indicates whether or not you can swap sliders.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder AllowSlidersSwap(bool value)
		{
			base.Options["allowSlidersSwap"] = value;
			return this;
		}

		/// <summary>Indicates whether or not you can swap sliders.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder AllowSlidersSwap(JS value)
		{
			base.Options["allowSlidersSwap"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder AnimationEnabled(bool value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether or not animation is enabled.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder AnimationEnabled(JS value)
		{
			base.Options["animationEnabled"] = value;
			return this;
		}

		/// <summary>Specifies when to call the onValueChanged function.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder CallValueChanged(ValueChangedCallMode value)
		{
			base.Options["callValueChanged"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an end user can specify the range using a mouse, without the use of sliders.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder ManualRangeSelectionEnabled(bool value)
		{
			base.Options["manualRangeSelectionEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an end user can specify the range using a mouse, without the use of sliders.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder ManualRangeSelectionEnabled(JS value)
		{
			base.Options["manualRangeSelectionEnabled"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an end user can shift the selected range to the required location on a scale by clicking.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder MoveSelectedRangeByClick(bool value)
		{
			base.Options["moveSelectedRangeByClick"] = value;
			return this;
		}

		/// <summary>Indicates whether or not an end user can shift the selected range to the required location on a scale by clicking.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder MoveSelectedRangeByClick(JS value)
		{
			base.Options["moveSelectedRangeByClick"] = value;
			return this;
		}

		/// <summary>Indicates whether to snap a slider to ticks.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder SnapToTicks(bool value)
		{
			base.Options["snapToTicks"] = value;
			return this;
		}

		/// <summary>Indicates whether to snap a slider to ticks.</summary>
		[Generated]
		public RangeSelectorBehaviorBuilder SnapToTicks(JS value)
		{
			base.Options["snapToTicks"] = value;
			return this;
		}
	}
}
