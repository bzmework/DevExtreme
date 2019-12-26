namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the appearance of the annotation's border.</summary>
	public class ChartAnnotationConfigBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartAnnotationConfigBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Colors the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Colors the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Makes the annotation's corners rounded.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder CornerRadius(double value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Makes the annotation's corners rounded.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder CornerRadius(JS value)
		{
			base.Options["cornerRadius"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Specifies the opacity of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the visibility of the annotation's border.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's border in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the annotation's border in pixels.</summary>
		[Generated]
		public ChartAnnotationConfigBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
