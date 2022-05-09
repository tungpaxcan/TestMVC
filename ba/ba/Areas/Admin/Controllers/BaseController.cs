using ba.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace ba.Areas.Admin.Controllers
{
    public class BaseController : Controller
    {
        // GET: Admin/Base
       protected override void OnActionExecuting(ActionExecutingContext fillterContext)
        {
            var session = (LoginUser)Session[CommonConstants.USER_SESSION];
            if (session == null)
            {
                fillterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(new { controller = "LoginAdmin", action = "Index", Area = "Admin" }));

            }
            base.OnActionExecuting(fillterContext);
        }
    }
}