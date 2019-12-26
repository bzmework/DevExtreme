using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the appearance of the labels of those constant lines that belong to the argument axis.</summary>
	public class ChartArgumentAxisConstantLineStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for constant line labels.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns constant line labels in the horizontal direction.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the position of constant line labels on the chart plot.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Aligns constant line labels in the vertical direction.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartArgumentAxisConstantLineStyleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
