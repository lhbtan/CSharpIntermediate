
using System;

namespace CSharpIntermediateLloyd
{



    class Program 
    {
        static void Main(string[] args)
        {
           
                var stack1 = new Stack();
                stack1.Push("1234");
                stack1.Push(123);
                stack1.Push("34536363");
                
                Console.WriteLine(stack1.Pop());
                Console.WriteLine(stack1.Pop());
                Console.WriteLine(stack1.Pop());
        }
    }
}
