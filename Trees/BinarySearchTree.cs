using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Trees
{
    sealed class TreeNode
    {
        internal int Data { get; set; }
        internal TreeNode Left { get; set; }
        internal TreeNode Right { get; set; }
        internal TreeNode(int Data)
        {
            this.Data = Data;
            this.Left = null;
            this.Right = null;
        }
    }
    class BinarySearchTree
    {
        public TreeNode Root { get; private set; }
        BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int Data)
        {
            if (Root == null)
                Root = new TreeNode(Data);
            else 
            {
                if (Root.Data < Data)
                {
                    if (Root.Left == null)
                        Root.Left = new TreeNode(Data);
                }
            }
        }
        public bool Lookup(int Data)
        {
            return false;
        }

    }
}
