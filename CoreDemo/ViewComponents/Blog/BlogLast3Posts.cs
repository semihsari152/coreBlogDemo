using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class BlogLast3Posts : ViewComponent
    {
        BlogManager wm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke()
        {   
            var values = wm.GetLast3Blog();
            return View(values);
        }
    }
}
