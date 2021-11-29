using Gerador_CSS.Class;
using Gerador_CSS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using System.Web.WebPages.Html;

namespace Gerador_CSS.Controllers
{
    public class AccountController : Controller
    {
        // GET: Account
        public ActionResult Acesso()
        {
            User user = new User();

            return View(user);
        }

        [HttpPost]
        public ActionResult Acesso(User user)
        {
            if(!string.IsNullOrEmpty(user.Email) && !string.IsNullOrEmpty(user.Password))
            {

                bool HaveAccess = Account.VerifyAccess(user);

                if (HaveAccess)
                {
                    FormsAuthentication.SetAuthCookie(user.Email, false);

                    Util.Log("LOGIN REALIZADO");

                    return RedirectToAction("Index", "Home");
                }

                Util.Log("TENTATIVA DE LOGIN");

            }

            return View(user);

        }

        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            Util.Log("LOGOUT");
            return RedirectToAction("Index", "Home");
        }
    }
}