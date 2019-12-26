namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the relation between the screen size qualifier and the number of columns in the grouped layout.</summary>
	public class FormGroupItemColCountByScreenBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FormGroupItemColCountByScreenBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Lg(int value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Lg(JS value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Md(int value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Md(JS value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Sm(int value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Sm(JS value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Xs(int value)
		{
			base.Options["xs"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormGroupItemColCountByScreenBuilder Xs(JS value)
		{
			base.Options["xs"] = value;
			return this;
		}
	}
}
