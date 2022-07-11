using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToRememberDataStructures.BST
{
    public class TreeNode
    {

        public int Value { get; set; }

        //  Null Children by default
        //  If need to be not null, will be set in BST class
        public TreeNode? LeftNode { get; set; } = null;
        public TreeNode? RightNode { get; set; } = null;



        public TreeNode(int value)
        {
            Value = value;
        }


    }
}
