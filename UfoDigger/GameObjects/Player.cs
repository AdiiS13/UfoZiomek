using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger.GameObjects
{
    public class Player : UserControl
    {
        public Timer timerUpdate;
        private System.ComponentModel.IContainer components;
        public PictureBox pictureBox1;

        public int speed = 5;
        

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UfoDigger.Properties.Resources.alien_bubble;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Enabled = true;
            this.timerUpdate.Interval = 25;
            this.timerUpdate.Tick += new System.EventHandler(this.Update);
            // 
            // Player
            // 
            this.Controls.Add(this.pictureBox1);
            this.Name = "Player";
            this.Size = new System.Drawing.Size(64, 64);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        public Player()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Update(object sender, EventArgs e)
        {
            //aktualizowanie pozycji gracza z dynamicznymi ograniczeniami zalenymi od rozmiaru okna
            if (Core.IsUp && (Top-speed > 0))
                Top -= speed;
            if (Core.IsDown && (Bottom+speed) < ParentForm.ClientRectangle.Height)
                Top += speed;
            if (Core.IsLeft && (Left-speed) > 0)
                Left -= speed;
            if (Core.IsRight && (Right+speed) < ParentForm.ClientRectangle.Width)
                Left += speed;
            
        }

        
    }
}
