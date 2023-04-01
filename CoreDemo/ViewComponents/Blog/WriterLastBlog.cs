using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.ViewComponents.Blog
{
    public class WriterLastBlog : ViewComponent
    {
        BlogManager wm = new BlogManager(new EfBlogRepository());
        public IViewComponentResult Invoke(int id)
        {
            id = 1;
            var values = wm.GetBlogListWithWriter(id);
            return View(values);
        }
    }
}
