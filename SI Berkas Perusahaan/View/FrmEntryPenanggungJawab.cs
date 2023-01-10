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
    public partial class FrmEntryPenanggungJawab : Form
    {
        private List<PenanggungJawab> listOfPenanggungJawab = new List<PenanggungJawab>();
        private PenanggungJawabController controller = new PenanggungJawabController();
        private PenanggungJawab penanggungJawab = null;
        public FrmEntryPenanggungJawab()
        {
            InitializeComponent();
            InitializeListView();
            LoadAllDataPenanggungJawab();
        }

        private void InitializeListView()
        {
            lvwPenanggungJawab.View = System.Windows.Forms.View.Details;
            lvwPenanggungJawab.FullRowSelect = true;
            lvwPenanggungJawab.GridLines = true;

            lvwPenanggungJawab.Columns.Add("No.", 35, HorizontalAlignment.Center);
            lvwPenanggungJawab.Columns.Add("Nama Lengkap", 200, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("No HP", 100, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("Email", 200, HorizontalAlignment.Left);
        }

        private void ResetForm()
        {
            penanggungJawab = null;
            txtEmail.Text = "";
            txtNamaLengkap.Text = "";
            txtNoHP.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            if (this.lvwPenanggungJawab.SelectedIndices.Count > 0)
                for (int i = 0; i < this.lvwPenanggungJawab.SelectedIndices.Count; i++)
                {
                    this.lvwPenanggungJawab.Items[this.lvwPenanggungJawab.SelectedIndices[i]].Selected = false;
                }
        }
        private void LoadAllDataPenanggungJawab()
        {
            LoadDataPenanggungJawab(controller.ReadAll());

        }

        private void LoadDataPenanggungJawab(List<PenanggungJawab> items)
        {
            lvwPenanggungJawab.Items.Clear();
            listOfPenanggungJawab.Clear();
            foreach (var item in items)
            {
                var no = lvwPenanggungJawab.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.NamaLengkap);
                itemView.SubItems.Add(item.NoHP);
                itemView.SubItems.Add(item.Email);
                listOfPenanggungJawab.Add(item);
                lvwPenanggungJawab.Items.Add(itemView);
            }
            // setiap kali load data baru object penanggung jawab dikosongkan
            ResetForm();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            var penanggungJawab = new PenanggungJawab
            {
                NamaLengkap = txtNamaLengkap.Text,
                Email = txtEmail.Text,
                NoHP = txtNoHP.Text
            };
            int result = controller.Create(penanggungJawab);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil ditambahkan !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);

                LoadAllDataPenanggungJawab();
                txtNamaLengkap.Select();
            }
            else
            {
                MessageBox.Show("Data gagal ditambahkan !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (penanggungJawab == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            penanggungJawab.Email = txtEmail.Text;
            penanggungJawab.NamaLengkap = txtNamaLengkap.Text;
            penanggungJawab.NoHP = txtNoHP.Text;

            int result = controller.Update(penanggungJawab);
            if (result > 0)
            {
                MessageBox.Show("Data berhasil diperbaiki !", "Informasi",
               MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadAllDataPenanggungJawab();
            }
            else
            {
                MessageBox.Show("Data gagal diperbaiki !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void lvwPenanggungJawab_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEmail.Text = "";
            txtNamaLengkap.Text = "";
            txtNoHP.Text = "";
            if (lvwPenanggungJawab.SelectedItems.Count > 0)
            {
                // ubah object penanggung jawab dengan data yang di select
                penanggungJawab = listOfPenanggungJawab[lvwPenanggungJawab.SelectedIndices[0]];
                txtEmail.Text = penanggungJawab.Email;
                txtNamaLengkap.Text = penanggungJawab.NamaLengkap;
                txtNoHP.Text = penanggungJawab.NoHP;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
            else
            {
                penanggungJawab = null;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (penanggungJawab == null)
            {
                MessageBox.Show("Data belum dipilih !!!", "Peringatan",
               MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (MessageBox.Show("Apakah kamu yakin?", "Peringatan", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)
            {

                int result = controller.Delete(penanggungJawab);
                if (result > 0)
                {
                    MessageBox.Show("Data berhasil dihapus !", "Informasi",
                   MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadAllDataPenanggungJawab();
                }
                else
                {
                    MessageBox.Show("Data gagal dihapus !!!", "Peringatan",
                   MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            ResetForm();
        }

        private void btnCari_Click(object sender, EventArgs e)
        {
            LoadDataPenanggungJawab(controller.ReadByName(txtCari.Text));

        }


        private void txtCari_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnCari.PerformClick();
        }
    }
}
