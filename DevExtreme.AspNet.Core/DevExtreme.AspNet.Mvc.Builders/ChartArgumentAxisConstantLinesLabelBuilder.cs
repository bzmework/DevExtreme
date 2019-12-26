using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the constant line label.</summary>
	public class ChartArgumentAxisConstantLinesLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for constant line labels.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns constant line labels in the horizontal direction.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the position of constant line labels on the chart plot.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Position(RelativePosition value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies the text of a constant line label. By default, equals to the value of the constant line.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text of a constant line label. By default, equals to the value of the constant line.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Aligns constant line labels in the vertical direction.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes constant line labels visible.</summary>
		[Generated]
		public ChartArgumentAxisConstantLinesLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
