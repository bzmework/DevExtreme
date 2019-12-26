namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the group borders in the selected state.</summary>
	public class TreeMapGroupSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the group borders in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group borders in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels. Applies to a group in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels. Applies to a group in the selected state.</summary>
		[Generated]
		public TreeMapGroupSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
