using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{
    class LightSource
    {
        public Color color;
        public RotateStruct koefs;
        public Vector direction;

        public LightSource(Color color, double tetay, Vector direction)
        {
            this.direction = direction;
            this.color = color;
            this.koefs = new RotateStruct(90, tetay, 0);
        }
    }

}
