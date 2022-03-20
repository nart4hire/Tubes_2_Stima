using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Microsoft.Msagl.Drawing;
using System.Diagnostics;

namespace DiggingDeep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private TreeNode root;
        // create a graph object
        Microsoft.Msagl.Drawing.Graph graph;
        // create a viewer object
        Microsoft.Msagl.GraphViewerGdi.GViewer viewer = new Microsoft.Msagl.GraphViewerGdi.GViewer();
        private void button_openFolder_Click(object sender, EventArgs e)
        {
            // create new graph
            graph = new Microsoft.Msagl.Drawing.Graph("graph");
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string selected = dialog.SelectedPath;
                if (Directory.Exists(selected))
                {
                    root = new TreeNode(selected, selected);
                    IterateDirectory(selected, root, true);
                }
                DrawTree();
            }
        }

        private void IterateDirectory(string path, TreeNode node, bool root)
        {
            string pathname = Path.GetFileName(path);
            string[] files = Directory.GetFiles(path);
            foreach(string file in files)
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
            foreach(string dir in dirs)
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
            // bind viewer engine to panel
            panelTree.SuspendLayout();
            viewer.Dock = System.Windows.Forms.DockStyle.Fill;
            panelTree.Controls.Add(viewer);
            panelTree.ResumeLayout();
        }

        public void ResetGraphColor()
        {
            foreach(var node in graph.Nodes)
            {
                node.Attr.FillColor = Microsoft.Msagl.Drawing.Color.White;
            }
            foreach(var edge in graph.Edges)
            {
                edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black;
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
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
            Controls.Add(labelTime);
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
    }
}
