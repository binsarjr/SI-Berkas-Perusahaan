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
    public partial class FrmEntryJenisBerkas : Form
    {

        private List<JenisBerkas> listOfJenisBerkas = new List<JenisBerkas>();
        private JenisBerkasController controller = new JenisBerkasController();
        private JenisBerkas jenisBerkas = null;
        public FrmEntryJenisBerkas()
        {
            InitializeComponent();
            InitializeListView();
            LoadDataJenisBerkas();
        }
        private void InitializeListView()
        {
            lvwJenisBerkas.View = System.Windows.Forms.View.Details;
            lvwJenisBerkas.FullRowSelect = true;
            lvwJenisBerkas.GridLines = true;

            lvwJenisBerkas.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwJenisBerkas.Columns.Add("Kode", 100, HorizontalAlignment.Left);
            lvwJenisBerkas.Columns.Add("Nama", 100, HorizontalAlignment.Left);
        }

        private void LoadDataJenisBerkas()
        {
            lvwJenisBerkas.Items.Clear();
            listOfJenisBerkas = controller.ReadByName(txtCari.Text);
            foreach (var item in listOfJenisBerkas)
            {
                var no = lvwJenisBerkas.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.Kode);
                itemView.SubItems.Add(item.Nama);
                lvwJenisBerkas.Items.Add(itemView);
            }
            ResetForm();
        }
        private void ResetForm()
        {
            txtKode.Text = "";
            txtKode.Enabled = true;
            txtNama.Text = "";
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            if (this.lvwJenisBerkas.SelectedIndices.Count > 0)
                for (int i = 0; i < this.lvwJenisBerkas.SelectedIndices.Count; i++)
                {
                    this.lvwJenisBerkas.Items[this.lvwJenisBerkas.SelectedIndices[i]].Selected = false;
                }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            JenisBerkas item = new JenisBerkas
            {
                Nama = txtNama.Text,
                Kode = txtKode.Text
            };
            int result = controller.Create(item);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadDataJenisBerkas();
                txtKode.Select();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (jenisBerkas == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            jenisBerkas.Kode = txtKode.Text;
            jenisBerkas.Nama = txtNama.Text;

            int result = controller.Update(jenisBerkas);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbaiki !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadDataJenisBerkas();
            }
            else
            {
                MessageBox.Show("Data gagal diperbaiki !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lvwJenisBerkas_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtKode.Text = "";
            txtNama.Text = "";
            // jika ada baris yang diklik/dipilih
            if (lvwJenisBerkas.SelectedItems.Count > 0)
            {
                // ubah object penanggung jawab dengan data yang di select
                jenisBerkas = listOfJenisBerkas[lvwJenisBerkas.SelectedIndices[0]];
                txtKode.Text = jenisBerkas.Kode;
                txtNama.Text = jenisBerkas.Nama;

                txtKode.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                jenisBerkas = null;
                txtKode.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (jenisBerkas == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Apakah kamu yakin?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {
                int result = controller.Delete(jenisBerkas);
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus !", "Informasi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadDataJenisBerkas();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataJenisBerkas();
        }

        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                btnCari.PerformClick();
            }
        }
    }
}
