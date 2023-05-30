using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRev.Models;
using VidlyRev.ViewModels;

namespace VidlyRev.Controllers
{
    public class CustomersController : Controller
    {
        // GET: Customers
        public ActionResult Index()
        {
            var customers = new IndexCustomersViewModel()
            {
                Customers = getCustomers()
            };
            return View(customers);
        }
        
        public ActionResult Details(int id)
        {
            var customer = getCustomers().Find(item => item.Id == id);
            if (customer != null)
                return View(customer);
            return HttpNotFound();
        }

        public List<Customer> getCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer() { Id = 1, Name = "John Smith" },
                new Customer() { Id = 2, Name = "Marry Williams" }
            };
            return customers;
        }
    }
}