﻿namespace Software_de_taquilla.Views
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
            txt_user = new TextBox();
            txt_pass = new TextBox();
            btn_login = new Button();
            SuspendLayout();
            // 
            // txt_user
            // 
            txt_user.Location = new Point(61, 56);
            txt_user.Multiline = true;
            txt_user.Name = "txt_user";
            txt_user.Size = new Size(229, 33);
            txt_user.TabIndex = 0;
            // 
            // txt_pass
            // 
            txt_pass.Location = new Point(61, 124);
            txt_pass.Multiline = true;
            txt_pass.Name = "txt_pass";
            txt_pass.Size = new Size(229, 33);
            txt_pass.TabIndex = 1;
            // 
            // btn_login
            // 
            btn_login.BackColor = Color.DarkSlateGray;
            btn_login.FlatAppearance.BorderSize = 0;
            btn_login.FlatStyle = FlatStyle.Flat;
            btn_login.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            btn_login.ForeColor = Color.White;
            btn_login.Location = new Point(61, 195);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(231, 25);
            btn_login.TabIndex = 2;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = false;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(341, 337);
            Controls.Add(btn_login);
            Controls.Add(txt_pass);
            Controls.Add(txt_user);
            Name = "Login";
            Text = "Login";
            Load += Login_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_user;
        private TextBox txt_pass;
        private Button btn_login;
    }
}