namespace Project_24_01_2023
{
    partial class PasswordsForm
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
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameTextBox = new System.Windows.Forms.TextBox();
            this.FirstNameLabel = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.AddPasswordButton = new System.Windows.Forms.Button();
            this.LogoutButton = new System.Windows.Forms.Button();
            this.DeletePasswordButton = new System.Windows.Forms.Button();
            this.ModifyPasswordButton = new System.Windows.Forms.Button();
            this.NotesLabel = new System.Windows.Forms.Label();
            this.WebsiteLabel = new System.Windows.Forms.Label();
            this.WebsiteTextBox = new System.Windows.Forms.TextBox();
            this.NotesTextBox = new System.Windows.Forms.TextBox();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.PasswordsLabel = new System.Windows.Forms.Label();
            this.ProfileLabel = new System.Windows.Forms.Label();
            this.CurrProfileLabel = new System.Windows.Forms.Label();
            this.LastNameLabel = new System.Windows.Forms.Label();
            this.LastNameTextBox = new System.Windows.Forms.TextBox();
            this.GeneratePassButton = new System.Windows.Forms.Button();
            this.PasswordsDataGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.PasswordTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.PasswordTextBox.Location = new System.Drawing.Point(130, 142);
            this.PasswordTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(349, 22);
            this.PasswordTextBox.TabIndex = 2;
            this.PasswordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            // 
            // FirstNameTextBox
            // 
            this.FirstNameTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.FirstNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.FirstNameTextBox.Location = new System.Drawing.Point(130, 73);
            this.FirstNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FirstNameTextBox.Name = "FirstNameTextBox";
            this.FirstNameTextBox.Size = new System.Drawing.Size(349, 22);
            this.FirstNameTextBox.TabIndex = 3;
            // 
            // FirstNameLabel
            // 
            this.FirstNameLabel.AutoSize = true;
            this.FirstNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.FirstNameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.FirstNameLabel.Location = new System.Drawing.Point(16, 69);
            this.FirstNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.FirstNameLabel.Name = "FirstNameLabel";
            this.FirstNameLabel.Size = new System.Drawing.Size(106, 25);
            this.FirstNameLabel.TabIndex = 4;
            this.FirstNameLabel.Text = "First Name";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordLabel.ForeColor = System.Drawing.Color.Cyan;
            this.PasswordLabel.Location = new System.Drawing.Point(24, 138);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(98, 25);
            this.PasswordLabel.TabIndex = 5;
            this.PasswordLabel.Text = "Password";
            // 
            // AddPasswordButton
            // 
            this.AddPasswordButton.BackColor = System.Drawing.Color.DarkGray;
            this.AddPasswordButton.Location = new System.Drawing.Point(21, 313);
            this.AddPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddPasswordButton.Name = "AddPasswordButton";
            this.AddPasswordButton.Size = new System.Drawing.Size(150, 28);
            this.AddPasswordButton.TabIndex = 6;
            this.AddPasswordButton.Text = "Add";
            this.AddPasswordButton.UseVisualStyleBackColor = false;
            this.AddPasswordButton.Click += new System.EventHandler(this.AddPasswordButton_Click);
            // 
            // LogoutButton
            // 
            this.LogoutButton.BackColor = System.Drawing.Color.DarkGray;
            this.LogoutButton.Location = new System.Drawing.Point(410, 9);
            this.LogoutButton.Margin = new System.Windows.Forms.Padding(4);
            this.LogoutButton.Name = "LogoutButton";
            this.LogoutButton.Size = new System.Drawing.Size(150, 28);
            this.LogoutButton.TabIndex = 9;
            this.LogoutButton.Text = "Log out";
            this.LogoutButton.UseVisualStyleBackColor = false;
            this.LogoutButton.Click += new System.EventHandler(this.LogoutButton_Click);
            // 
            // DeletePasswordButton
            // 
            this.DeletePasswordButton.BackColor = System.Drawing.Color.DarkGray;
            this.DeletePasswordButton.Location = new System.Drawing.Point(337, 313);
            this.DeletePasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeletePasswordButton.Name = "DeletePasswordButton";
            this.DeletePasswordButton.Size = new System.Drawing.Size(150, 28);
            this.DeletePasswordButton.TabIndex = 11;
            this.DeletePasswordButton.Text = "Delete";
            this.DeletePasswordButton.UseVisualStyleBackColor = false;
            this.DeletePasswordButton.Click += new System.EventHandler(this.DeletePasswordButton_Click);
            // 
            // ModifyPasswordButton
            // 
            this.ModifyPasswordButton.BackColor = System.Drawing.Color.DarkGray;
            this.ModifyPasswordButton.Location = new System.Drawing.Point(179, 313);
            this.ModifyPasswordButton.Margin = new System.Windows.Forms.Padding(4);
            this.ModifyPasswordButton.Name = "ModifyPasswordButton";
            this.ModifyPasswordButton.Size = new System.Drawing.Size(150, 28);
            this.ModifyPasswordButton.TabIndex = 12;
            this.ModifyPasswordButton.Text = "Modify";
            this.ModifyPasswordButton.UseVisualStyleBackColor = false;
            this.ModifyPasswordButton.Click += new System.EventHandler(this.ModifyPasswordButton_Click);
            // 
            // NotesLabel
            // 
            this.NotesLabel.AutoSize = true;
            this.NotesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.NotesLabel.ForeColor = System.Drawing.Color.Cyan;
            this.NotesLabel.Location = new System.Drawing.Point(59, 241);
            this.NotesLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NotesLabel.Name = "NotesLabel";
            this.NotesLabel.Size = new System.Drawing.Size(63, 25);
            this.NotesLabel.TabIndex = 17;
            this.NotesLabel.Text = "Notes";
            // 
            // WebsiteLabel
            // 
            this.WebsiteLabel.AutoSize = true;
            this.WebsiteLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.WebsiteLabel.ForeColor = System.Drawing.Color.Cyan;
            this.WebsiteLabel.Location = new System.Drawing.Point(38, 207);
            this.WebsiteLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WebsiteLabel.Name = "WebsiteLabel";
            this.WebsiteLabel.Size = new System.Drawing.Size(84, 25);
            this.WebsiteLabel.TabIndex = 16;
            this.WebsiteLabel.Text = "Website";
            // 
            // WebsiteTextBox
            // 
            this.WebsiteTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.WebsiteTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.WebsiteTextBox.Location = new System.Drawing.Point(130, 210);
            this.WebsiteTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.WebsiteTextBox.Name = "WebsiteTextBox";
            this.WebsiteTextBox.Size = new System.Drawing.Size(349, 22);
            this.WebsiteTextBox.TabIndex = 15;
            // 
            // NotesTextBox
            // 
            this.NotesTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.NotesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.NotesTextBox.Location = new System.Drawing.Point(130, 245);
            this.NotesTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.NotesTextBox.Name = "NotesTextBox";
            this.NotesTextBox.Size = new System.Drawing.Size(349, 22);
            this.NotesTextBox.TabIndex = 14;
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLabel.ForeColor = System.Drawing.Color.Cyan;
            this.EmailLabel.Location = new System.Drawing.Point(55, 172);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(67, 25);
            this.EmailLabel.TabIndex = 19;
            this.EmailLabel.Text = "E-mail";
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.EmailTextBox.Location = new System.Drawing.Point(130, 176);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(349, 22);
            this.EmailTextBox.TabIndex = 18;
            // 
            // PasswordsLabel
            // 
            this.PasswordsLabel.AutoSize = true;
            this.PasswordsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.PasswordsLabel.ForeColor = System.Drawing.Color.Cyan;
            this.PasswordsLabel.Location = new System.Drawing.Point(608, 9);
            this.PasswordsLabel.Name = "PasswordsLabel";
            this.PasswordsLabel.Size = new System.Drawing.Size(148, 31);
            this.PasswordsLabel.TabIndex = 20;
            this.PasswordsLabel.Text = "Passwords";
            // 
            // ProfileLabel
            // 
            this.ProfileLabel.AutoSize = true;
            this.ProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.ProfileLabel.ForeColor = System.Drawing.Color.Cyan;
            this.ProfileLabel.Location = new System.Drawing.Point(12, 9);
            this.ProfileLabel.Name = "ProfileLabel";
            this.ProfileLabel.Size = new System.Drawing.Size(91, 31);
            this.ProfileLabel.TabIndex = 21;
            this.ProfileLabel.Text = "Profile";
            // 
            // CurrProfileLabel
            // 
            this.CurrProfileLabel.AutoSize = true;
            this.CurrProfileLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.CurrProfileLabel.ForeColor = System.Drawing.Color.Teal;
            this.CurrProfileLabel.Location = new System.Drawing.Point(109, 9);
            this.CurrProfileLabel.Name = "CurrProfileLabel";
            this.CurrProfileLabel.Size = new System.Drawing.Size(209, 31);
            this.CurrProfileLabel.TabIndex = 22;
            this.CurrProfileLabel.Text = "PROFILENAME";
            // 
            // LastNameLabel
            // 
            this.LastNameLabel.AutoSize = true;
            this.LastNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LastNameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.LastNameLabel.Location = new System.Drawing.Point(16, 103);
            this.LastNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LastNameLabel.Name = "LastNameLabel";
            this.LastNameLabel.Size = new System.Drawing.Size(106, 25);
            this.LastNameLabel.TabIndex = 25;
            this.LastNameLabel.Text = "Last Name";
            // 
            // LastNameTextBox
            // 
            this.LastNameTextBox.BackColor = System.Drawing.Color.DarkGray;
            this.LastNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.5F);
            this.LastNameTextBox.Location = new System.Drawing.Point(130, 107);
            this.LastNameTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.LastNameTextBox.Name = "LastNameTextBox";
            this.LastNameTextBox.Size = new System.Drawing.Size(349, 22);
            this.LastNameTextBox.TabIndex = 24;
            // 
            // GeneratePassButton
            // 
            this.GeneratePassButton.Location = new System.Drawing.Point(486, 142);
            this.GeneratePassButton.Name = "GeneratePassButton";
            this.GeneratePassButton.Size = new System.Drawing.Size(90, 23);
            this.GeneratePassButton.TabIndex = 26;
            this.GeneratePassButton.Text = "Generate";
            this.GeneratePassButton.UseVisualStyleBackColor = true;
            this.GeneratePassButton.Click += new System.EventHandler(this.GeneratePassButton_Click);
            // 
            // PasswordsDataGrid
            // 
            this.PasswordsDataGrid.AllowUserToAddRows = false;
            this.PasswordsDataGrid.AllowUserToDeleteRows = false;
            this.PasswordsDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PasswordsDataGrid.Location = new System.Drawing.Point(614, 73);
            this.PasswordsDataGrid.MultiSelect = false;
            this.PasswordsDataGrid.Name = "PasswordsDataGrid";
            this.PasswordsDataGrid.ReadOnly = true;
            this.PasswordsDataGrid.RowHeadersWidth = 51;
            this.PasswordsDataGrid.RowTemplate.Height = 24;
            this.PasswordsDataGrid.Size = new System.Drawing.Size(1095, 568);
            this.PasswordsDataGrid.TabIndex = 27;
            this.PasswordsDataGrid.SelectionChanged += new System.EventHandler(this.PasswordsDataGrid_SelectionChanged);
            // 
            // PasswordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1732, 653);
            this.Controls.Add(this.PasswordsDataGrid);
            this.Controls.Add(this.GeneratePassButton);
            this.Controls.Add(this.LastNameLabel);
            this.Controls.Add(this.LastNameTextBox);
            this.Controls.Add(this.CurrProfileLabel);
            this.Controls.Add(this.ProfileLabel);
            this.Controls.Add(this.PasswordsLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.NotesLabel);
            this.Controls.Add(this.WebsiteLabel);
            this.Controls.Add(this.WebsiteTextBox);
            this.Controls.Add(this.NotesTextBox);
            this.Controls.Add(this.ModifyPasswordButton);
            this.Controls.Add(this.DeletePasswordButton);
            this.Controls.Add(this.LogoutButton);
            this.Controls.Add(this.AddPasswordButton);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.FirstNameLabel);
            this.Controls.Add(this.FirstNameTextBox);
            this.Controls.Add(this.PasswordTextBox);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(1750, 700);
            this.Name = "PasswordsForm";
            this.Text = "Password";
            ((System.ComponentModel.ISupportInitialize)(this.PasswordsDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox PasswordTextBox;
        private System.Windows.Forms.TextBox FirstNameTextBox;
        private System.Windows.Forms.Label FirstNameLabel;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Button AddPasswordButton;
        private System.Windows.Forms.Button LogoutButton;
        private System.Windows.Forms.Button DeletePasswordButton;
        private System.Windows.Forms.Button ModifyPasswordButton;
        private System.Windows.Forms.Label NotesLabel;
        private System.Windows.Forms.Label WebsiteLabel;
        private System.Windows.Forms.TextBox WebsiteTextBox;
        private System.Windows.Forms.TextBox NotesTextBox;
        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label PasswordsLabel;
        private System.Windows.Forms.Label ProfileLabel;
        private System.Windows.Forms.Label CurrProfileLabel;
        private System.Windows.Forms.Label LastNameLabel;
        private System.Windows.Forms.TextBox LastNameTextBox;
        private System.Windows.Forms.Button GeneratePassButton;
        private System.Windows.Forms.DataGridView PasswordsDataGrid;
    }
}