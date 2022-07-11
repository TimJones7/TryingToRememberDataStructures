using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryingToRememberDataStructures.BST
{
    public class BinarySearchTree
    {
        public TreeNode RootNode { get; set; }

        public int TotalNodesInTree { get; set; }

        public BinarySearchTree(int value)
        {
            RootNode = new TreeNode(value);
            TotalNodesInTree = 1;
        }





        public void InsertNode(int value)
        {
            this.TotalNodesInTree++;
            var newNode = new TreeNode(value);

            //  We need to Traverse the Tree to find where to insert
            //  Goal => find parent Node to insert new node as child of
            TreeNode seekParent = this.RootNode;
            bool hasBeenInserted = false;

            while (!hasBeenInserted)
            {
                if (newNode.Value > seekParent.Value)
                {
                    if (seekParent.RightNode is null)
                    {
                        seekParent.RightNode = newNode;
                        hasBeenInserted = true;
                    }
                    seekParent = seekParent.RightNode;
                }

                if (newNode.Value < seekParent.Value)
                {
                    if (seekParent.LeftNode is null)
                    {
                        seekParent.LeftNode = newNode;
                        hasBeenInserted = true;
                    }
                    seekParent = seekParent.LeftNode;
                }
            }
        }

        //  Create method to take in list and give back the created tree
        public  BinarySearchTree CreateTreeFromList(List<int> input)
        {
            BinarySearchTree newTree = new BinarySearchTree(input[0]);

            for(var item = 1; item < input.Count; item++)
            {
                newTree.InsertNode(item);
            }
            return newTree;
        }
    }

}









