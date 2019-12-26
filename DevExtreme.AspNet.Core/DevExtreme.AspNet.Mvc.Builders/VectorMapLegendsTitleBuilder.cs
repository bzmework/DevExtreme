using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend title.</summary>
	public class VectorMapLegendsTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapLegendsTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend title's font options.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Along with verticalAlignment, specifies the legend title's position.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Generates space around the legend title.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Margin(Action<VectorMapLegendsTitleMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the legend title.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Subtitle(Action<VectorMapLegendsTitleSubtitleBuilder> configurator)
		{
			NestedOptions("subtitle", configurator);
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Subtitle(string value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Subtitle(JS value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's text.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the legend title's vertical alignment.</summary>
		[Generated]
		public VectorMapLegendsTitleBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
