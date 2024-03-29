using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the load panel.</summary>
	public class DataGridLoadPanelBuilder : OptionsOwnerBuilder
	{
		/// <summary>Specifies whether to show the load panel or not.</summary>
		[Obsolete("Use Enabled(bool value) instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public DataGridLoadPanelBuilder Enabled(string value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		[Generated]
		public DataGridLoadPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables displaying the load panel automatically.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables displaying the load panel automatically.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies the height of the load panel in pixels.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the height of the load panel in pixels.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies a URL pointing to an image to be used as a loading indicator.</summary>
		[Generated]
		public DataGridLoadPanelBuilder IndicatorSrc(string value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>Specifies a URL pointing to an image to be used as a loading indicator.</summary>
		[Generated]
		public DataGridLoadPanelBuilder IndicatorSrc(JS value)
		{
			base.Options["indicatorSrc"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the widget when the load panel is shown.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Shading(bool value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies whether to shade the widget when the load panel is shown.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Shading(JS value)
		{
			base.Options["shading"] = value;
			return this;
		}

		/// <summary>Specifies the shading color. Applies only if shading is true.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShadingColor(string value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies the shading color. Applies only if shading is true.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShadingColor(JS value)
		{
			base.Options["shadingColor"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the loading indicator.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShowIndicator(bool value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the loading indicator.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShowIndicator(JS value)
		{
			base.Options["showIndicator"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the pane of the load panel.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShowPane(bool value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>Specifies whether to show the pane of the load panel.</summary>
		[Generated]
		public DataGridLoadPanelBuilder ShowPane(JS value)
		{
			base.Options["showPane"] = value;
			return this;
		}

		/// <summary>Specifies text displayed on the load panel.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Text(string value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies text displayed on the load panel.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Text(JS value)
		{
			base.Options["text"] = value;
			return this;
		}

		/// <summary>Specifies the width of the load panel in pixels.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the width of the load panel in pixels.</summary>
		[Generated]
		public DataGridLoadPanelBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
