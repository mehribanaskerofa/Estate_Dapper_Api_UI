﻿using Microsoft.AspNetCore.Mvc;

namespace Estate_UI.Controllers
{
    public class ProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
