using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the horizontal crosshair line individually.</summary>
	public class ChartCrosshairHorizontalLineBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairHorizontalLineBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Configures the label that belongs to the horizontal crosshair line.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Label(Action<ChartCrosshairHorizontalLineLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how transparent the horizontal crosshair line should be.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the horizontal crosshair line should be.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the horizontal crosshair line or not.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the horizontal crosshair line or not.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the horizontal crosshair line in pixels.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the horizontal crosshair line in pixels.</summary>
		[Generated]
		public ChartCrosshairHorizontalLineBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
