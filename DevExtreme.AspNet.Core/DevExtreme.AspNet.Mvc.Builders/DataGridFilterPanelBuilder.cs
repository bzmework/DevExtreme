using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the filter panel.</summary>
	public class DataGridFilterPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public DataGridFilterPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public DataGridFilterPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Customizes the filter expression's text representation.</summary>
		[Generated]
		public DataGridFilterPanelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the filter expression's text representation.</summary>
		[Generated]
		public DataGridFilterPanelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the filter expression is applied.</summary>
		[Generated]
		public DataGridFilterPanelBuilder FilterEnabled(bool value)
		{
			base.Options["filterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter expression is applied.</summary>
		[Generated]
		public DataGridFilterPanelBuilder FilterEnabled(JS value)
		{
			base.Options["filterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies texts for the filter panel's elements.</summary>
		[Generated]
		public DataGridFilterPanelBuilder Texts(Action<DataGridFilterPanelTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies whether the filter panel is visible.</summary>
		[Generated]
		public DataGridFilterPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter panel is visible.</summary>
		[Generated]
		public DataGridFilterPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
