using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTree
{
    class Program
    {
        static void Main(string[] args)
        {

            BinaryTree testTree = new BinaryTree();
            testTree.AddToBinaryTree(10);
            testTree.AddToBinaryTree(9);
            testTree.AddToBinaryTree(12);
            testTree.AddToBinaryTree(11);
        }
    }
}
