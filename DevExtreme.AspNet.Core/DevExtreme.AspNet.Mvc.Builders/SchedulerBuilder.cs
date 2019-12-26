using DevExtreme.AspNet.Mvc.Builders.DataSources;
using DevExtreme.AspNet.Mvc.Factories;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>The Scheduler is a widget that represents scheduled data and allows a user to manage and edit it.</summary>
	public class SchedulerBuilder : WidgetBuilder
	{
		[Generated]
		public SchedulerBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an HTML id for the widget's root element.</summary>
		[Generated]
		public SchedulerBuilder ID(string id)
		{
			InternalID.SetStatic(id);
			return this;
		}

		/// <summary>Specifies a JS expression calculating an HTML id for the root element of the widget defined within a template.</summary>
		[Generated]
		public SchedulerBuilder ID(JS expr)
		{
			InternalID.SetExpr(expr.Value);
			return this;
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SchedulerBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SchedulerBuilder AccessKey(string value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies the shortcut key that sets focus on the widget.</summary>
		[Generated]
		public SchedulerBuilder AccessKey(JS value)
		{
			base.Options["accessKey"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget adapts to small screens.</summary>
		[Generated]
		public SchedulerBuilder AdaptivityEnabled(bool value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget adapts to small screens.</summary>
		[Generated]
		public SchedulerBuilder AdaptivityEnabled(JS value)
		{
			base.Options["adaptivityEnabled"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding appointment is an all-day appointment.</summary>
		[Generated]
		public SchedulerBuilder AllDayExpr(string value)
		{
			base.Options["allDayExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value defines whether or not the corresponding appointment is an all-day appointment.</summary>
		[Generated]
		public SchedulerBuilder AllDayExpr(JS value)
		{
			base.Options["allDayExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators.</summary>
		[Generated]
		public SchedulerBuilder AppointmentCollectorTemplate(string templateContent)
		{
			AssignTemplate("appointmentCollectorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators.</summary>
		[Generated]
		public SchedulerBuilder AppointmentCollectorTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentCollectorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators.</summary>
		[Generated]
		public SchedulerBuilder AppointmentCollectorTemplate(TemplateName name)
		{
			AssignTemplate("appointmentCollectorTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators.</summary>
		[Generated]
		public SchedulerBuilder AppointmentCollectorTemplate(JS value)
		{
			base.Options["appointmentCollectorTemplate"] = value;
			return this;
		}

		/// <summary>Configures appointment reordering using drag and drop gestures.</summary>
		[Generated]
		public SchedulerBuilder AppointmentDragging(Action<SchedulerAppointmentDraggingBuilder> configurator)
		{
			NestedOptions("appointmentDragging", configurator);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTemplate(string templateContent)
		{
			AssignTemplate("appointmentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTemplate(TemplateName name)
		{
			AssignTemplate("appointmentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTemplate(JS value)
		{
			base.Options["appointmentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTooltipTemplate(string templateContent)
		{
			AssignTemplate("appointmentTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTooltipTemplate(TemplateName name)
		{
			AssignTemplate("appointmentTooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator.</summary>
		[Generated]
		public SchedulerBuilder AppointmentTooltipTemplate(JS value)
		{
			base.Options["appointmentTooltipTemplate"] = value;
			return this;
		}

		/// <summary>Specifies cell duration in minutes.</summary>
		[Generated]
		public SchedulerBuilder CellDuration(int value)
		{
			base.Options["cellDuration"] = value;
			return this;
		}

		/// <summary>Specifies cell duration in minutes.</summary>
		[Generated]
		public SchedulerBuilder CellDuration(JS value)
		{
			base.Options["cellDuration"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll the view in both directions at the same time.</summary>
		[Generated]
		public SchedulerBuilder CrossScrollingEnabled(bool value)
		{
			base.Options["crossScrollingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether or not an end-user can scroll the view in both directions at the same time.</summary>
		[Generated]
		public SchedulerBuilder CrossScrollingEnabled(JS value)
		{
			base.Options["crossScrollingEnabled"] = value;
			return this;
		}

		/// <summary>Specifies a date displayed on the current scheduler view by default.</summary>
		[Generated]
		public SchedulerBuilder CurrentDate(DateTime value)
		{
			base.Options["currentDate"] = value;
			return this;
		}

		/// <summary>Specifies a date displayed on the current scheduler view by default.</summary>
		[Generated]
		public SchedulerBuilder CurrentDate(double value)
		{
			base.Options["currentDate"] = value;
			return this;
		}

		/// <summary>Specifies a date displayed on the current scheduler view by default.</summary>
		[Generated]
		public SchedulerBuilder CurrentDate(string value)
		{
			base.Options["currentDate"] = value;
			return this;
		}

		/// <summary>Specifies a date displayed on the current scheduler view by default.</summary>
		[Generated]
		public SchedulerBuilder CurrentDate(JS value)
		{
			base.Options["currentDate"] = value;
			return this;
		}

		/// <summary>Specifies the currently displayed view. Accepts the view's name or type.</summary>
		[Generated]
		public SchedulerBuilder CurrentView(SchedulerViewType value)
		{
			base.Options["currentView"] = value;
			return this;
		}

		/// <summary>Specifies the currently displayed view. Accepts the view's name or type.</summary>
		[Generated]
		public SchedulerBuilder CurrentView(string value)
		{
			base.Options["currentView"] = value;
			return this;
		}

		/// <summary>Specifies the currently displayed view. Accepts the view's name or type.</summary>
		[Generated]
		public SchedulerBuilder CurrentView(JS value)
		{
			base.Options["currentView"] = value;
			return this;
		}

		/// <summary>Customizes the date navigator's text.</summary>
		[Generated]
		public SchedulerBuilder CustomizeDateNavigatorText(string jsFunc)
		{
			AssignJS("customizeDateNavigatorText", jsFunc);
			return this;
		}

		/// <summary>Customizes the date navigator's text.</summary>
		[Generated]
		public SchedulerBuilder CustomizeDateNavigatorText(RazorBlock jsFunc)
		{
			return CustomizeDateNavigatorText(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerBuilder DataCellTemplate(string templateContent)
		{
			AssignTemplate("dataCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerBuilder DataCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dataCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerBuilder DataCellTemplate(TemplateName name)
		{
			AssignTemplate("dataCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerBuilder DataCellTemplate(JS value)
		{
			base.Options["dataCellTemplate"] = value;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SchedulerBuilder DataSource(Func<DataSourceFactory, OptionsOwnerBuilder> configurator)
		{
			DataSource("dataSource", configurator);
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SchedulerBuilder DataSource(string staticJsonUrl, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.StaticJson().Url(staticJsonUrl).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SchedulerBuilder DataSource(IEnumerable data, params string[] key)
		{
			return DataSource((DataSourceFactory d) => d.Array().Data(data).Key(key));
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SchedulerBuilder DataSource(JS js)
		{
			base.Options["dataSource"] = js;
			return this;
		}

		/// <summary>Binds the widget to data.</summary>
		[Generated]
		public SchedulerBuilder DataSourceOptions(Action<DataSourceOptionsBuilder> configurator)
		{
			AssignDataSourceOptions(configurator);
			return this;
		}

		/// <summary>Specifies a custom template for day scale items.</summary>
		[Generated]
		public SchedulerBuilder DateCellTemplate(string templateContent)
		{
			AssignTemplate("dateCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for day scale items.</summary>
		[Generated]
		public SchedulerBuilder DateCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dateCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for day scale items.</summary>
		[Generated]
		public SchedulerBuilder DateCellTemplate(TemplateName name)
		{
			AssignTemplate("dateCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for day scale items.</summary>
		[Generated]
		public SchedulerBuilder DateCellTemplate(JS value)
		{
			base.Options["dateCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the date-time values' serialization format. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public SchedulerBuilder DateSerializationFormat(string value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the date-time values' serialization format. Use it only if you do not specify the dataSource at design time.</summary>
		[Generated]
		public SchedulerBuilder DateSerializationFormat(JS value)
		{
			base.Options["dateSerializationFormat"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value holds the description of the corresponding appointment.</summary>
		[Generated]
		public SchedulerBuilder DescriptionExpr(string value)
		{
			base.Options["descriptionExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field whose value holds the description of the corresponding appointment.</summary>
		[Generated]
		public SchedulerBuilder DescriptionExpr(JS value)
		{
			base.Options["descriptionExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SchedulerBuilder Disabled(bool value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget responds to user interaction.</summary>
		[Generated]
		public SchedulerBuilder Disabled(JS value)
		{
			base.Options["disabled"] = value;
			return this;
		}

		[Obsolete("Use the appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder DropDownAppointmentTemplate(string templateContent)
		{
			AssignTemplate("dropDownAppointmentTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder DropDownAppointmentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownAppointmentTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder DropDownAppointmentTemplate(TemplateName name)
		{
			AssignTemplate("dropDownAppointmentTemplate", name);
			return this;
		}

		[Obsolete("Use the appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder DropDownAppointmentTemplate(JS value)
		{
			base.Options["dropDownAppointmentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies which editing operations an end-user can perform on appointments.</summary>
		[Generated]
		public SchedulerBuilder Editing(Action<SchedulerEditingBuilder> configurator)
		{
			NestedOptions("editing", configurator);
			return this;
		}

		/// <summary>Specifies which editing operations an end-user can perform on appointments.</summary>
		[Generated]
		public SchedulerBuilder Editing(bool value)
		{
			base.Options["editing"] = value;
			return this;
		}

		/// <summary>Specifies which editing operations an end-user can perform on appointments.</summary>
		[Generated]
		public SchedulerBuilder Editing(JS value)
		{
			base.Options["editing"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SchedulerBuilder ElementAttr(string attributeName, object value)
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
		public SchedulerBuilder ElementAttr(object htmlAttributes)
		{
			base.Options["elementAttr"] = AnonymousObjectToHtmlAttributes(htmlAttributes);
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SchedulerBuilder ElementAttr(Dictionary<string, object> value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the attributes to be attached to the widget's root element.</summary>
		[Generated]
		public SchedulerBuilder ElementAttr(JS value)
		{
			base.Options["elementAttr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the ending of an appointment.</summary>
		[Generated]
		public SchedulerBuilder EndDateExpr(string value)
		{
			base.Options["endDateExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the ending of an appointment.</summary>
		[Generated]
		public SchedulerBuilder EndDateExpr(JS value)
		{
			base.Options["endDateExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the timezone of the appointment end date.</summary>
		[Generated]
		public SchedulerBuilder EndDateTimeZoneExpr(string value)
		{
			base.Options["endDateTimeZoneExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the timezone of the appointment end date.</summary>
		[Generated]
		public SchedulerBuilder EndDateTimeZoneExpr(JS value)
		{
			base.Options["endDateTimeZoneExpr"] = value;
			return this;
		}

		/// <summary>Specifies the last hour on the time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerBuilder EndDayHour(double value)
		{
			base.Options["endDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the last hour on the time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerBuilder EndDayHour(JS value)
		{
			base.Options["endDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the first day of a week. Does not apply to the agenda view.</summary>
		[Generated]
		public SchedulerBuilder FirstDayOfWeek(FirstDayOfWeek value)
		{
			base.Options["firstDayOfWeek"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SchedulerBuilder FocusStateEnabled(bool value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget can be focused using keyboard navigation.</summary>
		[Generated]
		public SchedulerBuilder FocusStateEnabled(JS value)
		{
			base.Options["focusStateEnabled"] = value;
			return this;
		}

		/// <summary>If true, appointments are grouped by date first and then by resource; opposite if false. Applies only if appointments are grouped and groupOrientation is "horizontal".</summary>
		[Generated]
		public SchedulerBuilder GroupByDate(bool value)
		{
			base.Options["groupByDate"] = value;
			return this;
		}

		/// <summary>If true, appointments are grouped by date first and then by resource; opposite if false. Applies only if appointments are grouped and groupOrientation is "horizontal".</summary>
		[Generated]
		public SchedulerBuilder GroupByDate(JS value)
		{
			base.Options["groupByDate"] = value;
			return this;
		}

		/// <summary>Specifies the resource kinds by which the scheduler's appointments are grouped in a timetable.</summary>
		[Generated]
		public SchedulerBuilder Groups(IEnumerable<string> value)
		{
			base.Options["groups"] = value;
			return this;
		}

		/// <summary>Specifies the resource kinds by which the scheduler's appointments are grouped in a timetable.</summary>
		[Generated]
		public SchedulerBuilder Groups(JS value)
		{
			base.Options["groups"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SchedulerBuilder Height(double value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SchedulerBuilder Height(string value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies the widget's height.</summary>
		[Generated]
		public SchedulerBuilder Height(JS value)
		{
			base.Options["height"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SchedulerBuilder Hint(string value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies text for a hint that appears when a user pauses on the widget.</summary>
		[Generated]
		public SchedulerBuilder Hint(JS value)
		{
			base.Options["hint"] = value;
			return this;
		}

		/// <summary>Specifies the time interval between when the date-time indicator changes its position, in milliseconds.</summary>
		[Generated]
		public SchedulerBuilder IndicatorUpdateInterval(double value)
		{
			base.Options["indicatorUpdateInterval"] = value;
			return this;
		}

		/// <summary>Specifies the time interval between when the date-time indicator changes its position, in milliseconds.</summary>
		[Generated]
		public SchedulerBuilder IndicatorUpdateInterval(JS value)
		{
			base.Options["indicatorUpdateInterval"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Max(DateTime value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Max(double value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Max(string value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>The latest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Max(JS value)
		{
			base.Options["max"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerBuilder MaxAppointmentsPerCell(MaxAppointmentsPerCell value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerBuilder MaxAppointmentsPerCell(int value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerBuilder MaxAppointmentsPerCell(JS value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Min(DateTime value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Min(double value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Min(string value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The earliest date the widget allows you to select.</summary>
		[Generated]
		public SchedulerBuilder Min(JS value)
		{
			base.Options["min"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty. Available for the Agenda view only.</summary>
		[Generated]
		public SchedulerBuilder NoDataText(string value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>The text or HTML markup displayed by the widget if the item collection is empty. Available for the Agenda view only.</summary>
		[Generated]
		public SchedulerBuilder NoDataText(JS value)
		{
			base.Options["noDataText"] = value;
			return this;
		}

		/// <summary>A function that is executed after an appointment is added to the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentAdded(string jsFunc)
		{
			AssignJS("onAppointmentAdded", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an appointment is added to the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentAdded(RazorBlock jsFunc)
		{
			return OnAppointmentAdded(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before an appointment is added to the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentAdding(string jsFunc)
		{
			AssignJS("onAppointmentAdding", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an appointment is added to the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentAdding(RazorBlock jsFunc)
		{
			return OnAppointmentAdding(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an appointment is clicked or tapped.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentClick(string jsFunc)
		{
			AssignJS("onAppointmentClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an appointment is clicked or tapped.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentClick(RazorBlock jsFunc)
		{
			return OnAppointmentClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user attempts to open the browser's context menu for an appointment. Allows you to replace this context menu with a custom context menu.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentContextMenu(string jsFunc)
		{
			AssignJS("onAppointmentContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user attempts to open the browser's context menu for an appointment. Allows you to replace this context menu with a custom context menu.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentContextMenu(RazorBlock jsFunc)
		{
			return OnAppointmentContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an appointment is double-clicked or double-tapped.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDblClick(string jsFunc)
		{
			AssignJS("onAppointmentDblClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an appointment is double-clicked or double-tapped.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDblClick(RazorBlock jsFunc)
		{
			return OnAppointmentDblClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after an appointment is deleted from the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDeleted(string jsFunc)
		{
			AssignJS("onAppointmentDeleted", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an appointment is deleted from the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDeleted(RazorBlock jsFunc)
		{
			return OnAppointmentDeleted(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before an appointment is deleted from the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDeleting(string jsFunc)
		{
			AssignJS("onAppointmentDeleting", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an appointment is deleted from the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentDeleting(RazorBlock jsFunc)
		{
			return OnAppointmentDeleting(UnwrapJavaScriptFunc(jsFunc));
		}

		[Obsolete("Use the onAppointmentFormOpening option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder OnAppointmentFormCreated(string jsFunc)
		{
			AssignJS("onAppointmentFormCreated", jsFunc);
			return this;
		}

		[Obsolete("Use the onAppointmentFormOpening option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerBuilder OnAppointmentFormCreated(RazorBlock jsFunc)
		{
			return OnAppointmentFormCreated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before an appointment details form is opened.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentFormOpening(string jsFunc)
		{
			AssignJS("onAppointmentFormOpening", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an appointment details form is opened.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentFormOpening(RazorBlock jsFunc)
		{
			return OnAppointmentFormOpening(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when an appointment is rendered.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentRendered(string jsFunc)
		{
			AssignJS("onAppointmentRendered", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when an appointment is rendered.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentRendered(RazorBlock jsFunc)
		{
			return OnAppointmentRendered(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after an appointment is updated in the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentUpdated(string jsFunc)
		{
			AssignJS("onAppointmentUpdated", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after an appointment is updated in the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentUpdated(RazorBlock jsFunc)
		{
			return OnAppointmentUpdated(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before an appointment is updated in the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentUpdating(string jsFunc)
		{
			AssignJS("onAppointmentUpdating", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before an appointment is updated in the data source.</summary>
		[Generated]
		public SchedulerBuilder OnAppointmentUpdating(RazorBlock jsFunc)
		{
			return OnAppointmentUpdating(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a view cell is clicked.</summary>
		[Generated]
		public SchedulerBuilder OnCellClick(string jsFunc)
		{
			AssignJS("onCellClick", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a view cell is clicked.</summary>
		[Generated]
		public SchedulerBuilder OnCellClick(RazorBlock jsFunc)
		{
			return OnCellClick(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when a user attempts to open the browser's context menu for a cell. Allows you to replace this context menu with a custom context menu.</summary>
		[Generated]
		public SchedulerBuilder OnCellContextMenu(string jsFunc)
		{
			AssignJS("onCellContextMenu", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when a user attempts to open the browser's context menu for a cell. Allows you to replace this context menu with a custom context menu.</summary>
		[Generated]
		public SchedulerBuilder OnCellContextMenu(RazorBlock jsFunc)
		{
			return OnCellContextMenu(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SchedulerBuilder OnContentReady(string jsFunc)
		{
			AssignJS("onContentReady", jsFunc);
			return this;
		}

		/// <summary>A function that is executed when the widget's content is ready and each time the content is changed.</summary>
		[Generated]
		public SchedulerBuilder OnContentReady(RazorBlock jsFunc)
		{
			return OnContentReady(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SchedulerBuilder OnDisposing(string jsFunc)
		{
			AssignJS("onDisposing", jsFunc);
			return this;
		}

		/// <summary>A function that is executed before the widget is disposed of.</summary>
		[Generated]
		public SchedulerBuilder OnDisposing(RazorBlock jsFunc)
		{
			return OnDisposing(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SchedulerBuilder OnInitialized(string jsFunc)
		{
			AssignJS("onInitialized", jsFunc);
			return this;
		}

		/// <summary>A function used in JavaScript frameworks to save the widget instance.</summary>
		[Generated]
		public SchedulerBuilder OnInitialized(RazorBlock jsFunc)
		{
			return OnInitialized(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SchedulerBuilder OnOptionChanged(string jsFunc)
		{
			AssignJS("onOptionChanged", jsFunc);
			return this;
		}

		/// <summary>A function that is executed after a widget option is changed.</summary>
		[Generated]
		public SchedulerBuilder OnOptionChanged(RazorBlock jsFunc)
		{
			return OnOptionChanged(UnwrapJavaScriptFunc(jsFunc));
		}

		/// <summary>Specifies the edit mode for recurring appointments.</summary>
		[Generated]
		public SchedulerBuilder RecurrenceEditMode(SchedulerRecurrenceEditMode value)
		{
			base.Options["recurrenceEditMode"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines exceptions for the current recurring appointment.</summary>
		[Generated]
		public SchedulerBuilder RecurrenceExceptionExpr(string value)
		{
			base.Options["recurrenceExceptionExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines exceptions for the current recurring appointment.</summary>
		[Generated]
		public SchedulerBuilder RecurrenceExceptionExpr(JS value)
		{
			base.Options["recurrenceExceptionExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines a recurrence rule for generating recurring appointments.</summary>
		[Generated]
		public SchedulerBuilder RecurrenceRuleExpr(string value)
		{
			base.Options["recurrenceRuleExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines a recurrence rule for generating recurring appointments.</summary>
		[Generated]
		public SchedulerBuilder RecurrenceRuleExpr(JS value)
		{
			base.Options["recurrenceRuleExpr"] = value;
			return this;
		}

		/// <summary>Specifies whether filtering is performed on the server or client side.</summary>
		[Generated]
		public SchedulerBuilder RemoteFiltering(bool value)
		{
			base.Options["remoteFiltering"] = value;
			return this;
		}

		/// <summary>Specifies whether filtering is performed on the server or client side.</summary>
		[Generated]
		public SchedulerBuilder RemoteFiltering(JS value)
		{
			base.Options["remoteFiltering"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerBuilder ResourceCellTemplate(string templateContent)
		{
			AssignTemplate("resourceCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerBuilder ResourceCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("resourceCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerBuilder ResourceCellTemplate(TemplateName name)
		{
			AssignTemplate("resourceCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerBuilder ResourceCellTemplate(JS value)
		{
			base.Options["resourceCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies an array of resources available in the scheduler.</summary>
		[Generated]
		public SchedulerBuilder Resources(Action<CollectionFactory<SchedulerResourceBuilder>> configurator)
		{
			Collection("resources", configurator);
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SchedulerBuilder RtlEnabled(bool value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Switches the widget to a right-to-left representation.</summary>
		[Generated]
		public SchedulerBuilder RtlEnabled(JS value)
		{
			base.Options["rtlEnabled"] = value;
			return this;
		}

		/// <summary>Specifies whether to apply shading to cover the timetable up to the current time.</summary>
		[Generated]
		public SchedulerBuilder ShadeUntilCurrentTime(bool value)
		{
			base.Options["shadeUntilCurrentTime"] = value;
			return this;
		}

		/// <summary>Specifies whether to apply shading to cover the timetable up to the current time.</summary>
		[Generated]
		public SchedulerBuilder ShadeUntilCurrentTime(JS value)
		{
			base.Options["shadeUntilCurrentTime"] = value;
			return this;
		}

		/// <summary>Specifies the "All-day" panel's visibility. Setting this option to false hides the panel along with the all-day appointments.</summary>
		[Generated]
		public SchedulerBuilder ShowAllDayPanel(bool value)
		{
			base.Options["showAllDayPanel"] = value;
			return this;
		}

		/// <summary>Specifies the "All-day" panel's visibility. Setting this option to false hides the panel along with the all-day appointments.</summary>
		[Generated]
		public SchedulerBuilder ShowAllDayPanel(JS value)
		{
			base.Options["showAllDayPanel"] = value;
			return this;
		}

		/// <summary>Specifies the current date-time indicator's visibility.</summary>
		[Generated]
		public SchedulerBuilder ShowCurrentTimeIndicator(bool value)
		{
			base.Options["showCurrentTimeIndicator"] = value;
			return this;
		}

		/// <summary>Specifies the current date-time indicator's visibility.</summary>
		[Generated]
		public SchedulerBuilder ShowCurrentTimeIndicator(JS value)
		{
			base.Options["showCurrentTimeIndicator"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the start of an appointment.</summary>
		[Generated]
		public SchedulerBuilder StartDateExpr(string value)
		{
			base.Options["startDateExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the start of an appointment.</summary>
		[Generated]
		public SchedulerBuilder StartDateExpr(JS value)
		{
			base.Options["startDateExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the timezone of the appointment start date.</summary>
		[Generated]
		public SchedulerBuilder StartDateTimeZoneExpr(string value)
		{
			base.Options["startDateTimeZoneExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that defines the timezone of the appointment start date.</summary>
		[Generated]
		public SchedulerBuilder StartDateTimeZoneExpr(JS value)
		{
			base.Options["startDateTimeZoneExpr"] = value;
			return this;
		}

		/// <summary>Specifies the first hour on the time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerBuilder StartDayHour(double value)
		{
			base.Options["startDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the first hour on the time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerBuilder StartDayHour(JS value)
		{
			base.Options["startDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SchedulerBuilder TabIndex(int value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the number of the element when the Tab key is used for navigating.</summary>
		[Generated]
		public SchedulerBuilder TabIndex(JS value)
		{
			base.Options["tabIndex"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that holds the subject of an appointment.</summary>
		[Generated]
		public SchedulerBuilder TextExpr(string value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies the name of the data source item field that holds the subject of an appointment.</summary>
		[Generated]
		public SchedulerBuilder TextExpr(JS value)
		{
			base.Options["textExpr"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerBuilder TimeCellTemplate(string templateContent)
		{
			AssignTemplate("timeCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerBuilder TimeCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("timeCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerBuilder TimeCellTemplate(TemplateName name)
		{
			AssignTemplate("timeCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerBuilder TimeCellTemplate(JS value)
		{
			base.Options["timeCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the timezone of the widget.</summary>
		[Generated]
		public SchedulerBuilder TimeZone(string value)
		{
			base.Options["timeZone"] = value;
			return this;
		}

		/// <summary>Specifies the timezone of the widget.</summary>
		[Generated]
		public SchedulerBuilder TimeZone(JS value)
		{
			base.Options["timeZone"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can switch views using tabs or a drop-down menu.</summary>
		[Generated]
		public SchedulerBuilder UseDropDownViewSwitcher(bool value)
		{
			base.Options["useDropDownViewSwitcher"] = value;
			return this;
		}

		/// <summary>Specifies whether a user can switch views using tabs or a drop-down menu.</summary>
		[Generated]
		public SchedulerBuilder UseDropDownViewSwitcher(JS value)
		{
			base.Options["useDropDownViewSwitcher"] = value;
			return this;
		}

		/// <summary>Specifies and configures the views to be available in the view switcher.</summary>
		[Generated]
		public SchedulerBuilder Views(Action<CollectionFactory<SchedulerViewBuilder>> configurator)
		{
			Collection("views", configurator);
			return this;
		}

		/// <summary>Specifies and configures the views to be available in the view switcher.</summary>
		[Generated]
		public SchedulerBuilder Views(IEnumerable<SchedulerViewType> value)
		{
			base.Options["views"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SchedulerBuilder Visible(bool value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies whether the widget is visible.</summary>
		[Generated]
		public SchedulerBuilder Visible(JS value)
		{
			base.Options["visible"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SchedulerBuilder Width(double value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SchedulerBuilder Width(string value)
		{
			base.Options["width"] = value;
			return this;
		}

		/// <summary>Specifies the widget's width.</summary>
		[Generated]
		public SchedulerBuilder Width(JS value)
		{
			base.Options["width"] = value;
			return this;
		}
	}
}
