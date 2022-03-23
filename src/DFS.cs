using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;

namespace DiggingDeep
{
    internal class DFS
    {
        private TreeNode tree;
        private Microsoft.Msagl.Drawing.Graph graph;

        // constructor
        public DFS(TreeNode tree, Graph graph)
        {
            this.tree = tree;
            this.graph = graph;
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
            this.graph.FindNode(tree.Name).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
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
                            this.graph.FindNode(child.Id).Attr.Color = Microsoft.Msagl.Drawing.Color.Red;
                            ColorEdge(current.Id, child.Id, "Red");
                            Search_DFS_rec(FileName, AllOccurence, ref result, ref path, ref visited, ref found);
                            if (found)
                            {
                                string pathFound = path.First().Name;
                                this.graph.FindNode(path.First().Id).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                                for (int i = 1; i < path.Count; i++)
                                {
                                    pathFound += @"\" + path[i].Name;
                                    this.graph.FindNode(path[i].Id).Attr.Color = Microsoft.Msagl.Drawing.Color.Blue;
                                    ColorEdge(path[i - 1].Id, path[i].Id, "Blue");
                                }
                                result.Add(pathFound);
                                if (AllOccurence)
                                {
                                    found = false;
                                    path.Remove(path.Last());
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

        public void ColorEdge(string src, string target, string color)
        {
            foreach (Edge edge in graph.Edges)
            {
                if (edge.Source == src && edge.Target == target)
                {
                    if (color == "Blue") { edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Blue; }
                    else if (color == "Red") { edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Red; }
                    else { edge.Attr.Color = Microsoft.Msagl.Drawing.Color.Black; }
                }
            }
        }
    }
}
