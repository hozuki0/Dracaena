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

        public CameraChunk[] Cameras { get; private set; }

        public ImageChunk[] Images { get; private set; }

        public MeshChunk[] Meshes { get; private set; }

        public NodeChunk[] Nodes { get; private set; }

        public AnimationChunk[] Animations { get; private set; }

        public SkinChunk[] Skins { get; private set; }

        public TextureChunk[] Textures { get; private set; }

        public TextureInfoChunk[] TextureInfos { get; private set; }

        public MaterialChunk[] Materials { get; private set; }

        public AccessorChunk[] Accessors { get; private set; }

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
                Accessors = jobject["accessors"].ToObject<AccessorChunk[]>();

                if (jobject.ContainsKey("animations"))
                {
                    Animations = jobject["animations"].ToObject<AnimationChunk[]>();
                }
                if (jobject.ContainsKey("skins"))
                {
                    Skins = jobject["skins"].ToObject<SkinChunk[]>();
                }
                if (jobject.ContainsKey("textures"))
                {
                    Textures = jobject["textures"].ToObject<TextureChunk[]>();
                }
                if (jobject.ContainsKey("textureinfos"))
                {
                    TextureInfos = jobject["textureinfos"].ToObject<TextureInfoChunk[]>();
                }
                if (jobject.ContainsKey("skins"))
                {
                    Skins = jobject["skins"].ToObject<SkinChunk[]>();
                }
                if (jobject.ContainsKey("cameras"))
                {
                    Cameras = jobject["cameras"].ToObject<CameraChunk[]>();
                }
                if (jobject.ContainsKey("images"))
                {
                    Images = jobject["images"].ToObject<ImageChunk[]>();
                }
                if (jobject.ContainsKey("materials"))
                {
                    Materials = jobject["materials"].ToObject<MaterialChunk[]>();
                }
            }
        }
    }

}
