using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program5
{
    class TreeNode 
    {
        public TreeNode LeftNode { get; set; }

        public IComparable Data { get; private set; }

        public TreeNode RightNode { get; set; }

        public TreeNode(IComparable T) 
        {
            Data = T;
        }

        public void Insert(IComparable insertValue)
        {
            if (insertValue.CompareTo(Data) < 0)
            {
                if (LeftNode == null)
                {
                    LeftNode = new TreeNode(insertValue);
                }
                else
                {
                    LeftNode.Insert(insertValue);
                }
            }
            else if (insertValue.CompareTo(Data) > 0)
            {
                if (RightNode == null)
                {
                    RightNode = new TreeNode(insertValue);
                }
                else
                {
                    RightNode.Insert(insertValue);
                }
            }
        }
    }

    public class Tree 
    {
        private TreeNode root;

        public void InsertNode(IComparable insertValue)
        {
            if (root == null)
            {
                root = new TreeNode(insertValue);
            }
            else
            {
                root.Insert(insertValue);
            }
        }

        public void PreOrderTraversal()
        {
            PreorderHelper(root);
        }
        
        private void PreorderHelper(TreeNode node)
        {
            if(node != null)
            {
                Console.Write($"{node.Data}");

                PreorderHelper(node.LeftNode);

                PreorderHelper(node.RightNode);
            }
        }

        private void InorderTraversal()
        {
            InorderHelper(root);
        }

        private void InorderHelper(TreeNode node)
        {
            if (node != null)
            {
                InorderHelper(node.LeftNode);

                Console.Write($"{node.Data}");

                InorderHelper(node.RightNode);
            }
        }

        public void PostorderTraversal()
        {
            PostorderHelper(root);
        }

        private void PostorderHelper(TreeNode node)
        {
            if(node != null)
            {
                PostorderHelper(node.LeftNode);

                PostorderHelper(node.RightNode);

                Console.Write($"{node.Data}");
            }
        }
    }
}
