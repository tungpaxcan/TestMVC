using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Models.EF;
using Models.Dao;
using System.Runtime.InteropServices;

namespace ba.Common
{[Serializable]
    public class LoginUser
    {
        
        public long UserID { set; get; }
        public string UserName{set;  get;
        }
    }
}