using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class CameraChunk : glTFDataChunkBase
    {
        public object Orthographic { get; set; }
        public object Perspective { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
    }
}
