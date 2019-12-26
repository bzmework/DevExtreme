namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Allows you to build a master-detail interface in the grid.</summary>
	public class DataGridMasterDetailBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridMasterDetailBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether detail sections appear expanded or collapsed.</summary>
		[Generated]
		public DataGridMasterDetailBuilder AutoExpandAll(bool value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Specifies whether detail sections appear expanded or collapsed.</summary>
		[Generated]
		public DataGridMasterDetailBuilder AutoExpandAll(JS value)
		{
			base.Options["autoExpandAll"] = value;
			return this;
		}

		/// <summary>Enables an end-user to expand/collapse detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Enabled(bool value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Enables an end-user to expand/collapse detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Enabled(JS value)
		{
			base.Options["enabled"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>Specifies a custom template for detail sections.</summary>
		[Generated]
		public DataGridMasterDetailBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}
	}
}
