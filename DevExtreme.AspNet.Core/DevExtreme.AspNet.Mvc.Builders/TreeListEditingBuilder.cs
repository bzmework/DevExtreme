using System;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Configures editing.</summary>
	public class TreeListEditingBuilder<T> : OptionsOwnerBuilder
	{
		[Generated]
		public TreeListEditingBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public TreeListEditingBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add new rows. It is called for each data row when defined as a function.</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowAdding(bool value)
		{
			base.Options["allowAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can add new rows. It is called for each data row when defined as a function.</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowAdding(JS value)
		{
			base.Options["allowAdding"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete rows. It is called for each data row when defined as a function.</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowDeleting(bool value)
		{
			base.Options["allowDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can delete rows. It is called for each data row when defined as a function.</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowDeleting(JS value)
		{
			base.Options["allowDeleting"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update rows. It is called for each data row when defined as a function</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowUpdating(bool value)
		{
			base.Options["allowUpdating"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can update rows. It is called for each data row when defined as a function</summary>
		[Generated]
		public TreeListEditingBuilder<T> AllowUpdating(JS value)
		{
			base.Options["allowUpdating"] = value;
			return this;
		}

		/// <summary>Configures the form. Used only if editing.mode is "form" or "popup".</summary>
		[Generated]
		public TreeListEditingBuilder<T> Form(Action<FormBuilder<T>> configurator)
		{
			NestedOptions("form", configurator);
			return this;
		}

		/// <summary>Specifies how a user edits data.</summary>
		[Generated]
		public TreeListEditingBuilder<T> Mode(GridEditMode value)
		{
			base.Options["mode"] = value;
			return this;
		}

		/// <summary>Configures the popup. Used only if editing.mode is "popup".</summary>
		[Generated]
		public TreeListEditingBuilder<T> Popup(Action<PopupBuilder> configurator)
		{
			NestedOptions("popup", configurator);
			return this;
		}

		/// <summary>Specifies operations that are performed after saving changes.</summary>
		[Generated]
		public TreeListEditingBuilder<T> RefreshMode(GridEditRefreshMode value)
		{
			base.Options["refreshMode"] = value;
			return this;
		}

		/// <summary>Specifies whether to select text in a cell when a user starts editing.</summary>
		[Generated]
		public TreeListEditingBuilder<T> SelectTextOnEditStart(bool value)
		{
			base.Options["selectTextOnEditStart"] = value;
			return this;
		}

		/// <summary>Specifies whether to select text in a cell when a user starts editing.</summary>
		[Generated]
		public TreeListEditingBuilder<T> SelectTextOnEditStart(JS value)
		{
			base.Options["selectTextOnEditStart"] = value;
			return this;
		}

		/// <summary>Specifies whether a single or double click should switch a cell to the editing state. Applies if editing.mode is "cell" or "batch".</summary>
		[Generated]
		public TreeListEditingBuilder<T> StartEditAction(GridStartEditAction value)
		{
			base.Options["startEditAction"] = value;
			return this;
		}

		/// <summary>Contains options that specify texts for editing-related UI elements.</summary>
		[Generated]
		public TreeListEditingBuilder<T> Texts(Action<TreeListEditingTextsBuilder> configurator)
		{
			NestedOptions("texts", configurator);
			return this;
		}

		/// <summary>Specifies whether the editing column uses icons instead of links.</summary>
		[Generated]
		public TreeListEditingBuilder<T> UseIcons(bool value)
		{
			base.Options["useIcons"] = value;
			return this;
		}

		/// <summary>Specifies whether the editing column uses icons instead of links.</summary>
		[Generated]
		public TreeListEditingBuilder<T> UseIcons(JS value)
		{
			base.Options["useIcons"] = value;
			return this;
		}
	}
}
