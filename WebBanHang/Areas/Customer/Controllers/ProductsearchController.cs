using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhoneStore.Areas.Customer.Controllers
    {[Area("Customer")]
    public class ProductsearchController : Controller
    {
        public IActionResult ProductSearch(string searchTerm)
        {
            ViewBag.SearchTerm = searchTerm;
            return View();
        }

    }
}
