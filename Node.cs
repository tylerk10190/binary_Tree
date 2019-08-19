﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace binaryTree
{
    public class Node
    {
        public int data;
        public Node leftChild;
        public Node rightChild;


        public Node(int data)
        {
            this.data = data;
            this.leftChild = null;
            this.rightChild = null;

        }
    }
}
