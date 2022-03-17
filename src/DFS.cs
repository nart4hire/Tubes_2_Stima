using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

// todo: path all occurence masih salah

namespace DiggingDeep
{
    internal class DFS
    {
        private TreeNode tree;
        private Panel panel;
        private Microsoft.Msagl.Drawing.Graph graph;
        private Microsoft.Msagl.GraphViewerGdi.GViewer viewer;

        // constructor
        public DFS(TreeNode tree, Panel panel, Graph graph, GViewer viewer)
        {
            this.tree = tree;
            this.panel = panel;
            this.graph = graph;
            this.viewer = viewer;
        }
        
        // search using DFS
        public HashSet<string> Search_DFS(string FileName, bool AllOccurence)
        {
            HashSet<string> result = new HashSet<string>();
            List<TreeNode> path = new List<TreeNode>();
            List<TreeNode> visited = new List<TreeNode>();
            bool found = false;
            visited.Add(tree);
            path.Add(tree);
            this.graph.FindNode(tree.Name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
            Search_DFS_rec(FileName, AllOccurence, ref result, ref path, ref visited, ref found);

            return result;
        }
        public void Search_DFS_rec(string FileName, bool AllOccurence, ref HashSet<string> result, ref List<TreeNode> path, ref List<TreeNode> visited, ref bool found)
        {
            if (path.Last().Name == FileName)
            {
                found = true;
            }
            else
            {
                if (path.Last().Children.Count == 0)
                {
                    path.Remove(path.Last());
                }
                else
                {
                    TreeNode current = path.Last();
                    foreach (TreeNode child in current.Children)
                    {
                        if (!visited.Contains(child))
                        {
                            visited.Add(child);
                            path.Add(child);
                            this.graph.FindNode(child.Name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Red;
                            Search_DFS_rec(FileName, AllOccurence, ref result, ref path, ref visited, ref found);
                            if (found)
                            {
                                string pathFound = path.First().Name;
                                this.graph.FindNode(path.First().Name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                                for (int i = 1; i < path.Count; i++)
                                {
                                    pathFound += @"\" + path[i].Name;
                                    this.graph.FindNode(path[i].Name).Attr.FillColor = Microsoft.Msagl.Drawing.Color.Blue;
                                }
                                result.Add(pathFound);
                                if (AllOccurence)
                                {
                                    found = false;
                                }
                                else
                                {
                                    return;
                                }
                            }
                            else
                            {
                                path.Remove(child);
                            }
                        }
                    }
                    
                }
                
            }
        }
    }
}
