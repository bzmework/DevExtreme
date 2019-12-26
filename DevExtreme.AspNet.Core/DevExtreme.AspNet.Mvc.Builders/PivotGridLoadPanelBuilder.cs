namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies options configuring the load panel.</summary>
	public class PivotGridLoadPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridLoadPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables or disables the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables or disables the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the height of the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the URL pointing to an image that will be used as a load indicator.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder IndicatorSrc(string value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>Specifies the URL pointing to an image that will be used as a load indicator.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder IndicatorSrc(JS value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a load indicator.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder ShowIndicator(bool value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show a load indicator.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder ShowIndicator(JS value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show load panel background.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder ShowPane(bool value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>Specifies whether or not to show load panel background.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder ShowPane(JS value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>Specifies the text to display inside a load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the text to display inside a load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the width of the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the load panel.</summary>
		[Generated]
		public PivotGridLoadPanelBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
