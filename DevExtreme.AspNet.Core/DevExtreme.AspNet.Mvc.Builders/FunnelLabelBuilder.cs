using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures funnel item labels.</summary>
	public class FunnelLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the labels' background. The default color is inherited from the funnel items.</summary>
		[Generated]
		public FunnelLabelBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Colors the labels' background. The default color is inherited from the funnel items.</summary>
		[Generated]
		public FunnelLabelBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the label borders.</summary>
		[Generated]
		public FunnelLabelBuilder Border(Action<FunnelLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Configures label connectors.</summary>
		[Generated]
		public FunnelLabelBuilder Connector(Action<FunnelLabelConnectorBuilder> configurator)
		{
			NestedOptions("connector", configurator);
			return this;
		}

		/// <summary>Customizes labels' text.</summary>
		[Generated]
		public FunnelLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes labels' text.</summary>
		[Generated]
		public FunnelLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies labels' font options.</summary>
		[Generated]
		public FunnelLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Formats the item value before displaying it in the label.</summary>
		[Generated]
		public FunnelLabelBuilder Format(Format value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the item value before displaying it in the label.</summary>
		[Generated]
		public FunnelLabelBuilder Format(string value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the item value before displaying it in the label.</summary>
		[Generated]
		public FunnelLabelBuilder Format(JS value)
		{
			base.Options["format"] = value;
			return this;
		}

		/// <summary>Formats the item value before displaying it in the label.</summary>
		[Generated]
		public FunnelLabelBuilder Format(Action<FormatBuilder> configurator)
		{
			NestedOptions("format", configurator);
			return this;
		}

		/// <summary>Specifies labels' position in relation to the funnel items.</summary>
		[Generated]
		public FunnelLabelBuilder HorizontalAlignment(HorizontalEdge value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Moves labels from their initial positions.</summary>
		[Generated]
		public FunnelLabelBuilder HorizontalOffset(double value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Moves labels from their initial positions.</summary>
		[Generated]
		public FunnelLabelBuilder HorizontalOffset(JS value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Specifies whether to display labels inside or outside funnel items or arrange them in columns.</summary>
		[Generated]
		public FunnelLabelBuilder Position(FunnelLabelPosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies whether to show labels for items with zero value.</summary>
		[Generated]
		public FunnelLabelBuilder ShowForZeroValues(bool value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies whether to show labels for items with zero value.</summary>
		[Generated]
		public FunnelLabelBuilder ShowForZeroValues(JS value)
		{
			base.Options["showForZeroValues"] = value;
			return this;
		}

		/// <summary>Specifies what to do with label texts that overflow the allocated space after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public FunnelLabelBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Controls the labels' visibility.</summary>
		[Generated]
		public FunnelLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Controls the labels' visibility.</summary>
		[Generated]
		public FunnelLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap label texts if they do not fit into a single line.</summary>
		[Generated]
		public FunnelLabelBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
