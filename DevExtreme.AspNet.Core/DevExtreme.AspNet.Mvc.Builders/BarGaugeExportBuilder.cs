using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the exporting and printing features.</summary>
	public class BarGaugeExportBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public BarGaugeExportBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public BarGaugeExportBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color that will fill transparent regions in the resulting file or document.</summary>
		[Generated]
		public BarGaugeExportBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color that will fill transparent regions in the resulting file or document.</summary>
		[Generated]
		public BarGaugeExportBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Enables the client-side exporting in the widget.</summary>
		[Generated]
		public BarGaugeExportBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the client-side exporting in the widget.</summary>
		[Generated]
		public BarGaugeExportBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which the widget will be exported.</summary>
		[Generated]
		public BarGaugeExportBuilder FileName(string value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which the widget will be exported.</summary>
		[Generated]
		public BarGaugeExportBuilder FileName(JS value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a set of export formats.</summary>
		[Generated]
		public BarGaugeExportBuilder Formats(IEnumerable<ExportFormat> value)
		{
			base.Options["formats"] = value;
			return this;
		}

		/// <summary>Adds an empty space around the exported widget; measured in pixels.</summary>
		[Generated]
		public BarGaugeExportBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Adds an empty space around the exported widget; measured in pixels.</summary>
		[Generated]
		public BarGaugeExportBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Enables the printing feature in the widget. Applies only if the export.enabled option is true.</summary>
		[Generated]
		public BarGaugeExportBuilder PrintingEnabled(bool value)
		{
			base.Options["printingEnabled"] = value;
			return this;
		}

		/// <summary>Enables the printing feature in the widget. Applies only if the export.enabled option is true.</summary>
		[Generated]
		public BarGaugeExportBuilder PrintingEnabled(JS value)
		{
			base.Options["printingEnabled"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public BarGaugeExportBuilder ProxyUrl(string value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public BarGaugeExportBuilder ProxyUrl(JS value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		/// <summary>A function that renders SVG markup on the HTML canvas. Required to export custom SVG elements (for example, markerTemplate).</summary>
		[Generated]
		public BarGaugeExportBuilder SvgToCanvas(string jsFunc)
		{
			AssignJS("svgToCanvas", jsFunc);
			return this;
		}

		/// <summary>A function that renders SVG markup on the HTML canvas. Required to export custom SVG elements (for example, markerTemplate).</summary>
		[Generated]
		public BarGaugeExportBuilder SvgToCanvas(RazorBlock jsFunc)
		{
			return SvgToCanvas(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
