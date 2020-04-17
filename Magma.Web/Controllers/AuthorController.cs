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
        // GET: Author
        [AllowAnonymous]
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
                    if (User.Identity.IsAuthenticated && User.IsInRole("Author"))
                    {
                        return View("AuthorUserView");
                    }
                    else
                    {
                        return View("AuthorPublicView");
                    }
                }
                else
                {
                    return View("BadRequest");
                }
            }
        }


    }
}