#region using directives
using BussinessEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion
namespace DataAccessLayer
{
    public class UserDAL
    {
        private static IneqContext db = new IneqContext();
        public static bool iniciarSesion(String us, string pwd)
        {
            //SELECT COUNT(=) FROM User WHERE Username = 'us' AND Password = 'pwd'
            return db.Users.Where(u => u.Username == us && u.Password == pwd).Count() > 0; //--> LINQ LAMBDA
        }
    }
}
