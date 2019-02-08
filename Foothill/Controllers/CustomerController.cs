using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Foothill.Models;
using Foothill.ViewModels;
using System.Data.Entity;

namespace Foothill.Controllers
{
    public class CustomerController : Controller
    {
        // Initializing DB Context

        private ApplicationDbContext _context;
        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }


        // GET: Customer
        public ActionResult Index()
        {
            // This is called differed execution
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();//GetCustomer();

            return View(customers);
        }


        [Route("Customer/Details/{Id:range(1,2)}")]
        public ActionResult Details(int Id)
        {

            var customer = _context.Customers.Include(c=>c.MembershipType).SingleOrDefault(c => c.Id == Id);
            
            if(customer == null)
            {
                return HttpNotFound();
            }
            return View(customer);
        }

        // Add New Customers View
        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new CustomerViewModel()
            {
                MembershipTypes=membershipType
            };
            return View(viewModel);
        }

        // Create New Customer
        [HttpPost]
        public ActionResult Create(Customer obj)
        {
            if(obj.Id!=0)
            {
                var getCustomerData = _context.Customers.SingleOrDefault(x => x.Id == obj.Id);
                getCustomerData.Name = obj.Name;
                getCustomerData.IsSubscribed = obj.IsSubscribed;
                getCustomerData.BirthDate = obj.BirthDate;
                getCustomerData.MembershipTypeId = obj.MembershipTypeId;
            }
            _context.Customers.Add(obj);
            _context.SaveChanges();
            return RedirectToAction("New", "Customer", new  { msg="success" });
        }


        //Edit 
        [Route("Customer/Edit/{Id}")]
        public ActionResult Edit(int Id)
        {
            var customer = _context.Customers.SingleOrDefault(c => c.Id == Id);
            if(customer==null)
            {
                return HttpNotFound();
            }
            var viewModel = new CustomerViewModel
            {
                Customer=customer,
                MembershipTypes = _context.MembershipTypes.ToList()
            };
            return View("New", viewModel);
        }

        // For Disposing Db Context 
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        //private IEnumerable<Customer> GetCustomer()
        //{
        //    return _context.Customers.ToList();
            
        //}
    }
}