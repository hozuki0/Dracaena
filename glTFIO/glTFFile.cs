using System;
using Newtonsoft.Json;


namespace glTFIO
{
    public class glTFFile
    {
        public glTFFile(string path)
        {
            using (var stream = new System.IO.StreamReader(path))
            {
                var jsonObjects = JsonConvert.DeserializeObject(stream.ReadToEnd());
                Console.WriteLine(jsonObjects);
            }
        }
    }
}
