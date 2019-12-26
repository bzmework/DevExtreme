using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An object defining constant line label options.</summary>
	public class PolarChartArgumentAxisConstantLineStyleLabelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PolarChartArgumentAxisConstantLineStyleLabelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineStyleLabelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for a constant line label.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineStyleLabelBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Indicates whether or not to display labels for the axis constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineStyleLabelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Indicates whether or not to display labels for the axis constant lines.</summary>
		[Generated]
		public PolarChartArgumentAxisConstantLineStyleLabelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
