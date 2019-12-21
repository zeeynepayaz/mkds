using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mkds.Models
{
    public class Customized_Subscription
    {
        public bool monday;
        public bool tuesday;
        public bool wednesday;
        public bool thursday;
        public bool friday;
        public bool saturday;
        public bool sunday;
        public Subscription subscription;
        public Customer customer;
    }
}