using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter {
    class AIFFDecoder : IDecoder {
        public void Decode(string filename) {
            Console.WriteLine("'Decoding {0}'.", filename);
        }

        public override string ToString() => "AIFFDecoder";

    }
}