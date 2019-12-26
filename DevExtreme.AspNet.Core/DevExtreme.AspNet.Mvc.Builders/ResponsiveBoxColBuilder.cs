namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the collection of columns for the grid used to position layout elements.</summary>
	public class ResponsiveBoxColBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ResponsiveBoxColBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The column's base width. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxColBuilder BaseSize(Mode value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The column's base width. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxColBuilder BaseSize(double value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The column's base width. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxColBuilder BaseSize(JS value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The column width ratio.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Ratio(double value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>The column width ratio.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Ratio(JS value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current column is rendered.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Screen(string value)
		{
			base.Options["screen"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current column is rendered.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Screen(JS value)
		{
			base.Options["screen"] = value;
			return this;
		}

		/// <summary>A factor that defines how much a column width shrinks relative to the rest of the columns in the container.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Shrink(double value)
		{
			base.Options["shrink"] = value;
			return this;
		}

		/// <summary>A factor that defines how much a column width shrinks relative to the rest of the columns in the container.</summary>
		[Generated]
		public ResponsiveBoxColBuilder Shrink(JS value)
		{
			base.Options["shrink"] = value;
			return this;
		}
	}
}
