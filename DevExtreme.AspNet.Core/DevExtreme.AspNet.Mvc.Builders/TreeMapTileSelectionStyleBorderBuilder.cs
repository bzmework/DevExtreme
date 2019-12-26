namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the tile borders in the selected state.</summary>
	public class TreeMapTileSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the tile borders in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the tile borders in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels. Applies to a tile in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels. Applies to a tile in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
