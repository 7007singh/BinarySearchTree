using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("___Binary Search Program___");
            Console.WriteLine("Inserted nodes in BST");
            BST tree = new BST();
            tree.AddNode(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.AddNode(22);
            tree.AddNode(40);
            tree.AddNode(60);
            tree.AddNode(95);
            tree.AddNode(11);
            tree.AddNode(65);
            tree.AddNode(3);
            tree.AddNode(16);
            tree.AddNode(63);
            tree.AddNode(67);
            tree.PreOrderTraversal(tree.root);
            int treeSize = tree.Size(tree.root);
            Console.WriteLine("\nSize of BST: " + treeSize);
            int key = Convert.ToInt32(tree.Search(tree.root, 63));
            if(key == 0)
            {
                Console.WriteLine("key not found");
            }
            else
            {
                Console.WriteLine("key found");
            }
            Console.ReadLine();
        }
    }
}
