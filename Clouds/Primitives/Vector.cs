using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    class Vector
    {
        public double x, y, z;
        public double length;

        public Vector(int x, int y, int z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            FindLength();
        }

        private void FindLength()
        {
            length = Math.Sqrt(x * x + y * y + z * z);
        }

        public static double ScalarMultiplication(Vector a, Vector b)
        {
            return a.x * b.x + a.y * b.y + a.z * b.z;
        }

    }
}
