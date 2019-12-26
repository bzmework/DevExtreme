using DevExtreme.NETCore.Demos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.ViewModels {
    public class AppointmentContextMenuItemsViewModel : RecurringAppointmentsViewModel {
        public IEnumerable<AppointmentContextMenuItem> ContextMenuItems { get; set; }
    }
}
