using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Defines common settings for all panes in a chart.</summary>
	public class ChartCommonPaneSettingsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonPaneSettingsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonPaneSettingsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane's background.</summary>
		[Generated]
		public ChartCommonPaneSettingsBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane's background.</summary>
		[Generated]
		public ChartCommonPaneSettingsBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Configures the pane border.</summary>
		[Generated]
		public ChartCommonPaneSettingsBuilder Border(Action<ChartCommonPaneSettingsBorderBuilder> configurator)
		{
			NestedOptions("border", configurator);
			return this;
		}
	}
}
