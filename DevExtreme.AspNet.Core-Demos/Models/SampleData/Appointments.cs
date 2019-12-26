﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.Models.SampleData {
    public partial class SampleData {
        public static readonly IEnumerable<Appointment> Appointments = new[] {
            new Appointment {
                AppointmentId = 1,
                Text = "Website Re-Design Plan",
                StartDate = new DateTime(2017, 5, 22, 9, 30, 0),
                EndDate = new DateTime(2017, 5, 22, 11, 30, 0)
            },
            new Appointment {
                AppointmentId = 2,
                Text = "Book Flights to San Fran for Sales Trip",
                StartDate = new DateTime(2017, 5, 22, 12, 0, 0),
                EndDate = new DateTime(2017, 5, 22, 13, 0, 0),
                AllDay = true
            },
            new Appointment {
                AppointmentId = 3,
                Text = "Install New Router in Dev Room",
                StartDate = new DateTime(2017, 5, 22, 14, 30, 0),
                EndDate = new DateTime(2017, 5, 22, 15, 30, 0)
            },
            new Appointment {
                AppointmentId = 4,
                Text = "Approve Personal Computer Upgrade Plan",
                StartDate = new DateTime(2017, 5, 23, 10, 0, 0),
                EndDate = new DateTime(2017, 5, 23, 11, 0, 0)
            },
            new Appointment {
                AppointmentId = 5,
                Text = "Final Budget Review",
                StartDate = new DateTime(2017, 5, 23, 12, 0, 0),
                EndDate = new DateTime(2017, 5, 23, 13, 35, 0)
            },
            new Appointment {
                AppointmentId = 6,
                Text = "New Brochures",
                StartDate = new DateTime(2017, 5, 23, 14, 30, 0),
                EndDate = new DateTime(2017, 5, 23, 15, 45, 0)
            },
            new Appointment {
                AppointmentId = 7,
                Text = "Install New Database",
                StartDate = new DateTime(2017, 5, 24, 9, 45, 0),
                EndDate = new DateTime(2017, 5, 24, 11, 15, 0)
            },
            new Appointment {
                AppointmentId = 8,
                Text = "Approve New Online Marketing Strategy",
                StartDate = new DateTime(2017, 5, 24, 12, 0, 0),
                EndDate = new DateTime(2017, 5, 24, 14, 0, 0)
            },
            new Appointment {
                AppointmentId = 9,
                Text = "Upgrade Personal Computers",
                StartDate = new DateTime(2017, 5, 24, 15, 15, 0),
                EndDate = new DateTime(2017, 5, 24, 16, 30, 0)
            },
            new Appointment {
                AppointmentId = 10,
                Text = "Customer Workshop",
                StartDate = new DateTime(2017, 5, 25, 11, 0, 0),
                EndDate = new DateTime(2017, 5, 25, 12, 0, 0),
                AllDay = true
            },
            new Appointment {
                AppointmentId = 11,
                Text = "Prepare 2015 Marketing Plan",
                StartDate = new DateTime(2017, 5, 25, 11, 0, 0),
                EndDate = new DateTime(2017, 5, 25, 13, 30, 0)
            },
            new Appointment {
                AppointmentId = 12,
                Text = "Brochure Design Review",
                StartDate = new DateTime(2017, 5, 25, 14, 0, 0),
                EndDate = new DateTime(2017, 5, 25, 15, 30, 0)
            },
            new Appointment {
                AppointmentId = 13,
                Text = "Create Icons for Website",
                StartDate = new DateTime(2017, 5, 26, 10, 0, 0),
                EndDate = new DateTime(2017, 5, 26, 11, 30, 0)
            },
            new Appointment {
                AppointmentId = 14,
                Text = "Upgrade Server Hardware",
                StartDate = new DateTime(2017, 5, 26, 14, 30, 0),
                EndDate = new DateTime(2017, 5, 26, 16, 0, 0)
            },
            new Appointment {
                AppointmentId = 15,
                Text = "Submit New Website Design",
                StartDate = new DateTime(2017, 5, 26, 16, 30, 0),
                EndDate = new DateTime(2017, 5, 26, 18, 0, 0)
            },
            new Appointment {
                AppointmentId = 16,
                Text = "Launch New Website",
                StartDate = new DateTime(2017, 5, 26, 12, 20, 0),
                EndDate = new DateTime(2017, 5, 26, 14, 0, 0)
            }
        };
    }
}
