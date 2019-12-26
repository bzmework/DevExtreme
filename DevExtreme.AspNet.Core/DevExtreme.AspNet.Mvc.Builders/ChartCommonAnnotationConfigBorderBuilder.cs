namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the annotation's border.</summary>
	public class ChartCommonAnnotationConfigBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the annotation's corners rounded.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes the annotation's corners rounded.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the opacity of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of the annotation's border.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's border in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's border in pixels.</summary>
		[Generated]
		public ChartCommonAnnotationConfigBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
