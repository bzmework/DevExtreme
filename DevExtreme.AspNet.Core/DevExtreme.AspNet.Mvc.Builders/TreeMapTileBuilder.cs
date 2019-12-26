using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures tiles.</summary>
	public class TreeMapTileBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the tile borders.</summary>
		[Generated]
		public TreeMapTileBuilder Border(Action<TreeMapTileBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Specifies a single color for all tiles.</summary>
		[Generated]
		public TreeMapTileBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a single color for all tiles.</summary>
		[Generated]
		public TreeMapTileBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the appearance of tiles in the hover state.</summary>
		[Generated]
		public TreeMapTileBuilder HoverStyle(Action<TreeMapTileHoverStyleBuilder> configurator)
		{
			NestedOptions("hoverStyle", configurator);
			return this;
		}

		/// <summary>Configures the tile labels.</summary>
		[Generated]
		public TreeMapTileBuilder Label(Action<TreeMapTileLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies the appearance of tiles in the selected state.</summary>
		[Generated]
		public TreeMapTileBuilder SelectionStyle(Action<TreeMapTileSelectionStyleBuilder> configurator)
		{
			NestedOptions("selectionStyle", configurator);
			return this;
		}
	}
}
