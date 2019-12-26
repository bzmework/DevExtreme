using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the widget's title.</summary>
	public class PolarChartTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for the title.</summary>
		[Generated]
		public PolarChartTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the title's alignment in a horizontal direction.</summary>
		[Generated]
		public PolarChartTitleBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public PolarChartTitleBuilder Margin(Action<PolarChartTitleMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public PolarChartTitleBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public PolarChartTitleBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the title.</summary>
		[Generated]
		public PolarChartTitleBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the title.</summary>
		[Generated]
		public PolarChartTitleBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public PolarChartTitleBuilder Subtitle(Action<PolarChartTitleSubtitleBuilder> configurator)
		{
			NestedOptions("subtitle", configurator);
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public PolarChartTitleBuilder Subtitle(string value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public PolarChartTitleBuilder Subtitle(JS value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Specifies the title's text.</summary>
		[Generated]
		public PolarChartTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the title's text.</summary>
		[Generated]
		public PolarChartTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the title when it overflows the allocated space after applying wordWrap: hide, truncate it and display an ellipsis, or do nothing.</summary>
		[Generated]
		public PolarChartTitleBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies the title's alignment in a vertical direction.</summary>
		[Generated]
		public PolarChartTitleBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the title if it does not fit into a single line.</summary>
		[Generated]
		public PolarChartTitleBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
