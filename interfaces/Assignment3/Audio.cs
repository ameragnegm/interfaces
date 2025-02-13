using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment3
{
    internal class Audio : IMediaPlayer
    {
        public void Play()
        {
            Console.WriteLine(" Audio Played");
        }

        public void Stop()
        {
            Console.WriteLine(" Audio Stopped");
        }
    }
}
