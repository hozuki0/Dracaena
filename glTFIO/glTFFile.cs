using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace glTFIO
{
    public class glTFFile
    {
        public glTFFile(string path)
        {
            using (var stream = new System.IO.StreamReader(path))
            {
                var allglTF = stream.ReadToEnd();
                var jobject = JObject.Parse(allglTF);

                var asset = jobject["asset"].ToObject<Internal.AssetChunk>();
                Console.WriteLine($"{nameof(asset.Generator)}:{asset.Generator}");
                Console.WriteLine($"{nameof(asset.Version)}:{asset.Version}");

                var bufferViews = jobject["bufferViews"].ToObject<Internal.BufferViewChunk[]>();
                foreach (var item in bufferViews)
                {
                    Console.WriteLine($"{nameof(item.Buffer)}:{item.Buffer}");
                    Console.WriteLine($"{nameof(item.ByteLength)}:{item.ByteLength}");
                    Console.WriteLine($"{nameof(item.ByteOffset)}:{item.ByteOffset}");
                    Console.WriteLine($"{nameof(item.Target)}:{item.Target}");
                }
                var buffers = jobject["buffers"].ToObject<Internal.BufferChunk[]>();
                foreach(var item in buffers)
                {
                    Console.WriteLine($"{nameof(item.ByteLength)}:{item.ByteLength}");
                    Console.WriteLine($"{nameof(item.Uri)}:{item.Uri}");
                }

                //foreach(var item in jobject)
                //{
                //    Console.WriteLine(item);
                //}
            }
        }
    }
}
