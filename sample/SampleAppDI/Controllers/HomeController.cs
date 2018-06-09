﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SampleAppDI.Models;

namespace SampleAppDI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MyTestClass _test;

        public HomeController(ILogger<HomeController> logger, MyTestClass test)
        {
            _logger = logger;
            _test = test;
        }

        public IActionResult Index()
        {
            _logger.LogInformation("Method: HomeController.Index() called.");
            _logger.LogInformation(@"MyTestInstance.Foo() = {0}", _test.Foo());
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
