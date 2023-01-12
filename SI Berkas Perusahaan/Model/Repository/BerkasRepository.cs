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
    public class BerkasRepository
    {
        private SQLiteConnection _conn;
        public BerkasRepository(DbContext context)
        {
            _conn = context.Conn;
        }

        public int Create(Berkas item)
        {
            int result = 0;

            string sql = @"INSERT INTO transaksi_berkas
                (id_penanggung_jawab, nama_berkas, kode_jenis_berkas, tgl_masuk)
                values
                (@penanggung_jawab, @nama, @jenis_berkas, @tgl_masuk)";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@penanggung_jawab", item.PenanggungJawab.Id);
                cmd.Parameters.AddWithValue("@nama", item.NamaBerkas);
                cmd.Parameters.AddWithValue("@jenis_berkas", item.JenisBerkas.Kode);
                cmd.Parameters.AddWithValue("@tgl_masuk", item.TanggalMasuk.ToString());
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Create Transaksi Berkas error: {0}", ex.Message);
                }

            }

            return result;
        }

        public int Update(Berkas item)
        {
            int result = 0;

            string sql = @"update transaksi_berkas set
                    id_penanggung_jawab=@penanggung_jawab,
                    nama_berkas=@nama,
                    kode_jenis_berkas=@jenis_berkas,
                    tgl_masuk=@tgl_masuk
                    where id=@id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@penanggung_jawab", item.PenanggungJawab.Id);
                cmd.Parameters.AddWithValue("@nama", item.NamaBerkas);
                cmd.Parameters.AddWithValue("@jenis_berkas", item.JenisBerkas.Kode);
                cmd.Parameters.AddWithValue("@tgl_masuk", item.TanggalMasuk.ToString());
                cmd.Parameters.AddWithValue("@id", item.Id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Update Transaksi Berkas error: {0}", ex.Message);
                }

            }

            return result;
        }
        public int Delete(Berkas item)
        {
            int result = 0;

            string sql = @"DELETE FROM transaksi_berkas WHERE id=@id";
            using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
            {
                cmd.Parameters.AddWithValue("@id", item.Id);
                try
                {
                    result = cmd.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    System.Diagnostics.Debug.Print("Delete Transaksi Berkas error: {0}", ex.Message);
                }

            }

            return result;
        }
        public List<Berkas> ReadAll()
        {
            var items = new List<Berkas>();


            try
            {
                string sql = @"select 
transaksi_berkas.id, id_penanggung_jawab,kode_jenis_berkas, nama_berkas, tgl_masuk, jenis_berkas.nama as jenis_berkas,
email,nama_lengkap, nohp
 from transaksi_berkas
 join penanggung_jawab on penanggung_jawab.id=transaksi_berkas.id_penanggung_jawab
 join jenis_berkas on jenis_berkas.kode=transaksi_berkas.kode_jenis_berkas
 order by nama_berkas";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new Berkas();
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaBerkas = dtr["nama_berkas"].ToString();
                            item.TanggalMasuk = DateTime.Parse(dtr["tgl_masuk"].ToString());
                            item.PenanggungJawab = new PenanggungJawab()
                            {
                                Id = Convert.ToInt32(dtr["id_penanggung_jawab"].ToString()),
                                Email= dtr["email"].ToString(),
                                NamaLengkap = dtr["nama_lengkap"].ToString(),
                                NoHP = dtr["nohp"].ToString()
                            };
                            item.JenisBerkas = new JenisBerkas()
                            {
                                Kode = dtr["kode_jenis_berkas"].ToString(),
                                Nama = dtr["jenis_berkas"].ToString(),
                            };
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadAll Transaksi Berkas error: {0}", ex.Message);
            }

            return items;
        }

        public List<Berkas> ReadByName(string nama)
        {
            var items = new List<Berkas>();


            try
            {
                string sql = @"select 
transaksi_berkas.id, id_penanggung_jawab,kode_jenis_berkas, nama_berkas, tgl_masuk, jenis_berkas.nama as jenis_berkas,
email,nama_lengkap, nohp
 from transaksi_berkas
 join penanggung_jawab on penanggung_jawab.id=transaksi_berkas.id_penanggung_jawab
 join jenis_berkas on jenis_berkas.kode=transaksi_berkas.kode_jenis_berkas
where nama_berkas like @nama_berkas
 order by nama_berkas";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@nama_berkas", string.Format("%{0}%", nama));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            var item = new Berkas();
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaBerkas = dtr["nama_berkas"].ToString();
                            item.TanggalMasuk = DateTime.Parse(dtr["tgl_masuk"].ToString());
                            item.PenanggungJawab= new PenanggungJawab()
                            {
                                Id = Convert.ToInt32(dtr["id_penanggung_jawab"].ToString()),
                                Email = dtr["email"].ToString(),
                                NamaLengkap = dtr["nama_lengkap"].ToString(),
                                NoHP = dtr["nohp"].ToString()
                            };
                            item.JenisBerkas = new JenisBerkas()
                            {
                                Kode = dtr["kode_jenis_berkas"].ToString(),
                                Nama = dtr["jenis_berkas"].ToString(),
                            };
                            items.Add(item);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadByName Transaksi Berkas error: {0}", ex.Message);
            }

            return items;
        }

        public Berkas ReadById(int id)
        {
            Berkas item = null;
            try
            {
                string sql = @"select 
transaksi_berkas.id, id_penanggung_jawab,kode_jenis_berkas, nama_berkas, tgl_masuk, jenis_berkas.nama as jenis_berkas,
email,nama_lengkap, nohp
 from transaksi_berkas
 join penanggung_jawab on penanggung_jawab.id=transaksi_berkas.id_penanggung_jawab
 join jenis_berkas on jenis_berkas.kode=transaksi_berkas.kode_jenis_berkas
where id=@id";
                using (SQLiteCommand cmd = new SQLiteCommand(sql, _conn))
                {
                    cmd.Parameters.AddWithValue("@id", string.Format("%{0}%", id.ToString()));
                    using (SQLiteDataReader dtr = cmd.ExecuteReader())
                    {
                        while (dtr.Read())
                        {
                            item.Id = Convert.ToInt32(dtr["id"].ToString());
                            item.NamaBerkas = dtr["nama_berkas"].ToString();
                            item.TanggalMasuk = DateTime.Parse(dtr["tgl_masuk"].ToString());
                            item.PenanggungJawab = new PenanggungJawab()
                            {
                                Id = Convert.ToInt32(dtr["id_penanggung_jawab"].ToString()),
                                Email = dtr["email"].ToString(),
                                NamaLengkap = dtr["nama_lengkap"].ToString(),
                                NoHP = dtr["nohp"].ToString()
                            };
                            item.JenisBerkas = new JenisBerkas()
                            {
                                Kode = dtr["kode_jenis_berkas"].ToString(),
                                Nama = dtr["jenis_berkas"].ToString(),
                            };
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.Print("ReadById Transaksi Berkas error: {0}", ex.Message);
            }
            return item;
        }
    }
}
