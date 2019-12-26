namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies adaptive layout options.</summary>
	public class PieChartAdaptiveLayoutBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PieChartAdaptiveLayoutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether point labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder KeepLabels(bool value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether point labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder KeepLabels(JS value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public PieChartAdaptiveLayoutBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
