using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies gauge range container options.</summary>
	public class CircularGaugeRangeContainerBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeRangeContainerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a range container's background color.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies a range container's background color.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the offset of the range container from an invisible scale line in pixels.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the offset of the range container from an invisible scale line in pixels.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of the range container in the CircularGauge widget.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Orientation(CircularGaugeElementOrientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the palette to be used for colorizing ranges in the range container.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies what to do with colors in the palette when their number is less than the number of ranges in the range container.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder PaletteExtensionMode(VizPaletteExtensionMode value)
		{
			base.Options["paletteExtensionMode"] = value;
			return this;
		}

		/// <summary>An array of objects representing ranges contained in the range container.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Ranges(Action<CollectionFactory<CircularGaugeRangeContainerRangeBuilder>> configurator)
		{
			Collection("ranges", configurator);
			return this;
		}

		/// <summary>Specifies the range container's width in pixels.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the range container's width in pixels.</summary>
		[Generated]
		public CircularGaugeRangeContainerBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
