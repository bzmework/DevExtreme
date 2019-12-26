namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies the settings of the scroll bar.</summary>
	public class ChartScrollBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartScrollBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartScrollBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color of the scroll bar.</summary>
		[Generated]
		public ChartScrollBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the scroll bar.</summary>
		[Generated]
		public ChartScrollBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between the scroll bar and the chart's plot in pixels.</summary>
		[Generated]
		public ChartScrollBarBuilder Offset(double value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the spacing between the scroll bar and the chart's plot in pixels.</summary>
		[Generated]
		public ChartScrollBarBuilder Offset(JS value)
		{
			base.Options["offset"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scroll bar.</summary>
		[Generated]
		public ChartScrollBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the scroll bar.</summary>
		[Generated]
		public ChartScrollBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the position of the scroll bar in the chart.</summary>
		[Generated]
		public ChartScrollBarBuilder Position(Position value)
		{
			base.Options["position"] = value;
			return this;
		}

		/// <summary>Specifies whether the scroll bar is visible or not.</summary>
		[Generated]
		public ChartScrollBarBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the scroll bar is visible or not.</summary>
		[Generated]
		public ChartScrollBarBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scroll bar in pixels.</summary>
		[Generated]
		public ChartScrollBarBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the scroll bar in pixels.</summary>
		[Generated]
		public ChartScrollBarBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
