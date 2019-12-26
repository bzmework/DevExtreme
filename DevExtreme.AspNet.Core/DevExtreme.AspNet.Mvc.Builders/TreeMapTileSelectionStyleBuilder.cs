using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of tiles in the selected state.</summary>
	public class TreeMapTileSelectionStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileSelectionStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the tile borders in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBuilder Border(Action<TreeMapTileSelectionStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors tiles in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors tiles in the selected state.</summary>
		[Generated]
		public TreeMapTileSelectionStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}
	}
}
