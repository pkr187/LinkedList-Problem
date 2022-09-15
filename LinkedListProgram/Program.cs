namespace LinkedListProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList list = new LinkedList();
            LinkedListStack stack = new LinkedListStack();
            LinkedListQueue queue = new LinkedListQueue();
            while (flag)
            {
                Console.WriteLine("please Enter Your option :");
                Console.WriteLine("1.Create a Linked List \n2.Add the Elemente in Reverse Order \n3.Appending the Elemente \n4.Insert At Particular Position \n5.Delete the first element in linked list \n6.Delete the last Element in Linked List \n7.Search for the element in the linked list \n8.Insert the node After Particular node \n9.Size \n10.Assending \n11.Push \n12.Pop \n13.Enqueue \n14.Dequeue ");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        list.Add(56);
                        list.Add(30);
                        list.Add(70);
                        list.Display();
                        break;
                    case 2:
                        list.AddInReverseOrder(70);
                        list.AddInReverseOrder(30);
                        list.AddInReverseOrder(56);
                        list.Display();
                        break;
                    case 3:
                        list.Append(56);
                        list.Append(30);
                        list.Append(70);
                        list.Display();
                        break;
                    case 4:
                        list.InsertAtParticularPosition(2, 65);
                        list.Display();
                        break;
                    case 5:
                        list.Pop();
                        list.Display();
                        break;
                    case 6:
                        list.PopLast();
                        list.Display();
                        break;
                    case 7:
                        list.Search(56);
                        list.Display();
                        break;
                    case 8:
                        list.InsertNodeAfterParticularNode(40, 30);
                        list.Display();
                        break;
                    case 9:
                        list.DeleteNodeAtparticularPosition(2);
                        list.Size();
                        list.Display();
                        break;
                    case 11:
                        stack.Push(70);
                        stack.Display();
                        break;
                    case 12:
                        stack.Pop();
                        stack.Display();
                        break;
                    case 13:
                        queue.Enqueue(70);
                        queue.Display();
                        break;
                    case 14:
                        queue.Dequeue();
                        queue.Display();
                        break;
                }
            }
        }
    }
}