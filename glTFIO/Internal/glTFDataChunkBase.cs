using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class glTFDataChunkBase
    {
        public Dictionary<string, object> Extensions { get; set; }
        public object Extras { get; set; }
    }
}
