namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the group borders.</summary>
	public class TreeMapGroupBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapGroupBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapGroupBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the group borders.</summary>
		[Generated]
		public TreeMapGroupBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the group borders.</summary>
		[Generated]
		public TreeMapGroupBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels.</summary>
		[Generated]
		public TreeMapGroupBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the group borders in pixels.</summary>
		[Generated]
		public TreeMapGroupBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
