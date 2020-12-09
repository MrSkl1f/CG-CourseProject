using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    static class Moving
    {
        public static void MovePoint(ref int x, ref int y, ref int z, MoveStruct moveKoefs)
        {
            x += moveKoefs.dx;
            y += moveKoefs.dy;
            z += moveKoefs.dz;
        }
    }
    class MoveStruct
    {
        public int dx;
        public int dy;
        public int dz;
        public MoveStruct(int dx, int dy, int dz)
        {
            this.dx = dx;
            this.dy = dy;
            this.dz = dz;
        }
    }
}
