using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures client-side exporting.</summary>
	public class PivotGridExportBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public PivotGridExportBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public PivotGridExportBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Enables client-side exporting.</summary>
		[Generated]
		public PivotGridExportBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables client-side exporting.</summary>
		[Generated]
		public PivotGridExportBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which grid data is exported.</summary>
		[Generated]
		public PivotGridExportBuilder FileName(string value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies a default name for the file to which grid data is exported.</summary>
		[Generated]
		public PivotGridExportBuilder FileName(JS value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies whether Excel should hide warnings if there are errors in the exported document.</summary>
		[Generated]
		public PivotGridExportBuilder IgnoreExcelErrors(bool value)
		{
			base.Options["ignoreExcelErrors"] = value;
			return this;
		}

		/// <summary>Specifies whether Excel should hide warnings if there are errors in the exported document.</summary>
		[Generated]
		public PivotGridExportBuilder IgnoreExcelErrors(JS value)
		{
			base.Options["ignoreExcelErrors"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PivotGridExportBuilder ProxyUrl(string value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public PivotGridExportBuilder ProxyUrl(JS value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}
	}
}
