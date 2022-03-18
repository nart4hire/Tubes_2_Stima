namespace DiggingDeep
{
    partial class Form1
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
            this.button_openFolder = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTree = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkPath = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.inputFileName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.radBtnBFS = new System.Windows.Forms.RadioButton();
            this.radBtnDFS = new System.Windows.Forms.RadioButton();
            this.checkBox_all = new System.Windows.Forms.CheckBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button_openFolder
            // 
            this.button_openFolder.Location = new System.Drawing.Point(163, 77);
            this.button_openFolder.Name = "button_openFolder";
            this.button_openFolder.Size = new System.Drawing.Size(144, 39);
            this.button_openFolder.TabIndex = 0;
            this.button_openFolder.Text = "Choose Folder";
            this.button_openFolder.UseVisualStyleBackColor = true;
            this.button_openFolder.Click += new System.EventHandler(this.button_openFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Choose Starting Directory";
            // 
            // panelTree
            // 
            this.panelTree.Location = new System.Drawing.Point(523, 23);
            this.panelTree.Name = "panelTree";
            this.panelTree.Size = new System.Drawing.Size(800, 369);
            this.panelTree.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(533, 399);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Path File:";
            // 
            // linkPath
            // 
            this.linkPath.AutoSize = true;
            this.linkPath.Location = new System.Drawing.Point(533, 415);
            this.linkPath.Name = "linkPath";
            this.linkPath.Size = new System.Drawing.Size(0, 16);
            this.linkPath.TabIndex = 4;
            this.linkPath.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPath_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(163, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Input File Name";
            // 
            // inputFileName
            // 
            this.inputFileName.Location = new System.Drawing.Point(163, 182);
            this.inputFileName.Name = "inputFileName";
            this.inputFileName.Size = new System.Drawing.Size(156, 22);
            this.inputFileName.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(163, 257);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 16);
            this.label4.TabIndex = 7;
            this.label4.Text = "Input Metode Pencarian";
            // 
            // radBtnBFS
            // 
            this.radBtnBFS.AutoSize = true;
            this.radBtnBFS.Location = new System.Drawing.Point(166, 285);
            this.radBtnBFS.Name = "radBtnBFS";
            this.radBtnBFS.Size = new System.Drawing.Size(54, 20);
            this.radBtnBFS.TabIndex = 8;
            this.radBtnBFS.TabStop = true;
            this.radBtnBFS.Text = "BFS";
            this.radBtnBFS.UseVisualStyleBackColor = true;
            // 
            // radBtnDFS
            // 
            this.radBtnDFS.AutoSize = true;
            this.radBtnDFS.Location = new System.Drawing.Point(166, 311);
            this.radBtnDFS.Name = "radBtnDFS";
            this.radBtnDFS.Size = new System.Drawing.Size(55, 20);
            this.radBtnDFS.TabIndex = 9;
            this.radBtnDFS.TabStop = true;
            this.radBtnDFS.Text = "DFS";
            this.radBtnDFS.UseVisualStyleBackColor = true;
            // 
            // checkBox_all
            // 
            this.checkBox_all.AutoSize = true;
            this.checkBox_all.Location = new System.Drawing.Point(163, 220);
            this.checkBox_all.Name = "checkBox_all";
            this.checkBox_all.Size = new System.Drawing.Size(138, 20);
            this.checkBox_all.TabIndex = 10;
            this.checkBox_all.Text = "Find all occurence";
            this.checkBox_all.UseVisualStyleBackColor = true;
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(163, 354);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 11;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 399);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 12;
            this.label5.Text = "Time Spent:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(166, 419);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(0, 16);
            this.labelTime.TabIndex = 13;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(1354, 469);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.checkBox_all);
            this.Controls.Add(this.radBtnDFS);
            this.Controls.Add(this.radBtnBFS);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputFileName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linkPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panelTree);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_openFolder);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button button_openFolder;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTree;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton radBtnBFS;
        private System.Windows.Forms.RadioButton radBtnDFS;
        private System.Windows.Forms.CheckBox checkBox_all;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelTime;
    }
}

