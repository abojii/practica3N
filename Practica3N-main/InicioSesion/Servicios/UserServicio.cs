using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InicioSesion.Servicios
{
   internal class UserServicio
   {
      public bool ValidateUser(string user, string password)
      {
         return user == "admin" && password == "1234";
      }
   }
}
