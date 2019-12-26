using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	public class GaugeIndicatorBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public GaugeIndicatorBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GaugeIndicatorBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the length of an arrow for the indicator of the textCloud type in pixels.</summary>
		[Generated]
		public GaugeIndicatorBuilder ArrowLength(double value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the length of an arrow for the indicator of the textCloud type in pixels.</summary>
		[Generated]
		public GaugeIndicatorBuilder ArrowLength(JS value)
		{
			base.Options["arrowLength"] = value;
			return this;
		}

		/// <summary>Specifies the background color for the indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the background color for the indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the base value for the indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder BaseValue(double value)
		{
			base.Options["baseValue"] = value;
			return this;
		}

		/// <summary>Specifies the base value for the indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder BaseValue(JS value)
		{
			base.Options["baseValue"] = value;
			return this;
		}

		/// <summary>Specifies a radius small enough for the indicator to begin adapting.</summary>
		[Generated]
		public GaugeIndicatorBuilder BeginAdaptingAtRadius(double value)
		{
			base.Options["beginAdaptingAtRadius"] = value;
			return this;
		}

		/// <summary>Specifies a radius small enough for the indicator to begin adapting.</summary>
		[Generated]
		public GaugeIndicatorBuilder BeginAdaptingAtRadius(JS value)
		{
			base.Options["beginAdaptingAtRadius"] = value;
			return this;
		}

		/// <summary>Specifies a color of the indicator.</summary>
		[Generated]
		public GaugeIndicatorBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color of the indicator.</summary>
		[Generated]
		public GaugeIndicatorBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of the rangeBar indicator. Applies only if the geometry.orientation option is "vertical".</summary>
		[Generated]
		public GaugeIndicatorBuilder HorizontalOrientation(HorizontalEdge value)
		{
			base.Options["horizontalOrientation"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the needle and the center of a gauge for the indicator of a needle-like type.</summary>
		[Generated]
		public GaugeIndicatorBuilder IndentFromCenter(double value)
		{
			base.Options["indentFromCenter"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the needle and the center of a gauge for the indicator of a needle-like type.</summary>
		[Generated]
		public GaugeIndicatorBuilder IndentFromCenter(JS value)
		{
			base.Options["indentFromCenter"] = value;
			return this;
		}

		/// <summary>Specifies the indicator length.</summary>
		[Generated]
		public GaugeIndicatorBuilder Length(double value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the indicator length.</summary>
		[Generated]
		public GaugeIndicatorBuilder Length(JS value)
		{
			base.Options["length"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the indicator and the invisible scale line.</summary>
		[Generated]
		public GaugeIndicatorBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the indicator and the invisible scale line.</summary>
		[Generated]
		public GaugeIndicatorBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize indicators differently.</summary>
		[Generated]
		public GaugeIndicatorBuilder Palette(VizPalette value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize indicators differently.</summary>
		[Generated]
		public GaugeIndicatorBuilder Palette(IEnumerable<string> value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Sets the palette to be used to colorize indicators differently.</summary>
		[Generated]
		public GaugeIndicatorBuilder Palette(JS value)
		{
			base.Options["palette"] = value;
			return this;
		}

		/// <summary>Specifies the second color for the indicator of the twoColorNeedle type.</summary>
		[Generated]
		public GaugeIndicatorBuilder SecondColor(string value)
		{
			base.Options["secondColor"] = value;
			return this;
		}

		/// <summary>Specifies the second color for the indicator of the twoColorNeedle type.</summary>
		[Generated]
		public GaugeIndicatorBuilder SecondColor(JS value)
		{
			base.Options["secondColor"] = value;
			return this;
		}

		/// <summary>Specifies the length of a twoNeedleColor type indicator tip as a percentage.</summary>
		[Generated]
		public GaugeIndicatorBuilder SecondFraction(double value)
		{
			base.Options["secondFraction"] = value;
			return this;
		}

		/// <summary>Specifies the length of a twoNeedleColor type indicator tip as a percentage.</summary>
		[Generated]
		public GaugeIndicatorBuilder SecondFraction(JS value)
		{
			base.Options["secondFraction"] = value;
			return this;
		}

		/// <summary>Specifies the range bar size for an indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder Size(double value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the range bar size for an indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder Size(JS value)
		{
			base.Options["size"] = value;
			return this;
		}

		/// <summary>Specifies the inner diameter in pixels, so that the spindle has the shape of a ring.</summary>
		[Generated]
		public GaugeIndicatorBuilder SpindleGapSize(double value)
		{
			base.Options["spindleGapSize"] = value;
			return this;
		}

		/// <summary>Specifies the inner diameter in pixels, so that the spindle has the shape of a ring.</summary>
		[Generated]
		public GaugeIndicatorBuilder SpindleGapSize(JS value)
		{
			base.Options["spindleGapSize"] = value;
			return this;
		}

		/// <summary>Specifies the spindle's diameter in pixels for the indicator of a needle-like type.</summary>
		[Generated]
		public GaugeIndicatorBuilder SpindleSize(double value)
		{
			base.Options["spindleSize"] = value;
			return this;
		}

		/// <summary>Specifies the spindle's diameter in pixels for the indicator of a needle-like type.</summary>
		[Generated]
		public GaugeIndicatorBuilder SpindleSize(JS value)
		{
			base.Options["spindleSize"] = value;
			return this;
		}

		/// <summary>Specifies the appearance of the text displayed in an indicator of the rangeBar type.</summary>
		[Generated]
		public GaugeIndicatorBuilder Text(Action<GaugeIndicatorTextBuilder> configurator)
		{
			NestedOptions("text", configurator);
			return this;
		}

		/// <summary>Specifies the type of gauge indicators.</summary>
		[Generated]
		public GaugeIndicatorBuilder Type(GaugeIndicatorType value)
		{
			base.Options["type"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of the rangeBar indicator. Applies only if the geometry.orientation option is "horizontal".</summary>
		[Generated]
		public GaugeIndicatorBuilder VerticalOrientation(VerticalEdge value)
		{
			base.Options["verticalOrientation"] = value;
			return this;
		}

		/// <summary>Specifies the width of an indicator in pixels.</summary>
		[Generated]
		public GaugeIndicatorBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of an indicator in pixels.</summary>
		[Generated]
		public GaugeIndicatorBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
