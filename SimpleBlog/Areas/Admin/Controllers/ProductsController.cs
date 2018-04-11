using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SimpleBlog.Areas.Admin.Controllers
{
    [Authorize(Roles = "Admin")]

public class ProductsController : Controller
    {
        
        public ActionResult Index()
        {
            return Content("Admin posts");
        }

        

        public ActionResult Update(int Id)
        {
            return Content("Products Controller Update Action Result with Id" + Id.ToString());
        }


    }
}