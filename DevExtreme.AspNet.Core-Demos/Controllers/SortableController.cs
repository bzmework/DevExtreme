using System;
using System.Collections.Generic;
using System.Linq;
using DevExtreme.NETCore.Demos.Models.SampleData;
using Microsoft.AspNetCore.Mvc;

namespace DevExtreme.NETCore.Demos.Controllers {
    public class SortableController : Controller {
        public ActionResult Customization() {
            return View(SampleData.EmployeeTasks.Where(task => task.Task_Parent_ID != 0));
        }
    }
}
