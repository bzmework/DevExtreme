using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>An array of tab configuration objects.</summary>
	public class FormTabBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormTabBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormTabBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not labels of items displayed within the current tab are aligned.</summary>
		[Generated]
		public FormTabBuilder<T> AlignItemLabels(bool value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether or not labels of items displayed within the current tab are aligned.</summary>
		[Generated]
		public FormTabBuilder<T> AlignItemLabels(JS value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies a badge text for the tab.</summary>
		[Generated]
		public FormTabBuilder<T> Badge(string value)
		{
			base.Options["badge"] = value;
			return this;
		}

		/// <summary>Specifies a badge text for the tab.</summary>
		[Generated]
		public FormTabBuilder<T> Badge(JS value)
		{
			base.Options["badge"] = value;
			return this;
		}

		/// <summary>The count of columns in the tab layout.</summary>
		[Generated]
		public FormTabBuilder<T> ColCount(int value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>The count of columns in the tab layout.</summary>
		[Generated]
		public FormTabBuilder<T> ColCount(JS value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>Specifies the relation between the screen size qualifier and the number of columns in the tabbed layout.</summary>
		[Generated]
		public FormTabBuilder<T> ColCountByScreen(Action<FormTabbedItemTabsColCountByScreenBuilder> configurator)
		{
			NestedOptions("colCountByScreen", configurator);
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the tab can respond to user interaction.</summary>
		[Generated]
		public FormTabBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether or not the tab can respond to user interaction.</summary>
		[Generated]
		public FormTabBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed on the tab.</summary>
		[Generated]
		public FormTabBuilder<T> Icon(string value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Specifies the icon to be displayed on the tab.</summary>
		[Generated]
		public FormTabBuilder<T> Icon(JS value)
		{
			base.Options["icon"] = value;
			return this;
		}

		/// <summary>Holds an array of form items displayed within the tab.</summary>
		[Generated]
		public FormTabBuilder<T> Items(Action<FormItemsFactory<T>> configurator)
		{
			CustomCollection("items", configurator);
			return this;
		}

		/// <summary>The template to be used for rendering the tab.</summary>
		[Generated]
		public FormTabBuilder<T> TabTemplate(string templateContent)
		{
			AssignTemplate("tabTemplate", templateContent);
			return this;
		}

		/// <summary>The template to be used for rendering the tab.</summary>
		[Generated]
		public FormTabBuilder<T> TabTemplate(RazorBlock templateContent)
		{
			AssignTemplate("tabTemplate", templateContent);
			return this;
		}

		/// <summary>The template to be used for rendering the tab.</summary>
		[Generated]
		public FormTabBuilder<T> TabTemplate(TemplateName name)
		{
			AssignTemplate("tabTemplate", name);
			return this;
		}

		/// <summary>The template to be used for rendering the tab.</summary>
		[Generated]
		public FormTabBuilder<T> TabTemplate(JS value)
		{
			base.Options["tabTemplate"] = value;
			return this;
		}

		/// <summary>The template to be used for rendering the tab content.</summary>
		[Generated]
		public FormTabBuilder<T> Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>The template to be used for rendering the tab content.</summary>
		[Generated]
		public FormTabBuilder<T> Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>The template to be used for rendering the tab content.</summary>
		[Generated]
		public FormTabBuilder<T> Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>The template to be used for rendering the tab content.</summary>
		[Generated]
		public FormTabBuilder<T> Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies the tab title.</summary>
		[Generated]
		public FormTabBuilder<T> Title(string value)
		{
			base.Options["title"] = value;
			return this;
		}

		/// <summary>Specifies the tab title.</summary>
		[Generated]
		public FormTabBuilder<T> Title(JS value)
		{
			base.Options["title"] = value;
			return this;
		}
	}
}
