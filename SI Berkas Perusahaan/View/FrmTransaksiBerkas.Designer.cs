
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
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.lvwPenanggungJawab = new System.Windows.Forms.ListView();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnTambah = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama Lengkap";
            // 
            // txtNamaLengkap
            // 
            this.txtNamaLengkap.Location = new System.Drawing.Point(22, 69);
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            this.txtNamaLengkap.Size = new System.Drawing.Size(242, 26);
            this.txtNamaLengkap.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "No HP.";
            // 
            // txtNoHP
            // 
            this.txtNoHP.Location = new System.Drawing.Point(23, 146);
            this.txtNoHP.Name = "txtNoHP";
            this.txtNoHP.Size = new System.Drawing.Size(242, 26);
            this.txtNoHP.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(295, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(300, 69);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(242, 26);
            this.txtEmail.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.lvwPenanggungJawab);
            this.groupBox1.Location = new System.Drawing.Point(32, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 294);
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
            this.btnCari.Size = new System.Drawing.Size(118, 36);
            this.btnCari.TabIndex = 11;
            this.btnCari.Text = "Cari";
            this.btnCari.UseVisualStyleBackColor = true;
            // 
            // txtCari
            // 
            this.txtCari.Location = new System.Drawing.Point(6, 35);
            this.txtCari.Name = "txtCari";
            this.txtCari.Size = new System.Drawing.Size(600, 26);
            this.txtCari.TabIndex = 11;
            // 
            // lvwPenanggungJawab
            // 
            this.lvwPenanggungJawab.HideSelection = false;
            this.lvwPenanggungJawab.Location = new System.Drawing.Point(6, 76);
            this.lvwPenanggungJawab.Name = "lvwPenanggungJawab";
            this.lvwPenanggungJawab.Size = new System.Drawing.Size(724, 201);
            this.lvwPenanggungJawab.TabIndex = 0;
            this.lvwPenanggungJawab.UseCompatibleStateImageBehavior = false;
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
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnReset);
            this.groupBox2.Controls.Add(this.txtNamaLengkap);
            this.groupBox2.Controls.Add(this.btnDelete);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnUpdate);
            this.groupBox2.Controls.Add(this.txtNoHP);
            this.groupBox2.Controls.Add(this.btnTambah);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtEmail);
            this.groupBox2.Location = new System.Drawing.Point(32, 43);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(737, 256);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Data Entri";
            // 
            // FrmTransaksiBerkas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 662);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmTransaksiBerkas";
            this.Text = "FrmTransaksiBerkas";
            this.Load += new System.EventHandler(this.FrmTransaksiBerkas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvwPenanggungJawab;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}