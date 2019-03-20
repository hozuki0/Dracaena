using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO
{
    public class CameraObject : ISceneObject
    {
        public CameraObject(ISceneObject parent)
        {
            this.parent = parent;
        }
        private ISceneObject parent;
        public ISceneObject Parent => parent;

        public List<ISceneObject> Children { get; set; } = new List<ISceneObject>();
        public string Name { get; set; }
        public float[][] Matrix { get; set; } = new float[4][]
         {
                new float[4]{1,0,0,0},
                new float[4]{0,1,0,0},
                new float[4]{0,0,1,0},
                new float[4]{0,0,0,1}
         };
    }
}
