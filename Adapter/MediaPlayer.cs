using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class MediaPlayer : IMediaPlayer {
        public void play(string filename, IDecoder decoder) {
            decoder.Decode(filename);
            Console.WriteLine("Playing '{0}' with decoder {1}", filename, decoder.ToString());
        }
    }
}
