using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models.EF;

namespace Models.Dao
{
    public class UserDao
    {
        TestDbContext db = new TestDbContext();

        public long Insert(User entity)
        {
            db.Users.Add(entity);
            db.SaveChanges();
            return entity.ID;
        }
        public User GetName(string username)
        {
            return db.Users.SingleOrDefault(x => x.UserName == username);
        }
        public int Login(String username,String password)
        {
            var result = db.Users.SingleOrDefault(x => x.UserName == username);
            if (result == null)
            {
                return 0;
            }
            else if (result.Status == false)
            {
                return -1;
            }
            else if (result.PassWord == password )
            {
                return 1;
            }
            else return -2;
            
                
        }
    }
}
