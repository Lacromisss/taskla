﻿using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Services()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
