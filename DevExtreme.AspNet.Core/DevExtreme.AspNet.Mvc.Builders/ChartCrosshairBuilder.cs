using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the crosshair feature.</summary>
	public class ChartCrosshairBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCrosshairBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCrosshairBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the crosshair lines.</summary>
		[Generated]
		public ChartCrosshairBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the crosshair lines.</summary>
		[Generated]
		public ChartCrosshairBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the crosshair lines.</summary>
		[Generated]
		public ChartCrosshairBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Enables the crosshair.</summary>
		[Generated]
		public ChartCrosshairBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the crosshair.</summary>
		[Generated]
		public ChartCrosshairBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Configures the horizontal crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder HorizontalLine(Action<ChartCrosshairHorizontalLineBuilder> configurator)
		{
			NestedOptions("horizontalLine", configurator);
			return this;
		}

		/// <summary>Configures the horizontal crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder HorizontalLine(bool value)
		{
			base.Options["horizontalLine"] = value;
			return this;
		}

		/// <summary>Configures the horizontal crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder HorizontalLine(JS value)
		{
			base.Options["horizontalLine"] = value;
			return this;
		}

		/// <summary>Configures the crosshair labels.</summary>
		[Generated]
		public ChartCrosshairBuilder Label(Action<ChartCrosshairLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies how transparent the crosshair lines should be.</summary>
		[Generated]
		public ChartCrosshairBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the crosshair lines should be.</summary>
		[Generated]
		public ChartCrosshairBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Configures the vertical crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder VerticalLine(Action<ChartCrosshairVerticalLineBuilder> configurator)
		{
			NestedOptions("verticalLine", configurator);
			return this;
		}

		/// <summary>Configures the vertical crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder VerticalLine(bool value)
		{
			base.Options["verticalLine"] = value;
			return this;
		}

		/// <summary>Configures the vertical crosshair line individually.</summary>
		[Generated]
		public ChartCrosshairBuilder VerticalLine(JS value)
		{
			base.Options["verticalLine"] = value;
			return this;
		}

		/// <summary>Specifies the width of the crosshair lines.</summary>
		[Generated]
		public ChartCrosshairBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the crosshair lines.</summary>
		[Generated]
		public ChartCrosshairBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
