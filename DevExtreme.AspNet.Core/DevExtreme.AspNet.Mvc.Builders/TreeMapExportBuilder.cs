using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the exporting and printing features.</summary>
	public class TreeMapExportBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeMapExportBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeMapExportBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the color that will fill transparent regions in the resulting file or document.</summary>
		[Generated]
		public TreeMapExportBuilder BackgroundColor(string value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Specifies the color that will fill transparent regions in the resulting file or document.</summary>
		[Generated]
		public TreeMapExportBuilder BackgroundColor(JS value)
		{
			base.Options["backgroundColor"] = value;
			return this;
		}

		/// <summary>Enables the client-side exporting in the widget.</summary>
		[Generated]
		public TreeMapExportBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the client-side exporting in the widget.</summary>
		[Generated]
		public TreeMapExportBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which the widget will be exported.</summary>
		[Generated]
		public TreeMapExportBuilder FileName(string value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which the widget will be exported.</summary>
		[Generated]
		public TreeMapExportBuilder FileName(JS value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a set of export formats.</summary>
		[Generated]
		public TreeMapExportBuilder Formats(IEnumerable<ExportFormat> value)
		{
			base.Options["formats"] = value;
			return this;
		}

		/// <summary>Adds an empty space around the exported widget; measured in pixels.</summary>
		[Generated]
		public TreeMapExportBuilder Margin(double value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Adds an empty space around the exported widget; measured in pixels.</summary>
		[Generated]
		public TreeMapExportBuilder Margin(JS value)
		{
			base.Options["margin"] = value;
			return this;
		}

		/// <summary>Enables the printing feature in the widget. Applies only if the export.enabled option is true.</summary>
		[Generated]
		public TreeMapExportBuilder PrintingEnabled(bool value)
		{
			base.Options["printingEnabled"] = value;
			return this;
		}

		/// <summary>Enables the printing feature in the widget. Applies only if the export.enabled option is true.</summary>
		[Generated]
		public TreeMapExportBuilder PrintingEnabled(JS value)
		{
			base.Options["printingEnabled"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public TreeMapExportBuilder ProxyUrl(string value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public TreeMapExportBuilder ProxyUrl(JS value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		/// <summary>A function that renders SVG markup on the HTML canvas. Required to export custom SVG elements (for example, markerTemplate).</summary>
		[Generated]
		public TreeMapExportBuilder SvgToCanvas(string jsFunc)
		{
			AssignJS("svgToCanvas", jsFunc);
			return this;
		}

		/// <summary>A function that renders SVG markup on the HTML canvas. Required to export custom SVG elements (for example, markerTemplate).</summary>
		[Generated]
		public TreeMapExportBuilder SvgToCanvas(RazorBlock jsFunc)
		{
			return SvgToCanvas(UnwrapJavaScriptFunc(jsFunc));
		}
	}
}
