using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the strip label.</summary>
	public class ChartArgumentAxisStripsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for strip labels.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Aligns strip labels in the horizontal direction.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the text of the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text of the strip label.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Aligns strip labels in the vertical direction.</summary>
		[Generated]
		public ChartArgumentAxisStripsLabelBuilder VerticalAlignment(VerticalAlignment value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
