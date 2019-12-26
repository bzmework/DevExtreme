using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the gauge's scale options.</summary>
	public class LinearGaugeScaleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public LinearGaugeScaleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public LinearGaugeScaleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public LinearGaugeScaleBuilder AllowDecimals(bool value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies whether to allow decimal values on the scale. When false, the scale contains integer values only.</summary>
		[Generated]
		public LinearGaugeScaleBuilder AllowDecimals(JS value)
		{
			base.Options["allowDecimals"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder CustomMinorTicks(IEnumerable<double> value)
		{
			base.Options["customMinorTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder CustomMinorTicks(JS value)
		{
			base.Options["customMinorTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom major ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder CustomTicks(IEnumerable<double> value)
		{
			base.Options["customTicks"] = value;
			return this;
		}

		/// <summary>Specifies an array of custom major ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder CustomTicks(JS value)
		{
			base.Options["customTicks"] = value;
			return this;
		}

		/// <summary>Specifies the end value for the scale of the gauge.</summary>
		[Generated]
		public LinearGaugeScaleBuilder EndValue(double value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the end value for the scale of the gauge.</summary>
		[Generated]
		public LinearGaugeScaleBuilder EndValue(JS value)
		{
			base.Options["endValue"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of scale ticks. Applies only if the geometry.orientation option is "vertical".</summary>
		[Generated]
		public LinearGaugeScaleBuilder HorizontalOrientation(HorizontalAlignment value)
		{
			base.Options["horizontalOrientation"] = value;
			return this;
		}

		/// <summary>Specifies common options for scale labels.</summary>
		[Generated]
		public LinearGaugeScaleBuilder Label(Action<LinearGaugeScaleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies options of the gauge's minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder MinorTick(Action<LinearGaugeScaleMinorTickBuilder> configurator)
		{
			NestedOptions("minorTick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder MinorTickInterval(double value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between minor ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder MinorTickInterval(JS value)
		{
			base.Options["minorTickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels.</summary>
		[Generated]
		public LinearGaugeScaleBuilder ScaleDivisionFactor(double value)
		{
			base.Options["scaleDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the minimum distance between two neighboring major ticks in pixels.</summary>
		[Generated]
		public LinearGaugeScaleBuilder ScaleDivisionFactor(JS value)
		{
			base.Options["scaleDivisionFactor"] = value;
			return this;
		}

		/// <summary>Specifies the start value for the scale of the gauge.</summary>
		[Generated]
		public LinearGaugeScaleBuilder StartValue(double value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies the start value for the scale of the gauge.</summary>
		[Generated]
		public LinearGaugeScaleBuilder StartValue(JS value)
		{
			base.Options["startValue"] = value;
			return this;
		}

		/// <summary>Specifies options of the gauge's major ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder Tick(Action<LinearGaugeScaleTickBuilder> configurator)
		{
			NestedOptions("tick", configurator);
			return this;
		}

		/// <summary>Specifies an interval between major ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder TickInterval(double value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies an interval between major ticks.</summary>
		[Generated]
		public LinearGaugeScaleBuilder TickInterval(JS value)
		{
			base.Options["tickInterval"] = value;
			return this;
		}

		/// <summary>Specifies the orientation of scale ticks. Applies only if the geometry.orientation option is "horizontal".</summary>
		[Generated]
		public LinearGaugeScaleBuilder VerticalOrientation(VerticalAlignment value)
		{
			base.Options["verticalOrientation"] = value;
			return this;
		}
	}
}
