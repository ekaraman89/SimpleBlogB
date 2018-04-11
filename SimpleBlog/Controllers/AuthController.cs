using SimpleBlog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace SimpleBlog.Controllers
{
    public class AuthController : Controller
    {

        public ActionResult login()
        {
            return View(new AuthLogin() { Test = "DENEME" + DateTime.Now.ToString() });
        }

        [HttpPost]
        public ActionResult login(AuthLogin form, string ReturnUrl)

        {
            if (!ModelState.IsValid)
            {
                return View(form);
            }

            FormsAuthentication.SetAuthCookie(form.Username, true);
            if (!string.IsNullOrWhiteSpace(ReturnUrl))
                return Redirect(ReturnUrl);

            return RedirectToRoute("Home");
            //return Content("Our form data : " + form.Username + "-" + form.Password);
        }

        public ActionResult listusers()
        {
            return View(
                new AuthListUser()
                {
                    Users = new List<AuthLogin>() {
                        new AuthLogin() {Username="Cem",Password="123"},
                        new AuthLogin() {Username="a",Password="123a"},
                        new AuthLogin() {Username="b",Password="123b"},
                        new AuthLogin() {Username="c",Password="123c"},
                        new AuthLogin() {Username="d",Password="123d"},

                    }
                });
        }
    }
}