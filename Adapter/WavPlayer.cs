using System;

namespace Adapter {
    class WavPlayer : IWavPlayer { // adaptee

        // this is the equivalent Decode
        public void Change(string filename) {
            Console.WriteLine("'Decoding {0}'.", filename);
        }

        // lots of other stuff

        public override string ToString() => "WavDecoder";
    }
}