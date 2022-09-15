using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList
    {
        internal Node head;
        //uc1
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
        /// <summary>
        /// Method create "AddInReverseOrder" 
        /// </summary>
        /// <param name="data"></param>
        internal void AddInReverseOrder(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = this.head;
                head = newNode;
                head.next = temp;
            }
        }
        /// <summary>
        /// Method create "Append" 
        /// </summary>
        /// <param name="data"></param>
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
            Console.WriteLine("{0} append into linked list", node.data);
        }
        /// <summary>
        /// Method create "InsertAtParticularPosition"
        /// </summary>
        /// <param name="Position"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        internal Node InsertAtParticularPosition(int Position, int data)
        {
            Node node = new Node(data);
            if (Position < 1)
            {
                Console.WriteLine("Invalid Position");

            }
            else if (Position == 1)
            {
                node.next = this.head;
                head = node;
            }
            else
            {
                Node temp = head;
                while (Position > 2)
                {
                    temp = temp.next;
                    Position--;
                }
                node.next = temp.next;
                temp.next = node;
            }
            return node;
        }
        /// <summary>
        /// Method create "Pop"
        /// </summary>
        /// <returns></returns>
        public Node Pop()
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
        /// <summary>
        /// Mwthod Create "PopLast"
        /// </summary>
        /// <returns></returns>
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
        /// <summary>
        /// Method created = Search
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        public int Search(int data)
        {
            int count = 0;
            Node temp = head;
            if (this.head == null)
            {
                Console.WriteLine("Element Not found plz try Again");
                return 0;
            }
            while (temp != null)
            {
                if (temp.data == data)
                {
                    Console.WriteLine("Element Found sucessfully");
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }
        public void InsertNodeAfterParticularNode(int data, int dataToSearch)
        {
            int position = Search(dataToSearch);
            if (position == 0)
            {
                Console.WriteLine("No such element found");
                return;
            }
            Node node = new Node(data);
            Node temp = this.head;
            for (int i = 1; i < position; i++)
            {
                temp = temp.next;
            }
            node.next = temp.next;
            temp.next = node;
        }
        public void DeleteNodeAtparticularPosition(int Position)
        {
            if (this.head == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            Node temp = this.head;
            if (Position == 0)
            {
                this.head = temp.next;
                return;
            }

            for (int i = 0; temp != null && i < Position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next = temp.next.next;
            temp.next = next;
        }
        public int Size()
        {
            int count = 0;
            Node temp = head;
            if (temp == null)
            {
                return 0;
            }
            while (temp != null)
            {
                count++;
                temp = temp.next;
            }
            Console.WriteLine($"Linked List Size is {count}");
            return count;
        }
        /// <summary>
        /// Dispaly Method
        /// </summary>
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }

    }
}

