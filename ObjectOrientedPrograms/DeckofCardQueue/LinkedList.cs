using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.DeckofCardQueue
{
    public class Node
    {
        public string data;
        public Node next = null;
        public Node(string data)
        {
            this.data = data;
            this.next = null;
        }
    }
    public class LinkedList
    {
        Node head = null;
        public void Enqueue(string data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                Console.WriteLine("Inserted 1" + " " + node.data);
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
                Console.WriteLine("Inserted 2" + " " + node.data);
            }
        }
        public void Dequeue(string data)
        {
            Node temp = head;
            Node Prev = head;
            if (temp == null)
            {
                Console.WriteLine("empty");
                return;
            }
            else if (temp.data == data)
            {
                head = temp.next;
                Console.WriteLine("found" + " " + data);
                return;
            }
            else
            {
                while (temp != null)
                {
                    if (temp.data == data)
                    {
                        Prev.next = temp.next;
                        Console.WriteLine("found");
                        Console.WriteLine("found1 " + " " + temp.data);
                        return;
                    }
                    Prev = temp;
                    temp = temp.next;
                }
                if (temp == null)
                {
                    Console.WriteLine("no data found");
                }
            }
        }
        public void IsEmpty()
        {
            Node temp = head;
            if (head == null)
            {
                Console.WriteLine("Arithematic expression is balanced");
            }
            else
            {
                while (temp != null)
                {
                    Console.WriteLine(temp.data + " ");
                }
                temp = temp.next;
            }
            Console.WriteLine("Arthematic expression is not balanced");
        }
    }
}
