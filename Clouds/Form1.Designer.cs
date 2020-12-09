namespace Clouds
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.canvas = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RotateLeft = new System.Windows.Forms.Button();
            this.RotateRight = new System.Windows.Forms.Button();
            this.teta = new System.Windows.Forms.NumericUpDown();
            this.RotateUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RotateDown = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ScaleMore = new System.Windows.Forms.Button();
            this.scale = new System.Windows.Forms.NumericUpDown();
            this.ScaleLess = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.MoveLeft = new System.Windows.Forms.Button();
            this.move = new System.Windows.Forms.NumericUpDown();
            this.MoveRight = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MoveUp = new System.Windows.Forms.Button();
            this.MoveDown = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.CheckGenGround = new System.Windows.Forms.CheckBox();
            this.CreateScene = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.heightDeltaGround = new System.Windows.Forms.NumericUpDown();
            this.label8 = new System.Windows.Forms.Label();
            this.stepForGround = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.knotsForGround = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.mapSize = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dhGround = new System.Windows.Forms.NumericUpDown();
            this.heightDeltaCloud = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.stepForCloud = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.knotsForCloud = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.move)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightDeltaGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepForGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knotsForGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSize)).BeginInit();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dhGround)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightDeltaCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepForCloud)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.knotsForCloud)).BeginInit();
            this.SuspendLayout();
            // 
            // canvas
            // 
            this.canvas.Location = new System.Drawing.Point(12, 12);
            this.canvas.Name = "canvas";
            this.canvas.Size = new System.Drawing.Size(881, 519);
            this.canvas.TabIndex = 0;
            this.canvas.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RotateLeft);
            this.groupBox1.Controls.Add(this.RotateRight);
            this.groupBox1.Controls.Add(this.teta);
            this.groupBox1.Controls.Add(this.RotateUp);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.RotateDown);
            this.groupBox1.Location = new System.Drawing.Point(1045, 240);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(140, 175);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поворот";
            // 
            // RotateLeft
            // 
            this.RotateLeft.Location = new System.Drawing.Point(6, 45);
            this.RotateLeft.Name = "RotateLeft";
            this.RotateLeft.Size = new System.Drawing.Size(125, 26);
            this.RotateLeft.TabIndex = 19;
            this.RotateLeft.Text = "Влево";
            this.RotateLeft.UseVisualStyleBackColor = true;
            this.RotateLeft.Click += new System.EventHandler(this.RotateLeft_Click);
            // 
            // RotateRight
            // 
            this.RotateRight.Location = new System.Drawing.Point(6, 77);
            this.RotateRight.Name = "RotateRight";
            this.RotateRight.Size = new System.Drawing.Size(125, 26);
            this.RotateRight.TabIndex = 20;
            this.RotateRight.Text = "Вправо";
            this.RotateRight.UseVisualStyleBackColor = true;
            this.RotateRight.Click += new System.EventHandler(this.RotateRight_Click);
            // 
            // teta
            // 
            this.teta.Increment = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.teta.Location = new System.Drawing.Point(41, 19);
            this.teta.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.teta.Name = "teta";
            this.teta.Size = new System.Drawing.Size(90, 20);
            this.teta.TabIndex = 14;
            this.teta.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // RotateUp
            // 
            this.RotateUp.Location = new System.Drawing.Point(6, 109);
            this.RotateUp.Name = "RotateUp";
            this.RotateUp.Size = new System.Drawing.Size(125, 26);
            this.RotateUp.TabIndex = 21;
            this.RotateUp.Text = "Вверх";
            this.RotateUp.UseVisualStyleBackColor = true;
            this.RotateUp.Click += new System.EventHandler(this.RotateUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "teta";
            // 
            // RotateDown
            // 
            this.RotateDown.Location = new System.Drawing.Point(6, 141);
            this.RotateDown.Name = "RotateDown";
            this.RotateDown.Size = new System.Drawing.Size(125, 26);
            this.RotateDown.TabIndex = 22;
            this.RotateDown.Text = "Вниз";
            this.RotateDown.UseVisualStyleBackColor = true;
            this.RotateDown.Click += new System.EventHandler(this.RotateDown_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ScaleMore);
            this.groupBox2.Controls.Add(this.scale);
            this.groupBox2.Controls.Add(this.ScaleLess);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(900, 421);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(139, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Масштаб";
            // 
            // ScaleMore
            // 
            this.ScaleMore.Location = new System.Drawing.Point(9, 45);
            this.ScaleMore.Name = "ScaleMore";
            this.ScaleMore.Size = new System.Drawing.Size(125, 25);
            this.ScaleMore.TabIndex = 23;
            this.ScaleMore.Text = "Больше";
            this.ScaleMore.UseVisualStyleBackColor = true;
            this.ScaleMore.Click += new System.EventHandler(this.ScaleMore_Click);
            // 
            // scale
            // 
            this.scale.Location = new System.Drawing.Point(41, 19);
            this.scale.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.scale.Name = "scale";
            this.scale.Size = new System.Drawing.Size(90, 20);
            this.scale.TabIndex = 17;
            this.scale.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ScaleLess
            // 
            this.ScaleLess.Location = new System.Drawing.Point(9, 77);
            this.ScaleLess.Name = "ScaleLess";
            this.ScaleLess.Size = new System.Drawing.Size(125, 25);
            this.ScaleLess.TabIndex = 24;
            this.ScaleLess.Text = "Меньше";
            this.ScaleLess.UseVisualStyleBackColor = true;
            this.ScaleLess.Click += new System.EventHandler(this.ScaleLess_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "koef";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.MoveLeft);
            this.groupBox3.Controls.Add(this.move);
            this.groupBox3.Controls.Add(this.MoveRight);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.MoveUp);
            this.groupBox3.Controls.Add(this.MoveDown);
            this.groupBox3.Location = new System.Drawing.Point(899, 240);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(140, 175);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сдвиг";
            // 
            // MoveLeft
            // 
            this.MoveLeft.Location = new System.Drawing.Point(8, 45);
            this.MoveLeft.Name = "MoveLeft";
            this.MoveLeft.Size = new System.Drawing.Size(125, 26);
            this.MoveLeft.TabIndex = 15;
            this.MoveLeft.Text = "Влево";
            this.MoveLeft.UseVisualStyleBackColor = true;
            this.MoveLeft.Click += new System.EventHandler(this.MoveLeft_Click);
            // 
            // move
            // 
            this.move.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.move.Location = new System.Drawing.Point(41, 19);
            this.move.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.move.Name = "move";
            this.move.Size = new System.Drawing.Size(90, 20);
            this.move.TabIndex = 15;
            this.move.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // MoveRight
            // 
            this.MoveRight.Location = new System.Drawing.Point(8, 77);
            this.MoveRight.Name = "MoveRight";
            this.MoveRight.Size = new System.Drawing.Size(125, 26);
            this.MoveRight.TabIndex = 16;
            this.MoveRight.Text = "Вправо";
            this.MoveRight.UseVisualStyleBackColor = true;
            this.MoveRight.Click += new System.EventHandler(this.MoveRight_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "delta";
            // 
            // MoveUp
            // 
            this.MoveUp.Location = new System.Drawing.Point(8, 109);
            this.MoveUp.Name = "MoveUp";
            this.MoveUp.Size = new System.Drawing.Size(125, 26);
            this.MoveUp.TabIndex = 17;
            this.MoveUp.Text = "Вверх";
            this.MoveUp.UseVisualStyleBackColor = true;
            this.MoveUp.Click += new System.EventHandler(this.MoveUp_Click);
            // 
            // MoveDown
            // 
            this.MoveDown.Location = new System.Drawing.Point(8, 141);
            this.MoveDown.Name = "MoveDown";
            this.MoveDown.Size = new System.Drawing.Size(125, 26);
            this.MoveDown.TabIndex = 18;
            this.MoveDown.Text = "Вниз";
            this.MoveDown.UseVisualStyleBackColor = true;
            this.MoveDown.Click += new System.EventHandler(this.MoveDown_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.CheckGenGround);
            this.groupBox4.Controls.Add(this.CreateScene);
            this.groupBox4.Controls.Add(this.groupBox6);
            this.groupBox4.Controls.Add(this.mapSize);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Location = new System.Drawing.Point(899, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(394, 205);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Создание изображения";
            // 
            // CheckGenGround
            // 
            this.CheckGenGround.AutoSize = true;
            this.CheckGenGround.Checked = true;
            this.CheckGenGround.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CheckGenGround.Location = new System.Drawing.Point(208, 146);
            this.CheckGenGround.Name = "CheckGenGround";
            this.CheckGenGround.Size = new System.Drawing.Size(115, 17);
            this.CheckGenGround.TabIndex = 25;
            this.CheckGenGround.Text = "Генерация земли";
            this.CheckGenGround.UseVisualStyleBackColor = true;
            this.CheckGenGround.CheckedChanged += new System.EventHandler(this.CheckGenGround_CheckedChanged);
            // 
            // CreateScene
            // 
            this.CreateScene.Location = new System.Drawing.Point(6, 152);
            this.CreateScene.Name = "CreateScene";
            this.CreateScene.Size = new System.Drawing.Size(189, 47);
            this.CreateScene.TabIndex = 19;
            this.CreateScene.Text = "Сгенерировать изображение";
            this.CreateScene.UseVisualStyleBackColor = true;
            this.CreateScene.Click += new System.EventHandler(this.CreateScene_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.heightDeltaGround);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.stepForGround);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.knotsForGround);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Location = new System.Drawing.Point(199, 19);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(187, 94);
            this.groupBox6.TabIndex = 24;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Земля";
            // 
            // heightDeltaGround
            // 
            this.heightDeltaGround.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightDeltaGround.Location = new System.Drawing.Point(89, 66);
            this.heightDeltaGround.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightDeltaGround.Name = "heightDeltaGround";
            this.heightDeltaGround.Size = new System.Drawing.Size(90, 20);
            this.heightDeltaGround.TabIndex = 22;
            this.heightDeltaGround.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 68);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Высота";
            // 
            // stepForGround
            // 
            this.stepForGround.Location = new System.Drawing.Point(89, 40);
            this.stepForGround.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.stepForGround.Name = "stepForGround";
            this.stepForGround.Size = new System.Drawing.Size(90, 20);
            this.stepForGround.TabIndex = 20;
            this.stepForGround.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Шаг полигона";
            // 
            // knotsForGround
            // 
            this.knotsForGround.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.knotsForGround.Location = new System.Drawing.Point(89, 14);
            this.knotsForGround.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.knotsForGround.Name = "knotsForGround";
            this.knotsForGround.Size = new System.Drawing.Size(90, 20);
            this.knotsForGround.TabIndex = 19;
            this.knotsForGround.Value = new decimal(new int[] {
            20,
            0,
            0,
            0});
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Узлы сетки";
            // 
            // mapSize
            // 
            this.mapSize.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.mapSize.Location = new System.Drawing.Point(278, 120);
            this.mapSize.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mapSize.Name = "mapSize";
            this.mapSize.Size = new System.Drawing.Size(90, 20);
            this.mapSize.TabIndex = 20;
            this.mapSize.Value = new decimal(new int[] {
            500,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(205, 122);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 21;
            this.label5.Text = "Размер";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dhGround);
            this.groupBox5.Controls.Add(this.heightDeltaCloud);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.stepForCloud);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Controls.Add(this.knotsForCloud);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Location = new System.Drawing.Point(6, 19);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(187, 127);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Облака";
            // 
            // dhGround
            // 
            this.dhGround.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.dhGround.Location = new System.Drawing.Point(89, 95);
            this.dhGround.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.dhGround.Name = "dhGround";
            this.dhGround.Size = new System.Drawing.Size(90, 20);
            this.dhGround.TabIndex = 24;
            this.dhGround.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // heightDeltaCloud
            // 
            this.heightDeltaCloud.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.heightDeltaCloud.Location = new System.Drawing.Point(89, 66);
            this.heightDeltaCloud.Maximum = new decimal(new int[] {
            500,
            0,
            0,
            0});
            this.heightDeltaCloud.Name = "heightDeltaCloud";
            this.heightDeltaCloud.Size = new System.Drawing.Size(90, 20);
            this.heightDeltaCloud.TabIndex = 22;
            this.heightDeltaCloud.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 89);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 26);
            this.label11.TabIndex = 25;
            this.label11.Text = "Расстояние до \r\nземли";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Высота";
            // 
            // stepForCloud
            // 
            this.stepForCloud.Location = new System.Drawing.Point(89, 40);
            this.stepForCloud.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.stepForCloud.Name = "stepForCloud";
            this.stepForCloud.Size = new System.Drawing.Size(90, 20);
            this.stepForCloud.TabIndex = 20;
            this.stepForCloud.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Шаг полигона";
            // 
            // knotsForCloud
            // 
            this.knotsForCloud.Increment = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.knotsForCloud.Location = new System.Drawing.Point(89, 14);
            this.knotsForCloud.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.knotsForCloud.Name = "knotsForCloud";
            this.knotsForCloud.Size = new System.Drawing.Size(90, 20);
            this.knotsForCloud.TabIndex = 19;
            this.knotsForCloud.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "Узлы сетки";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1303, 545);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.canvas);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.canvas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scale)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.move)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.heightDeltaGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepForGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knotsForGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mapSize)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dhGround)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.heightDeltaCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepForCloud)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.knotsForCloud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canvas;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.NumericUpDown teta;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown move;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown scale;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button MoveLeft;
        private System.Windows.Forms.Button MoveRight;
        private System.Windows.Forms.Button MoveUp;
        private System.Windows.Forms.Button MoveDown;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.NumericUpDown mapSize;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown knotsForCloud;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.NumericUpDown heightDeltaGround;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown stepForGround;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown knotsForGround;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown heightDeltaCloud;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown stepForCloud;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown dhGround;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button CreateScene;
        private System.Windows.Forms.Button RotateLeft;
        private System.Windows.Forms.Button RotateRight;
        private System.Windows.Forms.Button RotateUp;
        private System.Windows.Forms.Button RotateDown;
        private System.Windows.Forms.Button ScaleMore;
        private System.Windows.Forms.Button ScaleLess;
        private System.Windows.Forms.CheckBox CheckGenGround;
    }
}

