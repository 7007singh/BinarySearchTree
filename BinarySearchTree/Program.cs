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
            BinarySTree tree = new BinarySTree();
            tree.AddNode(56);
            tree.AddNode(30);
            tree.AddNode(70);
            tree.PreOrderTraversal(tree.root);
            Console.ReadLine();
        }
    }
}
