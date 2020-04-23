using System;

namespace CSharpIntermediateLloyd
{
    public class Stopwatch
    {
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public Boolean IsStarted { get; set; }

        public void Start()
        {
            if (!IsStarted)
            {
                IsStarted = true;
                StartTime = DateTime.Now;
            }
            else
            {
                throw new InvalidOperationException("Stopwatch is already started");
            }
        }

        public double Stop()
        {
            var diff = TimeSpan.Zero;
            if (IsStarted)
            {
                IsStarted = false;
                EndTime = DateTime.Now;
                diff = EndTime - StartTime;
                
            }
            return diff.TotalSeconds;
        }
    }
}