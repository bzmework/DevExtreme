namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures a tooltip's border.</summary>
	public class SparklineTooltipBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SparklineTooltipBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the transparency of a tooltip's border.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip's border is visible.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether a tooltip's border is visible.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of a tooltip's border in pixels.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of a tooltip's border in pixels.</summary>
		[Generated]
		public SparklineTooltipBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
