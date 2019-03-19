using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracaena
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = @"C:\Working\Reference\glTF-Sample-Models\2.0\Box\glTF\";
            var gltf = new glTFIO.glTFFile($"{dir}Box.gltf");
            Console.Read();
        }
    }
}
