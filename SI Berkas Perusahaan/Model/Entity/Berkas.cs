using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SI_Berkas_Perusahaan.Model.Entity
{
    public class Berkas
    {
        public int Id { get; set; }
        public JenisBerkas JenisBerkas { get; set; }
        public PenanggungJawab PenanggungJawab { get; set; }
        public string NamaBerkas { get; set; }
        public DateTime TanggalMasuk { get; set; }
    }
}
