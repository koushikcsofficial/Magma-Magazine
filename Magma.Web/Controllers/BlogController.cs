using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Magma.Web.Controllers
{
    [Authorize(Roles ="Author, Admin")]
    public class BlogController : Controller
    {
        [HttpGet]
        public ActionResult AddSimpleBlog()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddPhotographyBlog()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddAudioBlog()
        {
            return View();
        }

        [HttpGet]
        public ActionResult AddVideoBlog()
        {
            return View();
        }
    }
}