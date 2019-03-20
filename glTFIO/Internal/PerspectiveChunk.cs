using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class PerspectiveChunk : glTFDataChunkBase
    {
        public float AspectRatio { get; set; }
        public float Yfov { get; set; }
        public float Zfar { get; set; }
        public float Znear { get; set; }
    }
}
