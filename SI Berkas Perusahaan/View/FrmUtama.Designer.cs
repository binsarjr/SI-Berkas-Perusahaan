﻿
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
            this.referensiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.penanggungJawabToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jenisBerkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transaksiBerkasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.referensiToolStripMenuItem,
            this.transaksiBerkasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 1, 0, 1);
            this.menuStrip1.Size = new System.Drawing.Size(533, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // referensiToolStripMenuItem
            // 
            this.referensiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.penanggungJawabToolStripMenuItem,
            this.jenisBerkasToolStripMenuItem});
            this.referensiToolStripMenuItem.Name = "referensiToolStripMenuItem";
            this.referensiToolStripMenuItem.Size = new System.Drawing.Size(67, 22);
            this.referensiToolStripMenuItem.Text = "Referensi";
            // 
            // penanggungJawabToolStripMenuItem
            // 
            this.penanggungJawabToolStripMenuItem.Name = "penanggungJawabToolStripMenuItem";
            this.penanggungJawabToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.J)));
            this.penanggungJawabToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.penanggungJawabToolStripMenuItem.Text = "Penanggung Jawab";
            this.penanggungJawabToolStripMenuItem.Click += new System.EventHandler(this.penanggungJawabToolStripMenuItem_Click);
            // 
            // jenisBerkasToolStripMenuItem
            // 
            this.jenisBerkasToolStripMenuItem.Name = "jenisBerkasToolStripMenuItem";
            this.jenisBerkasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.jenisBerkasToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.jenisBerkasToolStripMenuItem.Text = "Jenis Berkas";
            // 
            // transaksiBerkasToolStripMenuItem
            // 
            this.transaksiBerkasToolStripMenuItem.Name = "transaksiBerkasToolStripMenuItem";
            this.transaksiBerkasToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.transaksiBerkasToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.transaksiBerkasToolStripMenuItem.Text = "Transaksi Berkas";
            // 
            // FrmUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmUtama";
            this.Text = "FrmUtama";
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
    }
}