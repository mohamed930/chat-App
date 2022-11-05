using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Controller
{
    class loginController
    {
         String userName;
         String password;

         enum login_data
         {
             mohamed,
             password
         }

         public loginController(String userName, String password)
         {
             this.userName = userName;
             this.password = password;
         }


         public bool loginOperation()
         {
             if (userName == Convert.ToString(login_data.mohamed) && password == Convert.ToString(login_data.password))
             {
                 return true;
             }
             else
             {
                 return false;
             }
         }
    }
}
