using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace interfaces.Assignment3
{
    internal class Media
    {
        public void Play(IMediaPlayer media)
        {
            media.Play();
        }

        public void Stop(IMediaPlayer media)
        {
            media.Stop();
        }
    }
}
