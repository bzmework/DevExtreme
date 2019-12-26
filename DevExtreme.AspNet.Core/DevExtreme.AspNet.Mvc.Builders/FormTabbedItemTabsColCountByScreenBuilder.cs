namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the relation between the screen size qualifier and the number of columns in the tabbed layout.</summary>
	public class FormTabbedItemTabsColCountByScreenBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Lg(int value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Lg(JS value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Md(int value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Md(JS value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Sm(int value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Sm(JS value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Xs(int value)
		{
			base.Options["xs"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormTabbedItemTabsColCountByScreenBuilder Xs(JS value)
		{
			base.Options["xs"] = value;
			return this;
		}
	}
}
