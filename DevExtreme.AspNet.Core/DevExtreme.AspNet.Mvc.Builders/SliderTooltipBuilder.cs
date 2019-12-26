using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip.</summary>
	public class SliderTooltipBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SliderTooltipBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SliderTooltipBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip is enabled.</summary>
		[Generated]
		public SliderTooltipBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip is enabled.</summary>
		[Generated]
		public SliderTooltipBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's display format.</summary>
		[Generated]
		public SliderTooltipBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's display format.</summary>
		[Generated]
		public SliderTooltipBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's display format.</summary>
		[Generated]
		public SliderTooltipBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Specifies a tooltip's display format.</summary>
		[Generated]
		public SliderTooltipBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies whether a tooltip is over or under the slider.</summary>
		[Generated]
		public SliderTooltipBuilder Position(VerticalEdge value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies when the widget shows a tooltip.</summary>
		[Generated]
		public SliderTooltipBuilder ShowMode(SliderTooltipShowMode value)
		{
			base.Options["showMode"] = value;
			return this;
		}
	}
}
