using System;
using System.Threading.Channels;

namespace CSharpIntermediateLloyd
{
    class Program 
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Post Created, type 'up' to upvote, 'down' to downvote 'title: ...' to change the title and 'status' to see status");
            var post = new Post();
            while (true)
            {
                var input = Console.ReadLine().ToLower();
                if (input == "up")
                {
                    post.Upvotes = 6;
                }
                else if (input == "down")
                {
                    post.Downvotes = 7;
                }
                else if (input.Substring(0, 6) == "title:")
                {
                    var title = input.Substring(7);
                    post.SetTitle(title);
                }
                else if (input == "status")
                {
                    var current = post.ShowCurrent();
                    Console.WriteLine("Total vote status of "+post.Title + " is: " + current);
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
