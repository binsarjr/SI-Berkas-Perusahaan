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
    public class JenisBerkasRepository
    {
        private SQLiteConnection _conn;
        public JenisBerkasRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(JenisBerkas item)
        {
            int result = 0;

            string sql = @"INSERT INTO jenis_berkas (kode,nama) values (@kode, @nama)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kode", item.Kode);
                cmd.Parameters.AddWithValue("@nama", item.Nama);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Jenis Berkas error: {0}", ex.Message);
                }

            }

            return result;
        }

        public int Update(JenisBerkas item)
        {
            int result = 0;

            string sql = @"update jenis_berkas set nama=@nama where kode=@kode";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@nama", item.Nama);
                cmd.Parameters.AddWithValue("@kode", item.Kode);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update Jenis Berkas error: {0}", ex.Message);
                }

            }

            return result;
        }
        public int Delete(JenisBerkas item)
        {
            int result = 0;

            string sql = @"DELETE FROM jenis_berkas WHERE kode=@kode";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@kode", item.Kode);
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
        public List<JenisBerkas> ReadAll(string nama = "")
        {
            var items = new List<JenisBerkas>();


            try
            {
                string sql = @"select kode,nama
 from jenis_berkas
 order by nama";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new JenisBerkas();
                            item.Nama = dtr["nama"].ToString();
                            item.Kode = dtr["kode"].ToString();
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll JenisBerkas error: {0}", ex.Message);
            }

            return items;
        }

        public List<JenisBerkas> ReadByName(string nama)
        {
            var items = new List<JenisBerkas>();


            try
            {
                string sql = @"select kode,nama
 from jenis_berkas where nama like @nama
 order by nama";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama", string.Format("%{0}%", nama));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new JenisBerkas();
                            item.Nama = dtr["nama"].ToString();
                            item.Kode = dtr["kode"].ToString();
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
