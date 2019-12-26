using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies gauge range container options.</summary>
	public class LinearGaugeRangeContainerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeRangeContainerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a range container's background color.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies a range container's background color.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of the range container. Applies only if the geometry.orientation option is "vertical".</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder HorizontalOrientation(HorizontalAlignment value)
		{
			base.Options["horizontalOrientation"] = value;
			return this;
		}

		/// <summary>Specifies the offset of the range container from an invisible scale line in pixels.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the offset of the range container from an invisible scale line in pixels.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of ranges in the range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>An array of objects representing ranges contained in the range container.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Ranges(Action<CollectionFactory<LinearGaugeRangeContainerRangeBuilder>> configurator)
		{
			Collection("ranges", configurator);
			return this;
		}

		/// <summary>Specifies the orientation of the range container. Applies only if the geometry.orientation option is "horizontal".</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder VerticalOrientation(VerticalAlignment value)
		{
			base.Options["verticalOrientation"] = value;
			return this;
		}

		/// <summary>Specifies the width of the range container's start and end boundaries in the LinearGauge widget.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Width(Action<LinearGaugeRangeContainerWidthBuilder> configurator)
		{
			NestedOptions("width", configurator);
			return this;
		}

		/// <summary>Specifies the width of the range container's start and end boundaries in the LinearGauge widget.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the range container's start and end boundaries in the LinearGauge widget.</summary>
		[Generated]
		public LinearGaugeRangeContainerBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
