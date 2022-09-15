using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    internal class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            this.top = null;
        }
        ///<summary>
        ///UC-10
        ///Create Stack
        ///</summary>
        ///<returns></returns>
        internal void Push(int value)
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
            Console.WriteLine("{0} pushed to stack", value);
        }
        ///<summary>
        ///UC-11
        ///Peek & Pop from Stack
        ///</summary>
        ///<returns></returns>
        internal void Peek() //to show the top most element
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not Possible");
                return;
            }
            Console.WriteLine("Value Popped is {0}", this.top.data);
            this.top = this.top.next;
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
    

