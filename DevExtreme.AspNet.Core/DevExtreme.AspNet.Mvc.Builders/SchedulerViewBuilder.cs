using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace DevExtreme.AspNet.Mvc.Builders
{
	/// <summary>Specifies and configures the views to be available in the view switcher.</summary>
	public class SchedulerViewBuilder : OptionsOwnerBuilder, ICollectionItem
	{
		[Generated]
		int ICollectionItem.Index
		{
			get;
			set;
		}

		[Generated]
		public SchedulerViewBuilder(OptionsOwnerContext context)
			: base(context)
		{
		}

		/// <summary>Specifies an option by its name.</summary>
		[Generated]
		public SchedulerViewBuilder Option(string jsName, object value)
		{
			base.Options[jsName] = value;
			return this;
		}

		/// <summary>Specifies the number of dates that can be shown at a time in the agenda view.</summary>
		[Generated]
		public SchedulerViewBuilder AgendaDuration(int value)
		{
			base.Options["agendaDuration"] = value;
			return this;
		}

		/// <summary>Specifies the number of dates that can be shown at a time in the agenda view.</summary>
		[Generated]
		public SchedulerViewBuilder AgendaDuration(JS value)
		{
			base.Options["agendaDuration"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentCollectorTemplate(string templateContent)
		{
			AssignTemplate("appointmentCollectorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentCollectorTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentCollectorTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentCollectorTemplate(TemplateName name)
		{
			AssignTemplate("appointmentCollectorTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for cell overflow indicators in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentCollectorTemplate(JS value)
		{
			base.Options["appointmentCollectorTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTemplate(string templateContent)
		{
			AssignTemplate("appointmentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTemplate(TemplateName name)
		{
			AssignTemplate("appointmentTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for appointments.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTemplate(JS value)
		{
			base.Options["appointmentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTooltipTemplate(string templateContent)
		{
			AssignTemplate("appointmentTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTooltipTemplate(RazorBlock templateContent)
		{
			AssignTemplate("appointmentTooltipTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTooltipTemplate(TemplateName name)
		{
			AssignTemplate("appointmentTooltipTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for tooltips displayed when users click an appointment or cell overflow indicator in this view.</summary>
		[Generated]
		public SchedulerViewBuilder AppointmentTooltipTemplate(JS value)
		{
			base.Options["appointmentTooltipTemplate"] = value;
			return this;
		}

		/// <summary>The cell duration in minutes.</summary>
		[Generated]
		public SchedulerViewBuilder CellDuration(int value)
		{
			base.Options["cellDuration"] = value;
			return this;
		}

		/// <summary>The cell duration in minutes.</summary>
		[Generated]
		public SchedulerViewBuilder CellDuration(JS value)
		{
			base.Options["cellDuration"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerViewBuilder DataCellTemplate(string templateContent)
		{
			AssignTemplate("dataCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerViewBuilder DataCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dataCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerViewBuilder DataCellTemplate(TemplateName name)
		{
			AssignTemplate("dataCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for table cells.</summary>
		[Generated]
		public SchedulerViewBuilder DataCellTemplate(JS value)
		{
			base.Options["dataCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for date scale items.</summary>
		[Generated]
		public SchedulerViewBuilder DateCellTemplate(string templateContent)
		{
			AssignTemplate("dateCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for date scale items.</summary>
		[Generated]
		public SchedulerViewBuilder DateCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dateCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for date scale items.</summary>
		[Generated]
		public SchedulerViewBuilder DateCellTemplate(TemplateName name)
		{
			AssignTemplate("dateCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for date scale items.</summary>
		[Generated]
		public SchedulerViewBuilder DateCellTemplate(JS value)
		{
			base.Options["dateCellTemplate"] = value;
			return this;
		}

		[Obsolete("Use the views.appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerViewBuilder DropDownAppointmentTemplate(string templateContent)
		{
			AssignTemplate("dropDownAppointmentTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the views.appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerViewBuilder DropDownAppointmentTemplate(RazorBlock templateContent)
		{
			AssignTemplate("dropDownAppointmentTemplate", templateContent);
			return this;
		}

		[Obsolete("Use the views.appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerViewBuilder DropDownAppointmentTemplate(TemplateName name)
		{
			AssignTemplate("dropDownAppointmentTemplate", name);
			return this;
		}

		[Obsolete("Use the views.appointmentTooltipTemplate option instead.")]
		[EditorBrowsable(EditorBrowsableState.Never)]
		[Generated]
		public SchedulerViewBuilder DropDownAppointmentTemplate(JS value)
		{
			base.Options["dropDownAppointmentTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the last hour on the view's time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerViewBuilder EndDayHour(double value)
		{
			base.Options["endDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the last hour on the view's time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerViewBuilder EndDayHour(JS value)
		{
			base.Options["endDayHour"] = value;
			return this;
		}

		/// <summary>The first day of a week. Does not apply to the agenda view.</summary>
		[Generated]
		public SchedulerViewBuilder FirstDayOfWeek(FirstDayOfWeek value)
		{
			base.Options["firstDayOfWeek"] = value;
			return this;
		}

		/// <summary>If true, appointments are grouped by date first and then by resource; opposite if false. Applies only if appointments are grouped and groupOrientation is "horizontal".</summary>
		[Generated]
		public SchedulerViewBuilder GroupByDate(bool value)
		{
			base.Options["groupByDate"] = value;
			return this;
		}

		/// <summary>If true, appointments are grouped by date first and then by resource; opposite if false. Applies only if appointments are grouped and groupOrientation is "horizontal".</summary>
		[Generated]
		public SchedulerViewBuilder GroupByDate(JS value)
		{
			base.Options["groupByDate"] = value;
			return this;
		}

		/// <summary>Arranges resource headers vertically (in a column) or horizontally (in a row).</summary>
		[Generated]
		public SchedulerViewBuilder GroupOrientation(Orientation value)
		{
			base.Options["groupOrientation"] = value;
			return this;
		}

		/// <summary>The resource kinds by which appointments are grouped.</summary>
		[Generated]
		public SchedulerViewBuilder Groups(IEnumerable<string> value)
		{
			base.Options["groups"] = value;
			return this;
		}

		/// <summary>The resource kinds by which appointments are grouped.</summary>
		[Generated]
		public SchedulerViewBuilder Groups(JS value)
		{
			base.Options["groups"] = value;
			return this;
		}

		/// <summary>Multiplies the default view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder IntervalCount(int value)
		{
			base.Options["intervalCount"] = value;
			return this;
		}

		/// <summary>Multiplies the default view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder IntervalCount(JS value)
		{
			base.Options["intervalCount"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder MaxAppointmentsPerCell(MaxAppointmentsPerCell value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder MaxAppointmentsPerCell(int value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>Specifies the limit of full-sized appointments displayed per cell. Applies to all views except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder MaxAppointmentsPerCell(JS value)
		{
			base.Options["maxAppointmentsPerCell"] = value;
			return this;
		}

		/// <summary>A custom name for the view. This name goes to the view switcher.</summary>
		[Generated]
		public SchedulerViewBuilder Name(string value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>A custom name for the view. This name goes to the view switcher.</summary>
		[Generated]
		public SchedulerViewBuilder Name(JS value)
		{
			base.Options["name"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerViewBuilder ResourceCellTemplate(string templateContent)
		{
			AssignTemplate("resourceCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerViewBuilder ResourceCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("resourceCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerViewBuilder ResourceCellTemplate(TemplateName name)
		{
			AssignTemplate("resourceCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for resource headers.</summary>
		[Generated]
		public SchedulerViewBuilder ResourceCellTemplate(JS value)
		{
			base.Options["resourceCellTemplate"] = value;
			return this;
		}

		/// <summary>Specifies the date from which to start counting the view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder StartDate(DateTime value)
		{
			base.Options["startDate"] = value;
			return this;
		}

		/// <summary>Specifies the date from which to start counting the view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder StartDate(double value)
		{
			base.Options["startDate"] = value;
			return this;
		}

		/// <summary>Specifies the date from which to start counting the view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder StartDate(string value)
		{
			base.Options["startDate"] = value;
			return this;
		}

		/// <summary>Specifies the date from which to start counting the view interval. Applies to all view types except "agenda".</summary>
		[Generated]
		public SchedulerViewBuilder StartDate(JS value)
		{
			base.Options["startDate"] = value;
			return this;
		}

		/// <summary>Specifies the first hour on the view's time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerViewBuilder StartDayHour(double value)
		{
			base.Options["startDayHour"] = value;
			return this;
		}

		/// <summary>Specifies the first hour on the view's time scale. Accepts integer values from 0 to 24.</summary>
		[Generated]
		public SchedulerViewBuilder StartDayHour(JS value)
		{
			base.Options["startDayHour"] = value;
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerViewBuilder TimeCellTemplate(string templateContent)
		{
			AssignTemplate("timeCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerViewBuilder TimeCellTemplate(RazorBlock templateContent)
		{
			AssignTemplate("timeCellTemplate", templateContent);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerViewBuilder TimeCellTemplate(TemplateName name)
		{
			AssignTemplate("timeCellTemplate", name);
			return this;
		}

		/// <summary>Specifies a custom template for time scale items.</summary>
		[Generated]
		public SchedulerViewBuilder TimeCellTemplate(JS value)
		{
			base.Options["timeCellTemplate"] = value;
			return this;
		}

		/// <summary>The name of the view.</summary>
		[Generated]
		public SchedulerViewBuilder Type(SchedulerViewType value)
		{
			base.Options["type"] = value;
			return this;
		}
	}
}
