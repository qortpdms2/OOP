using System;

namespace LinkedList
{
    public class LinkedListStack
    {
        public Node top;
        public LinkedListStack()
        {
            this.top = null;
        }

        public void push(int data)
        {
            Node newNode = new Node(data);
            newNode.next = top;
            top = newNode;


        }


        public int pop()
        {
            int data;
            if (this.top == null)
            {
                return -1;
            }
            else
            {
                data = this.top.data;
                this.top = this.top.next;
                return data;
            }
        }
    }
}
