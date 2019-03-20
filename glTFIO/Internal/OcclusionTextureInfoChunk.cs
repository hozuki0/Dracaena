using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class OcclusionTextureInfoChunk : glTFDataChunkBase
    {
        public int Index { get; set; }
        public int? TexCoord { get; set; } = 0;
        public float Strength { get; set; } = 1;
    }
}
