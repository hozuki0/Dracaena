using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class BufferViewChunk
    {
        public int Buffer { get; set; }
        public int ByteOffset { get; set; }
        public int ByteLength { get; set; }
        public int Target { get; set; }
    }
}
