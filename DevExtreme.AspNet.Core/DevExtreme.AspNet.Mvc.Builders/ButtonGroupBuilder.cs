using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The ButtonGroup is a widget that contains a set of toggle buttons and can be used as a mode switcher.</summary>
	public class ButtonGroupBuilder : WidgetBuilder
	{
		[Generated]
		public ButtonGroupBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public ButtonGroupBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public ButtonGroupBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public ButtonGroupBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ButtonGroupBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public ButtonGroupBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ButtonGroupBuilder ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public ButtonGroupBuilder ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a template for all the buttons in the group.</summary>
		[Generated]
		public ButtonGroupBuilder ButtonTemplate(string templateContent)
		{
			AssignTemplate("buttonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template for all the buttons in the group.</summary>
		[Generated]
		public ButtonGroupBuilder ButtonTemplate(RazorBlock templateContent)
		{
			AssignTemplate("buttonTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a template for all the buttons in the group.</summary>
		[Generated]
		public ButtonGroupBuilder ButtonTemplate(TemplateName name)
		{
			AssignTemplate("buttonTemplate", name);
			return this;
		}

		/// <summary>Specifies a template for all the buttons in the group.</summary>
		[Generated]
		public ButtonGroupBuilder ButtonTemplate(JS value)
		{
			base.Options["buttonTemplate"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ButtonGroupBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public ButtonGroupBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonGroupBuilder ElementAttr(string attributeName, object value)
		{
			base.Options["elementAttr"] = new Dictionary<string, object>
			{
				{
					attributeName,
					value
				}
			};
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonGroupBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonGroupBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public ButtonGroupBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ButtonGroupBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public ButtonGroupBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonGroupBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonGroupBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public ButtonGroupBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ButtonGroupBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public ButtonGroupBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ButtonGroupBuilder HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public ButtonGroupBuilder HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Configures buttons in the group.</summary>
		[Generated]
		public ButtonGroupBuilder Items(Action<CollectionFactory<ButtonGroupItemBuilder>> configurator)
		{
			Collection("items", configurator);
			return this;
		}

		[Obsolete("Use the buttonTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ButtonGroupBuilder ItemTemplate(string templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the buttonTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ButtonGroupBuilder ItemTemplate(RazorBlock templateContent)
		{
			AssignTemplate("itemTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the buttonTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ButtonGroupBuilder ItemTemplate(TemplateName name)
		{
			AssignTemplate("itemTemplate", name);
			return this;
		}

		[Obsolete("Use the buttonTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public ButtonGroupBuilder ItemTemplate(JS value)
		{
			base.Options["itemTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys used to distinguish between the selected buttons.</summary>
		[Generated]
		public ButtonGroupBuilder KeyExpr(string value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>Specifies which data field provides keys used to distinguish between the selected buttons.</summary>
		[Generated]
		public ButtonGroupBuilder KeyExpr(JS value)
		{
			base.Options["keyExpr"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ButtonGroupBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public ButtonGroupBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ButtonGroupBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public ButtonGroupBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ButtonGroupBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public ButtonGroupBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a button is clicked or tapped.</summary>
		[Generated]
		public ButtonGroupBuilder OnItemClick(string jsFunc)
		{
			AssignJS("onItemClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a button is clicked or tapped.</summary>
		[Generated]
		public ButtonGroupBuilder OnItemClick(RazorBlock jsFunc)
		{
			return OnItemClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ButtonGroupBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public ButtonGroupBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a button is selected or selection is canceled.</summary>
		[Generated]
		public ButtonGroupBuilder OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a button is selected or selection is canceled.</summary>
		[Generated]
		public ButtonGroupBuilder OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ButtonGroupBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public ButtonGroupBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Contains the keys of the selected buttons and allows selecting buttons initially.</summary>
		[Generated]
		public ButtonGroupBuilder SelectedItemKeys(IEnumerable value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>Contains the keys of the selected buttons and allows selecting buttons initially.</summary>
		[Generated]
		public ButtonGroupBuilder SelectedItemKeys(JS value)
		{
			base.Options["selectedItemKeys"] = value;
			return this;
		}

		/// <summary>Contains the data objects that correspond to the selected buttons. The data objects are taken from the items array.</summary>
		[Generated]
		public ButtonGroupBuilder SelectedItems(IEnumerable value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>Contains the data objects that correspond to the selected buttons. The data objects are taken from the items array.</summary>
		[Generated]
		public ButtonGroupBuilder SelectedItems(JS value)
		{
			base.Options["selectedItems"] = value;
			return this;
		}

		/// <summary>Specifies whether a single or multiple buttons can be in the selected state simultaneously.</summary>
		[Generated]
		public ButtonGroupBuilder SelectionMode(ButtonGroupSelectionMode value)
		{
			base.Options["selectionMode"] = value;
			return this;
		}

		/// <summary>Specifies how buttons in the group are styled.</summary>
		[Generated]
		public ButtonGroupBuilder StylingMode(ButtonStylingMode value)
		{
			base.Options["stylingMode"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ButtonGroupBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public ButtonGroupBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ButtonGroupBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public ButtonGroupBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonGroupBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonGroupBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public ButtonGroupBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
