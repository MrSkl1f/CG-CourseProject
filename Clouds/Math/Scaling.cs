using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    static class Scaling
    {
        public static void ScalePoint(ref int x, ref int y, ref int z, ScaleStruct koefs)
        {
            double x_tmp = x;
            double y_tmp = y;
            double z_tmp = z;
            x = (int)(x_tmp * koefs.kx);
            y = (int)(y_tmp * koefs.ky);
            z = (int)(z_tmp * koefs.kz);
        }
    }

    class ScaleStruct
    {
        public double kx;
        public double ky;
        public double kz;
        public ScaleStruct(double kx, double ky, double kz)
        {
            this.kx = kx;
            this.ky = ky;
            this.kz = kz;
        }
    }
}
