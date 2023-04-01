using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDemo.Controllers
{
    public class CommentController : Controller
    {
        CommentManager cm = new CommentManager(new EfCommentRepository());
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public PartialViewResult CommentAdd()
        {
            return PartialView();
        }
        [HttpPost]
        public PartialViewResult CommentAdd(Comment p)
        {
            p.CommentDate = DateTime.Now;
            p.CommentStatus = true;
            p.BlogID = 5;
            cm.TAdd(p);
            return PartialView();
        }

        public PartialViewResult Comments(int id)
        {
            var values = cm.GetList(id);
            return PartialView();
        }
    }
}
