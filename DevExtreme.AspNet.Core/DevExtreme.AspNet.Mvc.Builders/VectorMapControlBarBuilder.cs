namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the control bar.</summary>
	public class VectorMapControlBarBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public VectorMapControlBarBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public VectorMapControlBarBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies a color for the outline of the control bar elements.</summary>
		[Generated]
		public VectorMapControlBarBuilder BorderColor(string value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the outline of the control bar elements.</summary>
		[Generated]
		public VectorMapControlBarBuilder BorderColor(JS value)
		{
			base.Options["borderColor"] = value;
			return this;
		}

		/// <summary>Specifies a color for the inner area of the control bar elements.</summary>
		[Generated]
		public VectorMapControlBarBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies a color for the inner area of the control bar elements.</summary>
		[Generated]
		public VectorMapControlBarBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to display the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the position of the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder HorizontalAlignment(HorizontalAlignment value)
		{
			base.Options["horizontalAlignment"] = value;
			return this;
		}

		/// <summary>Specifies the margin of the control bar in pixels.</summary>
		[Generated]
		public VectorMapControlBarBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the margin of the control bar in pixels.</summary>
		[Generated]
		public VectorMapControlBarBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the opacity of the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies the position of the control bar.</summary>
		[Generated]
		public VectorMapControlBarBuilder VerticalAlignment(VerticalEdge value)
		{
			base.Options["verticalAlignment"] = value;
			return this;
		}
	}
}
