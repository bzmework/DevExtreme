using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevExtreme.NETCore.Demos.Models.SampleData {
    public partial class SampleData {
        public static IEnumerable<AppointmentContextMenuItem> AppointmentContextMenuItems {
            get {
                return new[] {
                    new AppointmentContextMenuItem {
                        Name = "Open",
                        Text = "Open"
                    },
                    new AppointmentContextMenuItem {
                        Name = "Delete",
                        Text = "Delete"
                    },
                    new AppointmentContextMenuItem {
                        Name = "RepeatWeekly",
                        Text = "Repeat Weekly",
                        BeginGroup = true
                    },
                    new AppointmentContextMenuItem {
                        Name = "SetRoom",
                        Text = "Set Room",
                        BeginGroup = true,
                        Disabled = true
                    }
                }.Concat(
                    RecurringAppointmentsResources.Select(r => new AppointmentContextMenuItem {
                        Id = r.Id,
                        Text = r.Text,
                        Color = r.Color
                    })
                );
            }
        }
    }
}
