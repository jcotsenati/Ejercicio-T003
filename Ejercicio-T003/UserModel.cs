using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_T003
{
    internal class UserModel
    {

        public bool LoginUser(string user, string pass) {

            if (user == "jorge" && pass == "jorge")
            {
                UserCache.Email = "jorge@gmail.com";
                UserCache.Position = "JEFE";
                UserCache.FirstName = "jorge";
                UserCache.LastName = "cotrado";
                UserCache.LoginName = "jcotrado";

                return true;
            }
            else {

                return false;
            }

            
        }
    }
}
