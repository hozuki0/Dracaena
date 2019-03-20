using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class TextureChunk : glTFDataChunkBase
    {
        public int? Sampler { get; set; }
        public int? Source { get; set; }
        public String Name { get; set; }
    }
}
