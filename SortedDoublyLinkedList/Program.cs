using System;

namespace SortedDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> list = new LinkedList<int>();

            list.Insert(1);
            list.Insert(2);
            list.Insert(4);
            list.Insert(3);
            list.Insert(0);
            list.Insert(0);
            list.Remove(1);
            list.Insert(1);

            list.Display();
        }
    }
}
