using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    abstract class Object
    {
        bool isVisible;
        public Object(bool isVisible = true)
        {
            this.isVisible = isVisible;
        }
        public abstract Object Transform(RotateStruct turnKoefs, ScaleStruct scaleKoefs, MoveStruct moveKoefs);
        public abstract List<Polygon> GetPolygons();
    }
}
