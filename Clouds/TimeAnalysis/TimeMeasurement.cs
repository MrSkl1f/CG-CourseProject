using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;
using System.Drawing;

namespace Clouds
{
    static class TimeMeasurement
    {
        private const int maxSize = 1001;
        private const int maxStep = 10; 
        private const int numberOfRepetitions = 5;
        public static void CheckTimeMap()
        {
            Stopwatch clock = new Stopwatch();
            List<string> line = new List<string>();
            for (int i = 0; i < maxSize; i += 100)
            {
                long time = 0;
                for (int j = 0; j < numberOfRepetitions; j++)
                {
                    clock.Restart();
                    Map curMap = new Map(6, 6, i);
                    clock.Stop();
                    time += clock.ElapsedTicks;
                }
                time /= numberOfRepetitions;
                line.Add((i + 1).ToString() + " " + time.ToString());
            }
            string path = "C:/Users/MrSklif/Desktop/BMSTU/CG_CP/Clouds/RPZ/source/Size.dat";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, line);
        }
        public static void CheckTimeShape()
        {
            Stopwatch clock = new Stopwatch();
            Map map = new Map(6, 6, 100);
            List<string> line = new List<string>();
            for (int i = 0; i < maxStep; i++)
            {
                long time = 0;
                for (int j = 0; j < numberOfRepetitions; j++)
                {
                    clock.Restart();
                    Shape curShape = new Shape(map, Color.Gray, i);
                    clock.Stop();
                    time += clock.ElapsedTicks;
                }
                time /= numberOfRepetitions;
                line.Add((i + 1).ToString() + " " + time.ToString());
            }
            string path = "C:/Users/MrSklif/Desktop/BMSTU/CG_CP/Clouds/RPZ/source/Step.dat";
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            File.AppendAllLines(path, line);
        }
    }
}
