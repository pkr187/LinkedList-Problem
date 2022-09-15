namespace LinkedListProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool flag = true;
            LinkedList list = new LinkedList();
            while (flag)
            {
                Console.WriteLine("please Enter Your option :");
                Console.WriteLine("1.Create a Linked List \n2.Add the Elemente in Reverse Order ");
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
                }
            }
        }
    }
}
