using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Magma.DomainModels;
using Magma.ServiceLayer;

namespace Magma.Web.Controllers
{
    public class UserController : Controller
    {
        User user = new User();
        UserDetail ud;
        [AllowAnonymous]
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        [Authorize(Roles = "User")]
        public ActionResult AuthorCreation()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public ActionResult AuthorCreation(string Mobile, string ImagePath)
        {
            if (user.IsMobilePresent(Mobile))
            {
                string err = "It seems you are already an author";
            }
            else
            {
                ud = new UserDetail();
                ud.User_Id = user.getAccountIdByEmail(User.Identity.Name);
                ud.User_Mobile = Mobile;
                ud.User_Avatar = ImagePath;
            }
            return View();
        }
    }
}