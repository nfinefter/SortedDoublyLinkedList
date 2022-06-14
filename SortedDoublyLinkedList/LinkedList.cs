using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SortedDoublyLinkedList
{
    class LinkedList<T> : IEnumerable<T> where T : IComparable<T>
    {
        public int Count;
        public Node<T> Head;
        public Node<T> Tail;

        public LinkedList()
        {
            Head = new Node<T>(default);
        }

        public void Insert(T value)
        {
            Node<T> curr = Head;
            while(curr.Next != null && curr.Next.Value.CompareTo(value) < 0)
            {
                curr = curr.Next;
            }
           
            ConnectNodes(curr, new Node<T>(value), curr.Next);
            //curr.Next = new Node<T>(value);
           

        }
        private void ConnectNodes(Node<T> previous, Node<T> newNode, Node<T> next)
        {
            //Make connections
            //Check for which case we are in (inserting at the end, inserting in between) 

            newNode.Next = next;
            newNode.Prev = previous;

            newNode.Prev.Next = newNode; // newNode.Prev == null at this point

            if (newNode.Next != null)
            {
                newNode.Next.Prev = newNode;

            }
            //Hint: think about where previous and next will end up if we are inserting at the last spot, considering that 'next' can never be null.
        }

        public void Remove(T value)
        {
            Node<T> curr = Head.Next;

            while (curr.Next != null )
            {
                if (curr.Value.CompareTo(value) == 0)
                {
                    
                    RemoveLinks(curr.Prev);
                }

                curr = curr.Next;
            }
            
        }

        private void RemoveLinks(Node<T> node)
        {
            node.Next = node.Next.Next;
            node.Prev = node.Next.Prev;
        }

        public void Display()
        {
            Node<T> curr = Head.Next;

            while (curr != null)
            {
                Console.WriteLine(curr.Value);
                curr = curr.Next;
            }
        }

        public IEnumerator<T> GetEnumerator()
        {
            Node<T> curr = Head.Next;

            while (curr != null)
            {
                yield return curr.Value;
                curr = curr.Next;
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
