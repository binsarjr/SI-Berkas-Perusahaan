using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using SI_Berkas_Perusahaan.Model.Repository;
using SI_Berkas_Perusahaan.Model.Entity;
using SI_Berkas_Perusahaan.Model.Context;
using System.Windows.Forms;

namespace SI_Berkas_Perusahaan.Controller
{
    public class JenisBerkasController
    {
        private JenisBerkasRepository _repository;

        /**
         * Memvalidasi data data sebelum masuk ke proses utama
         */
        private bool Validate(JenisBerkas item)
        {
            if (item.Nama== "")
            {
                MessageBox.Show("Nama Wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (item.Kode == "")
            {
                MessageBox.Show("Kode nWajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        public int Create(JenisBerkas item)
        {
            int result = 0;
            if (!Validate(item)) return 0;

            using (DbContext context = new DbContext())
            {
                _repository = new JenisBerkasRepository(context);
                result = _repository.Create(item);
            }
            return result;
        }
        public int Update(JenisBerkas item)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new JenisBerkasRepository(context);
                result = _repository.Update(item);
            }
            return result;
        }

        public int Delete(JenisBerkas item)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new JenisBerkasRepository(context);
                result = _repository.Delete(item);
            }
            return result;
        }

        public List<JenisBerkas> ReadAll()
        {
            var items = new List<JenisBerkas>();

            using (DbContext context = new DbContext())
            {
                _repository = new JenisBerkasRepository(context);

                items = _repository.ReadAll();
            }

            return items;
        }
        public List<JenisBerkas> ReadByName(string nama)
        {
            var items = new List<JenisBerkas>();

            using (DbContext context = new DbContext())
            {
                _repository = new JenisBerkasRepository(context);

                items = _repository.ReadByName(nama);
            }

            return items;
        }
    }
}
