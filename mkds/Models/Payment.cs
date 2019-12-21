using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace mkds.Models
{
    public class Payment
    {
        public Customized_Subscription customized_subscription;
        public Customer customer;
        public Payment_Option option;
        public double price;
        public DateTime date;
    }
}