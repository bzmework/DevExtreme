using DevExtreme.AspNet.Mvc.Factories;
using DevExtreme.AspNet.Mvc.Helpers;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Form widget represents fields of a data object as a collection of label-editor pairs. These pairs can be arranged in several groups, tabs and columns.</summary>
	public class FormBuilder<T> : WidgetBuilder
	{
		protected override void OnBeforeRendering()
		{
			base.OnBeforeRendering();
			AppendValidationGroup();
			if (base.Options.TryGetValue("formData", out object value))
			{
				ViewDataDictionary viewDataDictionary = new ViewDataDictionary(base.ViewContext.ViewData);
				viewDataDictionary.ModelExplorer = base.ViewContext.ViewData.ModelExplorer.GetExplorerForModel(value);
				ViewContext viewContext = new ViewContext(base.ViewContext, base.ViewContext.View, viewDataDictionary, base.ViewContext.Writer);
				ICollection<IDictionary<string, object>> simpleItems = new FormSimpleItemCollector(base.Options).Collect();
				PrepareValidationRules(viewContext, simpleItems);
				PrepareEditorOptionsForModelErrors(viewContext, simpleItems);
			}
		}

		private void PrepareEditorOptionsForModelErrors(ViewContext viewContext, IEnumerable<IDictionary<string, object>> simpleItems)
		{
			ModelStateDictionary modelState = viewContext.ViewData.ModelState;
			foreach (IDictionary<string, object> simpleItem in simpleItems)
			{
				if (simpleItem.TryGetValue("dataField", out object value) && modelState.TryGetValue(value as string, out ModelStateEntry value2) && value2.Errors.Count > 0)
				{
					IDictionary<string, object> nestedOptions = OptionsOwnerBuilder.GetNestedOptions(simpleItem, "editorOptions");
					nestedOptions["isValid"] = false;
					nestedOptions["validationError"] = new
					{
						message = value2.Errors.First().ErrorMessage
					};
				}
			}
		}

		private void PrepareValidationRules(ViewContext viewContext, IEnumerable<IDictionary<string, object>> simpleItems)
		{
			foreach (IDictionary<string, object> item in simpleItems.Where((IDictionary<string, object> options) => !options.ContainsKey("validationRules")))
			{
				if (item.TryGetValue("dataField", out object value))
				{
					IEnumerable<IDictionary<string, object>> validationRulesByPropertyName = DataAnnotationsHelper.GetValidationRulesByPropertyName(value as string, viewContext);
					if (validationRulesByPropertyName.Count() > 0)
					{
						item.Add("validationRules", validationRulesByPropertyName);
					}
				}
			}
		}

		[Generated]
		public FormBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public FormBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public FormBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FormBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FormBuilder<T> AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FormBuilder<T> AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FormBuilder<T> ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FormBuilder<T> ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all root item labels are aligned.</summary>
		[Generated]
		public FormBuilder<T> AlignItemLabels(bool value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether or not all root item labels are aligned.</summary>
		[Generated]
		public FormBuilder<T> AlignItemLabels(JS value)
		{
			base.Options["alignItemLabels"] = value;
			return this;
		}

		/// <summary>Specifies whether or not item labels in all groups are aligned.</summary>
		[Generated]
		public FormBuilder<T> AlignItemLabelsInAllGroups(bool value)
		{
			base.Options["alignItemLabelsInAllGroups"] = value;
			return this;
		}

		/// <summary>Specifies whether or not item labels in all groups are aligned.</summary>
		[Generated]
		public FormBuilder<T> AlignItemLabelsInAllGroups(JS value)
		{
			base.Options["alignItemLabelsInAllGroups"] = value;
			return this;
		}

		/// <summary>The count of columns in the form layout.</summary>
		[Generated]
		public FormBuilder<T> ColCount(Mode value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>The count of columns in the form layout.</summary>
		[Generated]
		public FormBuilder<T> ColCount(int value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>The count of columns in the form layout.</summary>
		[Generated]
		public FormBuilder<T> ColCount(JS value)
		{
			base.Options["colCount"] = value;
			return this;
		}

		/// <summary>Specifies dependency between the screen factor and the count of columns in the form layout.</summary>
		[Generated]
		public FormBuilder<T> ColCountByScreen(Action<FormColCountByScreenBuilder> configurator)
		{
			NestedOptions("colCountByScreen", configurator);
			return this;
		}

		/// <summary>Specifies a function that customizes a form item after it has been created.</summary>
		[Generated]
		public FormBuilder<T> CustomizeItem(string jsFunc)
		{
			AssignJS("customizeItem", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that customizes a form item after it has been created.</summary>
		[Generated]
		public FormBuilder<T> CustomizeItem(RazorBlock jsFunc)
		{
			return CustomizeItem(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FormBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FormBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FormBuilder<T> ElementAttr(string attributeName, object value)
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
		public FormBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FormBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FormBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FormBuilder<T> FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FormBuilder<T> FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Provides the Form's data. Gets updated every time form fields change.</summary>
		[Generated]
		public FormBuilder<T> FormData(object value)
		{
			base.Options["formData"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FormBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FormBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FormBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FormBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FormBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FormBuilder<T> HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FormBuilder<T> HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Holds an array of form items.</summary>
		[Generated]
		public FormBuilder<T> Items(Action<FormItemsFactory<T>> configurator)
		{
			CustomCollection("items", configurator);
			return this;
		}

		/// <summary>Specifies the location of a label against the editor.</summary>
		[Generated]
		public FormBuilder<T> LabelLocation(FormLabelLocation value)
		{
			base.Options["labelLocation"] = value;
			return this;
		}

		/// <summary>The minimum column width used for calculating column count in the form layout.</summary>
		[Generated]
		public FormBuilder<T> MinColWidth(double value)
		{
			base.Options["minColWidth"] = value;
			return this;
		}

		/// <summary>The minimum column width used for calculating column count in the form layout.</summary>
		[Generated]
		public FormBuilder<T> MinColWidth(JS value)
		{
			base.Options["minColWidth"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FormBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FormBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FormBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FormBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the Enter key has been pressed while an editor is focused.</summary>
		[Generated]
		public FormBuilder<T> OnEditorEnterKey(string jsFunc)
		{
			AssignJS("onEditorEnterKey", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the Enter key has been pressed while an editor is focused.</summary>
		[Generated]
		public FormBuilder<T> OnEditorEnterKey(RazorBlock jsFunc)
		{
			return OnEditorEnterKey(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the value of a formData object field is changed.</summary>
		[Generated]
		public FormBuilder<T> OnFieldDataChanged(string jsFunc)
		{
			AssignJS("onFieldDataChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the value of a formData object field is changed.</summary>
		[Generated]
		public FormBuilder<T> OnFieldDataChanged(RazorBlock jsFunc)
		{
			return OnFieldDataChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FormBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FormBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FormBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FormBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>The text displayed for optional fields.</summary>
		[Generated]
		public FormBuilder<T> OptionalMark(string value)
		{
			base.Options["optionalMark"] = value;
			return this;
		}

		/// <summary>The text displayed for optional fields.</summary>
		[Generated]
		public FormBuilder<T> OptionalMark(JS value)
		{
			base.Options["optionalMark"] = value;
			return this;
		}

		/// <summary>Specifies whether all editors on the form are read-only. Applies only to non-templated items.</summary>
		[Generated]
		public FormBuilder<T> ReadOnly(bool value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>Specifies whether all editors on the form are read-only. Applies only to non-templated items.</summary>
		[Generated]
		public FormBuilder<T> ReadOnly(JS value)
		{
			base.Options["readOnly"] = value;
			return this;
		}

		/// <summary>The text displayed for required fields.</summary>
		[Generated]
		public FormBuilder<T> RequiredMark(string value)
		{
			base.Options["requiredMark"] = value;
			return this;
		}

		/// <summary>The text displayed for required fields.</summary>
		[Generated]
		public FormBuilder<T> RequiredMark(JS value)
		{
			base.Options["requiredMark"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown for end-users if a required field value is not specified.</summary>
		[Generated]
		public FormBuilder<T> RequiredMessage(string value)
		{
			base.Options["requiredMessage"] = value;
			return this;
		}

		/// <summary>Specifies the message that is shown for end-users if a required field value is not specified.</summary>
		[Generated]
		public FormBuilder<T> RequiredMessage(JS value)
		{
			base.Options["requiredMessage"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FormBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FormBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a function that categorizes screens by their width.</summary>
		[Generated]
		public FormBuilder<T> ScreenByWidth(string jsFunc)
		{
			AssignJS("screenByWidth", jsFunc);
			return this;
		}

		/// <summary>Specifies a function that categorizes screens by their width.</summary>
		[Generated]
		public FormBuilder<T> ScreenByWidth(RazorBlock jsFunc)
		{
			return ScreenByWidth(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A Boolean value specifying whether to enable or disable form scrolling.</summary>
		[Generated]
		public FormBuilder<T> ScrollingEnabled(bool value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>A Boolean value specifying whether to enable or disable form scrolling.</summary>
		[Generated]
		public FormBuilder<T> ScrollingEnabled(JS value)
		{
			base.Options["scrollingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a colon is displayed at the end of form labels.</summary>
		[Generated]
		public FormBuilder<T> ShowColonAfterLabel(bool value)
		{
			base.Options["showColonAfterLabel"] = value;
			return this;
		}

		/// <summary>Specifies whether or not a colon is displayed at the end of form labels.</summary>
		[Generated]
		public FormBuilder<T> ShowColonAfterLabel(JS value)
		{
			base.Options["showColonAfterLabel"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the optional mark is displayed for optional fields.</summary>
		[Generated]
		public FormBuilder<T> ShowOptionalMark(bool value)
		{
			base.Options["showOptionalMark"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the optional mark is displayed for optional fields.</summary>
		[Generated]
		public FormBuilder<T> ShowOptionalMark(JS value)
		{
			base.Options["showOptionalMark"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the required mark is displayed for required fields.</summary>
		[Generated]
		public FormBuilder<T> ShowRequiredMark(bool value)
		{
			base.Options["showRequiredMark"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the required mark is displayed for required fields.</summary>
		[Generated]
		public FormBuilder<T> ShowRequiredMark(JS value)
		{
			base.Options["showRequiredMark"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the total validation summary is displayed on the form.</summary>
		[Generated]
		public FormBuilder<T> ShowValidationSummary(bool value)
		{
			base.Options["showValidationSummary"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the total validation summary is displayed on the form.</summary>
		[Generated]
		public FormBuilder<T> ShowValidationSummary(JS value)
		{
			base.Options["showValidationSummary"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FormBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FormBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Gives a name to the internal validation group.</summary>
		[Generated]
		public FormBuilder<T> ValidationGroup(string value)
		{
			base.Options["validationGroup"] = value;
			return this;
		}

		/// <summary>Gives a name to the internal validation group.</summary>
		[Generated]
		public FormBuilder<T> ValidationGroup(JS value)
		{
			base.Options["validationGroup"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FormBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FormBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FormBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FormBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FormBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
