namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the item location and size against the widget grid.</summary>
	public class ResponsiveBoxItemsLocationBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public ResponsiveBoxItemsLocationBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies which column the element should occupy. Accepts an index from the cols array.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Col(int value)
		{
			base.Options["col"] = value;
			return this;
		}

		/// <summary>Specifies which column the element should occupy. Accepts an index from the cols array.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Col(JS value)
		{
			base.Options["col"] = value;
			return this;
		}

		/// <summary>Specifies how many columns the element should span.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Colspan(int value)
		{
			base.Options["colspan"] = value;
			return this;
		}

		/// <summary>Specifies how many columns the element should span.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Colspan(JS value)
		{
			base.Options["colspan"] = value;
			return this;
		}

		/// <summary>Specifies which row the element should occupy. Accepts an index from the rows array.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Row(int value)
		{
			base.Options["row"] = value;
			return this;
		}

		/// <summary>Specifies which row the element should occupy. Accepts an index from the rows array.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Row(JS value)
		{
			base.Options["row"] = value;
			return this;
		}

		/// <summary>Specifies how many rows the element should span.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Rowspan(int value)
		{
			base.Options["rowspan"] = value;
			return this;
		}

		/// <summary>Specifies how many rows the element should span.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Rowspan(JS value)
		{
			base.Options["rowspan"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current location settings should be applied to the element.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Screen(string value)
		{
			base.Options["screen"] = value;
			return this;
		}

		/// <summary>Decides on which screens the current location settings should be applied to the element.</summary>
		[Generated]
		public ResponsiveBoxItemsLocationBuilder Screen(JS value)
		{
			base.Options["screen"] = value;
			return this;
		}
	}
}
