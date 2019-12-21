using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using mkds.Models;

namespace mkds.Controllers
{
    public class SubscribeController : Controller
    {
        // GET: Subscribe
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail()
        {
            return View();
        }

        public Subscription CreateMockData()
        {
            Chef chef = new Chef();
            Meal meal1 = new Meal();
            Subscription subscription1 = new Subscription();
            return subscription1;
        }
    }
}