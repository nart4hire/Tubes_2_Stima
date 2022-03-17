using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiggingDeep
{
    internal class TreeNode
    {
		private readonly string name;
		// constructor
		public TreeNode(string name)
		{
			this.name = name;
			Children = new List<TreeNode>();
		}

		public string Name
        {
			get { return name; }
		}
		public List<TreeNode> Children
		{ get; set; } = null;

		public TreeNode AddChild(string name)
		{
			var node = new TreeNode(name);
			Children.Add(node);
			return node;
		}
	}
}
