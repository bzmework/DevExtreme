using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies a gauge's scale options.</summary>
	public class CircularGaugeScaleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public CircularGaugeScaleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public CircularGaugeScaleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public CircularGaugeScaleBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public CircularGaugeScaleBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder CustomMinorTicks(IEnumerable<double> value)
		{
			base.Options["customMinorTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder CustomMinorTicks(JS value)
		{
			base.Options["customMinorTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom major ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder CustomTicks(IEnumerable<double> value)
		{
			base.Options["customTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom major ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder CustomTicks(JS value)
		{
			base.Options["customTicks"] = value;
			return this;
		}

		/// <summary>Specifies the end value for the scale of the gauge.</summary>
		[Generated]
		public CircularGaugeScaleBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the end value for the scale of the gauge.</summary>
		[Generated]
		public CircularGaugeScaleBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies common options for scale labels.</summary>
		[Generated]
		public CircularGaugeScaleBuilder Label(Action<CircularGaugeScaleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies options of the gauge's minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder MinorTick(Action<CircularGaugeScaleMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of scale ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder Orientation(CircularGaugeElementOrientation value)
		{
			base.Options["orientation"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels.</summary>
		[Generated]
		public CircularGaugeScaleBuilder ScaleDivisionFactor(double value)
		{
			base.Options["scaleDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels.</summary>
		[Generated]
		public CircularGaugeScaleBuilder ScaleDivisionFactor(JS value)
		{
			base.Options["scaleDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the start value for the scale of the gauge.</summary>
		[Generated]
		public CircularGaugeScaleBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies the start value for the scale of the gauge.</summary>
		[Generated]
		public CircularGaugeScaleBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies options of the gauge's major ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder Tick(Action<CircularGaugeScaleTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between major ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between major ticks.</summary>
		[Generated]
		public CircularGaugeScaleBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}
	}
}
