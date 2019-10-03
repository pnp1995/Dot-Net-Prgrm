using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectOrientedPrograms.DeckofCardQueue
{
   public class Node<T>
    {
        T data;
        Node<T> next;
        Node<T> previous;
        private Node<T> nextnode;

        public Node()
        {
            this.next = null;
            this.previous = null;
        }
        public Node(T data,Node<T>next,Node<T>prevoius)
        {
            this.data = data;
            this.previous = null;
            this.next = null;
        }
        public void SetData(T data)
        {
            this.data = data;
        }
        public  T GetData()
        {
            return this.data;
        }
        public void SetNext(Node<T>nextData)
        {
            this.next = nextnode;
        }
        public Node<T>GetNext()
        {
            return this.next;
        }
        public void SetPrevious(Node<T>previousnode)
        {
            this.previous = previousnode;
        }
        public Node<T>GetPrevious()
        {
            return this.previous;
        }
    }
}
