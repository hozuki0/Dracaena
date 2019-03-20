using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class NormalTextureInfoChunk : glTFDataChunkBase
    {
        public int Index { get; set; }
        public int? TexCoord { get; set; } = 0;
        public float? Scale { get; set; } = 1.0f;
    }
}
