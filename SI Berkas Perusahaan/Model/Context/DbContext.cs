using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.IO;
using System.Data.SQLite;

namespace SI_Berkas_Perusahaan.Model.Context
{
    public class DbContext:IDisposable
    {
        private SQLiteConnection _conn;
        public SQLiteConnection Conn
        {
            get
            {
                return _conn ?? (_conn = GetOpenConnection());
            }
        }
         
        private SQLiteConnection GetOpenConnection()
        {
            SQLiteConnection conn = null;
            try
            {
                string dbName = @"D:\Semester 3\Pemrograman Lanjut\Final Project\SI Berkas Perusahaan\SI Berkas Perusahaan\Database\SiPendataanBerkas.db";
                //string dbName =  Directory.GetCurrentDirectory()+ "\\Database\\SiPendataanBerkas.db";
                string connectionString = string.Format("Data Source ={0}; FailIfMissing = True", dbName);
                conn = new SQLiteConnection(connectionString); 
                conn.Open(); 
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print("Open Connection Error: {0}", ex.Message);
            }
            return conn;
        }

        public void Dispose()
        {
            if (_conn != null)
            {
                try
                {
                    if (_conn.State != ConnectionState.Closed) _conn.Close();
                }
                finally
                {
                    _conn.Dispose();
                }
            }
            GC.SuppressFinalize(this);
        }
    }
}
