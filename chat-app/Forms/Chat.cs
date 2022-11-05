using chat_app.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app.Forms
{
    public partial class Chat : Form
    {
        users u;

        public Chat()
        {
            InitializeComponent();
        }

        public Chat(users u)
        {
            InitializeComponent();
            this.u = u;

            ShowUserData();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Program.OpenSecondaryForm(new updateData(u), this);
        }

        void ShowUserData()
        {
            userNameLabel.Text = u.getName();

            if (u.getStatus())
            {
                statusView.BackColor = Color.Green;
            }
            else
            {
                statusView.BackColor = Color.Red;
            }
        }
    }
}
