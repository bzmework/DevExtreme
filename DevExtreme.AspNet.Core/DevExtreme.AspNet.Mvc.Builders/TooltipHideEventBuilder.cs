namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of popover hiding.</summary>
	public class TooltipHideEventBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TooltipHideEventBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TooltipHideEventBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is hidden.</summary>
		[Generated]
		public TooltipHideEventBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is hidden.</summary>
		[Generated]
		public TooltipHideEventBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is hidden.</summary>
		[Generated]
		public TooltipHideEventBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is hidden.</summary>
		[Generated]
		public TooltipHideEventBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
