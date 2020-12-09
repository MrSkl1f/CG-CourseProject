using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    static class Rotation
    {
        static int centerX = 0;
        static int centerY = 0;
        
        public static void SetSize(int w, int h)
        {
            centerX = (int)(w/2);
            centerY = (int)(h/2);
        }
                
        static void RotateX(ref double y, ref double z, double tetax)
        {
            tetax = tetax * Math.PI / 180;
            double buf = y;
            y = centerY + Math.Cos(tetax) * (y - centerY) - Math.Sin(tetax) * z;
            z = Math.Cos(tetax) * z + Math.Sin(tetax) * (buf - centerY);
        }

        static void RotateX(ref double y, ref double z, double cosTetX, double sinTetX, int dh = 0)
        {
            double buf = y;
            int curCenY = centerY - dh;
            y = curCenY + cosTetX * (y - curCenY) - sinTetX * z;
            z = cosTetX * z + sinTetX * (buf - curCenY);
        }

        static void RotateY(ref double x, ref double z, double tetay)
        {
            tetay = tetay * Math.PI / 180;
            double buf = x;
            x = centerX + Math.Cos(tetay) * (x - centerX) - Math.Sin(tetay) * z;
            z = Math.Cos(tetay) * z + Math.Sin(tetay) * (buf - centerX);
        }

        static void RotateY(ref double x, ref double z, double cosTetY, double sinTetY, int dh = 0)
        {
            double buf = x;
            x = centerX + cosTetY * (x - centerX) - sinTetY * z;
            z = cosTetY * z + sinTetY * (buf - centerX);
        }

        static void RotateZ(ref double x, ref double y, double tetaz)
        {
            tetaz = tetaz * Math.PI / 180;
            double buf = x;
            x = centerX + Math.Cos(tetaz) * (x - centerX) - Math.Sin(tetaz) * (y - centerY);
            y = centerY + Math.Cos(tetaz) * (y - centerY) + Math.Sin(tetaz) * (buf - centerX);
        }

        static void RotateZ(ref double x, ref double y, double cosTetZ, double sinTetZ, int dh = 0)
        {
            double buf = x;
            int curCenY = centerY - dh;
            x = centerX + cosTetZ * (x - centerX) - sinTetZ * (y - curCenY);
            y = curCenY + cosTetZ * (y - curCenY) + sinTetZ * (buf - centerX);
        }

        public static void Transform(ref int x, ref int y, ref int z, double cosTetX, double sinTetX, double cosTetY, double sinTetY, double cosTetZ, double sinTetZ, int dh)
        {
            double x_tmp = x;
            double y_tmp = y;
            double z_tmp = z;
            RotateX(ref y_tmp, ref z_tmp, cosTetX, sinTetX, dh);
            RotateY(ref x_tmp, ref z_tmp, cosTetY, sinTetY, dh);
            RotateZ(ref x_tmp, ref y_tmp, cosTetZ, sinTetZ, dh);

            x = (int)x_tmp;
            y = (int)y_tmp;
            z = (int)z_tmp;
        }

        public static PointInt Transform(int x, int y, int z, RotateStruct koefs)
        {
            double x_tmp = x;
            double y_tmp = y;
            double z_tmp = z;
            RotateX(ref y_tmp, ref z_tmp, koefs.tetax);
            RotateY(ref x_tmp, ref z_tmp, koefs.tetay);
            RotateZ(ref x_tmp, ref y_tmp, koefs.tetaz);

            return new PointInt((int)x_tmp, (int)y_tmp, (int)z_tmp);
        }   
    }

    class RotateStruct
    {
        public double tetax;
        public double tetay;
        public double tetaz;
        public RotateStruct(double tx, double ty, double tz)
        {
            this.tetax = tx;
            this.tetay = ty;
            this.tetaz = tz;
        }
    }
}
