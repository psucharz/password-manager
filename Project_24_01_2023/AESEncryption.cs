using System;
using System.IO;
using System.Security.Cryptography;

namespace Project_24_01_2023
{
    internal class AESEncryption
    {
        private static readonly byte[] Salt = new byte[] {
            0x26, 0xdc, 0xff, 0x00,
            0xad, 0xed, 0x7a, 0xee,
            0xc5, 0xfe, 0x07, 0xaf,
            0x4d, 0x08, 0x22, 0x3c };

        /// <summary>
        /// Encrypts a plaintext with AES where key and IV are based on password.
        /// </summary>
        /// <param name="plainText">Plain text to be encrypted</param>
        /// <param name="password">Password from which a key is generated</param>
        /// <returns>Encrypted text</returns>
        public static string Encrypt(string plainText, string password)
        {
            byte[] encryptedBytes;
            using (Aes aes = Aes.Create())
            {
                aes.Key = GenerateKey(password);
                aes.IV = GenerateIV(password);
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform encryptor = aes.CreateEncryptor(aes.Key, aes.IV);

                using (MemoryStream msEncrypt = new MemoryStream())
                {
                    using (CryptoStream csEncrypt = new CryptoStream(msEncrypt, encryptor, CryptoStreamMode.Write))
                    {
                        using (StreamWriter swEncrypt = new StreamWriter(csEncrypt))
                        {
                            swEncrypt.Write(plainText);
                        }
                        encryptedBytes = msEncrypt.ToArray();
                    }
                }
            }
            return Convert.ToBase64String(encryptedBytes);
        }

        public static string Decrypt(string encryptedText, string password)
        {
            byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
            string decryptedText;
            using (Aes aes = Aes.Create())
            {
                aes.Key = GenerateKey(password);
                aes.IV = GenerateIV(password);
                aes.Padding = PaddingMode.PKCS7;

                ICryptoTransform decryptor = aes.CreateDecryptor(aes.Key, aes.IV);

                using (MemoryStream msDecrypt = new MemoryStream(encryptedBytes))
                {
                    using (CryptoStream csDecrypt = new CryptoStream(msDecrypt, decryptor, CryptoStreamMode.Read))
                    {
                        using (StreamReader srDecrypt = new StreamReader(csDecrypt))
                        {
                            decryptedText = srDecrypt.ReadToEnd();
                        }
                    }
                }
            }
            return decryptedText;
        }

        private static byte[] GenerateKey(string password)
        {
            using (Rfc2898DeriveBytes keyGenerator = new Rfc2898DeriveBytes(password, Salt))
            {
                return keyGenerator.GetBytes(32);
            }
        }

        public static byte[] GenerateIV(string password)
        {
            using (Rfc2898DeriveBytes ivGenerator = new Rfc2898DeriveBytes(password, Salt))
            {
                return ivGenerator.GetBytes(16);
            }
        }
    }
}
