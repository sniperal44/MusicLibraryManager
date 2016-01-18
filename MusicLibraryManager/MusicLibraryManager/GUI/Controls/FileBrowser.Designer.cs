﻿namespace MusicLibraryManager.GUI.Controls
{
    partial class FileBrowser
    {
        /// <summary> 
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sceltaCheckBoxToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselezionaTuttoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sceltaCheckBoxToolStripMenuItem,
            this.deselezionaTuttoToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(169, 70);
            // 
            // sceltaCheckBoxToolStripMenuItem
            // 
            this.sceltaCheckBoxToolStripMenuItem.Name = "sceltaCheckBoxToolStripMenuItem";
            this.sceltaCheckBoxToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.sceltaCheckBoxToolStripMenuItem.Text = "Scelta CheckBox";
            this.sceltaCheckBoxToolStripMenuItem.Click += new System.EventHandler(this.sceltaCheckBoxToolStripMenuItem_Click);
            // 
            // deselezionaTuttoToolStripMenuItem
            // 
            this.deselezionaTuttoToolStripMenuItem.Name = "deselezionaTuttoToolStripMenuItem";
            this.deselezionaTuttoToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.deselezionaTuttoToolStripMenuItem.Text = "Deseleziona Tutto";
            this.deselezionaTuttoToolStripMenuItem.Click += new System.EventHandler(this.deselezionaTuttoToolStripMenuItem_Click);
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.DoubleBuffered = true;
            this.Name = "FileBrowser";
            this.Size = new System.Drawing.Size(926, 513);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FileBrowser_MouseDown);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sceltaCheckBoxToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselezionaTuttoToolStripMenuItem;
    }
}
