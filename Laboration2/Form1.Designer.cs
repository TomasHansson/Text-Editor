namespace Laboration2
{
    partial class MainForm
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
            this.fileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.numberOfLettersWithSpaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberOfLettersWithoutSpaceLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberOfWordsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.numberOfRowsLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.mainTextBox = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenuItem,
            this.editMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMenuItem,
            this.openMenuItem,
            this.saveMenuItem,
            this.saveAsMenuItem,
            this.toolStripSeparator1,
            this.exitMenuItem});
            this.fileMenuItem.Name = "fileMenuItem";
            this.fileMenuItem.Size = new System.Drawing.Size(45, 20);
            this.fileMenuItem.Text = "Arkix";
            // 
            // newMenuItem
            // 
            this.newMenuItem.Name = "newMenuItem";
            this.newMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.newMenuItem.Size = new System.Drawing.Size(162, 22);
            this.newMenuItem.Text = "Ny";
            this.newMenuItem.Click += new System.EventHandler(this.NewMenuItem_Click);
            // 
            // openMenuItem
            // 
            this.openMenuItem.Name = "openMenuItem";
            this.openMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openMenuItem.Size = new System.Drawing.Size(162, 22);
            this.openMenuItem.Text = "Öppna...";
            this.openMenuItem.Click += new System.EventHandler(this.OpenMenuItem_Click);
            // 
            // saveMenuItem
            // 
            this.saveMenuItem.Name = "saveMenuItem";
            this.saveMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveMenuItem.Text = "Spara";
            this.saveMenuItem.Click += new System.EventHandler(this.SaveMenuItem_Click);
            // 
            // saveAsMenuItem
            // 
            this.saveAsMenuItem.Name = "saveAsMenuItem";
            this.saveAsMenuItem.Size = new System.Drawing.Size(162, 22);
            this.saveAsMenuItem.Text = "Spara som... ";
            this.saveAsMenuItem.Click += new System.EventHandler(this.SaveAsMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(159, 6);
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Name = "exitMenuItem";
            this.exitMenuItem.Size = new System.Drawing.Size(162, 22);
            this.exitMenuItem.Text = "Avsluta";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // editMenuItem
            // 
            this.editMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoMenuItem,
            this.toolStripSeparator2,
            this.cutMenuItem,
            this.copyMenuItem,
            this.pasteMenuItem,
            this.toolStripSeparator3,
            this.selectAllMenuItem});
            this.editMenuItem.Name = "editMenuItem";
            this.editMenuItem.Size = new System.Drawing.Size(65, 20);
            this.editMenuItem.Text = "Redigera";
            // 
            // undoMenuItem
            // 
            this.undoMenuItem.Name = "undoMenuItem";
            this.undoMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoMenuItem.Size = new System.Drawing.Size(178, 22);
            this.undoMenuItem.Text = "Ångra";
            this.undoMenuItem.Click += new System.EventHandler(this.UndoMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(175, 6);
            // 
            // cutMenuItem
            // 
            this.cutMenuItem.Name = "cutMenuItem";
            this.cutMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.cutMenuItem.Size = new System.Drawing.Size(178, 22);
            this.cutMenuItem.Text = "Klipp ut";
            this.cutMenuItem.Click += new System.EventHandler(this.CutMenuItem_Click);
            // 
            // copyMenuItem
            // 
            this.copyMenuItem.Name = "copyMenuItem";
            this.copyMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyMenuItem.Size = new System.Drawing.Size(178, 22);
            this.copyMenuItem.Text = "Kopiera";
            this.copyMenuItem.Click += new System.EventHandler(this.CopyMenuItem_Click);
            // 
            // pasteMenuItem
            // 
            this.pasteMenuItem.Name = "pasteMenuItem";
            this.pasteMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteMenuItem.Size = new System.Drawing.Size(178, 22);
            this.pasteMenuItem.Text = "Klistra in";
            this.pasteMenuItem.Click += new System.EventHandler(this.PasteMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(175, 6);
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            this.selectAllMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllMenuItem.Size = new System.Drawing.Size(178, 22);
            this.selectAllMenuItem.Text = "Markera allt";
            this.selectAllMenuItem.Click += new System.EventHandler(this.SelectAllMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfLettersWithSpaceLabel,
            this.numberOfLettersWithoutSpaceLabel,
            this.numberOfWordsLabel,
            this.numberOfRowsLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // numberOfLettersWithSpaceLabel
            // 
            this.numberOfLettersWithSpaceLabel.Name = "numberOfLettersWithSpaceLabel";
            this.numberOfLettersWithSpaceLabel.Size = new System.Drawing.Size(163, 17);
            this.numberOfLettersWithSpaceLabel.Text = "Bokstäver (inkl. mellanslag): 0";
            // 
            // numberOfLettersWithoutSpaceLabel
            // 
            this.numberOfLettersWithoutSpaceLabel.Name = "numberOfLettersWithoutSpaceLabel";
            this.numberOfLettersWithoutSpaceLabel.Size = new System.Drawing.Size(155, 17);
            this.numberOfLettersWithoutSpaceLabel.Text = "Bokstäver (ex. mellanslag): 0";
            // 
            // numberOfWordsLabel
            // 
            this.numberOfWordsLabel.Name = "numberOfWordsLabel";
            this.numberOfWordsLabel.Size = new System.Drawing.Size(39, 17);
            this.numberOfWordsLabel.Text = "Ord: 0";
            // 
            // numberOfRowsLabel
            // 
            this.numberOfRowsLabel.Name = "numberOfRowsLabel";
            this.numberOfRowsLabel.Size = new System.Drawing.Size(49, 17);
            this.numberOfRowsLabel.Text = "Rader: 0";
            // 
            // mainTextBox
            // 
            this.mainTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainTextBox.Location = new System.Drawing.Point(0, 24);
            this.mainTextBox.Name = "mainTextBox";
            this.mainTextBox.Size = new System.Drawing.Size(784, 515);
            this.mainTextBox.TabIndex = 2;
            this.mainTextBox.Text = "";
            this.mainTextBox.TextChanged += new System.EventHandler(this.MainTextBoxChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.mainTextBox);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "dok1.txt";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel numberOfLettersWithSpaceLabel;
        private System.Windows.Forms.ToolStripStatusLabel numberOfLettersWithoutSpaceLabel;
        private System.Windows.Forms.ToolStripStatusLabel numberOfWordsLabel;
        private System.Windows.Forms.ToolStripStatusLabel numberOfRowsLabel;
        private System.Windows.Forms.RichTextBox mainTextBox;
        private System.Windows.Forms.ToolStripMenuItem fileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem exitMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editMenuItem;
        private System.Windows.Forms.ToolStripMenuItem undoMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem cutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
    }
}

