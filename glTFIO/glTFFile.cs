using System;
using System.Collections;
using System.Linq;
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
                ShowAllMember(asset);

                var bufferViews = jobject["bufferViews"].ToObject<Internal.BufferViewChunk[]>();
                ShowAllMember(bufferViews);

                var buffers = jobject["buffers"].ToObject<Internal.BufferChunk[]>();
                ShowAllMember(buffers);

                var scenes = jobject["scenes"].ToObject<Internal.SceneChunk[]>();
                ShowAllMember(scenes);


            }
        }
        private static void ShowAllMember<T>(T value)
        {
            Console.WriteLine($"--{value.GetType()}Begin--");

            var props = value.GetType().GetProperties();
            foreach (var p in props)
            {
                if (p.PropertyType.IsArray)
                {
                    var arr = value.GetType().InvokeMember(p.Name, System.Reflection.BindingFlags.GetProperty, null, value, null) as IEnumerable;
                    foreach (var item in arr)
                    {
                        Console.WriteLine($"{p.Name}:{item}");
                    }
                }
                else
                {
                    var v = value.GetType().InvokeMember(p.Name, System.Reflection.BindingFlags.GetProperty, null, value, null);
                    Console.WriteLine($"{p.Name}:{v}");
                }
            }

            Console.WriteLine($"--{value.GetType()}End--\n");
        }
        private static void ShowAllMember<T>(T[] values)
        {
            foreach (var item in values)
            {
                ShowAllMember(item);
            }
        }
    }

}
