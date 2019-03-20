using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class AnimationSamplerChunk : glTFDataChunkBase
    {
        public int Input { get; set; }
        public string Interpolation { get; set; } = "LINEAR";
        public int OutPut { get; set; }
    }
}
