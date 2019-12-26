﻿using System;
using System.ComponentModel.DataAnnotations;

namespace DevExtreme.NETCore.Demos.Models {
    public class OrderWithDelivery {
        public int ID { get; set; }

        [Display(Name = "Invoice Number")]
        public int OrderNumber { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public int SaleAmount { get; set; }
        public string Terms { get; set; }
        public int TotalAmount { get; set; }

        [Display(Name = "City")]
        public string CustomerStoreCity { get; set; }
        public string Employee { get; set; }
    }
}
