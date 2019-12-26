using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the legend subtitle. The subtitle appears only if the title is specified.</summary>
	public class PieChartLegendTitleSubtitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartLegendTitleSubtitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the legend subtitle's font options.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the distance between the legend's title and subtitle in pixels.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the legend's title and subtitle in pixels.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the subtitle's text.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the subtitle's text.</summary>
		[Generated]
		public PieChartLegendTitleSubtitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}
	}
}
