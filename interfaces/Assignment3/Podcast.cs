using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment3
{
    internal class Podcast : IMediaPlayer
    {
        public void Play()
        {
            Console.WriteLine(" Podcast Played");
        }

        public void Stop()
        {
            Console.WriteLine(" Podcast Stopped");
        }
    }
}
