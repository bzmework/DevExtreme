﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DevExtreme.NETCore.Demos.Models {
    public class ElectronicsGroupedItem {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CurrentInventory { get; set; }
        public int Backorder { get; set; }
        public int Manufacturing { get; set; }
        public int Price { get; set; }
        public string ImageSrc { get; set; }
        public string IconSrc { get; set; }
    }
}
