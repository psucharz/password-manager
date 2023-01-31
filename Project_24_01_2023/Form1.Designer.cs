namespace Project_24_01_2023
{
    partial class Form1
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
            this.BAddUser = new System.Windows.Forms.Button();
            this.LMakeUser = new System.Windows.Forms.Label();
            this.TBName = new System.Windows.Forms.TextBox();
            this.LName = new System.Windows.Forms.Label();
            this.LSurname = new System.Windows.Forms.Label();
            this.TBSurname = new System.Windows.Forms.TextBox();
            this.LMakeLogin = new System.Windows.Forms.Label();
            this.TBMakeLogin = new System.Windows.Forms.TextBox();
            this.LMakePassword = new System.Windows.Forms.Label();
            this.TBMakePassword = new System.Windows.Forms.TextBox();
            this.LListUser = new System.Windows.Forms.Label();
            this.CBListUser = new System.Windows.Forms.ComboBox();
            this.LLogin = new System.Windows.Forms.Label();
            this.TBUseLogin = new System.Windows.Forms.TextBox();
            this.LUseLogin = new System.Windows.Forms.Label();
            this.LUsePassword = new System.Windows.Forms.Label();
            this.TBUsePassword = new System.Windows.Forms.TextBox();
            this.BLogIn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BAddUser
            // 
            this.BAddUser.Location = new System.Drawing.Point(17, 121);
            this.BAddUser.Name = "BAddUser";
            this.BAddUser.Size = new System.Drawing.Size(173, 23);
            this.BAddUser.TabIndex = 0;
            this.BAddUser.Text = "Dodaj Uzytkownika";
            this.BAddUser.UseVisualStyleBackColor = true;
            // 
            // LMakeUser
            // 
            this.LMakeUser.AutoSize = true;
            this.LMakeUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LMakeUser.Location = new System.Drawing.Point(12, 9);
            this.LMakeUser.Name = "LMakeUser";
            this.LMakeUser.Size = new System.Drawing.Size(178, 25);
            this.LMakeUser.TabIndex = 2;
            this.LMakeUser.Text = "Tworzenie Profilu";
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(90, 37);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(100, 20);
            this.TBName.TabIndex = 3;
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LName.Location = new System.Drawing.Point(12, 35);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(39, 20);
            this.LName.TabIndex = 4;
            this.LName.Text = "Imie";
            // 
            // LSurname
            // 
            this.LSurname.AutoSize = true;
            this.LSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LSurname.Location = new System.Drawing.Point(12, 55);
            this.LSurname.Name = "LSurname";
            this.LSurname.Size = new System.Drawing.Size(76, 20);
            this.LSurname.TabIndex = 5;
            this.LSurname.Text = "Nazwisko";
            // 
            // TBSurname
            // 
            this.TBSurname.Location = new System.Drawing.Point(90, 55);
            this.TBSurname.Name = "TBSurname";
            this.TBSurname.Size = new System.Drawing.Size(100, 20);
            this.TBSurname.TabIndex = 6;
            // 
            // LMakeLogin
            // 
            this.LMakeLogin.AutoSize = true;
            this.LMakeLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LMakeLogin.Location = new System.Drawing.Point(12, 75);
            this.LMakeLogin.Name = "LMakeLogin";
            this.LMakeLogin.Size = new System.Drawing.Size(48, 20);
            this.LMakeLogin.TabIndex = 7;
            this.LMakeLogin.Text = "Login";
            // 
            // TBMakeLogin
            // 
            this.TBMakeLogin.Location = new System.Drawing.Point(90, 75);
            this.TBMakeLogin.Name = "TBMakeLogin";
            this.TBMakeLogin.Size = new System.Drawing.Size(100, 20);
            this.TBMakeLogin.TabIndex = 8;
            // 
            // LMakePassword
            // 
            this.LMakePassword.AutoSize = true;
            this.LMakePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LMakePassword.Location = new System.Drawing.Point(13, 95);
            this.LMakePassword.Name = "LMakePassword";
            this.LMakePassword.Size = new System.Drawing.Size(51, 20);
            this.LMakePassword.TabIndex = 9;
            this.LMakePassword.Text = "Hasło";
            // 
            // TBMakePassword
            // 
            this.TBMakePassword.Location = new System.Drawing.Point(90, 95);
            this.TBMakePassword.Name = "TBMakePassword";
            this.TBMakePassword.Size = new System.Drawing.Size(100, 20);
            this.TBMakePassword.TabIndex = 10;
            // 
            // LListUser
            // 
            this.LListUser.AutoSize = true;
            this.LListUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LListUser.Location = new System.Drawing.Point(13, 147);
            this.LListUser.Name = "LListUser";
            this.LListUser.Size = new System.Drawing.Size(144, 20);
            this.LListUser.TabIndex = 11;
            this.LListUser.Text = "Lista użytkowników";
            // 
            // CBListUser
            // 
            this.CBListUser.FormattingEnabled = true;
            this.CBListUser.Location = new System.Drawing.Point(12, 170);
            this.CBListUser.Name = "CBListUser";
            this.CBListUser.Size = new System.Drawing.Size(140, 21);
            this.CBListUser.TabIndex = 12;
            // 
            // LLogin
            // 
            this.LLogin.AutoSize = true;
            this.LLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LLogin.Location = new System.Drawing.Point(11, 194);
            this.LLogin.Name = "LLogin";
            this.LLogin.Size = new System.Drawing.Size(116, 25);
            this.LLogin.TabIndex = 13;
            this.LLogin.Text = "Logowanie";
            // 
            // TBUseLogin
            // 
            this.TBUseLogin.Location = new System.Drawing.Point(66, 222);
            this.TBUseLogin.Name = "TBUseLogin";
            this.TBUseLogin.Size = new System.Drawing.Size(100, 20);
            this.TBUseLogin.TabIndex = 14;
            // 
            // LUseLogin
            // 
            this.LUseLogin.AutoSize = true;
            this.LUseLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUseLogin.Location = new System.Drawing.Point(12, 219);
            this.LUseLogin.Name = "LUseLogin";
            this.LUseLogin.Size = new System.Drawing.Size(48, 20);
            this.LUseLogin.TabIndex = 15;
            this.LUseLogin.Text = "Login";
            // 
            // LUsePassword
            // 
            this.LUsePassword.AutoSize = true;
            this.LUsePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LUsePassword.Location = new System.Drawing.Point(13, 239);
            this.LUsePassword.Name = "LUsePassword";
            this.LUsePassword.Size = new System.Drawing.Size(51, 20);
            this.LUsePassword.TabIndex = 16;
            this.LUsePassword.Text = "Hasło";
            // 
            // TBUsePassword
            // 
            this.TBUsePassword.Location = new System.Drawing.Point(66, 241);
            this.TBUsePassword.Name = "TBUsePassword";
            this.TBUsePassword.Size = new System.Drawing.Size(100, 20);
            this.TBUsePassword.TabIndex = 17;
            // 
            // BLogIn
            // 
            this.BLogIn.Location = new System.Drawing.Point(12, 262);
            this.BLogIn.Name = "BLogIn";
            this.BLogIn.Size = new System.Drawing.Size(75, 23);
            this.BLogIn.TabIndex = 18;
            this.BLogIn.Text = "Zaloguj";
            this.BLogIn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BLogIn);
            this.Controls.Add(this.TBUsePassword);
            this.Controls.Add(this.LUsePassword);
            this.Controls.Add(this.LUseLogin);
            this.Controls.Add(this.TBUseLogin);
            this.Controls.Add(this.LLogin);
            this.Controls.Add(this.CBListUser);
            this.Controls.Add(this.LListUser);
            this.Controls.Add(this.TBMakePassword);
            this.Controls.Add(this.LMakePassword);
            this.Controls.Add(this.TBMakeLogin);
            this.Controls.Add(this.LMakeLogin);
            this.Controls.Add(this.TBSurname);
            this.Controls.Add(this.LSurname);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.LMakeUser);
            this.Controls.Add(this.BAddUser);
            this.Name = "Form1";
            this.Text = "Users";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BAddUser;
        private System.Windows.Forms.Label LMakeUser;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.Label LSurname;
        private System.Windows.Forms.TextBox TBSurname;
        private System.Windows.Forms.Label LMakeLogin;
        private System.Windows.Forms.TextBox TBMakeLogin;
        private System.Windows.Forms.Label LMakePassword;
        private System.Windows.Forms.TextBox TBMakePassword;
        private System.Windows.Forms.Label LListUser;
        private System.Windows.Forms.ComboBox CBListUser;
        private System.Windows.Forms.Label LLogin;
        private System.Windows.Forms.TextBox TBUseLogin;
        private System.Windows.Forms.Label LUseLogin;
        private System.Windows.Forms.Label LUsePassword;
        private System.Windows.Forms.TextBox TBUsePassword;
        private System.Windows.Forms.Button BLogIn;
    }
}

