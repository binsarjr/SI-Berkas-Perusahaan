
namespace SI_Berkas_Perusahaan.View
{
    partial class FrmEntryJenisBerkas
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvwJenisBerkas = new System.Windows.Forms.ListView();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.lvwJenisBerkas);
            this.groupBox1.Location = new System.Drawing.Point(36, 222);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 286);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabel Jenis Berkas";
            // 
            // btnCari
            // 
            this.btnCari.ForeColor = System.Drawing.Color.Black;
            this.btnCari.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCari.Location = new System.Drawing.Point(612, 38);
            this.btnCari.Name = "btnCari";
            this.btnCari.Size = new System.Drawing.Size(118, 32);
            this.btnCari.TabIndex = 12;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(6, 41);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(600, 26);
            this.txtCari.TabIndex = 13;
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyUp);
            // 
            // lvwJenisBerkas
            // 
            this.lvwJenisBerkas.HideSelection = false;
            this.lvwJenisBerkas.Location = new System.Drawing.Point(6, 73);
            this.lvwJenisBerkas.Name = "lvwJenisBerkas";
            this.lvwJenisBerkas.Size = new System.Drawing.Size(724, 207);
            this.lvwJenisBerkas.TabIndex = 0;
            this.lvwJenisBerkas.UseCompatibleStateImageBehavior = false;
            this.lvwJenisBerkas.SelectedIndexChanged += new System.EventHandler(this.lvwJenisBerkas_SelectedIndexChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(321, 67);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(242, 26);
            this.txtNama.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(317, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Nama";
            // 
            // txtKode
            // 
            this.txtKode.Location = new System.Drawing.Point(17, 67);
            this.txtKode.Name = "txtKode";
            this.txtKode.Size = new System.Drawing.Size(242, 26);
            this.txtKode.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Kode";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(135, 131);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(118, 35);
            this.btnUpdate.TabIndex = 17;
            this.btnUpdate.Text = "Perbaiki";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnTambah
            // 
            this.btnTambah.Location = new System.Drawing.Point(11, 131);
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.Size = new System.Drawing.Size(118, 35);
            this.btnTambah.TabIndex = 16;
            this.btnTambah.Text = "Tambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(259, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(118, 35);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Hapus";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(383, 131);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(118, 35);
            this.btnReset.TabIndex = 19;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txtKode);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtNama);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(36, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(736, 180);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Entri";
            // 
            // FrmEntryJenisBerkas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 523);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmEntryJenisBerkas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Entry Jenis Berkas";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwJenisBerkas;
        private System.Windows.Forms.TextBox txtNama;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
    }
}