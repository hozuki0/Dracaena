using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO
{
    public class TransformObject : ISceneObject
    {
        public TransformObject()
        {
        }
        public TransformObject(ISceneObject parent)
        {
            this.parent = parent;
        }
        private ISceneObject parent;
        public ISceneObject Parent { get => parent; }
        public List<ISceneObject> Children { get; set; } = new List<ISceneObject>();
        public float[][] Matrix { get; set; } = new float[4][]
         {
                new float[4]{1,0,0,0},
                new float[4]{0,1,0,0},
                new float[4]{0,0,1,0},
                new float[4]{0,0,0,1}
         };
        public string Name { get; set; } = "Root";
    }
}
