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
        ErrorProvider passwordErrorProv;
        List<ProfileCredentials> profiles;

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
            var selectedProfile = (ProfileCredentials)ProfilesComboBox.SelectedItem;
            FirstNameTextBox.Text = selectedProfile.FirstName;
            LastNameTextBox.Text = selectedProfile.LastName;
            PasswordTextBox.Text = selectedProfile.Password;
            RecQuestionsComboBox.SelectedText = selectedProfile.RecoveryQuestion;
            RecAnswerTextBox.Text = new string(selectedProfile.RecoveryAnswer.Select(l => '*').ToArray());
        }

        /// <summary>
        /// Adds a new profile to the database, updates list and Form
        /// </summary>
        private void AddProfileButton_Click(object sender, EventArgs e)
        {
            ProfileCredentials pC = new ProfileCredentials(FirstNameTextBox.Text, LastNameTextBox.Text, Password2Label.Text,
                RecQuestionsComboBox.SelectedText, RecAnswerTextBox.Text);
            ProfilesDAO.SetProfile(pC);
            LoadProfiles();
        }

        /// <summary>
        /// Modifies profile selected in ComboBox with values typed in TextBoxes if given password is correct
        /// </summary>
        private void ModifyProfileButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                ProfileCredentials oldProfile = (ProfileCredentials)ProfilesComboBox.SelectedItem;
                if (Password2TextBox.Text != oldProfile.Password)
                {
                    MessageBox.Show("Provided password is incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (FirstNameTextBox.Text == String.Empty || LastNameTextBox.Text == String.Empty)
                {
                    MessageBox.Show("First name and last name are required", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    ProfileCredentials updatedProfile = new ProfileCredentials(FirstNameTextBox.Text, LastNameTextBox.Text, "",
                    RecQuestionsComboBox.SelectedText, RecAnswerTextBox.Text);
                    ProfilesDAO.ModifyProfile(oldProfile, updatedProfile);
                    LoadProfiles();
                }
            }
        }

        /// <summary>
        /// Deletes selected in ComboBox profile if given password is correct
        /// </summary>
        private void DeleteProfileButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                ProfileCredentials profile = (ProfileCredentials)ProfilesComboBox.SelectedItem;
                if (Password2TextBox.Text == profile.Password)
                {
                    ProfilesDAO.DeleteProfile(profile);
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
            var str = PasswordInfo.CheckPasswordStrength(PasswordTextBox.Text);
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
        /// opens file explorer to pick a profile picture < 1MB and in either .png or .jpeg format
        /// </summary>
        private void AddPhotoButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files(*.png;*.jpeg)|*.png;*.jpeg|All files (*.*)|*.*";
                openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(openFileDialog.FileName);
                    if (fileInfo.Length < 1000000) //Check if file size is smaller than 1 MB
                    {
                        string fileExtension = Path.GetExtension(openFileDialog.FileName).ToLower();
                        if (fileExtension == ".png" || fileExtension == ".jpeg")    //Check if file is an image
                        {
                            ProfileCredentials pC = (ProfileCredentials)ProfilesComboBox.SelectedItem;
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

        private void LoginButton_Click(object sender, EventArgs e)
        {

        }

        private void RecoverButton_Click(object sender, EventArgs e)
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                ProfileCredentials profile = (ProfileCredentials)ProfilesComboBox.SelectedItem;
                if(profile.RecoveryQuestion == RecQuestion2ComboBox.SelectedText && profile.RecoveryAnswer == RecAnswer2TextBox.Text)
                    Password2TextBox.Text = profile.Password;
                else
                    MessageBox.Show("Recovery answers either not set or incorrect", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadProfiles()
        {
            UpdateProfilesList();
            UpdateProfileComboBox();
            UpdateProfilePicture();
        }

        private void UpdateProfilePicture()
        {
            if (ProfilesComboBox.SelectedIndex > -1)
            {
                ProfileCredentials profile = (ProfileCredentials)ProfilesComboBox.SelectedItem;
                if (profile.ProfilePicture != null)
                {
                    using (var ms = new MemoryStream(profile.ProfilePicture))
                    {
                        Image image = Image.FromStream(ms);
                        ProfilePhoto.Image = image;
                    }
                }
            }
        }

        private void UpdateProfileComboBox()
        {
            ProfilesComboBox.Items.Clear();
            ProfilesComboBox.DataSource = profiles;
            ProfilesComboBox.DisplayMember = "FullName";
        }

        /// <summary>
        /// Puts profiles from database to List
        /// </summary>
        private void UpdateProfilesList()
        {
            profiles = ProfilesDAO.GetProfiles();
        }
    }
}
