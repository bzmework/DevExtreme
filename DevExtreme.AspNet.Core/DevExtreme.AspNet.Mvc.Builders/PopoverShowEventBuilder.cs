namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for displaying the widget.</summary>
	public class PopoverShowEventBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PopoverShowEventBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PopoverShowEventBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public PopoverShowEventBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public PopoverShowEventBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public PopoverShowEventBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public PopoverShowEventBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
