namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the tile borders.</summary>
	public class TreeMapTileBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTileBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTileBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the tile borders.</summary>
		[Generated]
		public TreeMapTileBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the tile borders.</summary>
		[Generated]
		public TreeMapTileBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels.</summary>
		[Generated]
		public TreeMapTileBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the tile borders in pixels.</summary>
		[Generated]
		public TreeMapTileBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
