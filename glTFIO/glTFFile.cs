using System;
using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using glTFIO.Internal;

namespace glTFIO
{
    public class glTFFile
    {
        public AssetChunk Asset { get; private set; }

        public BufferViewChunk[] BufferViews { get; private set; }

        public BufferChunk[] Buffers { get; private set; }

        public SceneChunk[] Scenes { get; private set; }

        public CameraChunk Camera { get; set; }

        public MeshChunk[] Meshes { get; set; }

        public glTFFile(string path)
        {
            using (var stream = new System.IO.StreamReader(path))
            {
                var allglTF = stream.ReadToEnd();
                var jobject = JObject.Parse(allglTF);

                Asset = jobject["asset"].ToObject<AssetChunk>();
                BufferViews = jobject["bufferViews"].ToObject<BufferViewChunk[]>();
                Buffers = jobject["buffers"].ToObject<BufferChunk[]>();
                Scenes = jobject["scenes"].ToObject<SceneChunk[]>();
                Meshes = jobject["meshes"].ToObject<MeshChunk[]>();

                if (jobject.ContainsKey("camera"))
                {
                    Camera = jobject["camera"].ToObject<CameraChunk>();
                }
            }
        }
    }

}
