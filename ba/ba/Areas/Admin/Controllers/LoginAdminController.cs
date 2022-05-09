using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ba.Models;
using Models.Dao;
using ba.Common;
namespace ba.Areas.Admin.Controllers
{
    public class LoginAdminController : Controller
    {
        // GET: LoginAdmin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login(UserAdminModel useradmin)
        {
            if (ModelState.IsValid)
            {   
                var dao = new UserDao();
                var result = dao.Login(useradmin.UserName,Md5.MD5Hash(useradmin.PassWord));

                if (result == 1)
                {
                    var user = dao.GetName(useradmin.UserName);
                    var usersession = new LoginUser();
                    usersession.UserID = user.ID;
                    usersession.UserName = user.UserName;
                    Session.Add(CommonConstants.USER_SESSION, usersession);
                    return RedirectToAction("Index", "HomeAdmin");
                }
                else if (result == -2)
                {
                    ModelState.AddModelError("", "Mật khẩu không đúng");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản đã bị khóa");
                }else if(result == 0)
                {
                    ModelState.AddModelError("", "Tài khoản không tồn tại");
                }
                else ModelState.AddModelError("", "Tài khoản không tồn tại");
            }

            return View("Index");
        }
    }
}