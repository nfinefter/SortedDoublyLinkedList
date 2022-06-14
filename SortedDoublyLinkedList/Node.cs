using System;
using System.Collections.Generic;
using System.Text;

namespace SortedDoublyLinkedList
{
    class Node<T>
    {
        public T Value;

        public Node<T> Next;
        public Node<T> Prev;

        public Node(T value)
        {
            Value = value;
        }

    }
}
