using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RestaurantApplication.ViewModel
{
    public class ItemViewModel
    {
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }
}