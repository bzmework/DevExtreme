using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the axis title.</summary>
	public class ChartArgumentAxisTitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartArgumentAxisTitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Aligns the axis title to the left, center, or right of the axis.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Alignment(HorizontalAlignment value)
		{
			base.Options["alignment"] = value;
			return this;
		}

		/// <summary>Specifies font options for the axis title.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between the axis title and axis labels.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Adds a pixel-measured empty space between the axis title and axis labels.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the text of the axis title.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text of the axis title.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the axis title when it overflows the allocated space after applying wordWrap: hide, truncate them and display an ellipsis, or do nothing.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the axis title if it does not fit into a single line.</summary>
		[Generated]
		public ChartArgumentAxisTitleBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
