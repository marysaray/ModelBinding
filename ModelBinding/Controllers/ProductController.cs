using Microsoft.AspNetCore.Mvc;
using ModelBinding.Models;

namespace ModelBinding.Controllers
{
    public class ProductController : Controller
    {
        // GET: /Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Create a new product";
            return View();
        }

        // POST: Send data to server after user submit form.
        [HttpPost]
        public IActionResult Create(IFormCollection formData) 
        {
            // Validate all data
            
            // Grab all the data from the IFormCollection and put in the product object
            Product p = new()
            {
                Title = formData["title"],
                Price = Convert.ToDouble(formData["price"]),
                Qty = Convert.ToInt32(formData["qty"])
            };
  

            // Add to database
            // ProductDb.Add(p);

            // Return data back to home page
            return RedirectToAction("Index", "Home");
        }

        // ModelBinding
        [HttpGet]
        public IActionResult CreateWithModelBinding()
        {
            ViewData["Title"] = "Create a new product";
            return View();
        }

        [HttpPost]
        public IActionResult CreateWithModelBinding(Product p)
        {
            if (ModelState.IsValid)
            {
                // Add to database here

                return RedirectToAction("Index", "Home"); // Send back to home page
            }
            // If the ModelState is not valid
            // show the user the same web page, with validation
            // errors
            return View(p); // pass in p for product model
        }
    }
}
