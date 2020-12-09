using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clouds
{
    public partial class Form1 : Form
    {
        Graphics g;   
        Scene scene, newScene;
        RotateStruct turnKoefs = new RotateStruct(-90, 0, 0);
        ScaleStruct scaleKoefs = new ScaleStruct(1.25, 1.25, 1.25);
        MoveStruct moveKoefs = new MoveStruct(0, 0, 0);
        LightSource sun;
        Zbuffer zbuf;

        public Form1()
        {
            InitializeComponent();
            Rotation.SetSize(canvas.Width, canvas.Height);
            g = canvas.CreateGraphics();
            canvas.BackColor = Color.LightBlue;

            scale.DecimalPlaces = 2;
            scale.Increment = 0.25m;
            scale.Value = 0.25m;
        }

        private void SetSun()
        {
            sun = new LightSource(Color.White, 110, new Vector(-1, 1, 0));
        }
        
        private void HandleSceneChange()
        {
            newScene = scene.GetTransformed(turnKoefs, scaleKoefs, moveKoefs);
            zbuf = new Zbuffer(newScene, canvas.Size, sun);
            canvas.Image = zbuf.AddShadows();
        }

        private void CreateScene_Click(object sender, EventArgs e)
        {
            turnKoefs = new RotateStruct(-90, 0, 0);
            scaleKoefs = new ScaleStruct(1.25, 1.25, 1.25);
            moveKoefs = new MoveStruct(canvas.Width / 2, canvas.Height / 2 - 150, 0);

            scene = new Scene(canvas.Size);
            CreateCloud();
            if (CheckGenGround.Checked)
                CreateGround();
            SetSun();
            HandleSceneChange();
        }
        private void CreateCloud()
        {
            int knots = Convert.ToInt32(knotsForCloud.Value);
            int step = Convert.ToInt32(stepForCloud.Value);
            int heightDelta = Convert.ToInt32(heightDeltaCloud.Value);
            int size = Convert.ToInt32(mapSize.Value);
            int dh;
            if (CheckGenGround.Checked)
                dh = Convert.ToInt32(dhGround.Value);
            else
                dh = 0;
            scene.CreateCloud(size, knots, step, heightDelta, dh);
        }
        private void CreateGround()
        {
            int knots = Convert.ToInt32(knotsForGround.Value);
            int step = Convert.ToInt32(stepForGround.Value);
            int heightDelta = Convert.ToInt32(heightDeltaGround.Value);
            int size = Convert.ToInt32(mapSize.Value);
            scene.CreateGround(size, knots, step, heightDelta);
        }

        private void MoveLeft_Click(object sender, EventArgs e)
        {
            moveKoefs.dx -= Convert.ToInt32(move.Value);
            HandleSceneChange();
        }
        private void MoveRight_Click(object sender, EventArgs e)
        {
            moveKoefs.dx += Convert.ToInt32(move.Value);
            HandleSceneChange();
        }
        private void MoveUp_Click(object sender, EventArgs e)
        {
            moveKoefs.dy -= Convert.ToInt32(move.Value);
            HandleSceneChange();
        }
        private void MoveDown_Click(object sender, EventArgs e)
        {
            moveKoefs.dy += Convert.ToInt32(move.Value);
            HandleSceneChange();
        }

        private void RotateLeft_Click(object sender, EventArgs e)
        {
            turnKoefs.tetay += Convert.ToDouble(teta.Value);
            HandleSceneChange();
        }
        private void RotateRight_Click(object sender, EventArgs e)
        {
            turnKoefs.tetay -= Convert.ToDouble(teta.Value);
            HandleSceneChange();
        }
        private void RotateUp_Click(object sender, EventArgs e)
        {
            turnKoefs.tetax += Convert.ToDouble(teta.Value);
            HandleSceneChange();
        }
        private void RotateDown_Click(object sender, EventArgs e)
        {
            turnKoefs.tetax -= Convert.ToDouble(teta.Value);
            HandleSceneChange();
        }

        private void ScaleMore_Click(object sender, EventArgs e)
        {
            scaleKoefs.kx += Convert.ToDouble(scale.Value);
            scaleKoefs.ky += Convert.ToDouble(scale.Value);
            scaleKoefs.kz += Convert.ToDouble(scale.Value);
            HandleSceneChange();
        }

        private void ScaleLess_Click(object sender, EventArgs e)
        {
            scaleKoefs.kx -= Convert.ToDouble(scale.Value);
            scaleKoefs.ky -= Convert.ToDouble(scale.Value);
            scaleKoefs.kz -= Convert.ToDouble(scale.Value);
            HandleSceneChange();
        }
        private void CheckGenGround_CheckedChanged(object sender, EventArgs e)
        {
            bool state = false;
            if (CheckGenGround.Checked)
                state = true;
            groupBox6.Enabled = state;
        }
    }
}
