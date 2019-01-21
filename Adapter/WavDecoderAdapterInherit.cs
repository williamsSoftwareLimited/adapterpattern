namespace Adapter {
    class WavDecoderAdapterInherit : WavPlayer, IDecoder {

        public void Decode(string filename) { // 
            Change(filename);
        }

        public override string ToString() => "WavDecoderAdapterInherit";

    }
}
