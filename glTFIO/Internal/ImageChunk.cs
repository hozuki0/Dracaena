using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO.Internal
{
    public class ImageChunk : glTFDataChunkBase
    {
        public string Uri { get; set; }
        public string MimeType { get; set; }
        public int? BufferView { get; set; }
        public string Name { get; set; }
    }
}
