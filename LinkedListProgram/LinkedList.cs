﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class LinkedList
    {
        internal Node head;
        ///<summary>
        ///UC-1 - Create Simple LinkedList
        ///</summary>
        ///Adding Element in LinkedList
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked list", node.data);
        }
        ///<summary>
        ///UC-2
        ///</summary>
        ///Adding Element in Reverse Order in LinkedList
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;//70
                head = newNode;//30
                head.next = temp;//70->30
            }
        }
        ///<summary>
        //UC3
        ///</summary>
        //Append the LinkedList
        public void Append(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node node1 = head;
                while (node1.next != null)
                {
                    node1 = node1.next;
                }
                node1.next = node;
            }
            Console.WriteLine("{0} appended into linked list", node.data);
        }
        ///<summary>
        ///UC-4
        ///Inserting Element At Particular Position.
        ///</summary>
        ///<param name="position">The position.</param>
        ///<param name="data">The data.</param>
        internal void InsertAtGivenPosition(int position, int data)
        {
            Node node = new Node(data);
            if (position < 1)
            {
                Console.WriteLine("Invalid Position");
            }
            else if (position == 1)
            {
                node.next = head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (position > 2)
                {
                    temp = temp.next;
                    temp.next = node;
                }
            }
        }
        ///<summary>
        ///UC-5
        ///Delete the first element from Linedlist.
        ///</summary>
        ///<returns></returns>
        public Node PopFirst()
        {
            Node node = head;
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            else
            {
                head = head.next;
            }
            return node;
        }
        ///<summary>
        ///UC-6
        ///Delete the last element from Linedlist.
        ///</summary>
        ///<returns></returns>
        public Node PopLast()
        {
            if (head == null)
            {
                Console.WriteLine("Linked List is Empty");
                return null;
            }
            else
            {
                Node n = head;
                while (n.next.next != null)
                {
                    n = n.next;
                }
                n.next = null;
                return n;
            }
        }
        ///<summary>
        ///UC-7
        ///Search element from Linkedlist.
        ///</summary>
        ///<returns></returns>
        public int Search(int data)
        {
            int count = 1;
            Node temp = head;
            if (this.head == null)
            {
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.data + " " + "\n");
                temp = temp.next;
            }
        }
    }
}
    

