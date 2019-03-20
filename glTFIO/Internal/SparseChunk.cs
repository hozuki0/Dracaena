using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class SparseChunk : glTFDataChunkBase
    {
        public int Count { get; set; }
        public IndicesChunk Indices { get; set; }
        public ValuesChunk Values { get; set; }
    }
}
