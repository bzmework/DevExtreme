namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options of popover hiding.</summary>
	public class PopoverHideEventBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PopoverHideEventBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PopoverHideEventBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is hidden.</summary>
		[Generated]
		public PopoverHideEventBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is hidden.</summary>
		[Generated]
		public PopoverHideEventBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is hidden.</summary>
		[Generated]
		public PopoverHideEventBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is hidden.</summary>
		[Generated]
		public PopoverHideEventBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
