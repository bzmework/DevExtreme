using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the widget's subtitle.</summary>
	public class TreeMapTitleSubtitleBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapTitleSubtitleBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies font options for the subtitle.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Font(Action<VizFontBuilder> configurator)
		{
			NestedOptions("font", configurator);
			return this;
		}

		/// <summary>Specifies the distance between the title and subtitle in pixels.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the distance between the title and subtitle in pixels.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies text for the subtitle.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text for the subtitle.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies what to do with the subtitle when it overflows the allocated space after applying wordWrap: hide, truncate it and display an ellipsis, or do nothing.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder TextOverflow(VizTextOverflow value)
		{
			base.Options["textOverflow"] = value;
			return this;
		}

		/// <summary>Specifies how to wrap the subtitle if it does not fit into a single line.</summary>
		[Generated]
		public TreeMapTitleSubtitleBuilder WordWrap(VizWordWrap value)
		{
			base.Options["wordWrap"] = value;
			return this;
		}
	}
}
