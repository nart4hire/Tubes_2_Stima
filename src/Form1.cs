using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace DiggingDeep
{
    public partial class DiggingDeep : Form
    {
        private TreeNode root;

        private bool openFolderClicked = false;
        private bool searchClicked = false;

        private Cursor neutral = new Cursor(Properties.Resources.shovel_neutral1.GetHicon());
        private Cursor click = new Cursor(Properties.Resources.shovel_click1.GetHicon());

        // create a graph object
        public Microsoft.Msagl.Drawing.Graph graph;
        // create a viewer object
        public Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public DiggingDeep()
        {
            InitializeComponent();
            this.Cursor = neutral;
            this.panelHeader.Cursor = neutral;
            this.panelLogo.Cursor = neutral;
            this.panelMenu.Cursor = neutral;
            this.panelTree.Cursor = neutral;

            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(100, 100);
            this.FormBorderStyle = FormBorderStyle.None;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Init the viewer
            // bind the graph to the viewer
            viewer.Graph = graph;
            // bind viewer engine to panel
            panelTree.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            viewer.Cursor = neutral;
            viewer.ToolBarIsVisible = false;
            viewer.OutsideAreaBrush = Brushes.Transparent;
            panelTree.Controls.Add(viewer);
            panelTree.ResumeLayout();
        }

        private void button_openFolder_Click(object sender, EventArgs e)
        {

            // create new graph
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            // graph.Attr.BackgroundColor = Microsoft.Msagl.Drawing.Color.Transparent;

            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
                this.searchClicked = false;

                string selected = dialog.SelectedPath;
                if (Directory.Exists(selected))
                {
                    root = new TreeNode(selected, selected);
                    IterateDirectory(selected, root, true);
                }
                DrawTree();
            }
            else
            {
                button_openFolder.BackgroundImage = Properties.Resources.Bark_BG;
                this.openFolderClicked = false;
            }

        }

        private void IterateDirectory(string path, TreeNode node, bool root)
        {
            string pathname = Path.GetFileName(path);
            string[] files = Directory.GetFiles(path);
            foreach (string file in files)
            {
                if (File.Exists(file))
                {
                    string filename = Path.GetFileName(file);
                    TreeNode child_file = node.AddChild(file, filename);
                    Node graphNode = graph.AddNode(file);
                    graph.AddEdge(path, file);
                    graphNode.LabelText = filename;
                }
            }
            string[] dirs = Directory.GetDirectories(path);
            foreach (string dir in dirs)
            {
                string dirname = Path.GetFileName(dir);
                TreeNode child_subdir = node.AddChild(dir, dirname);
                Node graphNode = graph.AddNode(dir);
                graph.AddEdge(path, dir);
                graphNode.LabelText = dirname;
                IterateDirectory(dir, child_subdir, false);
            }
        }

        public void DrawTree()
        {
            // bind the graph to the viewer
            viewer.Graph = graph;
        }

        public void ResetGraphColor()
        {
            foreach (var node in graph.Nodes)
            {
                node.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
            foreach (var edge in graph.Edges)
            {
                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_Clicked_BG;

            // measure execution time
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();

            ResetGraphColor();
            Controls.Add(linkPath);
            linkPath.Links.Clear();
            string fileName = inputFileName.Text;
            HashSet<string> res = new HashSet<string>();

            // BFS
            if (radBtnBFS.Checked)
            {
                BFS bfs = new BFS(root, graph);
                res = bfs.Search(fileName, checkBox_all.Checked);
            }

            // DFS
            else if (radBtnDFS.Checked)
            {
                DFS treeDFS = new DFS(this.root, graph);
                res = treeDFS.Search_DFS(fileName, checkBox_all.Checked);
            }

            if (res.Count > 0)
            {

                var stringBuilder = new StringBuilder();
                foreach (string path in res)
                {
                    linkPath.Links.Add(new LinkLabel.Link(stringBuilder.Length, path.Length, path));
                    stringBuilder.Append(path + "\n");
                }
                linkPath.Text = stringBuilder.ToString();
            }
            else
            {
                linkPath.Text = "Tidak ada path yang sesuai";
            }

            stopwatch.Stop();
            // Controls.Add(labelTime);
            labelTime.Text = stopwatch.ElapsedMilliseconds.ToString() + " ms";
            DrawTree();
        }

        private void linkPath_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (e.Link.LinkData.ToString() != "")
            {
                string pathToFile = Path.GetDirectoryName(e.Link.LinkData.ToString());

                Process.Start("explorer.exe", pathToFile);
            }
        }

        private void buttonMinimize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal) WindowState = FormWindowState.Minimized;
            else WindowState = FormWindowState.Normal;

        }

        private void buttonMaximize_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 0, 0));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private GraphicsPath GetPillBtn(RectangleF rec, float rad)
        {
            GraphicsPath g = new GraphicsPath();
            g.StartFigure();
            g.AddArc(rec.X, rec.Y, rad, rad, 180, 90);
            g.AddArc(rec.Width - rad, rec.Y, rad, rad, 270, 90);
            g.AddArc(rec.Width - rad, rec.Height - rad, rad, rad, 0, 90);
            g.AddArc(rec.X, rec.Height - rad, rad, rad, 90, 90);
            g.CloseFigure();
            return g;
        }
        private void radBtnBFS_Paint(object sender, PaintEventArgs e)
        {
            RectangleF rec = new RectangleF(0, 0, radBtnBFS.Width, radBtnBFS.Height);
            radBtnBFS.Region = new Region(GetPillBtn(rec, 32));
        }

        private void radBtnDFS_Paint(object sender, PaintEventArgs e)
        {
            RectangleF rec = new RectangleF(0, 0, radBtnDFS.Width, radBtnDFS.Height);
            radBtnDFS.Region = new Region(GetPillBtn(rec, 32));
        }

        private void inputFileName_Enter(object sender, EventArgs e)
        {
            inputFileName.ForeColor = System.Drawing.Color.Black;
            if (inputFileName.Text == "e.x. DiggingDeep.txt")
            {
                inputFileName.Text = "";
            }
        }

        private void inputFileName_Leave(object sender, EventArgs e)
        {
            if (inputFileName.Text == "")
            {
                inputFileName.ForeColor = System.Drawing.Color.Silver;
                inputFileName.Text = "e.x. DiggingDeep.txt";
            }
            buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
            this.searchClicked = false;
        }

        private void panelTextBox_Paint(object sender, PaintEventArgs e)
        {
            RectangleF rec = new RectangleF(0, 0, panelTextBox.Width, panelTextBox.Height);
            panelTextBox.Region = new Region(GetPillBtn(rec, 32));
        }

        private void checkBox_all_Paint(object sender, PaintEventArgs e)
        {
            RectangleF rec = new RectangleF(0, 0, checkBox_all.Width, checkBox_all.Height);
            checkBox_all.Region = new Region(GetPillBtn(rec, 32));
        }

        private void checkBox_all_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
            this.searchClicked = false;
        }

        private void radBtnBFS_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
            this.searchClicked = false;
        }

        private void radBtnDFS_CheckedChanged(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
            this.searchClicked = false;
        }

        private void panelTextBox_MouseEnter(object sender, EventArgs e)
        {
            panelTextBox.BackColor = ColorTranslator.FromHtml("#BE9776");
            inputFileName.BackColor = ColorTranslator.FromHtml("#BE9776");
        }

        private void panelTextBox_MouseLeave(object sender, EventArgs e)
        {
            panelTextBox.BackColor = ColorTranslator.FromHtml("#876445");
            inputFileName.BackColor = ColorTranslator.FromHtml("#876445");
        }

        private void inputFileName_MouseEnter(object sender, EventArgs e)
        {
            panelTextBox.BackColor = ColorTranslator.FromHtml("#BE9776");
            inputFileName.BackColor = ColorTranslator.FromHtml("#BE9776");
        }

        private void inputFileName_MouseLeave(object sender, EventArgs e)
        {
            panelTextBox.BackColor = ColorTranslator.FromHtml("#876445");
            inputFileName.BackColor = ColorTranslator.FromHtml("#876445");
        }

        private void button_openFolder_MouseDown(object sender, MouseEventArgs e)
        {
            button_openFolder.BackgroundImage = Properties.Resources.Bark_Clicked_BG;
            this.openFolderClicked = true;
        }

        private void button_openFolder_MouseEnter(object sender, EventArgs e)
        {
            button_openFolder.BackgroundImage = Properties.Resources.Bark_Hover_BG;
        }

        private void button_openFolder_MouseLeave(object sender, EventArgs e)
        {
            if (!this.openFolderClicked)
            {
                button_openFolder.BackgroundImage = Properties.Resources.Bark_BG;
            }
            else
            {
                button_openFolder.BackgroundImage = Properties.Resources.Bark_Clicked_BG;
            }
        }

        private void buttonSearch_MouseDown(object sender, MouseEventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_Clicked_BG;
            this.searchClicked = true;
        }

        private void buttonSearch_MouseEnter(object sender, EventArgs e)
        {
            buttonSearch.BackgroundImage = Properties.Resources.Bark_Hover_BG;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            if (!this.searchClicked)
            {
                buttonSearch.BackgroundImage = Properties.Resources.Bark_BG;
            }
            else
            {
                buttonSearch.BackgroundImage = Properties.Resources.Bark_Clicked_BG;
            }

        }
    }
}
