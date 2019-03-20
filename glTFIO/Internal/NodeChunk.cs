using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class NodeChunk : glTFDataChunkBase
    {
        public int? Camera { get; set; }
        public int[] Children { get; set; }
        public int? Skin { get; set; }
        public float[] Matrix { get; set; } = new float[16] { 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1 };
        public int? Mesh { get; set; }
        public float[] Rotation { get; set; } = new float[4] { 0, 0, 0, 1 };
        public float[] Scale { get; set; } = new float[3] { 1, 1, 1 };
        public float[] Translation { get; set; } = new float[3] { 0, 0, 0 };
        public float[] Weights { get; set; }
        public string Name { get; set; }
    }
}
