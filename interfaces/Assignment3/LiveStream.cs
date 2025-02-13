using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment3
{
    internal class LiveStream : IMediaPlayer
    {
        public void Play()
        {
            Console.WriteLine(" LiveStream Played");
        }

        public void Stop()
        {
            Console.WriteLine(" LiveStream Stopped");
        }
    }
}
