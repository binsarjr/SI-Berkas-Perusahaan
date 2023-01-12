
namespace SI_Berkas_Perusahaan.View
{
    partial class FrmTransaksiBerkas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaBerkas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvwBerkas = new System.Windows.Forms.ListView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbJenisBerkas = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnPilihPenanggungJawab = new System.Windows.Forms.Button();
            this.dtpTanggalMasuk = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(17, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Berkas";
            // 
            // txtNamaBerkas
            // 
            this.txtNamaBerkas.Location = new System.Drawing.Point(22, 69);
            this.txtNamaBerkas.Name = "txtNamaBerkas";
            this.txtNamaBerkas.Size = new System.Drawing.Size(242, 26);
            this.txtNamaBerkas.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Penanggung Jawab";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(295, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Tanggal Masuk";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.lvwBerkas);
            this.groupBox1.Location = new System.Drawing.Point(32, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 294);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Penanggung Jawab";
            // 
            // btnCari
            // 
            this.btnCari.ForeColor = System.Drawing.Color.Black;
            this.btnCari.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCari.Location = new System.Drawing.Point(612, 34);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(269, 36);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(6, 35);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(600, 26);
            this.txtCari.TabIndex = 11;
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyUp);
            // 
            // lvwBerkas
            // 
            this.lvwBerkas.HideSelection = false;
            this.lvwBerkas.Location = new System.Drawing.Point(6, 76);
            this.lvwBerkas.Name = "lvwBerkas";
            this.lvwBerkas.Size = new System.Drawing.Size(875, 201);
            this.lvwBerkas.TabIndex = 0;
            this.lvwBerkas.UseCompatibleStateImageBehavior = false;
            this.lvwBerkas.SelectedIndexChanged += new System.EventHandler(this.lvwBerkas_SelectedIndexChanged);
            // 
            // btnReset
            // 
            this.btnReset.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnReset.Location = new System.Drawing.Point(395, 197);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 10;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            this.btnDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnDelete.Location = new System.Drawing.Point(271, 197);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 35);
            this.btnDelete.TabIndex = 9;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnUpdate.Location = new System.Drawing.Point(147, 197);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 35);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Perbaiki";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnTambah.Location = new System.Drawing.Point(23, 197);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 35);
            this.btnTambah.TabIndex = 7;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbJenisBerkas);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnPilihPenanggungJawab);
            this.groupBox2.Controls.Add(this.dtpTanggalMasuk);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txtNamaBerkas);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(32, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(887, 256);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Entri";
            // 
            // cmbJenisBerkas
            // 
            this.cmbJenisBerkas.FormattingEnabled = true;
            this.cmbJenisBerkas.Location = new System.Drawing.Point(299, 144);
            this.cmbJenisBerkas.Name = "cmbJenisBerkas";
            this.cmbJenisBerkas.Size = new System.Drawing.Size(243, 28);
            this.cmbJenisBerkas.TabIndex = 14;
            this.cmbJenisBerkas.SelectedIndexChanged += new System.EventHandler(this.cmbJenisBerkas_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(295, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Jenis Berkas";
            // 
            // btnPilihPenanggungJawab
            // 
            this.btnPilihPenanggungJawab.Location = new System.Drawing.Point(21, 144);
            this.btnPilihPenanggungJawab.Name = "btnPilihPenanggungJawab";
            this.btnPilihPenanggungJawab.Size = new System.Drawing.Size(241, 36);
            this.btnPilihPenanggungJawab.TabIndex = 12;
            this.btnPilihPenanggungJawab.Text = "Pilih Penanggung Jawab";
            this.btnPilihPenanggungJawab.UseVisualStyleBackColor = true;
            this.btnPilihPenanggungJawab.Click += new System.EventHandler(this.btnPilihPenanggungJawab_Click);
            // 
            // dtpTanggalMasuk
            // 
            this.dtpTanggalMasuk.Location = new System.Drawing.Point(299, 69);
            this.dtpTanggalMasuk.Name = "dtpTanggalMasuk";
            this.dtpTanggalMasuk.Size = new System.Drawing.Size(243, 26);
            this.dtpTanggalMasuk.TabIndex = 11;
            // 
            // FrmTransaksiBerkas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmTransaksiBerkas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entri  Transaksi Berkas";
            this.Load += new System.EventHandler(this.FrmTransaksiBerkas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaBerkas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvwBerkas;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnPilihPenanggungJawab;
        private System.Windows.Forms.DateTimePicker dtpTanggalMasuk;
        private System.Windows.Forms.ComboBox cmbJenisBerkas;
        private System.Windows.Forms.Label label4;
    }
}