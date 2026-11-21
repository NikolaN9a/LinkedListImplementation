using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace LinkedListImplementation
{
    internal class LinkedList
    {
        private Node head;
        public LinkedList()
        {
            head = null;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node(value);
            if (head == null)
            {
               head = newNode;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
           
        
            
       
        }
        public void Print()
        {
            if (head == null)
            {
                Console.WriteLine("The list is empty.");
                return;
            }       
            

            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " ");
                current = current.Next;
                
               
            }
            Console.WriteLine();
           
        }
    }
}
