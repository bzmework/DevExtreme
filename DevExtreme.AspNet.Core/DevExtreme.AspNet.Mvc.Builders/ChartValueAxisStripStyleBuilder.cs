using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of strips.</summary>
	public class ChartValueAxisStripStyleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartValueAxisStripStyleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Configures the appearance of strip labels.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder Label(Action<ChartValueAxisStripStyleLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder PaddingLeftRight(double value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the left/right border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder PaddingLeftRight(JS value)
		{
			base.Options["paddingLeftRight"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder PaddingTopBottom(double value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}

		/// <summary>Generates a pixel-measured empty space between the top/bottom border of a strip and the strip label.</summary>
		[Generated]
		public ChartValueAxisStripStyleBuilder PaddingTopBottom(JS value)
		{
			base.Options["paddingTopBottom"] = value;
			return this;
		}
	}
}
