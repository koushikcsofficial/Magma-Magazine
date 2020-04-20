using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Magma.DomainModels;
using Magma.ServiceLayer;

namespace Magma.Web.Controllers
{
    public class AuthorController : Controller
    {
        Author author = new Author();
        User user = new User();
        // GET: Author
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return View("BadRequest");
            }
            else
            {
                if (author.IsAuthorById(id))
                {
                    if (User.Identity.IsAuthenticated && id==user.getAccountIdByEmail(User.Identity.Name))
                    {
                        return RedirectToAction("AuthorIndex");
                    }
                    else
                    {
                        if(User.Identity.IsAuthenticated && author.IsSubscribed(id, user.getAccountIdByEmail(User.Identity.Name)))
                        {
                            ViewData["SubscriptionStatus"] = "Subscribed";
                            return View("PublicView");
                        }
                        else
                        {
                            ViewData["SubscriptionStatus"] = "Not Subscribed";
                            return View("PublicView");
                        }
                    }
                }
                else
                {
                    return View("BadRequest");
                }
            }
        }

        [Authorize(Roles ="Author")]
        [HttpGet]
        public ActionResult AuthorIndex()
        {
            return View("UserView");
        }
    }
}