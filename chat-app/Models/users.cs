using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat_app.Classes
{
    public class users
    {
        private int id { get; set; }
        private String name { get; set; }
        private bool status { get; set; }


        public users(int id, String name, bool status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }

        // Set Getter to my properity.
        public String getName()
        {
            return name;
        }

        public bool getStatus()
        {
            return status;
        }
    }
}
