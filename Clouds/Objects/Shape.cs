using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{
    class Shape : Object    
    {
        Map map;
        Color col;
        int dh;
        List<Polygon> polygons;
        
        public Shape(Map map, Color col, int dh, int step = 2, int heightDelta = 100)
        {
            this.map = map;
            this.col = col;
            this.dh = dh;
            polygons = new List<Polygon>();
            CreateModel(step, heightDelta);
        }
        private void CreateModel(int step, int heightDelta)
        {
            polygons = new List<Polygon>();
            int xOffset = -map.width / 2;
            int yOffsetZero = -map.height / 2;
            int yOffset;
            for (int i = 0; i < map.width - step; i += step, xOffset += step)
            {
                yOffset = yOffsetZero;
                for (int j = 0; j < map.height - step; j += step, yOffset += step)
                {
                    List<PointInt> points = new List<PointInt>();
                    points.Add(new PointInt(xOffset, yOffset, (int)(map[i, j] * heightDelta)));
                    points.Add(new PointInt(xOffset, yOffset + step, (int)(map[i, j + step] * heightDelta)));
                    points.Add(new PointInt(xOffset + step, yOffset + step, (int)(map[i + step, j + step] * heightDelta)));
                    points.Add(new PointInt(xOffset + step, yOffset, (int)(map[i + step, j] * heightDelta)));
                    polygons.Add(new Polygon(points, col));
                }
            }
        }
        private void TurnModel(RotateStruct turnKoefs)
        {
            double tetax = turnKoefs.tetax * Math.PI / 180;
            double tetay = turnKoefs.tetay * Math.PI / 180;
            double tetaz = turnKoefs.tetaz * Math.PI / 180;
            double cosTetX = Math.Cos(tetax), sinTetX = Math.Sin(tetax);
            double cosTetY = Math.Cos(tetay), sinTetY = Math.Sin(tetay);
            double cosTetZ = Math.Cos(tetaz), sinTetZ = Math.Sin(tetaz);
            foreach (Polygon pol in polygons)
            {
                foreach (PointInt v in pol.GetPointInts())
                {
                    Rotation.Transform(ref v.x, ref v.y, ref v.z, cosTetX, sinTetX, cosTetY, sinTetY, cosTetZ, sinTetZ, dh);
                }
            }
        }
        private void ScaleModel(ScaleStruct scaleKoefs)
        {
            foreach (Polygon pol in polygons)
            {
                foreach (PointInt v in pol.GetPointInts())
                {
                    Scaling.ScalePoint(ref v.x, ref v.y, ref v.z, scaleKoefs);
                }
            }
        }
        private void MoveModel(MoveStruct moveKoefs)
        {
            foreach (Polygon pol in polygons)
            {
                foreach (PointInt v in pol.GetPointInts())
                {
                    Moving.MovePoint(ref v.x, ref v.y, ref v.z, moveKoefs);
                }
            }
        }
        public override Object Transform(RotateStruct turnKoefs, ScaleStruct scaleKoefs, MoveStruct moveKoefs)
        {
            Map newMap = new Map(map);
            Shape shape = new Shape(newMap, col, dh);

            shape.TurnModel(turnKoefs);
            shape.ScaleModel(scaleKoefs);
            shape.MoveModel(moveKoefs);

            return shape;
        }
        public override List<Polygon> GetPolygons()
        {
            return polygons;
        }
    }
}
