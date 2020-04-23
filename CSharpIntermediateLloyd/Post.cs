using System;

namespace CSharpIntermediateLloyd
{
    public class Post
    {
        public int Upvotes { get; set; }
        public int Downvotes { get; set; }
        public DateTime Created { get; set; }
        public string Title { get; set; }

        public Post()
        {
            Downvotes = 0;
            Upvotes = 0;
            Created = DateTime.Now;
        }
        public void Upvote()
        {
            Upvotes++;
        }

        public void Downvote()
        {
            Downvotes++;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public int ShowCurrent()
        {
            var currentVotes = Upvotes - Downvotes;
            return currentVotes;
        }
    }
}