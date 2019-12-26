using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the strip label.</summary>
	public class ChartValueAxisStripsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisStripsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for strip labels.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns strip labels in the horizontal direction.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text of the strip label.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text of the strip label.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Aligns strip labels in the vertical direction.</summary>
		[Generated]
		public ChartValueAxisStripsLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
