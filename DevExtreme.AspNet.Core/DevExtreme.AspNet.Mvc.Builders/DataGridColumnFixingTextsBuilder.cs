namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Contains options that specify texts for column fixing commands in the context menu of a column header.</summary>
	public class DataGridColumnFixingTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridColumnFixingTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that fixes a column.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder Fix(string value)
		{
			base.Options["fix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that fixes a column.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder Fix(JS value)
		{
			base.Options["fix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the left edge of the widget.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder LeftPosition(string value)
		{
			base.Options["leftPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the left edge of the widget.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder LeftPosition(JS value)
		{
			base.Options["leftPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the right edge of the widget.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder RightPosition(string value)
		{
			base.Options["rightPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu subitem that fixes a column to the right edge of the widget.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder RightPosition(JS value)
		{
			base.Options["rightPosition"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that unfixes a column.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder Unfix(string value)
		{
			base.Options["unfix"] = value;
			return this;
		}

		/// <summary>Specifies text for the context menu item that unfixes a column.</summary>
		[Generated]
		public DataGridColumnFixingTextsBuilder Unfix(JS value)
		{
			base.Options["unfix"] = value;
			return this;
		}
	}
}
