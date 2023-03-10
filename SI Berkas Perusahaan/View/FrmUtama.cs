using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SI_Berkas_Perusahaan.View
{
    public partial class FrmUtama : Form
    {
        public FrmUtama()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void penanggungJawabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEntryPenanggungJawab = new FrmEntryPenanggungJawab();
            frmEntryPenanggungJawab.ShowDialog();
        }

        private void keluarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void jenisBerkasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEntryJenisBerkas = new FrmEntryJenisBerkas();
            frmEntryJenisBerkas.ShowDialog();
        }

        private void berkasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmTransaksiBerkas = new FrmTransaksiBerkas();
            frmTransaksiBerkas.ShowDialog();
        }

        private void FrmUtama_Load(object sender, EventArgs e)
        {

        }
    }
}
