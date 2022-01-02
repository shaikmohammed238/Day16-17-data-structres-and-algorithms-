﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Binary_Search_Word
{
    class BinaryTree
    {     //read in the list words comma separated from a File and then enter the word to be searched
        public Node Root { get; set; }

        public bool Add(int value)
        {
            Node before = null, after = this.Root;
            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;

            }
            return true;
        }
        public void TraversePreorder(Node Parent)
        {
            if (Parent != null)
            {
                if (Parent.Data == 3)
                {
                    Console.WriteLine("Data found");
                }
                Console.WriteLine(Parent.Data + " ");
                TraversePreorder(Parent.LeftNode);
                TraversePreorder(Parent.RightNode);
            }
        }
    }
}
