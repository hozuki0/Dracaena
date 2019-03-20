﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO
{
    public class MeshObject : ISceneObject
    {
        public MeshObject(ISceneObject parent)
        {
            this.parent = parent;
        }
        private ISceneObject parent = null;
        public ISceneObject Parent { get => parent; }
        public List<ISceneObject> Children { get; set; } = new List<ISceneObject>();
        public float[] Translation { get; set; }
        public float[] Rotation { get; set; }
        public float[] Scaling { get; set; }
        public Internal.MeshChunk MeshInfo { get; set; }    // temp
        public string Name { get; set; } = "Mesh";
        public float[][] Matrix { get; set; } = new float[4][]
         {
                new float[4]{1,0,0,0},
                new float[4]{0,1,0,0},
                new float[4]{0,0,1,0},
                new float[4]{0,0,0,1}
         };
    }
}