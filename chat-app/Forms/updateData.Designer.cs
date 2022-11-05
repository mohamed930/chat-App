namespace chat_app.Forms
{
    partial class updateData
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
            this.userNameTextFielld = new System.Windows.Forms.TextBox();
            this.passwordTextField = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.EditButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "تعديل بيانات المستخدم";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label2.Location = new System.Drawing.Point(175, 102);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "اسم المستخدم";
            // 
            // userNameTextFielld
            // 
            this.userNameTextFielld.Location = new System.Drawing.Point(28, 129);
            this.userNameTextFielld.Name = "userNameTextFielld";
            this.userNameTextFielld.Size = new System.Drawing.Size(211, 20);
            this.userNameTextFielld.TabIndex = 2;
            // 
            // passwordTextField
            // 
            this.passwordTextField.Location = new System.Drawing.Point(28, 191);
            this.passwordTextField.Name = "passwordTextField";
            this.passwordTextField.PasswordChar = '*';
            this.passwordTextField.Size = new System.Drawing.Size(211, 20);
            this.passwordTextField.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label3.Location = new System.Drawing.Point(175, 164);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "كلمة المرور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.label4.Location = new System.Drawing.Point(200, 229);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "الحالة";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(28, 255);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(211, 21);
            this.statusComboBox.TabIndex = 6;
            // 
            // EditButton
            // 
            this.EditButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditButton.Location = new System.Drawing.Point(86, 301);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(113, 34);
            this.EditButton.TabIndex = 7;
            this.EditButton.Text = "تعديل";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.White;
            this.BackButton.Image = global::chat_app.Properties.Resources.backbutton;
            this.BackButton.Location = new System.Drawing.Point(12, 12);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(40, 39);
            this.BackButton.TabIndex = 8;
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // updateData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 347);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.passwordTextField);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userNameTextFielld);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "updateData";
            this.Text = "updateData";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userNameTextFielld;
        private System.Windows.Forms.TextBox passwordTextField;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button BackButton;
    }
}