using System;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures export settings.</summary>
	public class DiagramExportBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DiagramExportBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DiagramExportBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the name of the file to which the diagram is exported.</summary>
		[Generated]
		public DiagramExportBuilder FileName(string value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		/// <summary>Specifies the name of the file to which the diagram is exported.</summary>
		[Generated]
		public DiagramExportBuilder FileName(JS value)
		{
			base.Options["fileName"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DiagramExportBuilder ProxyUrl(string value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}

		[Obsolete("Safari now supports the API for saving files, and this option is no longer required.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public DiagramExportBuilder ProxyUrl(JS value)
		{
			base.Options["proxyUrl"] = value;
			return this;
		}
	}
}
