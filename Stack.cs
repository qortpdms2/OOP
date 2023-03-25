using LinkedList;
using System;
using LL=LinkedList.LinkedListStack;


namespace Stack
{
    internal class Stack
    {
        static void Main(string[] args)
        {

            LL linkedStack = new LL();
            linkedStack.push(1);
            linkedStack.push(2);
            linkedStack.push(3);
            Console.WriteLine("LinkedList로 구현한 스택 : \n" + linkedStack.pop());
            Console.WriteLine(linkedStack.pop());
            Console.WriteLine(linkedStack.pop());
            Console.WriteLine(linkedStack.pop());


            ArrayStack.ArrayStack arrStack = new ArrayStack.ArrayStack(1000);
            arrStack.push(4);
            arrStack.push(5);
            arrStack.push(6);

            Console.WriteLine("Array로 구현한 스택 : \n" + arrStack.pop());
            Console.WriteLine(arrStack.pop());
            Console.WriteLine(arrStack.pop());
            Console.WriteLine(arrStack.peek());
        }
    }
}

namespace ArrayStack
{
    public class ArrayStack
    {
        public int[] arr;
        public int topIndex;
        public ArrayStack(int size)
        {
            this.arr = new int[size];
            this.topIndex = -1;
        }

        public void push(int data)
        {
            if (this.topIndex == this.arr.Length - 1)
            {
                return;
            }
            else
            {
                this.arr[++topIndex] = data;
            }

        }

        public int pop()
        {
            if (this.topIndex == -1)
            {
                return -1;
            }

            return this.arr[topIndex--];
        }

        public int peek()
        {
            return this.arr[topIndex];
        }
    }
}



public class Node
{
    public int data;
    public Node next;
    public Node(int data)
    {
        this.data = data;
        next = null;
    }
}
