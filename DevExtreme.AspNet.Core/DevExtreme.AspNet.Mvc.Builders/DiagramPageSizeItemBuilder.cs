namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array that specifies the page size items in the _Paze Size_ combobox on 'Properties' panel.</summary>
	public class DiagramPageSizeItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public DiagramPageSizeItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the page height.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the page height.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the display text.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the display text.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the page width.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the page width.</summary>
		[Generated]
		public DiagramPageSizeItemBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
