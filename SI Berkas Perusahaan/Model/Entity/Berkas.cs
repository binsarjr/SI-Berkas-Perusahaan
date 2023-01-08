using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Berkas_Perusahaan.Model.Entity
{
    public class Berkas
    {
        public JenisBerkas JenisBerkas { get; set; }
        public JenisBerkas PenanggungJawab { get; set; }
        public string NamaBerkas { get; set; }
        public DateTime TanggalMasuk { get; set; }
    }
}
