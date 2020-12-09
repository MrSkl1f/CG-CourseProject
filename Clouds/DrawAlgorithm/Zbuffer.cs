using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{

    class Zbuffer
    {
        Bitmap img;
        Bitmap imgFromSun;
        int[,] Zbuf;
        int[,] ZbufFromSun;
        
        LightSource sun;
        Size size;
        RotateStruct turnKoefs;
        int bg = -10000;
        
        public Zbuffer(Scene s, Size size, LightSource sun)
        {
            this.size = size;
            
            img = new Bitmap(size.Width, size.Height);
            imgFromSun = new Bitmap(size.Width, size.Height);

            InitBuffers();

            this.sun = sun;
            turnKoefs = sun.koefs;

            foreach (Object obj in s.GetModels())
            {
                ProcessObject(Zbuf, img, obj);
                ProcessObject(ZbufFromSun, imgFromSun, obj.Transform(turnKoefs, new ScaleStruct(1, 1, 1), new MoveStruct(0, 0, 0)));
            }
        }

        public Bitmap AddShadows()
        {
            Bitmap hm = new Bitmap(size.Width, size.Height);

            for (int i = 0; i < size.Width; i++)
            {
                for (int j = 0; j < size.Height; j++)
                {
                    int z = GetZ(i, j);
                    if (z != bg) 
                    {
                        PointInt cur = Rotation.Transform(i, j, z, turnKoefs);
                        
                        Color curPixColor = img.GetPixel(i, j);
                        if (cur.x < 0 || cur.y < 0 || cur.x >= size.Width || cur.y >= size.Height)
                        {
                            hm.SetPixel(i, j, curPixColor); 
                            continue;
                        }

                        if (ZbufFromSun[cur.y, cur.x] > cur.z + 5) 
                        {
                            Console.WriteLine("Yes");
                            hm.SetPixel(i, j, Colors.Mix(Color.DarkGray, curPixColor, 0.5f)); 
                        }
                        else
                        {
                            hm.SetPixel(i, j, curPixColor);
                        }
                    }
                }
            }

            return hm;
        }

        private void InitBuffers()
        {
            Zbuf = new int[size.Height, size.Width];
            ZbufFromSun = new int[size.Height, size.Width];

            for (int i = 0; i < size.Height; i++)
            {
                for (int j = 0; j < size.Width; j++)
                {
                    Zbuf[i, j] = bg;
                    ZbufFromSun[i, j] = bg;
                }
            }
        }

        private int GetZ(int x, int y)
        {
            return Zbuf[y, x];
        }

        private void ProcessObject(int[,] buffer, Bitmap image, Object obj)
        {
            Color col;
            foreach (Polygon polygon in obj.GetPolygons())
            {
                polygon.CalculatePointsInside(img.Width, img.Height);
                col = polygon.GetColor(sun);
                foreach (PointInt point in polygon.pointsInside)
                {
                    ProcessPoint(buffer, image, point, col);
                }
            }
        }

        private void ProcessPoint(int[,] buffer, Bitmap image, PointInt point, Color color)
        {
            
            if (!(point.x < 0 || point.x >= size.Width || point.y < 0 || point.y >= size.Height))
            {
                if (point.z > buffer[point.y, point.x])
                {
                    buffer[point.y, point.x] = point.z;
                    image.SetPixel(point.x, point.y, color);
                }
            }
        }

    }
}
