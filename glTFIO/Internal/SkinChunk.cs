using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class SkinChunk : glTFDataChunkBase
    {
        public int? InverseBindMatrices { get; set; }
        public int? Skeleton { get; set; }
        public int[] Joints { get; set; }
        public string Name { get; set; }
    }
}
