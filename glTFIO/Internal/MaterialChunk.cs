using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class MaterialChunk : glTFDataChunkBase
    {
        public string Name { get; set; }
        public PBRMetallicRoughnessChunk PbrMetallicRoughness { get; set; }
        public NormalTextureInfoChunk NormalTexture { get; set; }
        public OcclusionTextureInfoChunk OcclisionTexture { get; set; }
        public Dictionary<string, object> EmissiveTexture { get; set; }
        public float[] EmissiveFactor { get; set; } = new float[3] { 0, 0, 0 };
        public string AlphaMode { get; set; } = "OPAQUE";
        public float AlphaCutoff { get; set; } = 0.5f;
        public bool DoubleSided { get; set; } = false;
    }
}
