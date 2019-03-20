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
            var dir = @"../../sample/";
            var gltf = new glTFIO.glTFFile($"{dir}Avocado/gltf/Avocado.gltf");
            Console.Read();
        }
    }
}
