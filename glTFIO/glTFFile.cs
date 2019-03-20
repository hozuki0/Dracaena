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

        public CameraChunk Camera { get; private set; }
        public ImageChunk Image { get; private set; }

        public MeshChunk[] Meshes { get; private set; }

        public NodeChunk[] Nodes { get; private set; }

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
                Nodes = jobject["nodes"].ToObject<NodeChunk[]>();

                if (jobject.ContainsKey("camera"))
                {
                    Camera = jobject["camera"].ToObject<CameraChunk>();
                }
                if (jobject.ContainsKey("image"))
                {
                    Image = jobject["image"].ToObject<ImageChunk>();
                }
            }
        }
    }

}
