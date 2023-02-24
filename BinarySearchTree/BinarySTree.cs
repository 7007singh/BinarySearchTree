﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class BinarySTree
    {
        public Node root;
        public void AddNode(int data)
        {
            Node newNode = new Node(data);
            if (root == null)
            {
                root = newNode;
            }
            else
            {
                Node temp = root;
                Node parent;
                while (temp != null)
                {
                    parent = temp;

                    if (data < temp.data)
                    {
                        temp = temp.left;

                        if (temp == null)
                        {
                            parent.left = newNode;
                            return;
                        }
                    }
                    else
                    {
                        temp = temp.right;
                        if (temp == null)
                        {
                            parent.right = newNode;
                            return;
                        }
                    }
                }
            }
        }
        public void PreOrderTraversal(Node temp)
        {
            if (temp != null)
            {
                Console.Write(temp.data + " ");
                PreOrderTraversal(temp.left);
                PreOrderTraversal(temp.right);
            }
        }
    }
}
