using BankCMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace BankCMS.Controllers
{
    public class CustomerController : Controller
    {
        Customer[] customers = [
                new Customer(Id: 1, Name: "yousef", Number: "12345678", Age: 28),
                new Customer(Id: 2, Name: "othman", Number: "12345678", Age: 25),
                new Customer(Id: 3, Name: "fawaz", Number: "12345678", Age: 22),
            ];
        public IActionResult Index()
        {
            return View(customers);
        }
        public IActionResult Details(int id)
        {
            var customer = customers.Single(c => c.Id == id);
            if (customer == null)
            {
                return View("index");
            }
            return View(customer);
        }
    }
}
