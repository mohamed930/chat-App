using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            OpenForm(new Login());
        }

        public static void OpenForm(Form f)
        {
            Application.EnableVisualStyles();
            Application.Run(f);
        }

        public static void OpenSecondaryForm(Form f, Form ob)
        {
            ob.Hide();
            f.Closed += (s, args) => ob.Close();
            f.Show();
        }
    }
}
