﻿using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtreme.NETCore.Demos.Models;
using DevExtreme.NETCore.Demos.Models.SampleData;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace DevExtreme.NETCore.Demos.Controllers {
    public class TreeViewController : Controller {
        #region HierarchicalDataStructure
        public ActionResult HierarchicalDataStructure() {
            return View();
        }

        [HttpGet]
        public object GetHierarchicalData(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(TreeViewHierarchicalData.Products, loadOptions);
        }
        #endregion

        #region FlatDataStructure
        public ActionResult FlatDataStructure() {
            return View();
        }

        [HttpGet]
        public object GetPlainData(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(TreeViewPlainData.Products, loadOptions);
        }
        #endregion

        #region ItemSelectionAndCustomization
        public ActionResult ItemSelectionAndCustomization() {
            return View();
        }

        [HttpGet]
        public object SuperMartOfTheWest(DataSourceLoadOptions loadOptions) {
            var superMartProducts = TreeViewHierarchicalData.SuperMartOfTheWest.Items.ToArray();

            return DataSourceLoader.Load(new[] {
                superMartProducts[0],
                superMartProducts[1],
                superMartProducts[3]
            }, loadOptions);
        }

        #endregion

        public ActionResult VirtualMode() {
            return View();
        }

        public ActionResult LoadDataOnDemand() {
            return View();
        }

        #region TreeViewWithSearchBar
        public ActionResult TreeViewWithSearchBar() {
            return View();
        }

        [HttpGet]
        public object GetHierarchicalDataForSearch(DataSourceLoadOptions loadOptions) {
            return DataSourceLoader.Load(TreeViewHierarchicalDataForSearch.Products, loadOptions);
        }
        #endregion
    }
}
