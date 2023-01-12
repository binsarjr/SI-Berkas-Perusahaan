
namespace SI_Berkas_Perusahaan.View
{
    partial class FrmUtama
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.keluarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penanggungJawabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jenisBerkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBerkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.berkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.referensiToolStripMenuItem,
            this.transaksiBerkasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.keluarToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // keluarToolStripMenuItem
            // 
            this.keluarToolStripMenuItem.Name = "keluarToolStripMenuItem";
            this.keluarToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.keluarToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.keluarToolStripMenuItem.Text = "Keluar";
            this.keluarToolStripMenuItem.Click += new System.EventHandler(this.keluarToolStripMenuItem_Click);
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penanggungJawabToolStripMenuItem,
            this.jenisBerkasToolStripMenuItem});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(99, 29);
            this.referensiToolStripMenuItem.Text = "Referensi";
            // 
            // penanggungJawabToolStripMenuItem
            // 
            this.penanggungJawabToolStripMenuItem.Name = "penanggungJawabToolStripMenuItem";
            this.penanggungJawabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.penanggungJawabToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.penanggungJawabToolStripMenuItem.Text = "Penanggung Jawab";
            this.penanggungJawabToolStripMenuItem.Click += new System.EventHandler(this.penanggungJawabToolStripMenuItem_Click);
            // 
            // jenisBerkasToolStripMenuItem
            // 
            this.jenisBerkasToolStripMenuItem.Name = "jenisBerkasToolStripMenuItem";
            this.jenisBerkasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.jenisBerkasToolStripMenuItem.Size = new System.Drawing.Size(324, 34);
            this.jenisBerkasToolStripMenuItem.Text = "Jenis Berkas";
            this.jenisBerkasToolStripMenuItem.Click += new System.EventHandler(this.jenisBerkasToolStripMenuItem_Click);
            // 
            // transaksiBerkasToolStripMenuItem
            // 
            this.transaksiBerkasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.berkasToolStripMenuItem});
            this.transaksiBerkasToolStripMenuItem.Name = "transaksiBerkasToolStripMenuItem";
            this.transaksiBerkasToolStripMenuItem.Size = new System.Drawing.Size(98, 29);
            this.transaksiBerkasToolStripMenuItem.Text = "Transaksi";
            // 
            // berkasToolStripMenuItem
            // 
            this.berkasToolStripMenuItem.Name = "berkasToolStripMenuItem";
            this.berkasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.berkasToolStripMenuItem.Size = new System.Drawing.Size(229, 34);
            this.berkasToolStripMenuItem.Text = "Berkas";
            this.berkasToolStripMenuItem.Click += new System.EventHandler(this.berkasToolStripMenuItem_Click);
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmUtama";
            this.Text = "SI Pendataan Berkas";
            this.Load += new System.EventHandler(this.FrmUtama_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem referensiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem penanggungJawabToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jenisBerkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transaksiBerkasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem keluarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem berkasToolStripMenuItem;
    }
}