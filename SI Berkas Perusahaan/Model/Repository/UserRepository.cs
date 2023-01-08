using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using SI_Berkas_Perusahaan.Model.Context;

namespace SI_Berkas_Perusahaan.Model.Repository
{
    public class UserRepository
    {
        private SQLiteConnection _conn;
        public UserRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int ReadAttempt(string username, string password)
        {
            var result = 0;
            string sql = @"SELECT username,password FROM user WHERE username=@username AND password=@password";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                using (SQLiteDataReader dtr= cmd.ExecuteReader())
                {
                    while (dtr.Read()) result++;
                }
            }
            return result;
        }
    }
}
