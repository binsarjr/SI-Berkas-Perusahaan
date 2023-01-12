using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SI_Berkas_Perusahaan.Model.Entity;
using SI_Berkas_Perusahaan.Model.Repository;
using SI_Berkas_Perusahaan.Controller;

namespace SI_Berkas_Perusahaan.View
{
    public partial class FrmTransaksiBerkas : Form
    {
        private JenisBerkasController controllerJenisBerkas = new JenisBerkasController();
        private List<JenisBerkas> refJenisBerkas = new List<JenisBerkas>();
        private Berkas berkas = new Berkas();
        private List<Berkas> listOfBerkas = new List<Berkas>();
        private BerkasController controller = new BerkasController();
        public FrmTransaksiBerkas()
        {
            InitializeComponent();
            InitializeJenisBerkasCombobox();
            InitializeListView();
            LoadDataBerkas();
            ResetForm();
        }
        private void InitializeListView()
        {

            lvwBerkas.View = System.Windows.Forms.View.Details;
            lvwBerkas.FullRowSelect = true;
            lvwBerkas.GridLines = true;

            lvwBerkas.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwBerkas.Columns.Add("Nama Berkas", 150, HorizontalAlignment.Left);
            lvwBerkas.Columns.Add("Jenis Berkas", 130, HorizontalAlignment.Left);
            lvwBerkas.Columns.Add("Penanggung Jawab", 150, HorizontalAlignment.Left);
            lvwBerkas.Columns.Add("Tanggal Masuk", 110, HorizontalAlignment.Left);
        }

        private void LoadDataBerkas()
        {
            lvwBerkas.Items.Clear();
            listOfBerkas = controller.ReadByName(txtCari.Text);
            foreach (var item in listOfBerkas)
            {
                var no = lvwBerkas.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.NamaBerkas);
                itemView.SubItems.Add(item.JenisBerkas.Nama);
                itemView.SubItems.Add(item.PenanggungJawab.NamaLengkap);
                itemView.SubItems.Add(item.TanggalMasuk.ToString());
                lvwBerkas.Items.Add(itemView);
            }
            ResetForm();
        }
        private void ResetForm()
        {
            berkas = new Berkas();
            txtNamaBerkas.Text = "";
            dtpTanggalMasuk.ResetText();
            btnPilihPenanggungJawab.Text = "Pilih Penanggung Jawab";
            cmbJenisBerkas.SelectedIndex = 0;

            // reset selected
            if (this.lvwBerkas.SelectedIndices.Count > 0)
                for (int i = 0; i < this.lvwBerkas.SelectedIndices.Count; i++)
                {
                    this.lvwBerkas.Items[this.lvwBerkas.SelectedIndices[i]].Selected = false;
                }

            // disable button by default
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
        }
        private void InitializeJenisBerkasCombobox()
        {
            refJenisBerkas = controllerJenisBerkas.ReadAll();
            cmbJenisBerkas.Items.Clear();
            foreach (var item in refJenisBerkas)
            {
                cmbJenisBerkas.Items.Add(item.Nama);
            }
            cmbJenisBerkas.SelectedIndex = 0;
        }

        private void FrmTransaksiBerkas_Load(object sender, EventArgs e)
        {

        }

        private void cmbJenisBerkas_SelectedIndexChanged(object sender, EventArgs e)
        {
            berkas.JenisBerkas = refJenisBerkas[cmbJenisBerkas.SelectedIndex];
        }


        private void btnPilihPenanggungJawab_Click(object sender, EventArgs e)
        {

            var frmSelectPenanggungJawab = new FrmSelectPenanggungJawab(berkas.PenanggungJawab);
            if (frmSelectPenanggungJawab.ShowDialog() == DialogResult.OK)
            {
                berkas.PenanggungJawab = frmSelectPenanggungJawab.penanggungJawab;
                btnPilihPenanggungJawab.Text = berkas.PenanggungJawab.NamaLengkap;
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            berkas.NamaBerkas = txtNamaBerkas.Text;
            berkas.TanggalMasuk = dtpTanggalMasuk.Value;
            int result = controller.Create(berkas);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataBerkas();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataBerkas();
        }

        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCari.PerformClick();
        }

        private void lvwBerkas_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvwBerkas.SelectedItems.Count > 0)
            {
                // ubah object berkas dengan data yang di select
                berkas = listOfBerkas[lvwBerkas.SelectedIndices[0]];

                txtNamaBerkas.Text = berkas.NamaBerkas;
                dtpTanggalMasuk.Value = berkas.TanggalMasuk;

                btnPilihPenanggungJawab.Text = berkas.PenanggungJawab.NamaLengkap;

                int i = 0;
                foreach (var item in refJenisBerkas)
                {
                    if (item.Kode==berkas.JenisBerkas.Kode)
                    {
                        cmbJenisBerkas.SelectedIndex = i;
                        break;
                    }
                    i++;
                }

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                berkas = new Berkas();
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Apakah kamu yakin?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                int result = controller.Delete(berkas);
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus !", "Informasi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataBerkas();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            berkas.NamaBerkas = txtNamaBerkas.Text;
            berkas.TanggalMasuk = dtpTanggalMasuk.Value;
            int result = controller.Update(berkas);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbarui !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataBerkas();
            }
            else
            {
                MessageBox.Show("Data gagal diperbarui !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
