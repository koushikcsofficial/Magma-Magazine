using Magma.DomainModels;
using Magma.ServiceLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace Magma.Web.Controllers
{
    public class AuthController : Controller
    {
        User user = new User();
        UserLog ul;
        UserAccount ua;
        UserDetail ud;
        UserRoleMaster urm;
        // GET: Auth
        [AllowAnonymous]
        [HttpGet]
        public ActionResult Login()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Login(string loginemail, string loginpass)
        {
            try
            {
                if ((loginemail == null && loginpass == null) || (loginemail == null || loginpass == null))
                {
                    ModelState.AddModelError("", "Username or password can't be left empty");
                    return View();

                }
                else
                {
                    if (await user.IsLoginValidAsync(loginemail, loginpass))
                    {
                        FormsAuthentication.SetAuthCookie(loginemail, false);
                        ul = new UserLog();
                        ul.User_Id = await user.getAccountIdByEmailAsync(loginemail);
                        try
                        {
                            //trying to get the client Ip
                            ul.User_LoginFrom = GetIp();
                        }
                        catch (Exception)
                        {
                            ul.User_LoginFrom = "N/A";
                        }
                        ul.User_LoginTime = user.currentTimeIST();
                        user.registerUserLog(ul);
                        Session["LogId"] = user.getUserLogId(ul.User_LoginFrom);
                        return RedirectToAction("Index", "User");
                    }
                    else
                    {
                        ModelState.AddModelError("", "invalid Username or Password");
                        return View();
                    }
                }
                
            }
            catch (Exception)
            {
                return View();
            }
        }

        [AllowAnonymous]
        [HttpGet]
        public ActionResult Register()
        {
            return View();
        }

        [AllowAnonymous]
        [HttpPost]
        public ActionResult Register(string signupfname, string signuplname, int signupage, string signupgender, string signupemail, string signuppass, string signupconpass)
        {
                //checking for null entries
           if (signupemail != null && signupfname != null && signuplname != null && signupage > 0 && signupgender != null && signuppass != null && signupconpass != null)
           {
                    //cheching if the password and confirm password is same
                    if (signuppass == signupconpass)
                    {
                        ua = new UserAccount();
                        ud = new UserDetail();
                        if (user.IsEmailExists(signupemail))
                        {
                            ModelState.AddModelError("", "Email Already Exists in User Auth");
                            return View();
                        }
                        else
                        {
                            //Add new User to UserAccount table in the database
                            ua.User_Email = signupemail;
                            ua.User_Password = signuppass;
                            //Email verification will be set to 0 until user doesn't click on the verification link after registration.
                            //Once verified this field will be set to 1 and the row for the database will be updated.
                            ua.User_IsEmailVerified = 1;
                            ua.User_AccountCreatedAt = user.currentTimeIST();
                            //by default after creating the account user account will be active
                            ua.User_IsActive = 1;
                            try
                            {
                                //trying to get the client Ip
                                ua.User_AccountCreatedFrom = GetIp();
                            }
                            catch (Exception)
                            {
                                ua.User_AccountCreatedFrom = "N/A";
                            }
                            user.insertUserAccount(ua);

                            //Get the userId from the row to update UserRoleMaster table with the role "User"
                            urm = new UserRoleMaster();
                            urm.User_Id = user.getAccountIdByEmail(signupemail);
                            urm.Role_Id = user.getRoleIdByName("User");
                            user.insertUserRole(urm);

                            //Add record to UserDetails table
                            ud = new UserDetail();
                            ud.User_Id = user.getAccountIdByEmail(signupemail);
                            ud.User_FirstName = signupfname;
                            ud.User_LastName = signuplname;
                            ud.User_Gender = signupgender;
                            ud.User_Age = signupage;
                            user.insertUserDetails(ud);
                            return RedirectToAction("Login");
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Password and Confirm password didn't match");
                        return View();
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Fields can't be left empty");
                    return View();
                }
        }

        [HttpGet]
        public ActionResult Logout()
        {
            ul = new UserLog();
            ul.Id = Convert.ToInt32(Session["LogId"]);
            ul.User_LogoutTime = user.currentTimeIST();
            user.finishUserLog(ul);
            FormsAuthentication.SignOut();
            return RedirectToAction("Login");
        }

        //retriving function for the IP address of the client machine.
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