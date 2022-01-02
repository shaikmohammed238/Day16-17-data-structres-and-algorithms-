using Binary_Search_Word;
using System;

namespace BinarySearchTree
{    //read in the list words comma separated from a File and then enter the word to be searched
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree binaryTree = new BinaryTree();

            binaryTree.Add(1);
            binaryTree.Add(2);
            binaryTree.Add(7);
            binaryTree.Add(3);
            binaryTree.Add(0);
            binaryTree.TraversePreorder(binaryTree.Root);
        }
    }
}