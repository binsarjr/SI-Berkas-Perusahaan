using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SQLite;
using SI_Berkas_Perusahaan.Model.Context;
using SI_Berkas_Perusahaan.Model.Entity;

namespace SI_Berkas_Perusahaan.Model.Repository
{
    public class PenanggungJawabRepository
    {
        private SQLiteConnection _conn;
        public PenanggungJawabRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(PenanggungJawab penanggungJawab)
        {
            int result = 0;

            string sql = @"INSERT INTO penanggung_jawab (nama_lengkap,nohp,email) values (@nama_lengkap, @nohp, @email)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_lengkap", penanggungJawab.NamaLengkap);
                cmd.Parameters.AddWithValue("@nohp", penanggungJawab.NoHP);
                cmd.Parameters.AddWithValue("@email", penanggungJawab.Email);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Penanggung Jawab error: {0}", ex.Message);
                }

            }

            return result;
        }

        public int Update(PenanggungJawab penanggungJawab)
        {
            int result = 0;

            string sql = @"UPDATE penanggung_jawab SET nama_lengkap=@nama_lengkap, nohp=@nohp,email=@email WHERE id=@id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama_lengkap", penanggungJawab.NamaLengkap);
                cmd.Parameters.AddWithValue("@nohp", penanggungJawab.NoHP);
                cmd.Parameters.AddWithValue("@email", penanggungJawab.Email);
                cmd.Parameters.AddWithValue("@id", penanggungJawab.Id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update PenanggungJawab error: {0}", ex.Message);
                }

            }

            return result;
        }
        public int Delete(PenanggungJawab penanggungJawab)
        {
            int result = 0;

            string sql = @"DELETE FROM penanggung_jawab WHERE id=@id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", penanggungJawab.Id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete PenanggungJawab error: {0}", ex.Message);
                }

            }

            return result;
        }
        public List<PenanggungJawab> ReadAll(string nama = "")
        {
            var items = new List<PenanggungJawab>();


            try
            {
                string sql = @"select id, nama_lengkap, nohp,email
 from penanggung_jawab
 order by nama_lengkap";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new PenanggungJawab();
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaLengkap = dtr["nama_lengkap"].ToString();
                            item.NoHP = dtr["nohp"].ToString();
                            item.Email = dtr["email"].ToString();
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll PenanggungJawab error: {0}", ex.Message);
            }

            return items;
        }

        public List<PenanggungJawab> ReadByName(string nama)
        {
            var items = new List<PenanggungJawab>();


            try
            {
                string sql = @"select id, nama_lengkap, nohp,email
 from penanggung_jawab where nama_lengkap=@nama
 order by nama_lengkap";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new PenanggungJawab();
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaLengkap = dtr["nama_lengkap"].ToString();
                            item.NoHP = dtr["nohp"].ToString();
                            item.Email = dtr["email"].ToString();
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByName PenanggungJawab error: {0}", ex.Message);
            }

            return items;
        }

        public PenanggungJawab ReadById(int id)
        {
            PenanggungJawab item = null;
            try
            {
                string sql = @"select id, nama_lengkap, nohp,email
 from penanggung_jawab where id=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id", string.Format("%{0}%", id.ToString()));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaLengkap = dtr["nama_lengkap"].ToString();
                            item.NoHP = dtr["nohp"].ToString();
                            item.Email = dtr["email"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadById PenanggungJawab error: {0}", ex.Message);
            }
            return item;
        }

    }
}
