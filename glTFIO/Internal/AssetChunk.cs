using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class AssetChunk
    {
        public string Copyright { get; set; }
        public string Generator { get; set; }
        public string Version { get; set; }
        public string MinVersion { get; set; }
        public object Extensions { get; set; }
        public object Extras { get; set; }
    }
}
