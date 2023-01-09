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
            LoadAllDataJenisBerkas();
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

        private void LoadAllDataJenisBerkas()
        {
            LoadDataJenisBerkas(controller.ReadAll());
            // setiap kali load data baru object penanggung jawab dikosongkan
            ResetForm();
        }

        private void LoadDataJenisBerkas(List<JenisBerkas> items)
        {
            lvwJenisBerkas.Items.Clear();
            listOfJenisBerkas.Clear();
            foreach (var item in items)
            {
                var no = lvwJenisBerkas.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.Kode);
                itemView.SubItems.Add(item.Nama);
                listOfJenisBerkas.Add(item);
                lvwJenisBerkas.Items.Add(itemView);
            }
        }
        private void ResetForm()
        {
            txtKode.Text = "";
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

                LoadAllDataJenisBerkas();
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
            jenisBerkas.Kode= txtKode.Text;
            jenisBerkas.Nama = txtNama.Text;

            int result = controller.Update(jenisBerkas);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbaiki !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllDataJenisBerkas();
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
            if (lvwJenisBerkas.SelectedItems.Count > 0)
            {
                // ubah object penanggung jawab dengan data yang di select
                jenisBerkas= listOfJenisBerkas[lvwJenisBerkas.SelectedIndices[0]];
                txtKode.Text = jenisBerkas.Kode;
                txtNama.Text = jenisBerkas.Nama;

                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                jenisBerkas= null;
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
            int result = controller.Delete(jenisBerkas);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil dihapus !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllDataJenisBerkas();
            }
            else
            {
                MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
