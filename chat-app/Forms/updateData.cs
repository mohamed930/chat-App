using chat_app.Classes;
using chat_app.Controller;
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
    public partial class updateData : Form
    {

        users u;

        // make constructor that take user data from pervious page.
        public updateData(users u)
        {
            InitializeComponent();

            this.u = u;
            this.Focus();

            FillComboBox();
            showUserData();
        }

        // this action method for back button.
        private void BackButton_Click(object sender, EventArgs e)
        {
            // call method that open chat page and sent to him old user data.
            Program.OpenSecondaryForm(new Chat(u), this);
        }

        // this method for fill comboBox with avaliable status "Avaliable" or "busy"
        void FillComboBox()
        {
            String[] status = {"","متاح","مشغول"};

            // Add the status to the comboBox.
            foreach (var x in status) {
                statusComboBox.Items.Add(x);
            }
        }

        // this method to load user data from user object to UI page
        void showUserData()
        {
            // add name to NameTextField
            userNameTextFielld.Text = u.getName();

            // check status is true
            if (u.getStatus())
            {
                // make comboBox to index "1" -> "متاح"
                statusComboBox.SelectedIndex = 1;
            }
            else
            {
                // make comboBox to index "2" -> "مشغول"
                statusComboBox.SelectedIndex = 2;
            }
        }

        // this action method for Edit button.
        private void EditButton_Click(object sender, EventArgs e)
        {
            // first convert the String "متاح" to the true
            bool status;
            if (statusComboBox.SelectedIndex == 1)
                status = true;
            else
                status = false;
            
            // Send the data to Controller.
            updateController update = new updateController(userNameTextFielld.Text,passwordTextField.Text,status);
            // call update method in controller and wait the response.
            bool response = update.updateData();

            // check if response is true dismiss the page and show new data.
            if (response)
            {
                users u = new users(1, userNameTextFielld.Text, status);
                Program.OpenSecondaryForm(new Chat(u),this);
            }
            // Sent to user error message.
            else
                MessageBox.Show("البيانات غير صحيحه من فضلك اعد تأكيد البيانات");
        }
    }
}
