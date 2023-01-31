namespace Project_24_01_2023
{
    partial class Password
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
            this.TBLoginsAndPasswords = new System.Windows.Forms.TextBox();
            this.LAddPassword = new System.Windows.Forms.Label();
            this.TBPassword = new System.Windows.Forms.TextBox();
            this.TBLogin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BAddNewPassword = new System.Windows.Forms.Button();
            this.TBShowPassword = new System.Windows.Forms.Button();
            this.TBHidePassword = new System.Windows.Forms.Button();
            this.BLogOut = new System.Windows.Forms.Button();
            this.CBPassword = new System.Windows.Forms.ComboBox();
            this.BDeletePassword = new System.Windows.Forms.Button();
            this.BModyficatePassword = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ModeinPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlackModeinPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LightModeinPasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // TBLoginsAndPasswords
            // 
            this.TBLoginsAndPasswords.Location = new System.Drawing.Point(503, 24);
            this.TBLoginsAndPasswords.Multiline = true;
            this.TBLoginsAndPasswords.Name = "TBLoginsAndPasswords";
            this.TBLoginsAndPasswords.Size = new System.Drawing.Size(285, 414);
            this.TBLoginsAndPasswords.TabIndex = 0;
            // 
            // LAddPassword
            // 
            this.LAddPassword.AutoSize = true;
            this.LAddPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LAddPassword.Location = new System.Drawing.Point(12, 24);
            this.LAddPassword.Name = "LAddPassword";
            this.LAddPassword.Size = new System.Drawing.Size(129, 25);
            this.LAddPassword.TabIndex = 1;
            this.LAddPassword.Text = "Dodaj Hasło";
            // 
            // TBPassword
            // 
            this.TBPassword.Location = new System.Drawing.Point(67, 69);
            this.TBPassword.Name = "TBPassword";
            this.TBPassword.Size = new System.Drawing.Size(100, 20);
            this.TBPassword.TabIndex = 2;
            // 
            // TBLogin
            // 
            this.TBLogin.Location = new System.Drawing.Point(67, 52);
            this.TBLogin.Name = "TBLogin";
            this.TBLogin.Size = new System.Drawing.Size(100, 20);
            this.TBLogin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(13, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(13, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Haslo";
            // 
            // BAddNewPassword
            // 
            this.BAddNewPassword.Location = new System.Drawing.Point(17, 92);
            this.BAddNewPassword.Name = "BAddNewPassword";
            this.BAddNewPassword.Size = new System.Drawing.Size(150, 23);
            this.BAddNewPassword.TabIndex = 6;
            this.BAddNewPassword.Text = "Dodaj";
            this.BAddNewPassword.UseVisualStyleBackColor = true;
            // 
            // TBShowPassword
            // 
            this.TBShowPassword.Location = new System.Drawing.Point(360, 24);
            this.TBShowPassword.Name = "TBShowPassword";
            this.TBShowPassword.Size = new System.Drawing.Size(137, 23);
            this.TBShowPassword.TabIndex = 7;
            this.TBShowPassword.Text = "Wyświetl Hasła";
            this.TBShowPassword.UseVisualStyleBackColor = true;
            // 
            // TBHidePassword
            // 
            this.TBHidePassword.Location = new System.Drawing.Point(360, 49);
            this.TBHidePassword.Name = "TBHidePassword";
            this.TBHidePassword.Size = new System.Drawing.Size(137, 23);
            this.TBHidePassword.TabIndex = 8;
            this.TBHidePassword.Text = "Ukryj Hasła";
            this.TBHidePassword.UseVisualStyleBackColor = true;
            // 
            // BLogOut
            // 
            this.BLogOut.Location = new System.Drawing.Point(17, 405);
            this.BLogOut.Name = "BLogOut";
            this.BLogOut.Size = new System.Drawing.Size(124, 33);
            this.BLogOut.TabIndex = 9;
            this.BLogOut.Text = "Wylogój";
            this.BLogOut.UseVisualStyleBackColor = true;
            // 
            // CBPassword
            // 
            this.CBPassword.FormattingEnabled = true;
            this.CBPassword.Location = new System.Drawing.Point(17, 121);
            this.CBPassword.Name = "CBPassword";
            this.CBPassword.Size = new System.Drawing.Size(150, 21);
            this.CBPassword.TabIndex = 10;
            // 
            // BDeletePassword
            // 
            this.BDeletePassword.Location = new System.Drawing.Point(17, 148);
            this.BDeletePassword.Name = "BDeletePassword";
            this.BDeletePassword.Size = new System.Drawing.Size(150, 23);
            this.BDeletePassword.TabIndex = 11;
            this.BDeletePassword.Text = "Usuń";
            this.BDeletePassword.UseVisualStyleBackColor = true;
            // 
            // BModyficatePassword
            // 
            this.BModyficatePassword.Location = new System.Drawing.Point(17, 168);
            this.BModyficatePassword.Name = "BModyficatePassword";
            this.BModyficatePassword.Size = new System.Drawing.Size(150, 23);
            this.BModyficatePassword.TabIndex = 12;
            this.BModyficatePassword.Text = "Modyfikuj";
            this.BModyficatePassword.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ModeinPasswordToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 13;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ModeinPasswordToolStripMenuItem
            // 
            this.ModeinPasswordToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BlackModeinPasswordToolStripMenuItem,
            this.LightModeinPasswordToolStripMenuItem});
            this.ModeinPasswordToolStripMenuItem.Name = "ModeinPasswordToolStripMenuItem";
            this.ModeinPasswordToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.ModeinPasswordToolStripMenuItem.Text = "Tryb";
            // 
            // BlackModeinPasswordToolStripMenuItem
            // 
            this.BlackModeinPasswordToolStripMenuItem.Name = "BlackModeinPasswordToolStripMenuItem";
            this.BlackModeinPasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.BlackModeinPasswordToolStripMenuItem.Text = "Ciemny";
            // 
            // LightModeinPasswordToolStripMenuItem
            // 
            this.LightModeinPasswordToolStripMenuItem.Name = "LightModeinPasswordToolStripMenuItem";
            this.LightModeinPasswordToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LightModeinPasswordToolStripMenuItem.Text = "Jasny";
            // 
            // Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BModyficatePassword);
            this.Controls.Add(this.BDeletePassword);
            this.Controls.Add(this.CBPassword);
            this.Controls.Add(this.BLogOut);
            this.Controls.Add(this.TBHidePassword);
            this.Controls.Add(this.TBShowPassword);
            this.Controls.Add(this.BAddNewPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBLogin);
            this.Controls.Add(this.TBPassword);
            this.Controls.Add(this.LAddPassword);
            this.Controls.Add(this.TBLoginsAndPasswords);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Password";
            this.Text = "Password";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TBLoginsAndPasswords;
        private System.Windows.Forms.Label LAddPassword;
        private System.Windows.Forms.TextBox TBPassword;
        private System.Windows.Forms.TextBox TBLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BAddNewPassword;
        private System.Windows.Forms.Button TBShowPassword;
        private System.Windows.Forms.Button TBHidePassword;
        private System.Windows.Forms.Button BLogOut;
        private System.Windows.Forms.ComboBox CBPassword;
        private System.Windows.Forms.Button BDeletePassword;
        private System.Windows.Forms.Button BModyficatePassword;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ModeinPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlackModeinPasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LightModeinPasswordToolStripMenuItem;
    }
}