using System;
using System.Linq;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.Msagl.Drawing;
using Microsoft.Msagl.GraphViewerGdi;

namespace DiggingDeep
{
    internal readonly struct BFSNode
    {
        public List<string> Path { get; }
        public TreeNode Node { get; }

        public BFSNode(TreeNode node, List<string> path = null)
        {
            Path = path == null ? new List<string>() : new List<string>(path);
            Node = node;

            Path.Add(node.Name);
        }

        public string PathString()
        {
            return String.Join(@"\", Path);
        }
    }

    internal class BFS
    {
        private TreeNode Tree;
        private Graph Graph;

        public BFS(TreeNode tree, Graph graph)
        {
            Tree = tree;
            Graph = graph;
        }

        public HashSet<string> Search(string filename, bool isFindAll)
        {
            HashSet<string> result = new HashSet<string>();
            Queue<BFSNode> queue = new Queue<BFSNode>();

            queue.Enqueue(new BFSNode(Tree));

            while (queue.Count > 0)
            {
                BFSNode current = queue.Dequeue();

                if (current.Node.Name == filename)
                {
                    result.Add(current.PathString());
                    if (!isFindAll)
                    {
                        queue.Clear();
                    }
                }
                else
                {
                    foreach (TreeNode child in current.Node.Children)
                    {
                        queue.Enqueue(new BFSNode(child, current.Path));
                    }
                }
            }

            return result;
        }
    }
}
