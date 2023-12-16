using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Linkedlist
{
    class Node
    {
        public int data;
        public Node next;
    }
    internal class Stack_List
    {
        public Node top;

        public Stack_List()
        {
            top = null;
        }
    
        public bool IsEmpty()
        {
            if (top == null)
                return true;
            else
                return false;
        }

        public void Push(int x)
        {
            Node temp = new Node();
            temp.data = x;
            temp.next = top;
            top = temp;
        }

        public int Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }

            int x = top.data;
            top = top.next;
            return x;
        }
    }
}


