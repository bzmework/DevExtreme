using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of strip labels.</summary>
	public class ChartArgumentAxisStripStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisStripStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisStripStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for strip labels.</summary>
		[Generated]
		public ChartArgumentAxisStripStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns strip labels in the horizontal direction.</summary>
		[Generated]
		public ChartArgumentAxisStripStyleLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Aligns strip labels in the vertical direction.</summary>
		[Generated]
		public ChartArgumentAxisStripStyleLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
