﻿namespace MusicLibraryManager.GUI.Forms
{
    partial class MainForm
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

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.button2 = new System.Windows.Forms.Button();
            this.listBox_playlists = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.esportaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.originaleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.convertiMP3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.incorporaMetadataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.rimuoviToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fileBrowser1 = new MusicLibraryManager.GUI.Controls.FileBrowser();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(1107, 89);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 0;
            this.button2.Text = "Root";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox_playlists
            // 
            this.listBox_playlists.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_playlists.FormattingEnabled = true;
            this.listBox_playlists.Location = new System.Drawing.Point(12, 118);
            this.listBox_playlists.Name = "listBox_playlists";
            this.listBox_playlists.Size = new System.Drawing.Size(184, 459);
            this.listBox_playlists.TabIndex = 6;
            this.listBox_playlists.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listBox_playlists_MouseDoubleClick);
            this.listBox_playlists.MouseDown += new System.Windows.Forms.MouseEventHandler(this.listBox_playlists_MouseDown);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.BackgroundImage = global::MusicLibraryManager.Properties.Resources.setting;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(1132, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(50, 50);
            this.button3.TabIndex = 5;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(12, 89);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 0;
            this.button4.Text = "Crea Playlist";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.esportaToolStripMenuItem,
            this.toolStripSeparator1,
            this.incorporaMetadataToolStripMenuItem,
            this.toolStripSeparator2,
            this.toolStripMenuItem1,
            this.toolStripSeparator3,
            this.rimuoviToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(179, 110);
            // 
            // esportaToolStripMenuItem
            // 
            this.esportaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.originaleToolStripMenuItem,
            this.convertiMP3ToolStripMenuItem});
            this.esportaToolStripMenuItem.Name = "esportaToolStripMenuItem";
            this.esportaToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.esportaToolStripMenuItem.Text = "Esporta";
            // 
            // originaleToolStripMenuItem
            // 
            this.originaleToolStripMenuItem.Name = "originaleToolStripMenuItem";
            this.originaleToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.originaleToolStripMenuItem.Text = "Originale";
            this.originaleToolStripMenuItem.Click += new System.EventHandler(this.originaleToolStripMenuItem_Click);
            // 
            // convertiMP3ToolStripMenuItem
            // 
            this.convertiMP3ToolStripMenuItem.Name = "convertiMP3ToolStripMenuItem";
            this.convertiMP3ToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.convertiMP3ToolStripMenuItem.Text = "Converti MP3";
            this.convertiMP3ToolStripMenuItem.Click += new System.EventHandler(this.convertiMP3ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(175, 6);
            // 
            // incorporaMetadataToolStripMenuItem
            // 
            this.incorporaMetadataToolStripMenuItem.Name = "incorporaMetadataToolStripMenuItem";
            this.incorporaMetadataToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.incorporaMetadataToolStripMenuItem.Text = "Incorpora Metadata";
            this.incorporaMetadataToolStripMenuItem.Click += new System.EventHandler(this.incorporaMetadataToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(178, 22);
            this.toolStripMenuItem1.Text = "Check dei File";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.CheckDeiFiletoolStripMenuItem1_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // rimuoviToolStripMenuItem
            // 
            this.rimuoviToolStripMenuItem.Name = "rimuoviToolStripMenuItem";
            this.rimuoviToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.rimuoviToolStripMenuItem.Text = "Rimuovi";
            this.rimuoviToolStripMenuItem.Click += new System.EventHandler(this.rimuoviToolStripMenuItem_Click);
            // 
            // fileBrowser1
            // 
            this.fileBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileBrowser1.AutoScroll = true;
            this.fileBrowser1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.fileBrowser1.Location = new System.Drawing.Point(202, 118);
            this.fileBrowser1.Name = "fileBrowser1";
            this.fileBrowser1.Size = new System.Drawing.Size(980, 459);
            this.fileBrowser1.Status = MusicLibraryManager.GUI.Controls.FileBrowserStatus.browsing;
            this.fileBrowser1.TabIndex = 4;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1194, 595);
            this.Controls.Add(this.listBox_playlists);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.fileBrowser1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Music Library Manager";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Controls.FileBrowser fileBrowser1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox_playlists;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rimuoviToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem esportaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem originaleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem convertiMP3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem incorporaMetadataToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

