using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment3
{
    internal class Video : IMediaPlayer
    {
        public void Play()
        {
            Console.WriteLine(" Video Played");
        }

        public void Stop()
        {
            Console.WriteLine(" Video Stopped");
        }
    }
}
