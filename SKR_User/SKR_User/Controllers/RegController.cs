using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SKR_User.Controllers
{
    public class RegController : Controller
    {
        // GET: Reg
        public ActionResult register()
        {
            return base.View();
        }
    }
}