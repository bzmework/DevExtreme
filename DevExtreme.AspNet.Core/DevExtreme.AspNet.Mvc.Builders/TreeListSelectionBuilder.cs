namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures runtime selection.</summary>
	public class TreeListSelectionBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListSelectionBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListSelectionBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can select all rows at once.</summary>
		[Generated]
		public TreeListSelectionBuilder AllowSelectAll(bool value)
		{
			base.Options["allowSelectAll"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can select all rows at once.</summary>
		[Generated]
		public TreeListSelectionBuilder AllowSelectAll(JS value)
		{
			base.Options["allowSelectAll"] = value;
			return this;
		}

		/// <summary>Specifies the selection mode.</summary>
		[Generated]
		public TreeListSelectionBuilder Mode(SelectionMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Specifies whether selection is recursive.</summary>
		[Generated]
		public TreeListSelectionBuilder Recursive(bool value)
		{
			base.Options["recursive"] = value;
			return this;
		}

		/// <summary>Specifies whether selection is recursive.</summary>
		[Generated]
		public TreeListSelectionBuilder Recursive(JS value)
		{
			base.Options["recursive"] = value;
			return this;
		}
	}
}
