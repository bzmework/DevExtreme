using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object that defines the label configuration options of a strip.</summary>
	public class PolarChartArgumentAxisStripsLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisStripsLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisStripsLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a strip label.</summary>
		[Generated]
		public PolarChartArgumentAxisStripsLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the text displayed in a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripsLabelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text displayed in a strip.</summary>
		[Generated]
		public PolarChartArgumentAxisStripsLabelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
