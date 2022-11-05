using chat_app.Extensions;
namespace chat_app.Forms
{
    partial class Chat
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
            this.userNameLabel = new System.Windows.Forms.Label();
            this.statusView = new chat_app.Extensions.myPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(740, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "المحادثات";
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.userNameLabel.Location = new System.Drawing.Point(12, 14);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(68, 13);
            this.userNameLabel.TabIndex = 1;
            this.userNameLabel.Text = "اسم المستخدم";
            this.userNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.userNameLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // statusView
            // 
            this.statusView.BackColor = System.Drawing.Color.Lime;
            this.statusView.ForeColor = System.Drawing.Color.FloralWhite;
            this.statusView.Location = new System.Drawing.Point(86, 12);
            this.statusView.Name = "statusView";
            this.statusView.Size = new System.Drawing.Size(20, 20);
            this.statusView.TabIndex = 2;
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 472);
            this.Controls.Add(this.statusView);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.label1);
            this.Name = "Chat";
            this.Text = "l";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label userNameLabel;
        private myPanel statusView;
    }
}