namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the group borders in the hover state.</summary>
	public class TreeMapGroupHoverStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the group borders in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group borders in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels. Applies to a group in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels. Applies to a group in the hover state.</summary>
		[Generated]
		public TreeMapGroupHoverStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
