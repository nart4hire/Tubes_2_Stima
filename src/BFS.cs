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

        public BFSNode(TreeNode node, List<TreeNode> path = null)
        {
            Path = path == null ? new List<TreeNode>() : new List<TreeNode>(path);
            Path.Add(node);
        }

        public string Pathname()
        {
            return String.Join(@"\", Path);
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
                    foreach (TreeNode child in current.Node.Children)
                    {
                        queue.Enqueue(new BFSNode(child, current.Path));
                    }
                }
            }

            var result = new HashSet<string>();

            foreach (var bfsNode in found)
            {
                foreach (var node in bfsNode.Path)
                {
                    Graph.FindNode(node.Id).Attr.FillColor = Color.Blue;
                }
                result.Add(bfsNode.Pathname());
            }

            return result;
        }
    }
}
