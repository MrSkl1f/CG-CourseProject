using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Clouds
{
    class Scene
    {
        List<Object> scene;
        Size size;

        public Scene(Size size)
        {
            scene = new List<Object>();
            this.size = size;
        }

        private void AddModel(Object obj)
        {
            scene.Add(obj);
        }
        
        public List<Object> GetModels()
        {
            return scene;
        }

        public void CreateCloud(int size, int hilling, int step, int heightDelta, int dh)
        {
            Map map = new Map(hilling, hilling, size);
            Object cloud = new Shape(map, Color.LightBlue, dh, step, heightDelta);
            scene.Add(cloud);
        }

        public void CreateGround(int size, int hilling, int step, int heightDelta)
        {
            Map map = new Map(hilling, hilling, size);
            Object ground = new Shape(map, Color.Green, 0, step, heightDelta);
            scene.Add(ground);
        }
        
        public Scene GetTransformed(RotateStruct turnKoefs, ScaleStruct scaleKoefs, MoveStruct moveKoefs)
        {
            Scene s = new Scene(size);

            foreach (Object obj in scene)
            {
                s.AddModel(obj.Transform(turnKoefs, scaleKoefs, moveKoefs));
            }

            return s;
        }
    }
        
}
