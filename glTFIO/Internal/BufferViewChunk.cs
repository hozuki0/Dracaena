using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class BufferViewChunk : glTFDataChunkBase
    {
        public int Buffer { get; set; }
        public int ByteOffset { get; set; } = 0;
        public int? ByteLength { get; set; }
        public int? ByteStride { get; set; }
        public int? Target { get; set; }
        public string Name { get; set; }
    }
}
