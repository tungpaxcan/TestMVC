using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ba.Models
{
    public class UserAdminModel
    {
        [Required(ErrorMessage ="Mời bạn nhập tài khoản!")]
        public string UserName { set; get; }
        [Required(ErrorMessage ="Mời bạn nhập mật khẩu!")]
        public string PassWord { set; get; }
    }
}