﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class IndicesChunk : glTFDataChunkBase
    {
        public int BufferView { get; set; }
        public int? ByteOffset { get; set; } = 0;
        public int ComponentType { get; set; }
    }
}
