﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace CoreDemo.Controllers
{
    public class CategoryController : Controller
    {

        CategoryManager cm= new CategoryManager(new EfCategoryRepo());
        public IActionResult Index()
        {
            var values = cm.GetList();
            return View(values);
        }
    }
}
