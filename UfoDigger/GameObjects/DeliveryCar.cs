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
            if (Core.IsUp && (Top - speed > 0))
            {
                Top -= speed;
                rotationAngle = 270;            
            }
            if (Core.IsDown && (Bottom + speed) < parentForm.ClientRectangle.Height)
            {  
                Top += speed;
                rotationAngle = 90;            
            }
            if (Core.IsLeft && (Left - speed) > 0)
            { 
                Left -= speed;
                rotationAngle = 180;
            }
            if (Core.IsRight && (Right + speed) < parentForm.ClientRectangle.Width)
            { 
                Left += speed;
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

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
