using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Controller
{
    class updateController
    {
        String userName;
        String password;
        bool status;

        public updateController(String userName, String password, bool status)
        {
            this.userName = userName;
            this.password = password;
            this.status = status;
        }

        // MARK: TODO: this method for update user data.
        public bool updateData()
        {
            // check if we re
            if (userName == "" || password == "")
            {
                return false;
            }
            else
            {
                // MARK:- TODO:- We write here code that update data in database.


                return true;
            }
            
        }

    }
}
