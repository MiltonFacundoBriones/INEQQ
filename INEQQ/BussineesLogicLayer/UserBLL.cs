#region using directives
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#endregion

namespace BussineesLogicLayer
{
    public class UserBLL
    {
        public static string iniciarSesion(string us, string pwd)
        {
            bool isLogIn = DataAccessLayer.UserDAL.iniciarSesion(us, pwd);

            if (isLogIn)
            {
                return " ";
            }
            else
            {
                return "No se pudo iniciar sesion";
            }
        }
    }
}
