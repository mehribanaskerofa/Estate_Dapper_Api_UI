﻿using Microsoft.AspNetCore.Mvc;

namespace Estate_Api.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
