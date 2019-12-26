using DevExtreme.AspNet.Mvc.Factories;
using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>This article describes configuration options of a group form item.</summary>
	public class FormGroupItemBuilder<T> : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public FormGroupItemBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether or not all group item labels are aligned.</summary>
		[Generated]
		public FormGroupItemBuilder<T> AlignItemLabels(bool value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all group item labels are aligned.</summary>
		[Generated]
		public FormGroupItemBuilder<T> AlignItemLabels(JS value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies the group caption.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Caption(string value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>Specifies the group caption.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Caption(JS value)
		{
			base.Options["caption"] = value;
			return this;
		}

		/// <summary>The count of columns in the group layout.</summary>
		[Generated]
		public FormGroupItemBuilder<T> ColCount(int value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>The count of columns in the group layout.</summary>
		[Generated]
		public FormGroupItemBuilder<T> ColCount(JS value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>Specifies the relation between the screen size qualifier and the number of columns in the grouped layout.</summary>
		[Generated]
		public FormGroupItemBuilder<T> ColCountByScreen(Action<FormGroupItemColCountByScreenBuilder> configurator)
		{
			NestedOptions("colCountByScreen", configurator);
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> ColSpan(int value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies the number of columns spanned by the item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> ColSpan(JS value)
		{
			base.Options["colSpan"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> CssClass(string value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Specifies a CSS class to be applied to the form item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> CssClass(JS value)
		{
			base.Options["cssClass"] = value;
			return this;
		}

		/// <summary>Holds an array of form items displayed within the group.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Items(Action<FormItemsFactory<T>> configurator)
		{
			CustomCollection("items", configurator);
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies a name that identifies the form item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A template to be used for rendering a group item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Template(string templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>A template to be used for rendering a group item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Template(RazorBlock templateContent)
		{
			AssignTemplate("template", templateContent);
			return this;
		}

		/// <summary>A template to be used for rendering a group item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Template(TemplateName name)
		{
			AssignTemplate("template", name);
			return this;
		}

		/// <summary>A template to be used for rendering a group item.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Template(JS value)
		{
			base.Options["template"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the current form item is visible.</summary>
		[Generated]
		public FormGroupItemBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormGroupItemBuilder<T> VisibleIndex(int value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}

		/// <summary>Specifies the sequence number of the item in a form, group or tab.</summary>
		[Generated]
		public FormGroupItemBuilder<T> VisibleIndex(JS value)
		{
			base.Options["visibleIndex"] = value;
			return this;
		}
	}
}
