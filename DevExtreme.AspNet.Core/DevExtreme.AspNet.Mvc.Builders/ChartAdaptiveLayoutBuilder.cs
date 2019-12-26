namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies adaptive layout options.</summary>
	public class ChartAdaptiveLayoutBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public ChartAdaptiveLayoutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether point labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder KeepLabels(bool value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether point labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder KeepLabels(JS value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public ChartAdaptiveLayoutBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
