namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies dependency between the screen factor and the count of columns in the form layout.</summary>
	public class FormColCountByScreenBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FormColCountByScreenBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormColCountByScreenBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormColCountByScreenBuilder Lg(int value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a large screen size.</summary>
		[Generated]
		public FormColCountByScreenBuilder Lg(JS value)
		{
			base.Options["lg"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Md(int value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a middle-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Md(JS value)
		{
			base.Options["md"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Sm(int value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for a small-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Sm(JS value)
		{
			base.Options["sm"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Xs(int value)
		{
			base.Options["xs"] = value;
			return this;
		}

		/// <summary>The count of columns for an extra small-sized screen.</summary>
		[Generated]
		public FormColCountByScreenBuilder Xs(JS value)
		{
			base.Options["xs"] = value;
			return this;
		}
	}
}
