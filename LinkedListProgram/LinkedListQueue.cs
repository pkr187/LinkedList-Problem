using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
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
    

