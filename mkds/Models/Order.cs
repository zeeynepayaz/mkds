﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mkds.Models
{
    public class Order
    {
        public int order_id;
        public Meal meal;
        public Carrier carrier;
    }
}