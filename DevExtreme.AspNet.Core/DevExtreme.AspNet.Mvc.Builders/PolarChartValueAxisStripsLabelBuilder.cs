using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object that defines the label configuration options of a strip.</summary>
	public class PolarChartValueAxisStripsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartValueAxisStripsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartValueAxisStripsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a strip label.</summary>
		[Generated]
		public PolarChartValueAxisStripsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the text displayed in a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripsLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in a strip.</summary>
		[Generated]
		public PolarChartValueAxisStripsLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
