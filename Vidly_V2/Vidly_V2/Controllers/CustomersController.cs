using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_V2.Models;

namespace Vidly_V2.Controllers
{
    public class CustomersController : Controller
    {
        //// GET: Customers
        //public ActionResult Index()
        //{
        //    return View();
        //}

        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id=1, Name="Ajay"},
                new Customer { Id=2, Name="Rao"}
            };
        }
    }
}