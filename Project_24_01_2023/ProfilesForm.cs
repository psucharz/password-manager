using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Project_24_01_2023
{
    public partial class ProfilesForm : Form
    {
        private ErrorProvider passwordErrorProv;
        private List<Profile> profiles;

        public ProfilesForm()
        {
            InitializeComponent();
            passwordErrorProv = new ErrorProvider();
            LoadProfiles();
        }

        /// <summary>
        /// Updates Form when user changes profile selection
        /// </summary>
        private void ProfilesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
            if (selectedProfile != null)
            {
                FirstNameTextBox.Text = selectedProfile.FirstName;
                LastNameTextBox.Text = selectedProfile.LastName;
                PasswordTextBox.Text = new string(selectedProfile.Password.Select(l => '*').ToArray());
                RecQuestionsComboBox.Text = selectedProfile.RecoveryQuestion;
                RecAnswerTextBox.Text = new string(selectedProfile.RecoveryAnswer.Select(l => '*').ToArray());
                UpdateProfilePicture();
            }
        }

        /// <summary>
        /// Adds a new profile to the database, updates list and Form
        /// </summary>
        private void AddProfileButton_Click(object sender, EventArgs e)
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
                string encPass = AESEncryption.Encrypt(PasswordTextBox.Text, PasswordTextBox.Text);
                string encAns = AESEncryption.Encrypt(RecAnswerTextBox.Text, RecAnswerTextBox.Text);
                Profile pC = new Profile(0, FirstNameTextBox.Text, LastNameTextBox.Text, encPass,
                    RecQuestionsComboBox.Text, encAns);
                ProfilesDAO.SetProfile(pC);
                LoadProfiles();
            }
        }

        /// <summary>
        /// Modifies profile selected in ComboBox with values typed in TextBoxes if given password is correct
        /// </summary>
        private void ModifyProfileButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1 && Password2TextBox.Text != String.Empty)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                string decPass = AESEncryption.Decrypt(selectedProfile.Password, Password2TextBox.Text);
                if (Password2TextBox.Text != decPass)
                {
                    MessageBox.Show("Provided password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (FirstNameTextBox.Text == String.Empty || LastNameTextBox.Text == String.Empty)
                {
                    MessageBox.Show("First name and last name are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string encAns = AESEncryption.Encrypt(RecAnswerTextBox.Text, RecAnswerTextBox.Text);
                    Profile profile = new Profile(selectedProfile.Id, FirstNameTextBox.Text, LastNameTextBox.Text, "",
                    RecQuestionsComboBox.Text, encAns);
                    ProfilesDAO.ModifyProfile(profile);
                    LoadProfiles();
                }
            }
            else
            {
                MessageBox.Show("You must provide a password to this selectedProfile", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Deletes selected in ComboBox profile if given password is correct
        /// </summary>
        private void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                string decPass = AESEncryption.Decrypt(selectedProfile.Password, Password2TextBox.Text);
                if (Password2TextBox.Text == decPass)
                {
                    ProfilesDAO.DeleteProfile(selectedProfile);
                    LoadProfiles();
                }
                else
                {
                    MessageBox.Show("Provided password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        /// <summary>
        /// Checks passwords strength whenever it's changed
        /// </summary>
        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            string str = PasswordInfo.CheckPasswordStrength(PasswordTextBox.Text);
            if (str == "Password is strong")
                passwordErrorProv.SetError(PasswordTextBox, String.Empty);
            else
                passwordErrorProv.SetError(PasswordTextBox, str);
        }

        /// <summary>
        /// generates a strong password (uppercase, lowercase letters, digits, symbols, length of 8)
        /// </summary>
        private void GenPasswordButton_Click(object sender, EventArgs e)
        {
            PasswordTextBox.Text = PasswordInfo.GeneratePassword();
        }

        /// <summary>
        /// opens file explorer to pick a selectedProfile picture < 1MB and in either .png or .jpeg format
        /// </summary>
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.png;*.jpg)|*.png;*.jpg|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(openFileDialog.FileName);
                    if (fileInfo.Length < 1000000) //Check if file size is smaller than 1 MB
                    {
                        string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                        if (fileExtension == ".png" || fileExtension == ".jpg")    //Check if file is an image
                        {
                            Profile pC = (Profile)ProfilesComboBox.SelectedItem;
                            using (var stream = new FileStream(openFileDialog.FileName, FileMode.Open))
                            {
                                var picture = new byte[stream.Length];
                                stream.Read(picture, 0, (int)stream.Length);
                                ProfilesDAO.ModifyProfilePicture(pC, picture);
                                LoadProfiles();
                            }
                            ProfilePhoto.ImageLocation = openFileDialog.FileName;
                        }
                        else
                        {
                            MessageBox.Show("Selected file is not a valid image. Please select either .png or .jpeg image.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Selected file is too large. Please select an image that is smaller than 1 MB.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        /// <summary>
        /// Opens a new Form containing passwords linked to this selectedProfile
        /// </summary>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                string decPass = AESEncryption.Decrypt(selectedProfile.Password, Password2TextBox.Text);
                if (Password2TextBox.Text != decPass)
                {
                    selectedProfile.TimeOutLogin();
                    MessageBox.Show("Provided password is incorrect.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (DateTime.Parse(selectedProfile.LoginTimeout) > DateTime.Now)
                {
                    MessageBox.Show("Too many login attempts. Try again later.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    PasswordsForm passwordsForm = new PasswordsForm(selectedProfile);
                    passwordsForm.ShowDialog();
                }
            }
        }

        /// <summary>
        /// Recovers forgotten password if user correctly answers recovery questions
        /// </summary>
        private void RecoverButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                string decAns = AESEncryption.Decrypt(selectedProfile.RecoveryAnswer, RecAnswer2TextBox.Text);
                if(selectedProfile.RecoveryQuestion == RecQuestion2ComboBox.Text && decAns == RecAnswer2TextBox.Text)
                    Password2TextBox.Text = selectedProfile.Password;
                else
                    MessageBox.Show("Recovery answers either not set or incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void RecQuestionsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                if (RecQuestionsComboBox.Text == selectedProfile.RecoveryQuestion)
                    RecAnswerTextBox.Text = new string(selectedProfile.RecoveryAnswer.Select(l => '*').ToArray());
                else
                    RecAnswerTextBox.Text = String.Empty;
            }
        }

        private void LoadProfiles()
        {
            UpdateProfilesList();
            UpdateProfileComboBox();
            UpdateProfilePicture();
            UpdateRecoveryQuestions();
        }

        private void UpdateRecoveryQuestions()
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                RecQuestionsComboBox.Text = selectedProfile.RecoveryQuestion;
                RecQuestion2ComboBox.Text = selectedProfile.RecoveryQuestion;
            }
        }

        private void UpdateProfilePicture()
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                Profile selectedProfile = (Profile)ProfilesComboBox.SelectedItem;
                if (selectedProfile.ProfilePicture != null)
                {
                    using (var ms = new MemoryStream(selectedProfile.ProfilePicture))
                    {
                        Image image = Image.FromStream(ms);
                        ProfilePhoto.Image = image;
                    }
                }
                else
                {
                    ProfilePhoto.Image = null;
                }
            }
        }

        private void UpdateProfileComboBox()
        {
            ProfilesComboBox.DataSource = null;
            ProfilesComboBox.Items.Clear();
            ProfilesComboBox.DataSource = profiles;
            ProfilesComboBox.DisplayMember = "FullName";
        }

        private void UpdateProfilesList()
        {
            profiles = ProfilesDAO.GetProfiles();
        }
    }
}
