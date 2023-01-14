﻿using RestaurantApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantApplication.Repositories
{
    public class ItemRepository
    {
        private RestaurantDBEntities objRestaurantDBEntities;
        public ItemRepository()
        {
            objRestaurantDBEntities = new RestaurantDBEntities();
        }
        public IEnumerable<SelectListItem> GetAllItems()
        {
            var objselectListItems = new List<SelectListItem>();
            objselectListItems = (from obj in objRestaurantDBEntities.Items
                                  select new SelectListItem()
                                  {
                                      Text = obj.ItemName,
                                      Value = obj.ItemID.ToString(),
                                      Selected = true

                                  }).ToList();
            return objselectListItems;


        }
    }
}