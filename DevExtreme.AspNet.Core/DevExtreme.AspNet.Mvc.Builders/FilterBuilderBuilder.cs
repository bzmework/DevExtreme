using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The FilterBuilder widget allows a user to build complex filter expressions with an unlimited number of filter conditions, combined by logical operations using the UI.</summary>
	public class FilterBuilderBuilder<T> : WidgetBuilder
	{
		[Generated]
		public FilterBuilderBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FilterBuilderBuilder<T> AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public FilterBuilderBuilder<T> AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can display hierarchical data fields.</summary>
		[Generated]
		public FilterBuilderBuilder<T> AllowHierarchicalFields(bool value)
		{
			base.Options["allowHierarchicalFields"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can display hierarchical data fields.</summary>
		[Generated]
		public FilterBuilderBuilder<T> AllowHierarchicalFields(JS value)
		{
			base.Options["allowHierarchicalFields"] = value;
			return this;
		}

		/// <summary>Configures custom filter operations.</summary>
		[Generated]
		public FilterBuilderBuilder<T> CustomOperations(Action<CollectionFactory<FilterBuilderCustomOperationBuilder>> configurator)
		{
			Collection("customOperations", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ElementAttr(string attributeName, object value)
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
		public FilterBuilderBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public FilterBuilderBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Configures fields.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Fields(Action<CollectionFactory<FilterBuilderFieldBuilder<T>>> configurator)
		{
			Collection("fields", configurator);
			return this;
		}

		/// <summary>Specifies filter operation descriptions.</summary>
		[Generated]
		public FilterBuilderBuilder<T> FilterOperationDescriptions(Action<FilterBuilderFilterOperationDescriptionsBuilder> configurator)
		{
			NestedOptions("filterOperationDescriptions", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FilterBuilderBuilder<T> FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public FilterBuilderBuilder<T> FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies group operation descriptions.</summary>
		[Generated]
		public FilterBuilderBuilder<T> GroupOperationDescriptions(Action<FilterBuilderGroupOperationDescriptionsBuilder> configurator)
		{
			NestedOptions("groupOperationDescriptions", configurator);
			return this;
		}

		/// <summary>Specifies a set of available group operations.</summary>
		[Generated]
		public FilterBuilderBuilder<T> GroupOperations(IEnumerable<FilterBuilderGroupOperations> value)
		{
			base.Options["groupOperations"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FilterBuilderBuilder<T> HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public FilterBuilderBuilder<T> HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies groups' maximum nesting level.</summary>
		[Generated]
		public FilterBuilderBuilder<T> MaxGroupLevel(double value)
		{
			base.Options["maxGroupLevel"] = value;
			return this;
		}

		/// <summary>Specifies groups' maximum nesting level.</summary>
		[Generated]
		public FilterBuilderBuilder<T> MaxGroupLevel(JS value)
		{
			base.Options["maxGroupLevel"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after an editor is created.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnEditorPrepared(string jsFunc)
		{
			AssignJS("onEditorPrepared", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an editor is created.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnEditorPrepared(RazorBlock jsFunc)
		{
			return OnEditorPrepared(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before an editor is created.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnEditorPreparing(string jsFunc)
		{
			AssignJS("onEditorPreparing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an editor is created.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnEditorPreparing(RazorBlock jsFunc)
		{
			return OnEditorPreparing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnValueChanged(string jsFunc)
		{
			AssignJS("onValueChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after the widget's value is changed.</summary>
		[Generated]
		public FilterBuilderBuilder<T> OnValueChanged(RazorBlock jsFunc)
		{
			return OnValueChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FilterBuilderBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public FilterBuilderBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FilterBuilderBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public FilterBuilderBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Allows you to specify a filter.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Value(string jsExpr)
		{
			AssignJS("value", jsExpr);
			return this;
		}

		/// <summary>Allows you to specify a filter.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Value(object filterExpr)
		{
			base.Options["value"] = filterExpr;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public FilterBuilderBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
