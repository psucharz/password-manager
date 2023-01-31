using PasswordGenerator;
using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Project_24_01_2023
{
    public class PasswordInfo
    {
        public string Password { get; set; }

        public String CheckPasswordStrength()
        {
            if (Password.Length < 10)
                return "Password must be at least 8 characters long";
            if (!Regex.IsMatch(Password, @"\p{Ll}"))
                return "Password must contain lowercase letters.";
            if (!Regex.IsMatch(Password, @"\p{Lu}"))
                return "Password must contain uppercase letters.";
            if (!Regex.IsMatch(Password, @"\d"))
                return "Password must contain digits.";
            if (!Regex.IsMatch(Password, @"[^a-zA-Z0-9]"))
                return "Password must contain special characters.";
            return "Password is strong";
        }

        public static String GeneratePassword()
        {
            PasswordGenerator.Password password = new Password(includeLowercase: true, includeUppercase: true, includeNumeric: true, includeSpecial: true, passwordLength: 8);
            return password.Next();
        }
    }

    public class ProfileCredentials : PasswordInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public DateTime DateCreated { get; set; }
        public Dictionary<string, string> recoveryQuestions;

        public ProfileCredentials(string firstname, string lastname, string password)
        {
            Firstname = firstname;
            Lastname = lastname;
            Password = password;
            DateCreated = DateTime.Now;
        }

        public void AddRecoveryQuestion(String question, String answer)
        {
            if (recoveryQuestions == null)
                recoveryQuestions = new Dictionary<string, string>();
            answer = answer.Trim();
            recoveryQuestions.Add(question, answer);
        }
    }

    public class Credentials : PasswordInfo
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
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
                    _email = value;
                else
                    throw new ArgumentException("Invalid URL address");
            }
        }
        public string Notes { get; set; }
        public DateTime DateCreated { get; set; }

        public Credentials(string firstname, string lastname, string email, string website, string password, string notes)
        {
            Firstname = firstname;
            Lastname = lastname;
            if (email.Length > 0)
                Email = email;
            if (email.Length > 0)
                Website = website;
            Password = password;
            Notes = notes;
            DateCreated = DateTime.Now;
        }
    }
}
