using PasswordGenerator;
using System;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Project_24_01_2023
{
    public class PasswordInfo
    {
        public string Password { get; set; }

        public PasswordInfo(string password)
        {
            Password = password;
        }

        public PasswordInfo() { }

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
            PasswordGenerator.Password password = new PasswordGenerator.Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 8);
            return password.Next();
        }
    }

    public class Profile : PasswordInfo
    {
        public long Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] ProfilePicture { get; set; }
        public string RecoveryQuestion { get; set; }
        public string RecoveryAnswer { get; set; }
        public string DateModified { get; set; }
        public string LoginTimeout { get; set; }
        public long FailedLoginAttempts { get; set; }

        public string FullName => FirstName + " " + LastName;

        public Profile() { }

        public Profile(long id, string firstname, string lastname, string password, string recoveryQuestion, string recoveryAnswer) : base(password)
        {
            Id = id;
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
                LoginTimeout = DateTime.Now.AddHours(1).ToString("yyyy-MM-dd HH:mm:ss");
                return true;
            }
            else
            {
                FailedLoginAttempts++;
                return false;
            }
        }
    }

    public class Password : PasswordInfo
    {
        public long Id { get; set; }
        public long ReferenceId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public string Notes { get; set; }
        public string DateModified { get; set; }

        public Password() { }

        public Password(string firstname, string lastname, string password,
            string email, string website,  string notes, long id, long referenceId) : base(password)
        {
            Id = id;
            ReferenceId = referenceId;
            FirstName = firstname;
            LastName = lastname;
            Email = email;
            Website = website;
            Notes = notes;
            DateModified = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }
    }
}
