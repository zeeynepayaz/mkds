using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mkds.Models
{
    public class Subscription
    {
        public string name;
        public double price;
        public Meal monday_meal;
        public Meal tuesday_meal;
        public Meal wednesday_meal;
        public Meal thursday_meal;
        public Meal friday_meal;
        public Meal saturday_meal;
        public Meal sunday_meal;
    }
}