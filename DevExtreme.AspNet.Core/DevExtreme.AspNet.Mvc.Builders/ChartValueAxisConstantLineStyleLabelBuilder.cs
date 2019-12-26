using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of the labels of those constant lines that belong to the value axis.</summary>
	public class ChartValueAxisConstantLineStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for constant line labels.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns constant line labels in the horizontal direction.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the position of constant line labels on the chart plot.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Aligns constant line labels in the vertical direction.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartValueAxisConstantLineStyleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
