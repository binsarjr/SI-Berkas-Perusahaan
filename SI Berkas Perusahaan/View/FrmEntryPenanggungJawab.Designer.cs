
namespace SI_Berkas_Perusahaan.View
{
    partial class FrmEntryPenanggungJawab
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmEntryPenanggungJawab));
            this.label1 = new System.Windows.Forms.Label();
            this.txtNamaLengkap = new System.Windows.Forms.TextBox();
            this.txtNoHP = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lvwPenanggungJawab = new System.Windows.Forms.ListView();
            this.btnTambah = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtCari = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCari = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // txtNamaLengkap
            // 
            resources.ApplyResources(this.txtNamaLengkap, "txtNamaLengkap");
            this.txtNamaLengkap.Name = "txtNamaLengkap";
            // 
            // txtNoHP
            // 
            resources.ApplyResources(this.txtNoHP, "txtNoHP");
            this.txtNoHP.Name = "txtNoHP";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // txtEmail
            // 
            resources.ApplyResources(this.txtEmail, "txtEmail");
            this.txtEmail.Name = "txtEmail";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCari);
            this.groupBox1.Controls.Add(this.txtCari);
            this.groupBox1.Controls.Add(this.lvwPenanggungJawab);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lvwPenanggungJawab
            // 
            this.lvwPenanggungJawab.HideSelection = false;
            resources.ApplyResources(this.lvwPenanggungJawab, "lvwPenanggungJawab");
            this.lvwPenanggungJawab.Name = "lvwPenanggungJawab";
            this.lvwPenanggungJawab.UseCompatibleStateImageBehavior = false;
            this.lvwPenanggungJawab.SelectedIndexChanged += new System.EventHandler(this.lvwPenanggungJawab_SelectedIndexChanged);
            // 
            // btnTambah
            // 
            resources.ApplyResources(this.btnTambah, "btnTambah");
            this.btnTambah.Name = "btnTambah";
            this.btnTambah.UseVisualStyleBackColor = true;
            this.btnTambah.Click += new System.EventHandler(this.btnTambah_Click);
            // 
            // btnUpdate
            // 
            resources.ApplyResources(this.btnUpdate, "btnUpdate");
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnDelete, "btnDelete");
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtCari
            // 
            resources.ApplyResources(this.txtCari, "txtCari");
            this.txtCari.Name = "txtCari";
            this.txtCari.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCari_KeyUp);
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
            resources.ApplyResources(this.groupBox2, "groupBox2");
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.TabStop = false;
            // 
            // btnCari
            // 
            this.btnCari.ForeColor = System.Drawing.Color.Black;
            resources.ApplyResources(this.btnCari, "btnCari");
            this.btnCari.Name = "btnCari";
            this.btnCari.UseVisualStyleBackColor = true;
            this.btnCari.Click += new System.EventHandler(this.btnCari_Click);
            // 
            // FrmEntryPenanggungJawab
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Name = "FrmEntryPenanggungJawab";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNamaLengkap;
        private System.Windows.Forms.TextBox txtNoHP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lvwPenanggungJawab;
        private System.Windows.Forms.Button btnTambah;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtCari;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCari;
    }
}