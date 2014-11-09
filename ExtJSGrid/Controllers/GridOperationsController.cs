using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GridInExtJS.Models;
using Newtonsoft.Json;

namespace GridInExtJS.Controllers
{
    public class GridOperationsController : Controller
    {
        //
        // GET: /GridOperations/Index

        public ActionResult Index()
        {
            var list = new List<UserStore>();

            //add the mockup data to display in the grid
            list.Add(new UserStore() { EmailAddress = "r.taylor@abc.com", FirstName = "Rose", LastName = "Taylor"});
            list.Add(new UserStore() { EmailAddress = "r.Nguyen@abc.com", FirstName = "Russell", LastName = "Nguyen" });
            list.Add(new UserStore() { EmailAddress = "e.davis@abc.com", FirstName = "Ellis", LastName = "Davis" });
            list.Add(new UserStore() { EmailAddress = "n.clarke@abc.com", FirstName = "Neal", LastName = "Clarke" });
            list.Add(new UserStore() { EmailAddress = "b.taylor@abc.com", FirstName = "Brendon", LastName = "Taylor" });

            //push the data on to the ViewBag.
            ViewBag.userStore = JsonConvert.SerializeObject(list);

            return View();
        }

    }
}
