using DataStructureAndAlgorithms.Arrays;
using DataStructureAndAlgorithms.Queue;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithms.Trees
{
    public abstract class MyClass
    {
        int coordinatesX;
        int coordinatesY;
    }

    public class TreeNode
    {
        public int Data { get; internal set; }
        public TreeNode Left { get; internal set; }
        public TreeNode Right { get; internal set; }
        internal TreeNode(int Data)
        {
            this.Data = Data;
            this.Left = null;
            this.Right = null;
        }
    }
    public class BinarySearchTree
    {
        public TreeNode Root { get; private set; }
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
                while (NodeToCompare != null)
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

        public TreeNode Traverse(TreeNode Node)
        {
            Console.WriteLine($" {Node.Data} ");
            if (Node.Right == null && Node.Left == null)
                return Node;
            if (Node.Left != null)
            {
                Traverse(Node.Left);
            }
            if (Node.Right!= null)
            {
                Traverse(Node.Right);
            }
            return Node;
        }

        public List<TreeNode> BreadthFirstSearch()
        {
            TreeNode currentNode = Root;
            List<TreeNode> listOfItems = new List<TreeNode>();
            MyQueue<TreeNode> myQueue = new MyQueue<TreeNode>();
            myQueue.Enqueue(currentNode);
            while(myQueue.Length>0)
            {
                currentNode = myQueue.Dequeue();
                listOfItems.Add(currentNode);
                if (currentNode.Left != null)
                    myQueue.Enqueue(currentNode.Left);
                if (currentNode.Right != null)
                    myQueue.Enqueue(currentNode.Right);
            }
            return listOfItems;
        }

        //public List<TreeNode> BreadthFirstSearchRecursive(MyQueue<TreeNode node)
        //{
        //    if()
        //}

        //public bool RemoveNode(int Data)
        //{
        //    var NodeToRemove = Lookup(Data);

        //    //If Node not found, return False
        //    if (NodeToRemove == null)
        //        return false;

        //    var parentNode = GetParentNode(NodeToRemove);
        //    var leftMostParentNode = GetLeftMostParentNode(NodeToRemove);
        //    //Removal of Leaf Nodes
        //    if (NodeToRemove.Right == null && NodeToRemove.Left == null)
        //    {
        //        if (parentNode.Right.Data == Data)
        //        {
        //            parentNode.Right = null;
        //        }
        //        else
        //            parentNode.Left = null;
        //        return true;
        //    }

        //    //Removal of Root Node
        //    if(NodeToRemove == Root)
        //    {
        //        if(NodeToRemove.Right !=null)
        //        {
        //            var potentialRootNode = NodeToRemove.Right;
        //            if(potentialRootNode.Left)
        //        }
        //        else
        //        {
        //            Root = NodeToRemove.Left;
        //        }
        //        return true;
        //    }

        //}

        private TreeNode GetParentNode(TreeNode node)
        {
            if (node.Data == Root.Data)
                return null;
            var currentNode = Root;
            while (currentNode != null)
            {
                if (currentNode.Left.Data == node.Data || currentNode.Right.Data == node.Data)
                    return currentNode;
                if (node.Data < currentNode.Data)
                    currentNode = currentNode.Left;
                else
                    currentNode = currentNode.Right;
            }
            return null;
        }
        private TreeNode GetLeftMostParentNode(TreeNode rootNode)
        {
            if (rootNode.Left == null)
                return null;
            var parentNode = rootNode;
            var leftChildNode = rootNode.Left;
            while (leftChildNode.Left != null)
            {
                parentNode = leftChildNode;
                leftChildNode = leftChildNode.Left;
            }
            return parentNode;
        }

        private bool IsNodeWithNoChild(TreeNode node)
        {
            if (node.Left == null && node.Right == null)
                return true;
            return false;
        }
    }
}
