namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>A tooltip to be used for the marker.</summary>
	public class MapMarkersTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public MapMarkersTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public MapMarkersTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip is visible by default or not.</summary>
		[Generated]
		public MapMarkersTooltipBuilder IsShown(bool value)
		{
			base.Options["isShown"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip is visible by default or not.</summary>
		[Generated]
		public MapMarkersTooltipBuilder IsShown(JS value)
		{
			base.Options["isShown"] = value;
			return this;
		}

		/// <summary>Specifies the tooltip text.</summary>
		[Generated]
		public MapMarkersTooltipBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the tooltip text.</summary>
		[Generated]
		public MapMarkersTooltipBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
