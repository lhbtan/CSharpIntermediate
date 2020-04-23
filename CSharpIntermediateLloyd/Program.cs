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
                    post.Upvote();
                }
                else if (input == "down")
                {
                    post.Downvote();
                }
                else if (input.Length >6)
                {
                    if (input.Substring(0, 6) == "title:")
                    {
                        var title = input.Substring(7);
                        post.SetTitle(title);
                    }
                    else
                    {
                        break;
                    }
                }
                else if (input == "status")
                {
                    var current = post.ShowCurrent();
                    Console.WriteLine("Total vote status of "+post.Title + " is: " + current);
                    Console.WriteLine("Post created at: " + post.Created);
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
