using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections.Generic;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>[tags] ctp The Gantt is a widget that displays the task flow and dependencies between tasks. #include common-ctp-note with { component: "Gantt" }</summary>
	public class GanttBuilder<T> : WidgetBuilder
	{
		[Generated]
		public GanttBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public GanttBuilder<T> ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public GanttBuilder<T> ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public GanttBuilder<T> Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public GanttBuilder<T> AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public GanttBuilder<T> AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public GanttBuilder<T> ActiveStateEnabled(bool value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not the widget changes its state when interacting with a user.</summary>
		[Generated]
		public GanttBuilder<T> ActiveStateEnabled(JS value)
		{
			base.Options["activeStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether users can select tasks in the Gantt.</summary>
		[Generated]
		public GanttBuilder<T> AllowSelection(bool value)
		{
			base.Options["allowSelection"] = value;
			return this;
		}

		/// <summary>Specifies whether users can select tasks in the Gantt.</summary>
		[Generated]
		public GanttBuilder<T> AllowSelection(JS value)
		{
			base.Options["allowSelection"] = value;
			return this;
		}

		/// <summary>An array of columns in the Gantt.</summary>
		[Generated]
		public GanttBuilder<T> Columns(IEnumerable<string> value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of columns in the Gantt.</summary>
		[Generated]
		public GanttBuilder<T> Columns(JS value)
		{
			base.Options["columns"] = value;
			return this;
		}

		/// <summary>An array of columns in the Gantt.</summary>
		[Generated]
		public GanttBuilder<T> Columns(Action<CollectionFactory<TreeListColumnBuilder<T>>> configurator)
		{
			Collection("columns", configurator);
			return this;
		}

		/// <summary>Configures dependencies.</summary>
		[Generated]
		public GanttBuilder<T> Dependencies(Action<GanttDependenciesBuilder> configurator)
		{
			NestedOptions("dependencies", configurator);
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public GanttBuilder<T> Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public GanttBuilder<T> Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Configures edit options.</summary>
		[Generated]
		public GanttBuilder<T> Editing(Action<GanttEditingBuilder> configurator)
		{
			NestedOptions("editing", configurator);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GanttBuilder<T> ElementAttr(string attributeName, object value)
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
		public GanttBuilder<T> ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GanttBuilder<T> ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public GanttBuilder<T> ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public GanttBuilder<T> FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public GanttBuilder<T> FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GanttBuilder<T> Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GanttBuilder<T> Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public GanttBuilder<T> Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public GanttBuilder<T> Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public GanttBuilder<T> Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public GanttBuilder<T> HoverStateEnabled(bool value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget changes its state when a user pauses on it.</summary>
		[Generated]
		public GanttBuilder<T> HoverStateEnabled(JS value)
		{
			base.Options["hoverStateEnabled"] = value;
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public GanttBuilder<T> OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public GanttBuilder<T> OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public GanttBuilder<T> OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public GanttBuilder<T> OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public GanttBuilder<T> OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public GanttBuilder<T> OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public GanttBuilder<T> OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public GanttBuilder<T> OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after users select a task or clear its selection.</summary>
		[Generated]
		public GanttBuilder<T> OnSelectionChanged(string jsFunc)
		{
			AssignJS("onSelectionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after users select a task or clear its selection.</summary>
		[Generated]
		public GanttBuilder<T> OnSelectionChanged(RazorBlock jsFunc)
		{
			return OnSelectionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Configures resource assignments.</summary>
		[Generated]
		public GanttBuilder<T> ResourceAssignments(Action<GanttResourceAssignmentsBuilder> configurator)
		{
			NestedOptions("resourceAssignments", configurator);
			return this;
		}

		/// <summary>Configures task resources.</summary>
		[Generated]
		public GanttBuilder<T> Resources(Action<GanttResourcesBuilder> configurator)
		{
			NestedOptions("resources", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public GanttBuilder<T> RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public GanttBuilder<T> RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the zoom level of tasks in the Gantt chart.</summary>
		[Generated]
		public GanttBuilder<T> ScaleType(GanttScaleType value)
		{
			base.Options["scaleType"] = value;
			return this;
		}

		/// <summary>Allows you to select a row or determine which row is selected.</summary>
		[Generated]
		public GanttBuilder<T> SelectedRowKey(object value)
		{
			base.Options["selectedRowKey"] = value;
			return this;
		}

		/// <summary>Specifies whether to display task resources.</summary>
		[Generated]
		public GanttBuilder<T> ShowResources(bool value)
		{
			base.Options["showResources"] = value;
			return this;
		}

		/// <summary>Specifies whether to display task resources.</summary>
		[Generated]
		public GanttBuilder<T> ShowResources(JS value)
		{
			base.Options["showResources"] = value;
			return this;
		}

		/// <summary>Specifies whether to show/hide horizontal faint lines that separate tasks.</summary>
		[Generated]
		public GanttBuilder<T> ShowRowLines(bool value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Specifies whether to show/hide horizontal faint lines that separate tasks.</summary>
		[Generated]
		public GanttBuilder<T> ShowRowLines(JS value)
		{
			base.Options["showRowLines"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public GanttBuilder<T> TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public GanttBuilder<T> TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the width of the task list in pixels.</summary>
		[Generated]
		public GanttBuilder<T> TaskListWidth(double value)
		{
			base.Options["taskListWidth"] = value;
			return this;
		}

		/// <summary>Specifies the width of the task list in pixels.</summary>
		[Generated]
		public GanttBuilder<T> TaskListWidth(JS value)
		{
			base.Options["taskListWidth"] = value;
			return this;
		}

		/// <summary>Configures tasks.</summary>
		[Generated]
		public GanttBuilder<T> Tasks(Action<GanttTasksBuilder> configurator)
		{
			NestedOptions("tasks", configurator);
			return this;
		}

		/// <summary>Specifies a task's title position.</summary>
		[Generated]
		public GanttBuilder<T> TaskTitlePosition(GanttTaskTitlePosition value)
		{
			base.Options["taskTitlePosition"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public GanttBuilder<T> Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public GanttBuilder<T> Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GanttBuilder<T> Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GanttBuilder<T> Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public GanttBuilder<T> Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
