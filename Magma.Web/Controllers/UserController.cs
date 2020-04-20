using System;
using System.Collections.Generic;
using System.IO;
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
        Content content;
        UserRoleMaster urm;
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
        [ValidateAntiForgeryToken]
        public ActionResult AuthorCreation(string Mobile, HttpPostedFileBase postedFile)
        {
            if (user.IsMobilePresent(Mobile))
            {
                string err = "It seems you are already an author";
                Console.WriteLine(err);
            }
            else
            {

                string Email = User.Identity.Name;
                content = new Content();
                byte[] bytes;
                using (BinaryReader br = new BinaryReader(postedFile.InputStream))
                {
                    bytes = br.ReadBytes(postedFile.ContentLength);
                }
                content.File_Name = user.currentTimeIST().ToString() + Path.GetFileName(postedFile.FileName);
                content.Content_Type = postedFile.ContentType;
                content.Data = bytes;
                content.Content_IsActive = 1;
                content.Uploaded_At = user.currentTimeIST();
                content.User_Uploaded = user.getAccountIdByEmail(Email);
                string ip = "";
                try
                {
                    ip = GetIp();
                }
                catch(Exception)
                {
                    ip = "N/A";
                }
                content.Uploaded_From = ip;
                user.insertContent(content);

                ud = new UserDetail();
                ud.User_Id = user.getAccountIdByEmail(Email);
                ud.User_Mobile = Mobile;
                ud.User_AvatarId = user.getUserAvatarId(user.getAccountIdByEmail(Email),ip);
                user.updateUserToAuthor(ud);

                urm = new UserRoleMaster();
                urm.User_Id = user.getAccountIdByEmail(Email);
                urm.Role_Id = user.getRoleIdByName("Author");
                user.insertUserRoleMaster(urm);

                return RedirectToAction("AuthorIndex", "Author");
            }
            return View();
        }

        private string GetIp()
        {
            string ip = System.Web.HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"];
            if (string.IsNullOrEmpty(ip))
            {
                ip = System.Web.HttpContext.Current.Request.ServerVariables["REMOTE_ADDR"];
            }
            return ip;
        }
    }
}