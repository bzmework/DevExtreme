using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures client-side exporting.</summary>
	public class DataGridExportBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridExportBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridExportBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Allows an end user to export selected rows only.</summary>
		[Generated]
		public DataGridExportBuilder AllowExportSelectedData(bool value)
		{
			base.Options["allowExportSelectedData"] = value;
			return this;
		}

		/// <summary>Allows an end user to export selected rows only.</summary>
		[Generated]
		public DataGridExportBuilder AllowExportSelectedData(JS value)
		{
			base.Options["allowExportSelectedData"] = value;
			return this;
		}

		/// <summary>Customizes an Excel cell after it is created.</summary>
		[Generated]
		public DataGridExportBuilder CustomizeExcelCell(string jsFunc)
		{
			AssignJS("customizeExcelCell", jsFunc);
			return this;
		}

		/// <summary>Customizes an Excel cell after it is created.</summary>
		[Generated]
		public DataGridExportBuilder CustomizeExcelCell(RazorBlock jsFunc)
		{
			return CustomizeExcelCell(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Enables the client-side exporting.</summary>
		[Generated]
		public DataGridExportBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables the client-side exporting.</summary>
		[Generated]
		public DataGridExportBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable Excel filtering for the exported data in the resulting XLSX file.</summary>
		[Generated]
		public DataGridExportBuilder ExcelFilterEnabled(bool value)
		{
			base.Options["excelFilterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable Excel filtering for the exported data in the resulting XLSX file.</summary>
		[Generated]
		public DataGridExportBuilder ExcelFilterEnabled(JS value)
		{
			base.Options["excelFilterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable word wrapping for the exported data in the resulting XLSX file.</summary>
		[Generated]
		public DataGridExportBuilder ExcelWrapTextEnabled(bool value)
		{
			base.Options["excelWrapTextEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to enable word wrapping for the exported data in the resulting XLSX file.</summary>
		[Generated]
		public DataGridExportBuilder ExcelWrapTextEnabled(JS value)
		{
			base.Options["excelWrapTextEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which grid data is exported.</summary>
		[Generated]
		public DataGridExportBuilder FileName(string value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which grid data is exported.</summary>
		[Generated]
		public DataGridExportBuilder FileName(JS value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies whether Excel should hide warnings if there are errors in the exported document.</summary>
		[Generated]
		public DataGridExportBuilder IgnoreExcelErrors(bool value)
		{
			base.Options["ignoreExcelErrors"] = value;
			return this;
		}

		/// <summary>Specifies whether Excel should hide warnings if there are errors in the exported document.</summary>
		[Generated]
		public DataGridExportBuilder IgnoreExcelErrors(JS value)
		{
			base.Options["ignoreExcelErrors"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DataGridExportBuilder ProxyUrl(string value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DataGridExportBuilder ProxyUrl(JS value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		/// <summary>Configures the texts of export commands, buttons, and hints.</summary>
		[Generated]
		public DataGridExportBuilder Texts(Action<DataGridExportTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}
	}
}
