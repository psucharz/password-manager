using Dapper;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;

namespace Project_24_01_2023
{
    public class ProfilesDAO
    {
        public static List<Profile> GetProfiles()
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                var output = idbc.Query<Profile>("SELECT * FROM Profile", new DynamicParameters());
                return output.ToList();
            }
        }

        public static void SetProfile(Profile profile)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("INSERT INTO Profile (FirstName, LastName, ProfilePicture, Password, RecoveryQuestion, RecoveryAnswer, RecoveryPassword, DateModified, LoginTimeout, FailedLoginAttempts) " +
                "VALUES (@FirstName, @LastName, @ProfilePicture, @Password, @RecoveryQuestion, @RecoveryAnswer, @RecoveryPassword, @DateModified, @LoginTimeout, @FailedLoginAttempts)",
                profile);
            }
        }

        public static void ModifyProfile(Profile profile)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("UPDATE Profile SET FirstName = @FirstName, LastName = @LastName, ProfilePicture = @ProfilePicture," +
                "RecoveryQuestion = @RecoveryQuestion, RecoveryAnswer = @RecoveryAnswer, RecoveryPassword = @RecoveryPassword, DateModified = @DateModified, LoginTimeout = @LoginTimeout, FailedLoginAttempts = @FailedLoginAttempts " +
                "WHERE Id = @Id",
                profile);
            }
        }

        public static void DeleteProfile(Profile profile)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("DELETE FROM Profile WHERE Id = @Id", profile);
            }
        }

        private static string LoadConnectionString(string id = "PassManagerDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }

        public static void ModifyProfilePicture(Profile pC, byte[] picture)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("UPDATE Profile SET ProfilePicture = @picture WHERE Id = @Id", new { picture, Id = pC.Id });
            }
        }
    }

    public class PasswordsDAO
    {
        public static List<Password> GetPasswords(Profile connectedProfile)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                var parameters = new DynamicParameters();
                parameters.Add("@ReferenceId", connectedProfile.Id);
                var output = idbc.Query<Password>("SELECT * FROM Password WHERE ReferenceId = @ReferenceId", parameters);
                return output.ToList();
            }
        }

        public static void SetPassword(Password password)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("INSERT INTO Password (ReferenceId, FirstName, LastName, Password, Email, Website, Notes, DateModified) " +
                "VALUES (@ReferenceId, @FirstName, @LastName, @Password, @Email, @Website, @Notes, @DateModified)",
                password);
            }
        }

        public static void ModifyPassword(Password password)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("UPDATE Password SET FirstName = @FirstName, LastName = @LastName, Password = @Password, Email = @Email, " +
                    "Website = @Website, Notes = @Notes, DateModified = @DateModified " +
                "WHERE Id = @Id",
                password);
            }
        }

        public static void DeletePassword(Password password)
        {
            using (IDbConnection idbc = new SQLiteConnection(LoadConnectionString()))
            {
                idbc.Execute("DELETE FROM Password WHERE Id = @Id", password);
            }
        }

        private static string LoadConnectionString(string id = "PassManagerDB")
        {
            return ConfigurationManager.ConnectionStrings[id].ConnectionString;
        }
    }
}
