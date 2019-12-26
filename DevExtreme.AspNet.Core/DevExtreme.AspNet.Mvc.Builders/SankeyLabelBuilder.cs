using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures sankey nodes' labels.</summary>
	public class SankeyLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the labels' borders.</summary>
		[Generated]
		public SankeyLabelBuilder Border(Action<SankeyLabelBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}

		/// <summary>Customizes the labels' texts.</summary>
		[Generated]
		public SankeyLabelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the labels' texts.</summary>
		[Generated]
		public SankeyLabelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the labels' font options.</summary>
		[Generated]
		public SankeyLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Moves the labels horizontally from their initial positions.</summary>
		[Generated]
		public SankeyLabelBuilder HorizontalOffset(double value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Moves the labels horizontally from their initial positions.</summary>
		[Generated]
		public SankeyLabelBuilder HorizontalOffset(JS value)
		{
			base.Options["horizontalOffset"] = value;
			return this;
		}

		/// <summary>Specifies how to arrange labels when there is insufficient space to display them all.</summary>
		[Generated]
		public SankeyLabelBuilder OverlappingBehavior(SankeyLabelOverlappingBehavior value)
		{
			base.Options["overlappingBehavior"] = value;
			return this;
		}

		/// <summary>Configures the labels' shadows.</summary>
		[Generated]
		public SankeyLabelBuilder Shadow(Action<SankeyLabelShadowBuilder> configurator)
		{
			NestedOptions("shadow", configurator);
			return this;
		}

		/// <summary>Specifies whether to color labels in the nodes' colors.</summary>
		[Generated]
		public SankeyLabelBuilder UseNodeColors(bool value)
		{
			base.Options["useNodeColors"] = value;
			return this;
		}

		/// <summary>Specifies whether to color labels in the nodes' colors.</summary>
		[Generated]
		public SankeyLabelBuilder UseNodeColors(JS value)
		{
			base.Options["useNodeColors"] = value;
			return this;
		}

		/// <summary>Moves the labels vertically from their initial positions.</summary>
		[Generated]
		public SankeyLabelBuilder VerticalOffset(double value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Moves the labels vertically from their initial positions.</summary>
		[Generated]
		public SankeyLabelBuilder VerticalOffset(JS value)
		{
			base.Options["verticalOffset"] = value;
			return this;
		}

		/// <summary>Specifies whether the labels are visible.</summary>
		[Generated]
		public SankeyLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the labels are visible.</summary>
		[Generated]
		public SankeyLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
