﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Project8.Models;

namespace Project8.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View("MyView",
                new Result()
                {
                    Controller = "CustomerController",
                    Action = "Index"
                });
        }
        public IActionResult List()
        {
            return View("MyView",
                new Result()
                {
                    Controller = "CustomerController",
                    Action = "List"
                });
        }
    }
}