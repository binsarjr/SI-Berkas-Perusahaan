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
    public class BerkasController
    {
        private BerkasRepository _repository;

        private bool Validate(Berkas item)
        {
            if (string.IsNullOrEmpty(item.NamaBerkas))
            {
                MessageBox.Show("Nama Berkas Wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (item.JenisBerkas==null)
            {
                MessageBox.Show("Jenis Berkas wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (item.TanggalMasuk== null)
            {
                MessageBox.Show("Tanggal wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            if (item.PenanggungJawab== null)
            {
                MessageBox.Show("Penanggung jawab wajib Di isi !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }

            return true;
        }

        public int Create(Berkas item)
        {
            int result = 0;
            if (!Validate(item)) return 0;

            using (DbContext context = new DbContext())
            {
                _repository = new BerkasRepository(context);
                result = _repository.Create(item);
            }
            return result;
        }
        public int Update(Berkas item)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new BerkasRepository(context);
                result = _repository.Update(item);
            }
            return result;
        }

        public int Delete(Berkas item)
        {
            int result = 0;
            using (DbContext context = new DbContext())
            {
                _repository = new BerkasRepository(context);
                result = _repository.Delete(item);
            }
            return result;
        }

        public List<Berkas> ReadAll()
        {
            var items = new List<Berkas>();

            using (DbContext context = new DbContext())
            {
                _repository = new BerkasRepository(context);

                items = _repository.ReadAll();
            }

            return items;
        }
        public List<Berkas> ReadByName(string nama)
        {
            var items = new List<Berkas>();

            using (DbContext context = new DbContext())
            {
                _repository = new BerkasRepository(context);

                items = _repository.ReadByName(nama);
            }

            return items;
        }
    }
}
