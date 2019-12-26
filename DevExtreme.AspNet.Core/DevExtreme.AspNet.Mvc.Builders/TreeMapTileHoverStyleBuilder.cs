using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of tiles in the hover state.</summary>
	public class TreeMapTileHoverStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileHoverStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileHoverStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of the tile borders in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBuilder Border(Action<TreeMapTileHoverStyleBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Colors tiles in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors tiles in the hover state.</summary>
		[Generated]
		public TreeMapTileHoverStyleBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}
	}
}
