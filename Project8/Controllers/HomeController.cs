using Microsoft.AspNetCore.Mvc;
using Project8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project8.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            return View("MyView",
                new Result()
                {
                Controller="HomeController", Action="Index"
                });
        }
    }
}
