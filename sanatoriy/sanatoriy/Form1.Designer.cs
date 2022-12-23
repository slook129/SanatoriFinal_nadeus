using System.Runtime.CompilerServices;

namespace sanatoriy
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.authorizationText = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.loginLabel = new System.Windows.Forms.Label();
            this.login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // authorizationText
            // 
            this.authorizationText.BackColor = System.Drawing.Color.Bisque;
            this.authorizationText.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.authorizationText.ForeColor = System.Drawing.Color.Black;
            this.authorizationText.Location = new System.Drawing.Point(0, 0);
            this.authorizationText.Name = "authorizationText";
            this.authorizationText.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.authorizationText.Size = new System.Drawing.Size(510, 82);
            this.authorizationText.TabIndex = 0;
            this.authorizationText.Text = "Авторизация";
            this.authorizationText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.Bisque;
            this.closeButton.Font = new System.Drawing.Font("Segoe UI Black", 26.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.closeButton.ForeColor = System.Drawing.Color.Brown;
            this.closeButton.Location = new System.Drawing.Point(435, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 57);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginLabel.Location = new System.Drawing.Point(12, 139);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(101, 37);
            this.loginLabel.TabIndex = 2;
            this.loginLabel.Text = "Логин";
            // 
            // login
            // 
            this.login.BackColor = System.Drawing.Color.Bisque;
            this.login.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.login.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login.Location = new System.Drawing.Point(119, 132);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(359, 44);
            this.login.TabIndex = 3;
            this.login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.login.TextChanged += new System.EventHandler(this.login_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 450);
            this.Controls.Add(this.login);
            this.Controls.Add(this.loginLabel);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.authorizationText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label authorizationText;
        private Button closeButton;
        private Label loginLabel;
        private TextBox login;
    }
}