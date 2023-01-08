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
