﻿using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class BlogController : Controller
    {
        BlogManager bm = new BlogManager(new EfBlogRepository());
        public IActionResult Index()
        {
            var values = bm.GetBlogListWithCategory();
            return View(values);
        }

        public IActionResult BlogDetails(int id)
        {
            ViewBag.id = id;
            var values = bm.GetBlogById(id);
            return View(values);
        }

        [AllowAnonymous]
        public IActionResult BlogListByWriter()
        {
            var values = bm.GetBlogListWithWriter(1);
            return View(values);
        }
    }
}
