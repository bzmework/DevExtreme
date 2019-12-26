using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures the filter panel.</summary>
	public class TreeListFilterPanelBuilder : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListFilterPanelBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListFilterPanelBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Customizes the filter expression's text representation.</summary>
		[Generated]
		public TreeListFilterPanelBuilder CustomizeText(string jsFunc)
		{
			AssignJS("customizeText", jsFunc);
			return this;
		}

		/// <summary>Customizes the filter expression's text representation.</summary>
		[Generated]
		public TreeListFilterPanelBuilder CustomizeText(RazorBlock jsFunc)
		{
			return CustomizeText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the filter expression is applied.</summary>
		[Generated]
		public TreeListFilterPanelBuilder FilterEnabled(bool value)
		{
			base.Options["filterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter expression is applied.</summary>
		[Generated]
		public TreeListFilterPanelBuilder FilterEnabled(JS value)
		{
			base.Options["filterEnabled"] = value;
			return this;
		}

		/// <summary>Specifies texts for the filter panel's elements.</summary>
		[Generated]
		public TreeListFilterPanelBuilder Texts(Action<TreeListFilterPanelTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies whether the filter panel is visible.</summary>
		[Generated]
		public TreeListFilterPanelBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the filter panel is visible.</summary>
		[Generated]
		public TreeListFilterPanelBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}
	}
}
