using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Trees
{
    internal class TreeNode
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
    public class BinarySearchTree
    {
        TreeNode Root { get; set; }
        public BinarySearchTree()
        {
            Root = null;
        }

        public void Insert(int Data)
        {
            var nodeToInsert = new TreeNode(Data);
            if (Root == null)
                Root = nodeToInsert;
            else
            {
                var currentNode = Root;
                while (true)
                {
                    if (Data > currentNode.Data)
                    {
                        if (currentNode.Right == null)
                        {
                            currentNode.Right = nodeToInsert;
                            break;
                        }
                        currentNode = currentNode.Right;
                    }
                    else if (Data < currentNode.Data)
                    {
                        if (currentNode.Left == null)
                        {
                            currentNode.Left = nodeToInsert;
                            break;
                        }
                        currentNode = currentNode.Left;
                    }
                    else
                        throw new Exception("Duplicate Element not allowed");
                }

            }
        }
        public bool ContainsData(int Data)
        {
            if (Lookup(Data) == null)
                return false;
            return true;
        }
        private TreeNode Lookup(int Data)
        {
            if (Root == null)
                return null;
            else if (Root.Data == Data)
                return Root;
            else
            {
                var NodeToCompare = Root;
                while (NodeToCompare!=null)
                {
                    if (NodeToCompare.Data == Data)
                    {
                        return NodeToCompare;
                    }
                    else if (Data > NodeToCompare.Data)
                    {
                        if (NodeToCompare.Right == null)
                            return null;
                        NodeToCompare = NodeToCompare.Right;
                    }
                    else
                    {
                        if (NodeToCompare.Left == null)
                            return null;
                        NodeToCompare = NodeToCompare.Left;
                    }
                }
                return null;
            }
        }
    }
}
