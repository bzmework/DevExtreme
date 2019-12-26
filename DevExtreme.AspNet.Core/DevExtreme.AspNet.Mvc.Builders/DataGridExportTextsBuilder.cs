namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the texts of export commands, buttons, and hints.</summary>
	public class DataGridExportTextsBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridExportTextsBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridExportTextsBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>The text or hint of the command that exports all data.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportAll(string value)
		{
			base.Options["exportAll"] = value;
			return this;
		}

		/// <summary>The text or hint of the command that exports all data.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportAll(JS value)
		{
			base.Options["exportAll"] = value;
			return this;
		}

		/// <summary>The text of the command that exports selected rows. Applies when allowExportSelectedData option is true.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportSelectedRows(string value)
		{
			base.Options["exportSelectedRows"] = value;
			return this;
		}

		/// <summary>The text of the command that exports selected rows. Applies when allowExportSelectedData option is true.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportSelectedRows(JS value)
		{
			base.Options["exportSelectedRows"] = value;
			return this;
		}

		/// <summary>The hint of the Export button when the allowExportSelectedData option is true.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportTo(string value)
		{
			base.Options["exportTo"] = value;
			return this;
		}

		/// <summary>The hint of the Export button when the allowExportSelectedData option is true.</summary>
		[Generated]
		public DataGridExportTextsBuilder ExportTo(JS value)
		{
			base.Options["exportTo"] = value;
			return this;
		}
	}
}
