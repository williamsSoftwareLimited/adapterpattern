using System;

namespace Adapter {
    class Mp3Decoder : IDecoder {
        public void Decode(string filename) {
            Console.WriteLine("'Decoding {0}'.", filename);
            // decode something
        }

        public override string ToString() => "Mp3Decoder";
        
    }
}
