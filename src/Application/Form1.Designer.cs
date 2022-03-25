namespace DiggingDeep
{
    partial class DiggingDeep
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiggingDeep));
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelTree = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkPath = new System.Windows.Forms.LinkLabel();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.radBtnBFS = new System.Windows.Forms.RadioButton();
            this.radBtnDFS = new System.Windows.Forms.RadioButton();
            this.checkBox_all = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.button_openFolder = new System.Windows.Forms.Button();
            this.panelTextBox = new System.Windows.Forms.Panel();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.buttonMaximize = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonMinimize = new System.Windows.Forms.Button();
            this.panelMenu.SuspendLayout();
            this.panelTextBox.SuspendLayout();
            this.panelHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTree
            // 
            this.panelTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelTree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.panelTree.Location = new System.Drawing.Point(296, 186);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(954, 410);
            this.panelTree.TabIndex = 2;
            this.panelTree.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTree_Paint);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.label2.Location = new System.Drawing.Point(293, 599);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path File:";
            // 
            // linkPath
            // 
            this.linkPath.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.linkPath.AutoSize = true;
            this.linkPath.BackColor = System.Drawing.Color.Transparent;
            this.linkPath.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkPath.Location = new System.Drawing.Point(293, 619);
            this.linkPath.Name = "linkPath";
            this.linkPath.Size = new System.Drawing.Size(0, 26);
            this.linkPath.TabIndex = 4;
            this.linkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPath_LinkClicked);
            // 
            // inputFileName
            // 
            this.inputFileName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.inputFileName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputFileName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inputFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputFileName.ForeColor = System.Drawing.Color.Silver;
            this.inputFileName.Location = new System.Drawing.Point(18, 6);
            this.inputFileName.MinimumSize = new System.Drawing.Size(0, 26);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(182, 26);
            this.inputFileName.TabIndex = 6;
            this.inputFileName.Text = "e.x. DiggingDeep.txt";
            this.inputFileName.TextChanged += new System.EventHandler(this.inputFileName_TextChanged);
            this.inputFileName.Enter += new System.EventHandler(this.inputFileName_Enter);
            this.inputFileName.Leave += new System.EventHandler(this.inputFileName_Leave);
            this.inputFileName.MouseEnter += new System.EventHandler(this.inputFileName_MouseEnter);
            this.inputFileName.MouseLeave += new System.EventHandler(this.inputFileName_MouseLeave);
            // 
            // radBtnBFS
            // 
            this.radBtnBFS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBtnBFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.radBtnBFS.FlatAppearance.BorderSize = 0;
            this.radBtnBFS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.radBtnBFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.radBtnBFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.radBtnBFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radBtnBFS.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnBFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radBtnBFS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.radBtnBFS.Location = new System.Drawing.Point(33, 232);
            this.radBtnBFS.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.radBtnBFS.Name = "radBtnBFS";
            this.radBtnBFS.Size = new System.Drawing.Size(120, 32);
            this.radBtnBFS.TabIndex = 8;
            this.radBtnBFS.TabStop = true;
            this.radBtnBFS.Text = "BFS";
            this.radBtnBFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnBFS.UseVisualStyleBackColor = false;
            this.radBtnBFS.CheckedChanged += new System.EventHandler(this.radBtnBFS_CheckedChanged);
            this.radBtnBFS.Paint += new System.Windows.Forms.PaintEventHandler(this.radBtnBFS_Paint);
            // 
            // radBtnDFS
            // 
            this.radBtnDFS.Appearance = System.Windows.Forms.Appearance.Button;
            this.radBtnDFS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.radBtnDFS.FlatAppearance.BorderSize = 0;
            this.radBtnDFS.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.radBtnDFS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.radBtnDFS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.radBtnDFS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.radBtnDFS.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radBtnDFS.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radBtnDFS.Location = new System.Drawing.Point(33, 270);
            this.radBtnDFS.Margin = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this.radBtnDFS.Name = "radBtnDFS";
            this.radBtnDFS.Size = new System.Drawing.Size(120, 32);
            this.radBtnDFS.TabIndex = 9;
            this.radBtnDFS.TabStop = true;
            this.radBtnDFS.Text = "DFS";
            this.radBtnDFS.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radBtnDFS.UseVisualStyleBackColor = false;
            this.radBtnDFS.CheckedChanged += new System.EventHandler(this.radBtnDFS_CheckedChanged);
            this.radBtnDFS.Paint += new System.Windows.Forms.PaintEventHandler(this.radBtnDFS_Paint);
            // 
            // checkBox_all
            // 
            this.checkBox_all.Appearance = System.Windows.Forms.Appearance.Button;
            this.checkBox_all.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.checkBox_all.FlatAppearance.BorderSize = 0;
            this.checkBox_all.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.checkBox_all.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(66)))), ((int)(((byte)(33)))));
            this.checkBox_all.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.checkBox_all.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox_all.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_all.ForeColor = System.Drawing.SystemColors.ControlText;
            this.checkBox_all.Location = new System.Drawing.Point(33, 181);
            this.checkBox_all.Name = "checkBox_all";
            this.checkBox_all.Size = new System.Drawing.Size(180, 32);
            this.checkBox_all.TabIndex = 10;
            this.checkBox_all.Text = "Find All?";
            this.checkBox_all.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_all.UseVisualStyleBackColor = false;
            this.checkBox_all.CheckedChanged += new System.EventHandler(this.checkBox_all_CheckedChanged);
            this.checkBox_all.Paint += new System.Windows.Forms.PaintEventHandler(this.checkBox_all_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.label5.Location = new System.Drawing.Point(28, 417);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 26);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time Spent:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Font = new System.Drawing.Font("MV Boli", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(151)))), ((int)(((byte)(118)))));
            this.labelTime.Location = new System.Drawing.Point(28, 440);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 26);
            this.labelTime.TabIndex = 13;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.labelTime);
            this.panelMenu.Controls.Add(this.label5);
            this.panelMenu.Controls.Add(this.buttonSearch);
            this.panelMenu.Controls.Add(this.checkBox_all);
            this.panelMenu.Controls.Add(this.radBtnDFS);
            this.panelMenu.Controls.Add(this.radBtnBFS);
            this.panelMenu.Controls.Add(this.button_openFolder);
            this.panelMenu.Controls.Add(this.panelTextBox);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 180);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 493);
            this.panelMenu.TabIndex = 15;
            // 
            // button_openFolder
            // 
            this.button_openFolder.BackColor = System.Drawing.Color.Transparent;
            this.button_openFolder.BackgroundImage = global::DiggingDeep.Properties.Resources.Bark_BG;
            this.button_openFolder.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button_openFolder.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.button_openFolder.FlatAppearance.BorderSize = 0;
            this.button_openFolder.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_openFolder.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_openFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_openFolder.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_openFolder.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.button_openFolder.Location = new System.Drawing.Point(15, 23);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(240, 100);
            this.button_openFolder.TabIndex = 0;
            this.button_openFolder.Text = "Choose Directory";
            this.button_openFolder.UseVisualStyleBackColor = false;
            this.button_openFolder.Click += new System.EventHandler(this.button_openFolder_Click);
            this.button_openFolder.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_openFolder_MouseDown);
            this.button_openFolder.MouseEnter += new System.EventHandler(this.button_openFolder_MouseEnter);
            this.button_openFolder.MouseLeave += new System.EventHandler(this.button_openFolder_MouseLeave);
            // 
            // panelTextBox
            // 
            this.panelTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(100)))), ((int)(((byte)(69)))));
            this.panelTextBox.Controls.Add(this.inputFileName);
            this.panelTextBox.Location = new System.Drawing.Point(33, 129);
            this.panelTextBox.Name = "panelTextBox";
            this.panelTextBox.Padding = new System.Windows.Forms.Padding(18, 6, 0, 0);
            this.panelTextBox.Size = new System.Drawing.Size(200, 32);
            this.panelTextBox.TabIndex = 0;
            this.panelTextBox.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTextBox_Paint);
            this.panelTextBox.MouseEnter += new System.EventHandler(this.panelTextBox_MouseEnter);
            this.panelTextBox.MouseLeave += new System.EventHandler(this.panelTextBox_MouseLeave);
            // 
            // buttonSearch
            // 
            this.buttonSearch.BackgroundImage = global::DiggingDeep.Properties.Resources.Bark_BG;
            this.buttonSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.buttonSearch.FlatAppearance.BorderSize = 0;
            this.buttonSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSearch.Font = new System.Drawing.Font("MV Boli", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(41)))), ((int)(((byte)(28)))));
            this.buttonSearch.Location = new System.Drawing.Point(15, 316);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(240, 100);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            this.buttonSearch.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonSearch_MouseDown);
            this.buttonSearch.MouseEnter += new System.EventHandler(this.buttonSearch_MouseEnter);
            this.buttonSearch.MouseLeave += new System.EventHandler(this.buttonSearch_MouseLeave);
            // 
            // panelHeader
            // 
            this.panelHeader.BackgroundImage = global::DiggingDeep.Properties.Resources.Title___Header;
            this.panelHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelHeader.Controls.Add(this.panelLogo);
            this.panelHeader.Controls.Add(this.buttonMaximize);
            this.panelHeader.Controls.Add(this.buttonExit);
            this.panelHeader.Controls.Add(this.buttonMinimize);
            this.panelHeader.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1262, 180);
            this.panelHeader.TabIndex = 14;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // panelLogo
            // 
            this.panelLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelLogo.BackColor = System.Drawing.Color.Transparent;
            this.panelLogo.BackgroundImage = global::DiggingDeep.Properties.Resources.DD_Logo;
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.Location = new System.Drawing.Point(426, 12);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(391, 127);
            this.panelLogo.TabIndex = 4;
            // 
            // buttonMaximize
            // 
            this.buttonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMaximize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.BackgroundImage = global::DiggingDeep.Properties.Resources.Twig_Maximise;
            this.buttonMaximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMaximize.FlatAppearance.BorderSize = 0;
            this.buttonMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMaximize.Image = global::DiggingDeep.Properties.Resources.Twig_Maximise;
            this.buttonMaximize.Location = new System.Drawing.Point(1180, 9);
            this.buttonMaximize.Name = "buttonMaximize";
            this.buttonMaximize.Size = new System.Drawing.Size(32, 32);
            this.buttonMaximize.TabIndex = 3;
            this.buttonMaximize.UseVisualStyleBackColor = false;
            this.buttonMaximize.Click += new System.EventHandler(this.buttonMaximize_Click);
            // 
            // buttonExit
            // 
            this.buttonExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonExit.BackColor = System.Drawing.Color.Transparent;
            this.buttonExit.BackgroundImage = global::DiggingDeep.Properties.Resources.Twig_Exit;
            this.buttonExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonExit.FlatAppearance.BorderSize = 0;
            this.buttonExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonExit.Location = new System.Drawing.Point(1218, 9);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(32, 32);
            this.buttonExit.TabIndex = 2;
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonMinimize
            // 
            this.buttonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonMinimize.BackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.BackgroundImage = global::DiggingDeep.Properties.Resources.Twig_Minimise;
            this.buttonMinimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonMinimize.FlatAppearance.BorderSize = 0;
            this.buttonMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMinimize.Location = new System.Drawing.Point(1142, 9);
            this.buttonMinimize.Name = "buttonMinimize";
            this.buttonMinimize.Size = new System.Drawing.Size(32, 32);
            this.buttonMinimize.TabIndex = 1;
            this.buttonMinimize.UseVisualStyleBackColor = false;
            this.buttonMinimize.Click += new System.EventHandler(this.buttonMinimize_Click);
            // 
            // DiggingDeep
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(60)))), ((int)(((byte)(41)))));
            this.ClientSize = new System.Drawing.Size(1262, 673);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.linkPath);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DiggingDeep";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            this.panelTextBox.ResumeLayout(false);
            this.panelTextBox.PerformLayout();
            this.panelHeader.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkPath;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.RadioButton radBtnBFS;
        private System.Windows.Forms.RadioButton radBtnDFS;
        private System.Windows.Forms.CheckBox checkBox_all;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonMinimize;
        private System.Windows.Forms.Button buttonMaximize;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panelTextBox;
    }
}

