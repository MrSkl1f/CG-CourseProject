using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clouds
{
    class FloatVector
    {
        public double X { get; set; }
        public double Y { get; set; }
        public FloatVector() { }
        public FloatVector(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }
        public double MultiplyVectors(FloatVector v)
        {
            return this.X * v.X + this.Y * v.Y;
        }
    }
}
