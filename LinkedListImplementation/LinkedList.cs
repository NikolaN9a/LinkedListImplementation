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

        public bool Contains(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.Data == value)
                {
                    return true;
                }
                current = current.Next;
            }
            return false;
        }
        public void Remove(int value)
        {
            if (head == null)
            {
                return;
            }

            if (head.Data == value)
            {
                head = head.Next;
                return;
            }

            Node current = head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            if (current.Next != null)
            {
                current.Next = current.Next.Next;
            }
            {
              
            }
        }
        public int Count()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.Next;
            }
            return count;
        }
        public void AddFirst(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = head;
            head = newNode;
        }
        public void Clear()
        {
            head = null;
        }
    }
}

