namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify texts for column fixing commands in the context menu of a column header.</summary>
	public class TreeListColumnFixingTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListColumnFixingTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that fixes a column.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder Fix(string value)
		{
			base.Options["fix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that fixes a column.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder Fix(JS value)
		{
			base.Options["fix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the left edge of the widget.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder LeftPosition(string value)
		{
			base.Options["leftPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the left edge of the widget.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder LeftPosition(JS value)
		{
			base.Options["leftPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the right edge of the widget.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder RightPosition(string value)
		{
			base.Options["rightPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the right edge of the widget.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder RightPosition(JS value)
		{
			base.Options["rightPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that unfixes a column.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder Unfix(string value)
		{
			base.Options["unfix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that unfixes a column.</summary>
		[Generated]
		public TreeListColumnFixingTextsBuilder Unfix(JS value)
		{
			base.Options["unfix"] = value;
			return this;
		}
	}
}
