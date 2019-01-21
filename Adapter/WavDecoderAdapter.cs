using System;
namespace Adapter {
    class WavDecoderAdapter : IDecoder {

        public void Decode(string filename) {

            // if the WavPlayer changes then this will have to be changed
            IWavPlayer wavPlayer = new WavPlayer();
            wavPlayer.Change(filename);
        }

        public override string ToString() => "WavDecoderAdapter";
    }
}
