using System;
using System.Collections.Generic;

namespace Linked_List_Homework
{
    public class LinkedList
    {
        public Node First { get; set; }

        public void Print()
        {
            Node move = First;
            while (move != null)
            {
                Console.Write(move.Data+"\t");
                move = move.Next;
            }
            Console.WriteLine();
        }

        public void Add(int val)
        {
            if (First == null)
            {
                First = new Node(val);
                return;
            }
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = new Node(val);
            move.Next.Prev = move;
        }
        public void RemoveKey(int key)
        {
            if (First == null)
            {
                Console.WriteLine("The List is Empty");
                return;
            }
            if (First.Data == key)
            {
                First = null;
                Console.WriteLine($"Done Key {key} Removed");
                return;
            }
            else
            {
                Node move = First;
                while (move.Next != null)
                {
                    if (move.Next.Data == key)
                    {
                        move.Next = move.Next.Next;
                        Console.WriteLine($"Done Key {key} Removed");
                        return;
                    }
                    move = move.Next;
                }
                Console.WriteLine("Item Not Found");
            }
        }
        public void Merge(LinkedList other_list)
        {
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Next = other_list.First;
        }

        public void Reverse()
        {
            Node move = First;
            while (move.Next != null)
            {
                move = move.Next;
            }
            move.Prev.Next = null;
            move.Next = First;
            First = move;
        }
    }
}
