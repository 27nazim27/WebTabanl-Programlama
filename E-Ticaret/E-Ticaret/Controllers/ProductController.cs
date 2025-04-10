﻿using E_Ticaret.Models;
using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    public class ProductController : Controller
    {
        private static List<Product> products = new();
        public IActionResult Index()
        {
            return View(products);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Product p)
        {
            products.Add(p);
            return View("Index",products);
        }
    }
}
