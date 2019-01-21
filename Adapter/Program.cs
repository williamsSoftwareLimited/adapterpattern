using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class Program {
        static void Main(string[] args) {

            IMediaPlayer mediaPlayer = new MediaPlayer();
            mediaPlayer.play("The only way is up", new Mp3Decoder());

            mediaPlayer.play("Happy as I know it", new AIFFDecoder());

            mediaPlayer.play("Paint it black", new WavPackDecoder());

            mediaPlayer.play("Blue Monday", new WavDecoderAdapter());

            mediaPlayer.play("Manic Monday", new WavDecoderAdapterInherit());

            Console.WriteLine("Press any key to finish...");
            Console.ReadKey();
        }
    }
}
