namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the pane border.</summary>
	public class ChartPanesBorderBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartPanesBorderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartPanesBorderBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Shows/hides the bottom border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Bottom(bool value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Shows/hides the bottom border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Bottom(JS value)
		{
			base.Options["bottom"] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane border.</summary>
		[Generated]
		public ChartPanesBorderBuilder Color(string value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the color of the pane border.</summary>
		[Generated]
		public ChartPanesBorderBuilder Color(JS value)
		{
			base.Options["color"] = value;
			return this;
		}

		/// <summary>Specifies the dash style of the pane border.</summary>
		[Generated]
		public ChartPanesBorderBuilder DashStyle(params DashStyle[] values)
		{
			base.Options["dashStyle"] = string.Join("", values).ToLower();
			return this;
		}

		/// <summary>Shows/hides the left border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Left(bool value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Shows/hides the left border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Left(JS value)
		{
			base.Options["left"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the pane border should be.</summary>
		[Generated]
		public ChartPanesBorderBuilder Opacity(double value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Specifies how transparent the pane border should be.</summary>
		[Generated]
		public ChartPanesBorderBuilder Opacity(JS value)
		{
			base.Options["opacity"] = value;
			return this;
		}

		/// <summary>Shows/hides the right border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Right(bool value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Shows/hides the right border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Right(JS value)
		{
			base.Options["right"] = value;
			return this;
		}

		/// <summary>Shows/hides the top border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Top(bool value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Shows/hides the top border of the pane. Applies only when the border.visible option is true.</summary>
		[Generated]
		public ChartPanesBorderBuilder Top(JS value)
		{
			base.Options["top"] = value;
			return this;
		}

		/// <summary>Shows the pane border.</summary>
		[Generated]
		public ChartPanesBorderBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Shows the pane border.</summary>
		[Generated]
		public ChartPanesBorderBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the width of the pane border in pixels.</summary>
		[Generated]
		public ChartPanesBorderBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the pane border in pixels.</summary>
		[Generated]
		public ChartPanesBorderBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
