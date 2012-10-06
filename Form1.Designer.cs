namespace sharParse
{
    partial class sharParse
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
            this.components = new System.ComponentModel.Container();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gb_fileDirectory = new System.Windows.Forms.GroupBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tb_fileDirectory = new System.Windows.Forms.TextBox();
            this.btn_browse = new System.Windows.Forms.Button();
            this.gb_replaceText = new System.Windows.Forms.GroupBox();
            this.tb_replaceText = new System.Windows.Forms.TextBox();
            this.gb_searchText = new System.Windows.Forms.GroupBox();
            this.tb_searchText = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseSensitiveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partialMatchesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.prog_Timer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gb_fileDirectory.SuspendLayout();
            this.gb_replaceText.SuspendLayout();
            this.gb_searchText.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.24873F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.75127F));
            this.tableLayoutPanel1.Controls.Add(this.gb_fileDirectory, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.gb_replaceText, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gb_searchText, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.08333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 47.91667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 71F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(498, 228);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gb_fileDirectory
            // 
            this.gb_fileDirectory.Controls.Add(this.label1);
            this.gb_fileDirectory.Controls.Add(this.progressBar1);
            this.gb_fileDirectory.Controls.Add(this.tb_fileDirectory);
            this.gb_fileDirectory.Controls.Add(this.btn_browse);
            this.gb_fileDirectory.Location = new System.Drawing.Point(3, 159);
            this.gb_fileDirectory.Name = "gb_fileDirectory";
            this.gb_fileDirectory.Size = new System.Drawing.Size(491, 66);
            this.gb_fileDirectory.TabIndex = 4;
            this.gb_fileDirectory.TabStop = false;
            this.gb_fileDirectory.Text = "File Directory";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.progressBar1.Location = new System.Drawing.Point(3, 37);
            this.progressBar1.MarqueeAnimationSpeed = 16;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(385, 23);
            this.progressBar1.Step = 0;
            this.progressBar1.TabIndex = 4;
            this.progressBar1.Tag = "";
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // tb_fileDirectory
            // 
            this.tb_fileDirectory.Location = new System.Drawing.Point(3, 16);
            this.tb_fileDirectory.Name = "tb_fileDirectory";
            this.tb_fileDirectory.Size = new System.Drawing.Size(477, 20);
            this.tb_fileDirectory.TabIndex = 0;
            this.tb_fileDirectory.TextChanged += new System.EventHandler(this.tb_fileDirectory_TextChanged);
            this.tb_fileDirectory.DoubleClick += new System.EventHandler(this.tb_fileDirectory_DoubleClick);
            this.tb_fileDirectory.Leave += new System.EventHandler(this.tb_fileDirectory_Leave);
            // 
            // btn_browse
            // 
            this.btn_browse.Location = new System.Drawing.Point(405, 41);
            this.btn_browse.Name = "btn_browse";
            this.btn_browse.Size = new System.Drawing.Size(75, 19);
            this.btn_browse.TabIndex = 3;
            this.btn_browse.Text = "Browse";
            this.btn_browse.UseVisualStyleBackColor = true;
            this.btn_browse.Click += new System.EventHandler(this.btn_browse_Click);
            // 
            // gb_replaceText
            // 
            this.gb_replaceText.Controls.Add(this.tb_replaceText);
            this.gb_replaceText.Location = new System.Drawing.Point(3, 84);
            this.gb_replaceText.Name = "gb_replaceText";
            this.gb_replaceText.Size = new System.Drawing.Size(491, 67);
            this.gb_replaceText.TabIndex = 1;
            this.gb_replaceText.TabStop = false;
            this.gb_replaceText.Text = "Replacement Text (New Text)";
            // 
            // tb_replaceText
            // 
            this.tb_replaceText.Location = new System.Drawing.Point(3, 19);
            this.tb_replaceText.Multiline = true;
            this.tb_replaceText.Name = "tb_replaceText";
            this.tb_replaceText.Size = new System.Drawing.Size(477, 41);
            this.tb_replaceText.TabIndex = 0;
            this.tb_replaceText.Leave += new System.EventHandler(this.tb_replaceText_Leave);
            // 
            // gb_searchText
            // 
            this.gb_searchText.Controls.Add(this.tb_searchText);
            this.gb_searchText.Location = new System.Drawing.Point(3, 3);
            this.gb_searchText.Name = "gb_searchText";
            this.gb_searchText.Size = new System.Drawing.Size(491, 69);
            this.gb_searchText.TabIndex = 0;
            this.gb_searchText.TabStop = false;
            this.gb_searchText.Text = "Search Text (Old Text)";
            // 
            // tb_searchText
            // 
            this.tb_searchText.Location = new System.Drawing.Point(3, 16);
            this.tb_searchText.Multiline = true;
            this.tb_searchText.Name = "tb_searchText";
            this.tb_searchText.Size = new System.Drawing.Size(477, 45);
            this.tb_searchText.TabIndex = 0;
            this.tb_searchText.TextChanged += new System.EventHandler(this.tb_searchText_TextChanged);
            this.tb_searchText.Leave += new System.EventHandler(this.tb_searchText_Leave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseSensitiveToolStripMenuItem,
            this.partialMatchesToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // caseSensitiveToolStripMenuItem
            // 
            this.caseSensitiveToolStripMenuItem.CheckOnClick = true;
            this.caseSensitiveToolStripMenuItem.Name = "caseSensitiveToolStripMenuItem";
            this.caseSensitiveToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.caseSensitiveToolStripMenuItem.Text = "Case Sensitive";
            this.caseSensitiveToolStripMenuItem.ToolTipText = "Should search be case sensitive?";
            // 
            // partialMatchesToolStripMenuItem
            // 
            this.partialMatchesToolStripMenuItem.Name = "partialMatchesToolStripMenuItem";
            this.partialMatchesToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.partialMatchesToolStripMenuItem.Text = "Partial Matches...";
            this.partialMatchesToolStripMenuItem.Click += new System.EventHandler(this.partialMatchesToolStripMenuItem_Click);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            // 
            // prog_Timer
            // 
            this.prog_Timer.Tick += new System.EventHandler(this.prog_Timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.label1.Location = new System.Drawing.Point(159, 44);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Parse";
            // 
            // sharParse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 252);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "sharParse";
            this.Text = "sharParse";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gb_fileDirectory.ResumeLayout(false);
            this.gb_fileDirectory.PerformLayout();
            this.gb_replaceText.ResumeLayout(false);
            this.gb_replaceText.PerformLayout();
            this.gb_searchText.ResumeLayout(false);
            this.gb_searchText.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox gb_searchText;
        private System.Windows.Forms.TextBox tb_searchText;
        private System.Windows.Forms.GroupBox gb_replaceText;
        private System.Windows.Forms.TextBox tb_replaceText;
        private System.Windows.Forms.GroupBox gb_fileDirectory;
        private System.Windows.Forms.TextBox tb_fileDirectory;
        private System.Windows.Forms.Button btn_browse;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem caseSensitiveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem partialMatchesToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Timer prog_Timer;
        private System.Windows.Forms.Label label1;
    }
}

