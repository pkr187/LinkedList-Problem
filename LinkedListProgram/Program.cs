using LinkedListProgram;

LinkedList list = new LinkedList();
bool flag = true;
while (flag)
{
    Console.WriteLine("Select Program\n 1.Create LinkedList\n 2.Add Element in Reverse Order\n 3.Append Element in LinkedList\n 4.Insert Element At Particular Position\n 5.Delete First Element In LinkedList\n 6.Delete Last Element In LinkedList\n 7.Search Element In LinkedList");
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
            list.Add(70);
            list.Add(30);
            list.Add(56);
            list.Display();
            break;

        case 3:
            list.Append(56);
            list.Append(30);
            list.Append(70);
            list.Display();
            break;

        case 4:
            list.Add(70);
            list.InsertAtGivenPosition(1, 30);
            list.Add(56);
            list.Display();
            break;

        case 5:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.PopFirst();
            list.Display();
            break;

        case 6:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.PopLast();
            list.Display();
            break;

        case 7:
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Search(56);
            list.Display();
            break;
    }
}