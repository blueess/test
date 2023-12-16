using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Stack_Array
    {
        int top;
        int[] data;
        
        public Stack_Array(int size)
        {
            top = -1;
            data = new int[size];         
        } 

        public bool IsEmpty()
        {
            if (top == -1)
                return true;
            else
                return false;
        }

        public bool IsFull()
        {
            if(top == data.Length-1)
                return true;
            else
                return false;
        }

        public void Push(int item)
        {
            if (IsFull())
            {
                Console.WriteLine("Stack Overflow");
            }       
                top++;
                data[top] = item;           
        }

        public void Pop()
        {
            if(IsEmpty())
            {
                Console.WriteLine("Stack Is Empty, You can't Pop Elements");
            }
            int x = data[top];
            Console.WriteLine(x);
            top--;
        }

        public void Peek()
        {
            if (IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine(data[top]);
        }

        public void Display()
        {
            Console.WriteLine($"Top = {top}");
            if(IsEmpty())
            {
                Console.WriteLine("Stack is Empty");
            }
            Console.WriteLine("Your Stack: ");
            for (int i = top;  i >= 0; i--)
            {
                Console.WriteLine(data[i]);
            }
        }
    }
}
