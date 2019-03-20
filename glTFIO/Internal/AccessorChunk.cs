using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class AccessorChunk : glTFDataChunkBase
    {
        public int? BufferView { get; set; }
        public int? ByteOffset { get; set; }
        public int ComponentType { get; set; }
        public bool Normalized { get; set; } = false;
        public int Count { get; set; }
        public string Type { get; set; }
        public float[] Max { get; set; }
        public float[] Min { get; set; }
        public SparseChunk Sparse { get; set; }
        public string Name { get; set; }
    }
}
