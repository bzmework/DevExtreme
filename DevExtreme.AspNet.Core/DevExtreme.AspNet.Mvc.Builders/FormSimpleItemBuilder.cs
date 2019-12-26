using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This article describes configuration options of a simple form item.</summary>
	public class FormSimpleItemBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormSimpleItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormSimpleItemBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormSimpleItemBuilder ColSpan(int value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormSimpleItemBuilder ColSpan(JS value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies the path to the formData object field bound to the current form item.</summary>
		[Generated]
		public FormSimpleItemBuilder DataField(string value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies the path to the formData object field bound to the current form item.</summary>
		[Generated]
		public FormSimpleItemBuilder DataField(JS value)
		{
			base.Options["dataField"] = value;
			return this;
		}

		/// <summary>Specifies which editor widget is used to display and edit the form item value.</summary>
		[Generated]
		public FormSimpleItemBuilder Editor(Func<FormItemEditorFactory, WidgetBuilder> widgetFactory)
		{
			NestedWidget(widgetFactory, "editorType", "editorOptions");
			return this;
		}

		/// <summary>Specifies the help text displayed for the current form item.</summary>
		[Generated]
		public FormSimpleItemBuilder HelpText(string value)
		{
			base.Options["helpText"] = value;
			return this;
		}

		/// <summary>Specifies the help text displayed for the current form item.</summary>
		[Generated]
		public FormSimpleItemBuilder HelpText(JS value)
		{
			base.Options["helpText"] = value;
			return this;
		}

		/// <summary>Specifies whether the current form item is required.</summary>
		[Generated]
		public FormSimpleItemBuilder IsRequired(bool value)
		{
			base.Options["isRequired"] = value;
			return this;
		}

		/// <summary>Specifies whether the current form item is required.</summary>
		[Generated]
		public FormSimpleItemBuilder IsRequired(JS value)
		{
			base.Options["isRequired"] = value;
			return this;
		}

		/// <summary>Specifies options for the form item label.</summary>
		[Generated]
		public FormSimpleItemBuilder Label(Action<FormItemLabelBuilder> configurator)
		{
			NestedOptions("label", configurator);
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A template to be used for rendering the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>A template to be used for rendering the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>A template to be used for rendering the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>A template to be used for rendering the form item.</summary>
		[Generated]
		public FormSimpleItemBuilder Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>An array of validation rules to be checked for the form item editor.</summary>
		[Generated]
		public FormSimpleItemBuilder ValidationRules(Action<ValidationRulesFactory> configurator)
		{
			CustomCollection("validationRules", configurator);
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormSimpleItemBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormSimpleItemBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormSimpleItemBuilder VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormSimpleItemBuilder VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}
	}
}
