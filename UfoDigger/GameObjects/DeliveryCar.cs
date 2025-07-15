using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger
{
    internal class DeliveryCar : UserControl
    {
        public Timer timerCarMovement;
        private System.ComponentModel.IContainer components;
        public PictureBox pictureBox1;

        private Form parentForm;
        private float rotationAngle = 0;

        public int speed = 15;

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerCarMovement = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UfoDigger.Properties.Resources.autotmpdelivery;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerCarMovement
            // 
            this.timerCarMovement.Enabled = true;
            //this.timerCarMovement.Stop();
            this.timerCarMovement.Interval = 25;
            this.timerCarMovement.Tick += new System.EventHandler(this.UpdateCar);
            // 
            // DeliveryCar
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "DeliveryCar";
            this.Size = new System.Drawing.Size(101, 51);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (this.FindForm() != null)
            {
                parentForm = this.FindForm();
                timerCarMovement.Start();
            }
        }
        public DeliveryCar()
        {
            InitializeComponent();
            //timerCarMovement.Start();
        }

        private void UpdateCar(object sender, EventArgs e)
        {
            //zabezpeczenie przed ParentForm == null
            if (parentForm == null) return;

            //aktualizowanie pozycji auta z dynamicznymi ograniczeniami zaleznymi od rozmiaru okna
            //now it also takes into account speed of car after upgrades
            // Move up
            if (Core.IsUp && Top > 0)
            {
                int moveAmount = Math.Min(speed, Top);
                Top -= moveAmount;
                rotationAngle = 270;
            }

            // Move down
            if (Core.IsDown && Top + Height < parentForm.ClientSize.Height)
            {
                int maxDistance = parentForm.ClientSize.Height - (Top + Height);
                int moveAmount = Math.Min(speed, maxDistance);
                Top += moveAmount;
                rotationAngle = 90;
            }

            // Move left
            if (Core.IsLeft && Left > 0)
            {
                int moveAmount = Math.Min(speed, Left);
                Left -= moveAmount;
                rotationAngle = 180;
            }

            // Move right
            if (Core.IsRight && Left + Width < parentForm.ClientSize.Width)
            {
                int maxDistance = parentForm.ClientSize.Width - (Left + Width);
                int moveAmount = Math.Min(speed, maxDistance);
                Left += moveAmount;
                rotationAngle = 0;
            }

            //obracanie auta w kierunku jazdy
            RotateCar();
        }

        private void RotateCar()
        {
            pictureBox1.Image = global::UfoDigger.Properties.Resources.autotmpdelivery;

            //obrot o odpowiedni kat
            var rotatedImage = new Bitmap(pictureBox1.Image);
            rotatedImage.RotateFlip(GetRotationFlip(rotationAngle));

            pictureBox1.Image = rotatedImage;
        }

        private RotateFlipType GetRotationFlip(float angle)
        {
            if (angle == 0) return RotateFlipType.RotateNoneFlipNone;
            if (angle == 90) return RotateFlipType.Rotate90FlipNone;
            if (angle == 180) return RotateFlipType.Rotate180FlipNone;
            if (angle == 270) return RotateFlipType.Rotate270FlipNone;

            return RotateFlipType.RotateNoneFlipNone;
        }

        private void DrawDebugRectangles()
        {
            using (Graphics g = parentForm.CreateGraphics())
            {
                g.Clear(parentForm.BackColor);
                g.DrawRectangle(Pens.Red, this.Bounds); // Outline of the car control
                g.DrawRectangle(Pens.Blue, pictureBox1.Bounds); // Outline of the image inside
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //this is just for debugging purposes, it draws a rectangle around the car control, delete it when not needed
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            e.Graphics.DrawRectangle(Pens.Red, 0, 0, Width - 1, Height - 1);
        }
    }
}
