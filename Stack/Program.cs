using Stack;
using System.Net.Http.Headers;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter size of stack: ");
        int size = int.Parse(Console.ReadLine());
        Stack_Array stack1 = new Stack_Array(size);
        Console.WriteLine("Your Stack was Created!");

        stack1.Push(12);
        stack1.Push(23);
        stack1.Push(41);
        stack1.Push(52);
        stack1.Push(65);
        
        stack1.Display();





    }
}