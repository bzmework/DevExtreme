namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the border of a selected point.</summary>
	public class ChartSeriesPointSelectionStyleBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is selected.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the point border when the point is selected.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the border of a selected point visible.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Makes the border of a selected point visible.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is selected.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the point border when the point is selected.</summary>
		[Generated]
		public ChartSeriesPointSelectionStyleBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
