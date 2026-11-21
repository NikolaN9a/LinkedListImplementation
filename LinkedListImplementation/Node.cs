using System;
using System.Collections.Generic;
using System.Text;

namespace LinkedListImplementation
{
    internal class Node
    {
        public int Data;
        public Node Next;
         public Node(int data)
        {
            Data = data;
            Next = null;
        }
    } 

}
