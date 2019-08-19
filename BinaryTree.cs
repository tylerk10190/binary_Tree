using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTree
{
    class BinaryTree
    {
        Node root;
        public BinaryTree()
        {
            root = null;
            

        }



        public void AddToBinaryTree(int data)
        {
            Node node = new Node(data);

            if (root == null)
            {
                root = node;
                return;
            }
            else
            {
                AddNewChild(root, node);
            }
        }

        private void AddNewChild(Node parent, Node childNode)
        {
            if(childNode.data <= parent.data)
            {
                if (parent.leftChild == null)
                {
                    parent.leftChild = childNode;
                }
                else
                {
                    AddNewChild(parent.leftChild, childNode);
                }
            }
            else
            {
                if(parent.rightChild == null)
                {
                    parent.rightChild = childNode;
                    return;
                }
                else
                {
                    AddNewChild(parent.rightChild, childNode);
                }

            }
            

        }
        public bool Search(int value)
        {
            Node currentNode = root;
            if(root == null)
            {
                return false;
            }
            while (true)
            {
                if (currentNode.data == value)
                {
                    return true;
                }
                else if (value < currentNode.data)
                {
                    if (currentNode.leftChild == null)
                    {
                        return false;
                    }
                    currentNode = currentNode.leftChild;
                }
                else if (value > currentNode.data)
                {
                    if (currentNode.rightChild == null)
                    {
                        return false;
                    }
                    currentNode = currentNode.rightChild;
                }
               
            }
            
        }

    }
}
