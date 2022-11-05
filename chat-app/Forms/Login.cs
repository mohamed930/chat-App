using chat_app.Classes;
using chat_app.Controller;
using chat_app.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chat_app
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        // MARK: TODO: This Method for action login button.
        void loginButton_Click(object sender, EventArgs e)
        {
            loginMethod();
        }

        // MARK: TODO: This Method for action foucus password textfield when enter enter.
        void userNameTextField_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Enter)
            {
                this.passwordTextField.Focus();
            }
        }

        // MARK: TODO: This Method for action when enter "enter button" in password make login operation.
        void passwordTextField_KeyDown(object sender, KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Enter)
            {
                // login meethod
                loginMethod();
            }
        }

        // MARK: TODO: This method that make login operation.
        void loginMethod()
        {
            // validate the username not empty.
            if (userNameTextField.Text == "")
            {
                MessageBox.Show("خطأ فى ادخال اسم المستخدم");
            }
            else
            {
                // validate the password not empty.
                if (passwordTextField.Text == "")
                {
                    MessageBox.Show("خطأ فى ادخال كلمة المرور");
                }
                else {
                    // First make object from login controller and send to it the username and password.
                    loginController login = new loginController(userNameTextField.Text, passwordTextField.Text);

                    // call method login operation.
                    bool response = login.loginOperation();

                    // receive the response from the server.
                    if (response)
                    {
                        // Add Data to user Model.
                        users user = new users(1,userNameTextField.Text,true);
                        // Move To Next Page.
                        Program.OpenSecondaryForm(new Chat(user), this);
                       

                    }
                    else
                    {
                        // Show Error user when login failed and clear password textfield and set foucus on it.
                        MessageBox.Show("كلمة المرور او اسم المستخدم غير صحيحه");
                        passwordTextField.Text = "";
                        passwordTextField.Focus();
                    }
                }
            }
        }
    }
}
