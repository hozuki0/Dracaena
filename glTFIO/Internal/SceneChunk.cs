﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class SceneChunk : glTFDataChunkBase
    {
        public uint[] Nodes { get; set; }
        public string Name { get; set; }
    }
}