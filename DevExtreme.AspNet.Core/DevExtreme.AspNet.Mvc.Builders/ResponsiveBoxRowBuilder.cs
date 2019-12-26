namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the collection of rows for the grid used to position layout elements.</summary>
	public class ResponsiveBoxRowBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ResponsiveBoxRowBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The row's base height. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder BaseSize(Mode value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The row's base height. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder BaseSize(double value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The row's base height. Calculated automatically when the singleColumnScreen option arranges all elements in a single column.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder BaseSize(JS value)
		{
			base.Options["baseSize"] = value;
			return this;
		}

		/// <summary>The row height ratio.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Ratio(double value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>The row height ratio.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Ratio(JS value)
		{
			base.Options["ratio"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current row is rendered.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Screen(string value)
		{
			base.Options["screen"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current row is rendered.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Screen(JS value)
		{
			base.Options["screen"] = value;
			return this;
		}

		/// <summary>A factor that defines how much a row height shrinks relative to the rest of the rows in the container.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Shrink(double value)
		{
			base.Options["shrink"] = value;
			return this;
		}

		/// <summary>A factor that defines how much a row height shrinks relative to the rest of the rows in the container.</summary>
		[Generated]
		public ResponsiveBoxRowBuilder Shrink(JS value)
		{
			base.Options["shrink"] = value;
			return this;
		}
	}
}
