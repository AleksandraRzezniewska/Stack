using System;

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            stack.Push("Ola");
            stack.Push("Wika");
            stack.Peek();
            stack.Pop();
            stack.Peek();

            Console.ReadKey();
        }
    }
}
