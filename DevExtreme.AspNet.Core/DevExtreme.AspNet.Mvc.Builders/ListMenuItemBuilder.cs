namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the array of items for a context menu called for a list item.</summary>
	public class ListMenuItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ListMenuItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ListMenuItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Holds on a function called when the item is clicked.</summary>
		[Generated]
		public ListMenuItemBuilder Action(string jsFunc)
		{
			AssignJS("action", jsFunc);
			return this;
		}

		/// <summary>Holds on a function called when the item is clicked.</summary>
		[Generated]
		public ListMenuItemBuilder Action(RazorBlock jsFunc)
		{
			return Action(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the menu item text.</summary>
		[Generated]
		public ListMenuItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the menu item text.</summary>
		[Generated]
		public ListMenuItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
