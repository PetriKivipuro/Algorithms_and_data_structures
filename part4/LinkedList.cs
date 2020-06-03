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


        public void AddFirst(int n)
        {
            Node addMe = new Node(n, null, null);

            if (this.head == null)
            {
                this.head = addMe;
                this.tail = this.head;
            }
            else
            {
                this.head.previous = addMe;
                addMe.next = this.head;
                this.head = addMe;
            }

        }

        public void AddLast(int n)
        {
            Node addMe = new Node(n, null, null);
            if (this.tail == null)
            {
                this.tail = addMe;
                this.head = this.tail;
            }
            else
            {
                this.tail.next = addMe;
                addMe.previous = this.tail;
                this.tail = addMe;
            }
        }

        public void RemoveFirst()
        {
            this.head = this.head.next;
            this.head.previous = null;
        }
        void RemoveLast()
        {
            this.tail = this.tail.previous;
            this.tail.next = null;
        }


        int GetNode(int x)
        {
            Node n = this.head;
            for (int i = 0; i < x; i++)
            {
                n = n.next;
            }
            return n.value;
        }

        public override string ToString()
        {
            string total = "";
            Node n = this.head;
            while (n != null)
            {
                total += n.value + " ";
                n = n.next;
            }
            return total;
        }
    }

}