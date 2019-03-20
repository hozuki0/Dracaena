using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class PrimitiveChunk : glTFDataChunkBase
    {
        public Dictionary<string, object> Attributes { get; set; }
        public int? Indices { get; set; }
        public int? Material { get; set; }
        public int? Mode { get; set; } = 4;
        public Dictionary<string, object>[] Targets { get; set; }
    }
}
