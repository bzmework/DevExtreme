namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for displaying the widget.</summary>
	public class TooltipShowEventBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TooltipShowEventBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TooltipShowEventBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public TooltipShowEventBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public TooltipShowEventBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public TooltipShowEventBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public TooltipShowEventBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
