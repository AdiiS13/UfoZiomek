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
        private Timer timerUpdate;
        private System.ComponentModel.IContainer components;
        private PictureBox pictureBox1;

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
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
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
            //aktualizowanie pozycji gracza
            if (Core.IsUp)
                Top -= speed;
            if (Core.IsDown)
                Top += speed;
            if (Core.IsLeft)
                Left -= speed;
            if (Core.IsRight)
                Left += speed;
        }
    }
}
