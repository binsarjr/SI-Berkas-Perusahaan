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
        public FrmEntryPenanggungJawab()
        {
            InitializeComponent();
            InitializeListView();
            LoadDataPenanggungJawab(controller.ReadAll());
        }

        private void InitializeListView()
        {
            lvwPenanggungJawab.View = System.Windows.Forms.View.Details;
            lvwPenanggungJawab.FullRowSelect = true;
            lvwPenanggungJawab.GridLines = true;

            lvwPenanggungJawab.Columns.Add("No.",35, HorizontalAlignment.Center);
            lvwPenanggungJawab.Columns.Add("Nama Lengkap", 200, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("No HP", 100, HorizontalAlignment.Left);
            lvwPenanggungJawab.Columns.Add("Email", 200, HorizontalAlignment.Left);
        }

        private void LoadDataPenanggungJawab(List<PenanggungJawab> items)
        {
            lvwPenanggungJawab.Items.Clear();
            foreach(var item in items) {
                var no = lvwPenanggungJawab.Items.Count + 1;
                var itemView = new ListViewItem(no.ToString());
                itemView.SubItems.Add(item.NamaLengkap);
                itemView.SubItems.Add(item.NoHP);
                itemView.SubItems.Add(item.Email);
                lvwPenanggungJawab.Items.Add(itemView);
            }
        }

    }
}
