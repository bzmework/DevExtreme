using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the widget's title.</summary>
	public class BarGaugeTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the title's alignment in a horizontal direction.</summary>
		[Generated]
		public BarGaugeTitleBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder Margin(Action<BarGaugeTitleMarginBuilder> configurator)
		{
			NestedOptions("margin", configurator);
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Generates space around the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder PlaceholderSize(double value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Reserves a pixel-measured space for the title.</summary>
		[Generated]
		public BarGaugeTitleBuilder PlaceholderSize(JS value)
		{
			base.Options["placeholderSize"] = value;
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public BarGaugeTitleBuilder Subtitle(Action<BarGaugeTitleSubtitleBuilder> configurator)
		{
			NestedOptions("subtitle", configurator);
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public BarGaugeTitleBuilder Subtitle(string value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Configures the widget's subtitle.</summary>
		[Generated]
		public BarGaugeTitleBuilder Subtitle(JS value)
		{
			base.Options["subtitle"] = value;
			return this;
		}

		/// <summary>Specifies the title's text.</summary>
		[Generated]
		public BarGaugeTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the title's text.</summary>
		[Generated]
		public BarGaugeTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the title when it overflows the allocated space after applying wordWrap: hide, truncate it and display an ellipsis, or do nothing.</summary>
		[Generated]
		public BarGaugeTitleBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies the title's alignment in a vertical direction.</summary>
		[Generated]
		public BarGaugeTitleBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the title if it does not fit into a single line.</summary>
		[Generated]
		public BarGaugeTitleBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
