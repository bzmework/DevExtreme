using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of strip labels.</summary>
	public class ChartValueAxisStripStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisStripStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisStripStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for strip labels.</summary>
		[Generated]
		public ChartValueAxisStripStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns strip labels in the horizontal direction.</summary>
		[Generated]
		public ChartValueAxisStripStyleLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Aligns strip labels in the vertical direction.</summary>
		[Generated]
		public ChartValueAxisStripStyleLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
