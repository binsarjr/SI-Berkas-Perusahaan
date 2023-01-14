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
    public class PenanggungJawabController
    {
        private PenanggungJawabRepository _repository;

        /**
         * Memvalidasi data data sebelum masuk ke proses utama
         */
        private bool Validate(PenanggungJawab penanggungJawab)
        {
            if (penanggungJawab.NamaLengkap == "")
            {
                MessageBox.Show("Nama Lengkap Wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (penanggungJawab.Email == "")
            {
                MessageBox.Show("Email Wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (penanggungJawab.NoHP == "")
            {
                MessageBox.Show("No HP Wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }
            
        public int Create(PenanggungJawab penanggungJawab)
        {
            int result = 0;
            if (!Validate(penanggungJawab)) return 0;

            using (DbContext context = new DbContext())
            {
                _repository = new PenanggungJawabRepository(context);
                result = _repository.Create(penanggungJawab);
            }
            return result;
        }
        public int Update(PenanggungJawab penanggungJawab)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new PenanggungJawabRepository(context);
                result = _repository.Update(penanggungJawab);
            }
            return result;
        }

        public int Delete(PenanggungJawab penanggungJawab)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new PenanggungJawabRepository(context);
                result = _repository.Delete(penanggungJawab);
            }
            return result;
        }

        public List<PenanggungJawab> ReadAll()
        {
            var items = new List<PenanggungJawab>();

            using (DbContext context = new DbContext())
            {
                _repository = new PenanggungJawabRepository(context);

                items = _repository.ReadAll();
            }

            return items;
        }
        public List<PenanggungJawab> ReadByName(string nama)
        {
            var items = new List<PenanggungJawab>();

            using (DbContext context = new DbContext())
            {
                _repository = new PenanggungJawabRepository(context);

                items = _repository.ReadByName(nama);
            }

            return items;
        }
    }
}
