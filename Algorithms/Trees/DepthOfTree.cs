using System;
using System.Collections.Generic;
using System.Text;

namespace Algorithms.Trees
{
    public class DepthOfTree
    {
        public static int MaxDepth(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            var a = MaxDepth(root.left);
            var b = MaxDepth(root.right);
            return (a > b ? a : b) + 1;
        }

        public static void RunSample()
        {
            TreeNode tree = new TreeNode();

            // populate list
            int count = 1;
            var temp1 = tree;
            var temp2 = tree;
            int nodes = 6;

            while (count <= nodes)
            {
                temp1.val = count * 2;
                if (count != nodes)
                {
                    temp1.left = new TreeNode();
                    temp1.right = new TreeNode();
                }
                
                temp2.val = count;
                temp2 = temp1.right;
                temp1 = temp1.left; 
                if (count != nodes)
                {
                    temp2.left = new TreeNode();
                    temp2.right = new TreeNode();
                }
                
                count++;
            }


            Console.WriteLine("ans: " + MaxDepth(tree).ToString());
        }
    }
}
