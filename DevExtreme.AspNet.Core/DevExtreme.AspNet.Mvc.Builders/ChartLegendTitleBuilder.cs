using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend title.</summary>
	public class ChartLegendTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartLegendTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartLegendTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's font options.</summary>
		[Generated]
		public ChartLegendTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend title's position.</summary>
		[Generated]
		public ChartLegendTitleBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Generates space around the legend title.</summary>
		[Generated]
		public ChartLegendTitleBuilder Margin(Action<ChartLegendTitleMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public ChartLegendTitleBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public ChartLegendTitleBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public ChartLegendTitleBuilder Subtitle(Action<ChartLegendTitleSubtitleBuilder> configurator)
		{
			NestedOptions("subtitle", configurator);
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public ChartLegendTitleBuilder Subtitle(string value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public ChartLegendTitleBuilder Subtitle(JS value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public ChartLegendTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public ChartLegendTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's vertical alignment.</summary>
		[Generated]
		public ChartLegendTitleBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
