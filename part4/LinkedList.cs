using System;
using System.Collections.Generic;

namespace Part4
{
    public class LinkedList
    {
        private Node head;
        private Node tail;

        public LinkedList()
        {
            this.head = null;
            this.tail = null;
        }


        void AddFirst(int n)
        {
            Node n1 = new Node(n, null, null);

            if (this.head == null)
            {
                this.head = n1;
                this.head = Node();
                this.tail = head;
            }
            else
            {
                this.head.previous = Node();
                Node.Next() = this.head;
                this.head = Node();
            }

        }

        void AddLast(int n)
        {
            Node nt = new Node(null, null, n);
        }

        void RemoveFirst()
        {

        }
        void RemoveLast()
        {

        }


        int GetNode(int x)
        {
            return 0;
        }

        override ToString()
        {
            return;
        }
    }

}