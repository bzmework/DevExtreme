using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the tile labels.</summary>
	public class TreeMapTileLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the font settings of the tile labels.</summary>
		[Generated]
		public TreeMapTileLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies what to do with labels that overflow their tiles after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public TreeMapTileLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Changes the visibility of the tile labels.</summary>
		[Generated]
		public TreeMapTileLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Changes the visibility of the tile labels.</summary>
		[Generated]
		public TreeMapTileLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap texts that do not fit into a single line.</summary>
		[Generated]
		public TreeMapTileLabelBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
