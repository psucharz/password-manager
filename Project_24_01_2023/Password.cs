using PasswordGenerator;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;

namespace Project_24_01_2023
{
    public class PasswordInfo
    {
        public string Password { get; set; }

        public PasswordInfo(string password)
        {
            Password = password;
        }

        public string CheckPasswordStrength()
        {
            return CheckPasswordStrength(Password);
        }

        public static string CheckPasswordStrength(string password)
        {
            if (password.Length < 8)
                return "Password must be at least 8 characters long";
            if (!Regex.IsMatch(password, @"\p{Ll}"))
                return "Password must contain lowercase letters.";
            if (!Regex.IsMatch(password, @"\p{Lu}"))
                return "Password must contain uppercase letters.";
            if (!Regex.IsMatch(password, @"\d"))
                return "Password must contain digits.";
            if (!Regex.IsMatch(password, @"[^a-zA-Z0-9]"))
                return "Password must contain special characters.";
            return "Password is strong";
        }

        public static string GeneratePassword()
        {
            PasswordGenerator.Password password = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 8);
            return password.Next();
        }
    }

    public class ProfileCredentials : PasswordInfo
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string RecoveryQuestion { get; set; }
        public string RecoveryAnswer { get; set; }
        public string DateModified { get; set; }
        public string LoginTimeout { get; set; }
        public int FailedLoginAttempts { get; set; }

        public string FullName => FirstName + " " + LastName;

        public ProfileCredentials(string firstname, string lastname, string password, string recoveryQuestion, string recoveryAnswer) : base(password)
        {
            FirstName = firstname;
            LastName = lastname;
            RecoveryQuestion = recoveryQuestion;
            RecoveryAnswer = recoveryAnswer;
            DateModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            LoginTimeout = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            FailedLoginAttempts = 0;
        }

        public void AddProfilePicture(Bitmap pfp)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                pfp.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                ProfilePicture = ms.ToArray();
            }
        }

        public bool TimeOutLogin()
        {
            if (FailedLoginAttempts > 10)
            {
                FailedLoginAttempts = 0;
                LoginTimeout = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                return true;
            }
            else
            {
                FailedLoginAttempts++;
                return false;
            }
        }
    }

    public class Credentials : PasswordInfo
    {
        public int ReferenceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        private string _email;
        public string Email
        {
            get => _email;
            set
            {
                if (Regex.IsMatch(value, @"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$"))
                    _email = value;
                else
                    throw new ArgumentException("Invalid email address");
            }
        }
        private string _website;
        public string Website
        {
            get => _website;
            set
            {
                if (Regex.IsMatch(value, @"/^(https?:\/\/)?(?:www\.)?[-a-zA-Z0-9@:%._\+~#=]{1,256}\.[a-zA-Z0-9()]{1,6}\b(?:[-a-zA-Z0-9()@:%_\+.~#?&\/=]*)$"))
                    _website = value;
                else
                    throw new ArgumentException("Invalid URL address");
            }
        }
        public string Notes { get; set; }
        public string DateModified { get; set; }

        public Credentials(string firstname, string lastname, string email, string website, string password, string notes) : base(password)
        {
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Website = website;
            Notes = notes;
            DateModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
