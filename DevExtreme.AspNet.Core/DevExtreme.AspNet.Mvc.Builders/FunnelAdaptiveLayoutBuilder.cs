namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies adaptive layout options.</summary>
	public class FunnelAdaptiveLayoutBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public FunnelAdaptiveLayoutBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container height at which the layout begins to adapt.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies whether item labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder KeepLabels(bool value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether item labels should be kept when the widget adapts the layout.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder KeepLabels(JS value)
		{
			base.Options["keepLabels"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the minimum container width at which the layout begins to adapt.</summary>
		[Generated]
		public FunnelAdaptiveLayoutBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
