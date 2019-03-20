using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class MeshChunk : glTFDataChunkBase
    {
        public PrimitiveChunk[] Primitives { get; set; }
        public float[] Weights { get; set; }
        public string Name { get; set; }
    }
}
