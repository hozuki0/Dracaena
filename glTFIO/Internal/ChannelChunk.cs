using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class ChannelChunk : glTFDataChunkBase
    {
        public int Sampler { get; set; }
        public object Target { get; set; }
    }
}
