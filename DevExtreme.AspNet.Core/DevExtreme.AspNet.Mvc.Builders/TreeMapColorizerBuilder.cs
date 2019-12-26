using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Manages the color settings.</summary>
	public class TreeMapColorizerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapColorizerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapColorizerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field whose values define the color of a tile. Applies only if the type option is "gradient" or "range".</summary>
		[Generated]
		public TreeMapColorizerBuilder ColorCodeField(string value)
		{
			base.Options["colorCodeField"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source field whose values define the color of a tile. Applies only if the type option is "gradient" or "range".</summary>
		[Generated]
		public TreeMapColorizerBuilder ColorCodeField(JS value)
		{
			base.Options["colorCodeField"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all tiles in a group must be colored uniformly. Applies only if the type option is "discrete".</summary>
		[Generated]
		public TreeMapColorizerBuilder ColorizeGroups(bool value)
		{
			base.Options["colorizeGroups"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all tiles in a group must be colored uniformly. Applies only if the type option is "discrete".</summary>
		[Generated]
		public TreeMapColorizerBuilder ColorizeGroups(JS value)
		{
			base.Options["colorizeGroups"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize tiles.</summary>
		[Generated]
		public TreeMapColorizerBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize tiles.</summary>
		[Generated]
		public TreeMapColorizerBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize tiles.</summary>
		[Generated]
		public TreeMapColorizerBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of treemap tiles.</summary>
		[Generated]
		public TreeMapColorizerBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>Allows you to paint tiles with similar values uniformly. Applies only if the type option is "gradient" or "range".</summary>
		[Generated]
		public TreeMapColorizerBuilder Range(IEnumerable<double> value)
		{
			base.Options["range"] = value;
			return this;
		}

		/// <summary>Allows you to paint tiles with similar values uniformly. Applies only if the type option is "gradient" or "range".</summary>
		[Generated]
		public TreeMapColorizerBuilder Range(JS value)
		{
			base.Options["range"] = value;
			return this;
		}

		/// <summary>Specifies the colorizing algorithm.</summary>
		[Generated]
		public TreeMapColorizerBuilder Type(TreeMapColorizerType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
