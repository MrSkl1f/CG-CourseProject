using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    class Map
    {
        public int height;
        public int width;
        PerlinNoize noize;
        double[,] map;
        public double this[int i, int j]
        {
            get => map[i, j];
            set => map[i, j] = value;
        }

        public Map(int w, int h, int size)
        {
            height = size;
            width = size;
            noize = new PerlinNoize(w, h, 0, size);
            map = new double[width, height];
            CreateMap();
        }

        public Map(Map map)
        {
            this.height = map.height;
            this.width = map.width;
            this.map = new double[this.width, this.height];
            CopyMap(map);
        }

        private void CopyMap(Map map)
        {
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    this.map[i, j] = map.map[i, j];
                }
            }
        }

        public void CreateMap()
        { 
            for (int i = 0; i < width; i++)
            {
                for (int j = 0; j < height; j++)
                {
                    map[i, j] = noize.Generate(i, j);
                }
            }
        }
    }
}
