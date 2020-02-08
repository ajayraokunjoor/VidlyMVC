﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly_V2.Models;
using Vidly_V2.ViewModels;

namespace Vidly_V2.Controllers
{
    public class CustomersController : Controller
    {
        //// GET: Customers
        //public ActionResult Index()
        //{
        //    return View();
        //}

        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        public ActionResult New()
        {
            var membershipTypes = _context.MembershipTypes.ToList();
            var viewModel = new CustomerFormViewModel
            {
                MembershipTypes = membershipTypes
            };

            return View("CustomerForm", viewModel);
        }

        [HttpPost]
        public ActionResult Save(Customer customer)
        {
            if(customer.Id == 0)
            _context.Customers.Add(customer);
            else
            {
                var customerInDb = _context.Customers.Single(c => c.Id == customer.Id);
                customerInDb.Name = customer.Name;
                customerInDb.BirthDate = customer.BirthDate;
                customerInDb.MembershipType = customer.MembershipType;
                customerInDb.IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            }
            _context.SaveChanges();

            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == id);
            if (customer == null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerFormViewModel
            {
                Customer = customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("CustomerForm", viewModel);
        }


        public ViewResult Index()
        {
            //var customers = GetCustomers();
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Details(int Id)
        {
            //var customer = GetCustomers().SingleOrDefault(c => c.Id == Id);
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(c => c.Id == Id);

            if (customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        //public IEnumerable<Customer> GetCustomers()
        //{
        //    return new List<Customer>
        //    {
        //        new Customer { Id=1, Name="Ajay"},
        //        new Customer { Id=2, Name="Rao"}
        //    };
        //}
    }
}