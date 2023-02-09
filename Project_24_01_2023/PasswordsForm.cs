using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project_24_01_2023
{
    public partial class PasswordsForm : Form
    {
        private ErrorProvider passwordErrorProv;
        private Profile profile;
        private List<Password> passwords;

        public PasswordsForm(Profile profileCredentials)
        {
            InitializeComponent();
            passwordErrorProv = new ErrorProvider();
            profile = profileCredentials;
            CurrProfileLabel.Text = profile.FullName;
            LoadPasswords();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void AddPasswordButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == String.Empty || LastNameTextBox.Text == String.Empty)
            {
                MessageBox.Show("First name and last name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (passwordErrorProv.GetError(PasswordTextBox) != String.Empty)
            {
                MessageBox.Show("Invalid password. Check password errors to know what's wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string encPass = AESEncryption.Encrypt(PasswordTextBox.Text, profile.Password);
                string encMail = AESEncryption.Encrypt(EmailTextBox.Text, profile.Password);
                Password p = new Password(FirstNameTextBox.Text, LastNameTextBox.Text, encPass, encMail, WebsiteTextBox.Text, NotesTextBox.Text,
                    0, profile.Id);
                PasswordsDAO.SetPassword(p);
                LoadPasswords();
            }
        }

        private void ModifyPasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordsDataGrid.SelectedRows.Count == 1)
            {
                if (FirstNameTextBox.Text == String.Empty || LastNameTextBox.Text == String.Empty)
                {
                    MessageBox.Show("First name and last name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (passwordErrorProv.GetError(PasswordTextBox) != String.Empty)
                {
                    MessageBox.Show("Invalid password. Check password errors to know what's wrong.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string encPass = AESEncryption.Encrypt(PasswordTextBox.Text, profile.Password);
                    string encMail = AESEncryption.Encrypt(EmailTextBox.Text, profile.Password);
                    Password p = new Password(FirstNameTextBox.Text, LastNameTextBox.Text, encPass, encMail, WebsiteTextBox.Text, NotesTextBox.Text,
                    (long)PasswordsDataGrid.SelectedRows[0].Cells["Id"].Value, profile.Id);
                    PasswordsDAO.ModifyPassword(p);
                    LoadPasswords();
                }
            }
        }

        private void DeletePasswordButton_Click(object sender, EventArgs e)
        {
            if (PasswordsDataGrid.Rows.Count > 0)
            {
                if (PasswordsDataGrid.SelectedRows.Count == 1)
                {
                    DataGridViewRow selectedRow = PasswordsDataGrid.SelectedRows[0];
                    Password password = null;
                    foreach (var pass in passwords)
                    {
                        if(pass.Id == (long)selectedRow.Cells["Id"].Value)
                            password = pass;
                    }
                    PasswordsDAO.DeletePassword(password);
                    LoadPasswords();
                }
                else
                {
                    MessageBox.Show("No item is selected in the list to be deleted.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("List of passwords is empty.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            var str = PasswordInfo.CheckPasswordStrength(PasswordTextBox.Text);
            if (str == "Password is strong")
                passwordErrorProv.SetError(PasswordTextBox, String.Empty);
            else
                passwordErrorProv.SetError(PasswordTextBox, str);
        }

        private void GeneratePassButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = PasswordInfo.GeneratePassword();
        }

        private void LoadPasswords()
        {
            UpdatePasswordsList();
            UpdateDataGrid();
        }

        private void UpdateDataGrid()
        {
            PasswordsDataGrid.DataSource = passwords;
        }

        private void UpdatePasswordsList()
        {
            passwords = PasswordsDAO.GetPasswords(profile);
            foreach (Password pass in passwords)
            {
                pass.Password = AESEncryption.Decrypt(pass.Password, profile.Password);
                pass.Email = AESEncryption.Decrypt(pass.Email, profile.Password);
            }
        }

        private void PasswordsDataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (PasswordsDataGrid.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = PasswordsDataGrid.SelectedRows[0];
                FirstNameTextBox.Text = selectedRow.Cells["FirstName"].Value.ToString();
                LastNameTextBox.Text = selectedRow.Cells["LastName"].Value.ToString();
                PasswordTextBox.Text = selectedRow.Cells["Password"].Value.ToString();
                EmailTextBox.Text = selectedRow.Cells["Email"].Value.ToString();
                WebsiteTextBox.Text = selectedRow.Cells["Website"].Value.ToString();
                NotesTextBox.Text = selectedRow.Cells["Notes"].Value.ToString();
            }
        }
    }
}
