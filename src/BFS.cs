using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Msagl.Drawing;

namespace DiggingDeep
{
    internal readonly struct BFSNode
    {
        public readonly List<TreeNode> Path;
        public TreeNode Node
        {
            get { return Path.Last(); }
        }

        public TreeNode Parent
        {
            get { return Path[Path.Count - 2]; }
        }

        public BFSNode(TreeNode node, List<TreeNode> path = null)
        {
            Path = path == null ? new List<TreeNode>() : new List<TreeNode>(path);
            Path.Add(node);
        }

        public string Pathname()
        {
            return String.Join(@"\", Path);
        }

        public bool HasParent()
        {
            return Path.Count >= 2;
        }
    }

    internal class BFS
    {
        private readonly TreeNode Tree;
        private readonly Graph Graph;

        public BFS(TreeNode tree, Graph graph)
        {
            Tree = tree;
            Graph = graph;
        }

        public HashSet<string> Search(string filename, bool isFindAll)
        {
            var found = new List<BFSNode>();
            var queue = new Queue<BFSNode>();

            queue.Enqueue(new BFSNode(Tree));

            while (queue.Count > 0)
            {
                BFSNode current = queue.Dequeue();

                if (current.Node.Name == filename)
                {
                    found.Add(current);
                    if (!isFindAll)
                    {
                        queue.Clear();
                    }
                }
                else
                {
                    Graph.FindNode(current.Node.Id).Attr.FillColor = Color.Red;
                    if (current.HasParent())
                    {
                        ColorEdge(current.Parent.Id, current.Node.Id, Color.Red);
                    }

                    foreach (TreeNode child in current.Node.Children)
                    {
                        queue.Enqueue(new BFSNode(child, current.Path));
                    }
                }
            }

            var result = new HashSet<string>();

            foreach (var bfsNode in found)
            {
                var path = bfsNode.Path;
                for (int i = 0; i < path.Count; i++)
                {
                    Graph.FindNode(path[i].Id).Attr.FillColor = Color.Blue;

                    if (i >= 1)
                    {
                        ColorEdge(path[i - 1].Id, path[i].Id, Color.Blue);
                    }
                }
                result.Add(bfsNode.Pathname());
            }

            return result;
        }

        private void ColorEdge(string src, string target, Color color)
        {
            foreach (Edge edge in Graph.Edges)
            {
                if (edge.Source == src && edge.Target == target)
                {
                    edge.Attr.Color = color;
                }
            }
        }
    }
}
