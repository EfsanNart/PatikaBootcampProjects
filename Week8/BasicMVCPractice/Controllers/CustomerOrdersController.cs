using BasicMVCPractice.Models;
using Microsoft.AspNetCore.Mvc;

namespace BasicMVCPractice.Controllers
{
    public class CustomerOrdersController : Controller
    {
        public IActionResult Index()
        {
            var customerOne = new Customer
            {
                Id = 1,
                FirstName = "Severus",
                LastName = "Snape",
                Email = "severuSnape@example.com"
            };

            var customerOneOrders = new List<Order>
            {
                new Order { Id = 1, ProductName = "Bag", Price = 20.00m, Quantity = 3 },
                new Order { Id = 2, ProductName = "Car", Price = 205.99m, Quantity = 2 },
                new Order { Id = 3, ProductName = "Scooter", Price = 75.50m, Quantity = 5 }
            };

            var viewModel = new CustomerOrderViewModel
            {
                Customer = customerOne,
                Orders = customerOneOrders
            };

            return View(viewModel);
        }

    }
}
