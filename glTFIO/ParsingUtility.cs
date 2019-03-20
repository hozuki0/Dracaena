using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace glTFIO
{
    public static class ParsingUtility
    {
        public static void Copy4x4From16Array(float[][] dst, float[] src)
        {
            if (dst.Length != 4 || dst[0].Length != 4) new Exception("Copy先の配列の要素が4x4ではありません");
            if (src.Length != 16) new Exception("Copy元の配列の要素が16ではありません");

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    dst[i][j] = src[i * 4 + j];
                }
            }
        }
    }
}
