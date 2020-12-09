using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{
    class Polygon
    {
        List<PointInt> v;
        Color basicColor = Color.Gray;
        public List<PointInt> pointsInside;
        Vector normal;

        public Polygon(List<PointInt> vertex, Color color)
        {
            pointsInside = new List<PointInt>();
            v = vertex;
            basicColor = color;
            normal = GetNormal();
        }

        public void CalculatePointsInside(int maxX, int maxY)
        {
            pointsInside = new List<PointInt>();
            List<PointInt> triangle = new List<PointInt>();
            triangle.Add(v[0]);
            triangle.Add(v[2]);
            triangle.Add(v[1]);
            CalculatePointsInsideTriangle(triangle, maxX, maxY);
            triangle = new List<PointInt>();
            triangle.Add(v[0]);
            triangle.Add(v[2]);
            triangle.Add(v[3]);
            CalculatePointsInsideTriangle(triangle, maxX, maxY);        
        }

        private void CalculatePointsInsideTriangle(List<PointInt> v, int lastXPossible, int lastYPossible, int firstXPossible = 0, int firstYPossible = 0)
        {
            int yMax, yMin;
            int[] x = new int[3], y = new int[3];

            for (int i = 0; i < 3; ++i)
            {
                x[i] = v[i].x;
                y[i] = v[i].y;
            }

            yMax = y.Max();
            yMin = y.Min();

            yMin = (yMin < firstYPossible) ? firstYPossible : yMin;
            yMax = (yMax < lastYPossible) ? yMax : lastYPossible;

            int x1 = 0, x2 = 0;
            double z1 = 0, z2 = 0;

            for (int yDot = yMin; yDot <= yMax; yDot++)
            {
                int fFirst = 1;
                for (int n = 0; n < 3; ++n)
                {
                    int n1 = (n == 2) ? 0 : n + 1;

                    if (yDot >= Math.Max(y[n], y[n1]) || yDot < Math.Min(y[n], y[n1]))
                        continue; 

                    double m = (double)(y[n] - yDot) / (y[n] - y[n1]);
                    if (fFirst == 0)
                    {
                        x2 = x[n] + (int)(m * (x[n1] - x[n]));
                        z2 = v[n].z + m * (v[n1].z - v[n].z);
                    }
                    else
                    {
                        x1 = x[n] + (int)(m * (x[n1] - x[n]));
                        z1 = v[n].z + m * (v[n1].z - v[n].z);
                    }
                    fFirst = 0;
                }

                if (x2 < x1)
                {
                    Swap(ref x1, ref x2);
                    Swap(ref z1, ref z2);
                }

                int xStart = (x1 < firstXPossible) ? firstXPossible : x1;
                int xEnd = (x2 < lastXPossible) ? x2 : lastXPossible;
                for (int xDot = xStart; xDot < xEnd; xDot++)
                {
                    double m = (double)(x1 - xDot) / (x1 - x2);
                    double zDot = z1 + m * (z2 - z1);

                    pointsInside.Add(new PointInt(xDot, yDot, (int)zDot));
                }
            }
        }

        public Vector GetNormal()
        {
            int len = v.Count();
            int a = 0, b = 0, c = 0;
            for (int i = 0; i < len - 1; i++)
            {
                a += (v[i].y - v[i + 1].y) * (v[i].z + v[i + 1].z);
                b += (v[i].x - v[i + 1].x) * (v[i].z + v[i + 1].z);
                c += (v[i].x - v[i + 1].x) * (v[i].y + v[i + 1].y);
            }
            a += (v[len - 1].y - v[0].y) * (v[len - 1].z + v[0].z);
            b += (v[len - 1].x - v[0].x) * (v[len - 1].z + v[0].z);
            c += (v[len - 1].x - v[0].x) * (v[len - 1].y + v[0].y);

            return new Vector(a, b, c);
        }

        public Color GetColor(LightSource light)
        {
            double cos = Vector.ScalarMultiplication(light.direction, normal) /
                (light.direction.length * normal.length);

            if (cos <= 0)
                return Colors.Mix(basicColor, Color.DarkGray, 0.4f);

            return Colors.Mix(basicColor, Color.DarkGray, (float)cos);

        }

        static void Swap<T>(ref T a, ref T b)
        {
            T temp = a;
            a = b;
            b = temp;
        }

        public List<PointInt> GetPointInts()
        {
            return v;
        }
    }
}
