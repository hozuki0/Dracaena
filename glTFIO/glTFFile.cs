using System;
using System.Collections;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using glTFIO.Internal;
using System.Collections.Generic;

namespace glTFIO
{
    public class glTFFile
    {
        public AssetChunk Asset { get; private set; }

        public BufferViewChunk[] BufferViews { get; private set; }

        public BufferChunk[] Buffers { get; private set; }

        // RESEARCH: Scene が複数ってどんな状況？
        public SceneChunk[] Scenes { get; private set; }
        public ISceneObject RootObject { get; private set; }
        private List<ISceneObject> sceneObjects;
        public List<ISceneObject> SceneObjects => sceneObjects;

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

            //Dictionary<BufferViewChunk, byte[]> bufferDict = new Dictionary<BufferViewChunk, byte[]>();
            //foreach (var view in BufferViews)
            //{
            //    using (var stream = new System.IO.FileStream(Buffers[view.Buffer].Uri, System.IO.FileMode.Open))
            //    using (var reader = new System.IO.BinaryReader(stream))
            //    {
            //        // offsetがあるとき読み捨てる
            //        if (view.ByteOffset.HasValue)
            //        {
            //            reader.ReadBytes(view.ByteOffset.Value);
            //        }
            //        bufferDict.Add(view, reader.ReadBytes(view.ByteLength));
            //    }
            //}

            BuildScene();

            sceneObjects = new List<ISceneObject>();
            CollectSceneObjectList(RootObject);
        }

        private void CollectSceneObjectList(ISceneObject parent)
        {
            sceneObjects.Add(parent);
            foreach (var item in parent.Children)
            {
                CollectSceneObjectList(item);
            }
        }

        private void BuildScene()
        {
            var topNode = Nodes.First();
            if (topNode.Children.Length == 0)
            {
                if (!topNode.Mesh.HasValue) throw new Exception("Scene Has No Object");
                var mesh = new MeshObject(null);
                BuildMesh(topNode, Meshes[topNode.Mesh.Value], mesh);
                RootObject = mesh;
                return;
            }

            RootObject = new TransformObject();
            foreach (var item in topNode.Children)
            {
                BuildNode(Nodes[item], topNode, RootObject);
            }

        }

        private void BuildSceneObject(NodeChunk nodeChunk, ISceneObject sceneObject)
        {
            ParsingUtility.Copy4x4From16Array(sceneObject.Matrix, nodeChunk.Matrix);
            if (nodeChunk.Name != null) sceneObject.Name = nodeChunk.Name;
            else sceneObject.Name = "NoName" + sceneObject.GetType().Name;
        }

        private void BuildNode(NodeChunk node, NodeChunk parentNode, ISceneObject parentObject)
        {
            ISceneObject scenedObject = null;
            // mesh
            if (node.Mesh.HasValue)
            {
                var mesh = new MeshObject(parentObject);
                BuildMesh(node, Meshes[node.Mesh.Value], mesh);
                scenedObject = mesh;
            }
            else if (node.Camera.HasValue)
            {
                var camera = new CameraObject(parentObject);
                BuildCamera(node, Cameras[node.Mesh.Value], camera);
                scenedObject = camera;
            }
            else
            {
                var transform = new TransformObject(parentObject);
                BuildSceneObject(node, transform);
                scenedObject = transform;
            }
            // 現在は一旦CameraとMesh以外は無視
            parentObject.Children.Add(scenedObject);

            foreach (var item in node.Children)
            {
                BuildNode(Nodes[item], node, scenedObject);
            }
        }

        private void BuildMesh(NodeChunk nodeChunk, MeshChunk meshChunk, MeshObject meshObject)
        {
            BuildSceneObject(nodeChunk, meshObject);
            meshObject.Translation = nodeChunk.Translation;
            meshObject.Rotation = nodeChunk.Rotation;
            meshObject.Scaling = nodeChunk.Scale;
            meshObject.MeshInfo = meshChunk;
        }

        private void BuildCamera(NodeChunk nodeChunk, CameraChunk cameraChunk, CameraObject cameraObject)
        {
            BuildSceneObject(nodeChunk, cameraObject);

        }
    }

}
