using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProblem
{
    internal class LinkedListQueue
    {
        private Node top;
        private Node head;
        public LinkedListQueue()
        {
            this.top = null;
        }
        ///<summary>
        ///UC-12
        ///Create Queue
        ///</summary>
        ///<returns></returns>
        internal void Enqueue(int value)
        {
            Node node = new Node(value);
            if (this.top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = this.top;
            }
            this.top = node;
            Console.WriteLine("{0} pushed to queue", value);
        }
        ///<summary>
        ///UC-13
        ///Dequeue Element
        ///</summary>
        ///<returns></returns>
        internal void Dequeue()
        {
            if (this.head == null)
            {
                Console.WriteLine("Queue is Empty, Deletion is not Possible");
                return;
            }
            else
            {
                while (this.head != null)
                {
                    Console.WriteLine("value Dequeue is {0}", this.head.data);
                    this.head = this.head.next;
                }
            }
        }
        internal void Display()
        {
            Node temp = this.top;
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}
    

