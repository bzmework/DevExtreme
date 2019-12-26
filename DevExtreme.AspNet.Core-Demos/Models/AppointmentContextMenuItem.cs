using DevExtreme.NETCore.Demos.Models.SampleData;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.Models {
    public class AppointmentContextMenuItem : RecurringAppointmentsResource {
        public string Name { get; set; }
        [JsonProperty(PropertyName = "beginGroup")]
        public bool BeginGroup { get; set; }
        [JsonProperty(PropertyName = "disabled")]
        public bool Disabled { get; set; }
    }
}
