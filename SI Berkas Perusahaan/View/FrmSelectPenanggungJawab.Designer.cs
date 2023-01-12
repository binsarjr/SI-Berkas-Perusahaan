
namespace SI_Berkas_Perusahaan.View
{
    partial class FrmSelectPenanggungJawab
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
            this.lvwPenanggungJawab = new System.Windows.Forms.ListView();
            this.btnPilih = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.lvwPenanggungJawab);
            this.groupBox1.Location = new System.Drawing.Point(24, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(736, 294);
            this.groupBox1.TabIndex = 7;
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
            // lvwPenanggungJawab
            // 
            this.lvwPenanggungJawab.HideSelection = false;
            this.lvwPenanggungJawab.Location = new System.Drawing.Point(6, 76);
            this.lvwPenanggungJawab.Name = "lvwPenanggungJawab";
            this.lvwPenanggungJawab.Size = new System.Drawing.Size(724, 201);
            this.lvwPenanggungJawab.TabIndex = 0;
            this.lvwPenanggungJawab.UseCompatibleStateImageBehavior = false;
            this.lvwPenanggungJawab.SelectedIndexChanged += new System.EventHandler(this.lvwPenanggungJawab_SelectedIndexChanged);
            // 
            // btnPilih
            // 
            this.btnPilih.Location = new System.Drawing.Point(554, 328);
            this.btnPilih.Name = "btnPilih";
            this.btnPilih.Size = new System.Drawing.Size(200, 36);
            this.btnPilih.TabIndex = 8;
            this.btnPilih.Text = "Pilih";
            this.btnPilih.UseVisualStyleBackColor = true;
            this.btnPilih.Click += new System.EventHandler(this.btnPilih_Click);
            // 
            // FrmSelectPenanggungJawab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 381);
            this.Controls.Add(this.btnPilih);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmSelectPenanggungJawab";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Pilih Penanggung Jawab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCari;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.ListView lvwPenanggungJawab;
        private System.Windows.Forms.Button btnPilih;
    }
}