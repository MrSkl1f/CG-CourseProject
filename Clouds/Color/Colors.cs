using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{
    static class Colors
    {
        public static Color Mix(Color a, Color b, float coefA)
        {
            coefA = Math.Min(coefA, 1);
            float coefB = 1 - coefA;
            int red = (int)(a.R * coefA + b.R * coefB);
            int green = (int)(a.G * coefA + b.G * coefB);
            int blue = (int)(a.B * coefA + b.B * coefB);

            return Color.FromArgb(red, green, blue);
        }
    }
}
