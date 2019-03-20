using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class AnimationChunk : glTFDataChunkBase
    {
        public ChannelChunk[] Channels { get; set; }
        public SamplerChunk[] Samplers { get; set; }
        public string Name { get; set; }
    }
}
