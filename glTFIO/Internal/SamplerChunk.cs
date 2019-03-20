using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class SamplerChunk : glTFDataChunkBase
    {
        public int? MagFilter { get; set; }
        public int? MinFilter { get; set; }
        public int? WrapS { get; set; }
        public int? WrapT { get; set; }
        public string Name { get; set; }
    }
}
