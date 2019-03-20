using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class PBRMetallicRoughnessChunk : glTFDataChunkBase
    {
        public float[] BaseColorFactor { get; set; } = new float[4] { 1, 1, 1, 1 };
        public Dictionary<string, object> BaseColorTexture { get; set; }
        public float MetallicFactor { get; set; }
        public float RoughnessFactor { get; set; }
        public Dictionary<string,object> MetallicRoughnessTexture { get; set; }
    }
}
