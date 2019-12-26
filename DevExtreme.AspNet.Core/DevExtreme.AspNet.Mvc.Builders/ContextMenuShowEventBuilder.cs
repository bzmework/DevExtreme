namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options for displaying the widget.</summary>
	public class ContextMenuShowEventBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ContextMenuShowEventBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ContextMenuShowEventBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public ContextMenuShowEventBuilder Delay(double value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>The delay in milliseconds after which the widget is displayed.</summary>
		[Generated]
		public ContextMenuShowEventBuilder Delay(JS value)
		{
			base.Options["delay"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public ContextMenuShowEventBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies the event names on which the widget is shown.</summary>
		[Generated]
		public ContextMenuShowEventBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}
	}
}
