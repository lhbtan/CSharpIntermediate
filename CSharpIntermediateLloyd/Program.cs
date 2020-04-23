using System;
using System.Threading.Channels;

namespace CSharpIntermediateLloyd
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write  'Start' to start the stopwatch, and 'Stop' to end it.");
            var stopwatch1 = new Stopwatch();
            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "start")
                {
                    stopwatch1.Start();
                }
                else if (input == "stop")
                {
                    var result = stopwatch1.Stop();
                    if (result == 0)
                    {
                        Console.WriteLine("Start the stopwatch first, no time recorded");
                    }
                    else
                    {
                        Console.WriteLine("Your time is: " + result + " seconds!");
                    }
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Program stopped");
        }
    }
}
