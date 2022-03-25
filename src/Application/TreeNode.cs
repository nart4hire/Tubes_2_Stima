using System.Collections.Generic;

namespace DiggingDeep
{
    internal class TreeNode
    {
        private readonly string name;
        public string Id { get; }
        // constructor
        public TreeNode(string id, string name)
        {
            Id = id;
            this.name = name;
            Children = new List<TreeNode>();
        }

        public string Name
        {
            get { return name; }
        }
        public List<TreeNode> Children
        { get; set; } = null;

        public TreeNode AddChild(string id, string name)
        {
            var node = new TreeNode(id, name);
            Children.Add(node);
            return node;
        }
        public override string ToString()
        {
            return name;
        }
    }
}
