using System;

namespace GetTargetCopy
{
    public class Program
    {
        public static void Main(string[] args)
        {
            TreeNode original = new TreeNode(7);

            TreeNode cloned = original;
            TreeNode copy = GetTargetCopy(original, cloned, new TreeNode(7));

            Console.WriteLine(copy.val);
        }

        public static TreeNode GetTargetCopy(TreeNode original, TreeNode cloned, TreeNode target)
        {
            return search(target, cloned);
        }

        public static TreeNode search(TreeNode searchNode, TreeNode currentNode)
        {
            if (currentNode != null)
            {
                if (currentNode.val == searchNode.val)
                {
                    return currentNode;
                }
                else
                {
                    TreeNode foundNode = search(searchNode, currentNode.left);
                    if (foundNode == null)
                    {
                        foundNode = search(searchNode, currentNode.right);
                    }

                    return foundNode;
                }
            }
            else
            {
                return null;
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
        }
    }
}