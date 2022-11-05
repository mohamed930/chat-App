namespace chat_app
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userNameTextField = new System.Windows.Forms.TextBox();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(205, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "تسجيل الدخول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(510, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم الستخدم";
            // 
            // userNameTextField
            // 
            this.userNameTextField.Location = new System.Drawing.Point(48, 111);
            this.userNameTextField.Name = "userNameTextField";
            this.userNameTextField.Size = new System.Drawing.Size(456, 20);
            this.userNameTextField.TabIndex = 2;
            this.userNameTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.userNameTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.userNameTextField_KeyDown);
            // 
            // passwordTextField
            // 
            this.passwordTextField.Location = new System.Drawing.Point(48, 156);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.Size = new System.Drawing.Size(456, 20);
            this.passwordTextField.TabIndex = 4;
            this.passwordTextField.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.passwordTextField.UseSystemPasswordChar = true;
            this.passwordTextField.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordTextField_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(510, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور";
            // 
            // loginButton
            // 
            this.loginButton.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(223, 196);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(202, 43);
            this.loginButton.TabIndex = 5;
            this.loginButton.Text = "تسجيل الدخول ";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 262);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextField;
        private System.Windows.Forms.TextBox passwordTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button loginButton;
    }
}

