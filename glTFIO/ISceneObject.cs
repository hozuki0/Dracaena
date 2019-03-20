using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO
{
    public interface ISceneObject
    {
        ISceneObject Parent { get; }       // Parent == null => Top
        List<ISceneObject> Children { get; set; }
    }
}
