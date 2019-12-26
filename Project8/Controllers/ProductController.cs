using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project8.Models;

namespace Project8.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView",
                new Result()
                {
                    Controller = "ProductController",
                    Action = "Index"
                });
        }
        public IActionResult List()
        {
            return View("MyView",
                new Result()
                {
                    Controller = "ProductController",
                    Action = "List"
                });
        }
        public IActionResult Newest()
        {
            return View("MyView",
                new Result()
                {
                    Controller = "ProductController",
                    Action = "Newest"
                });
        }
        public IActionResult Details(int id)
        {
            var res = new Result()
            {
                 Action="Details",
                  Controller="Product",
                   
            };
            res.RouteData["id"] = RouteData.Values["id"];
            return View("MyView",res);
        }
    }
}