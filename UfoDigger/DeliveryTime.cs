using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger
{
    public partial class DeliveryTime : Form
    {

        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKeys);


        public DeliveryTime()
        {
            InitializeComponent();

            //KeyPreview = true;
        }

        private void DeliveryTime_Shown(object sender, EventArgs e)
        {
            this.Activate();
        }


        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = true;

            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = true;

            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;

            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = true;

        }

         private void OnKeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = false;

            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = false;

            if (e.KeyCode == Core.KeyLeft)
                Core.IsLeft = false;

            if (e.KeyCode == Core.KeyRight)
                Core.IsRight = false;
        }

        private void DeliveryTime_Load(object sender, EventArgs e)
        {
            KeyPreview = true;
            //deliveryCar1.timerCarMovement.Start();
            //this.KeyDown += DeliveryTime_KeyDown;
        }

        


        //tu niby dziala poruszanie sie ale nie jest plynne
        /*private void DeliveryTime_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.W) && (deliveryCar1.Top - deliveryCar1.speed) > 0)
                deliveryCar1.Top -= deliveryCar1.speed;
            if ((e.KeyCode == Keys.S) && (deliveryCar1.Bottom + deliveryCar1.speed) < this.ClientRectangle.Height)
                deliveryCar1.Top += deliveryCar1.speed;
            if ((e.KeyCode == Keys.A) && (deliveryCar1.Left - deliveryCar1.speed) > 0)
                deliveryCar1.Left -= deliveryCar1.speed;
            if ((e.KeyCode == Keys.D) && (deliveryCar1.Right + deliveryCar1.speed) < this.ClientRectangle.Width)
                deliveryCar1.Left += deliveryCar1.speed;
        }*/
    }
}
