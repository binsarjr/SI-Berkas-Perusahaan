using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



using SI_Berkas_Perusahaan.Controller;
using SI_Berkas_Perusahaan.Model.Entity;
using SI_Berkas_Perusahaan.Model.Context;

namespace SI_Berkas_Perusahaan.View
{
    public partial class FrmSelectPenanggungJawab : Form
    {
        private List<PenanggungJawab> listOfPenanggungJawab = new List<PenanggungJawab>();
        private PenanggungJawabController controller = new PenanggungJawabController();
        public PenanggungJawab penanggungJawab = null;
        public FrmSelectPenanggungJawab(PenanggungJawab penanggungJawab)
        {
            this.penanggungJawab = penanggungJawab;
            InitializeComponent();
            InitializeListView();
            LoadDataPenanggungJawab();
        }
        private void InitializeListView()
        {
            lvwPenanggungJawab.View = System.Windows.Forms.View.Details;
            lvwPenanggungJawab.FullRowSelect = true;
            lvwPenanggungJawab.GridLines = true;

            lvwPenanggungJawab.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPenanggungJawab.Columns.Add("Nama Lengkap", 150, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("No HP", 100, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("Email", 150, HorizontalAlignment.Left);
        }
        private void ResetForm()
        {
            penanggungJawab = null;
            if (this.lvwPenanggungJawab.SelectedIndices.Count > 0)
                for (int i = 0; i < this.lvwPenanggungJawab.SelectedIndices.Count; i++)
                {
                    this.lvwPenanggungJawab.Items[this.lvwPenanggungJawab.SelectedIndices[i]].Selected = false;
                }
        }

        private void LoadDataPenanggungJawab()
        {
            listOfPenanggungJawab = controller.ReadByName(txtCari.Text);
            lvwPenanggungJawab.Items.Clear();
            foreach (var item in listOfPenanggungJawab)
            {
                var no = lvwPenanggungJawab.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.NamaLengkap);
                itemView.SubItems.Add(item.NoHP);
                itemView.SubItems.Add(item.Email);
                lvwPenanggungJawab.Items.Add(itemView);

                if (item == penanggungJawab)
                {
                    lvwPenanggungJawab.Items[no-1].Focused = true;
                    lvwPenanggungJawab.Items[no - 1].Selected = true;
                    lvwPenanggungJawab.Items[no - 1].EnsureVisible();
                    lvwPenanggungJawab.Select();
                }

            }
            // setiap kali load data baru object penanggung jawab dikosongkan
            ResetForm();
        }

        private void lvwPenanggungJawab_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwPenanggungJawab.SelectedItems.Count > 0)
            {
                // ubah object penanggung jawab dengan data yang di select
                penanggungJawab = listOfPenanggungJawab[lvwPenanggungJawab.SelectedIndices[0]];
            }
            else
            {
                penanggungJawab = null;
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {

            LoadDataPenanggungJawab();
        }


        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) btnCari.PerformClick();
        }

        private void btnPilih_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
