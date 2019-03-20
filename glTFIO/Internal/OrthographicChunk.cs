﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class OrthographicChunk : glTFDataChunkBase
    {
        public float Xmag { get; set; }
        public float Ymag { get; set; }
        public float Zfar { get; set; }
        public float Znear { get; set; }
    }
}
