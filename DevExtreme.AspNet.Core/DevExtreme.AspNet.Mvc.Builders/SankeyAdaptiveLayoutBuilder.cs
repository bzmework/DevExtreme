namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies adaptive layout options.</summary>
	public class SankeyAdaptiveLayoutBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public SankeyAdaptiveLayoutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether node labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder KeepLabels(bool value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether node labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder KeepLabels(JS value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public SankeyAdaptiveLayoutBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
