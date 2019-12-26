using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the vertical crosshair line individually.</summary>
	public class ChartCrosshairVerticalLineBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairVerticalLineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures the label that belongs to the vertical crosshair line.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Label(Action<ChartCrosshairVerticalLineLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how transparent the vertical crosshair line should be.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the vertical crosshair line should be.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the vertical crosshair line or not.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the vertical crosshair line or not.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the vertical crosshair line in pixels.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the vertical crosshair line in pixels.</summary>
		[Generated]
		public ChartCrosshairVerticalLineBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
