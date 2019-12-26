namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the tile borders in the hover state.</summary>
	public class TreeMapTileHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the tile borders in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the tile borders in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels. Applies to a tile in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels. Applies to a tile in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
