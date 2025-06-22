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

        public int houseCount { get; set; }
        public int trunkSize { get; set; }
        public int pizzaInTrunk { get; set; }
        public int numberOfUpgrades { get; set; }
        public int money { get; set; }
        public int payedPerPizza { get; set; }

        private List<PictureBox> housesList = new List<PictureBox>();
        private List<Label> housesLabel = new List<Label>();
        private List<PictureBox> thugsList = new List<PictureBox>();
        private Timer thugsTimer = new Timer();
        private bool checkIfItsFightTime = true;


        public DeliveryTime()
        {
            InitializeComponent();
            this.FormClosing += DeliveryTime_FormClosing;
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
            {
                Core.IsDown = false;
            }

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

            moneyL.Text = money.ToString();

            //spawnowanie rzeczy na mapie dostawy
            SpawnHouses(houseCount);
            //SpawnFuelCanisters();
            SpawnThugs(numberOfUpgrades);
        }

        private void SpawnThugs(int hooligansDifficulty)
        {
            int thugNumbers;
            //sprawdzenie liczby dresiarzy do spawnowania na podstawie ilosci upgrade'ow gracza
            if (hooligansDifficulty < 3)
                thugNumbers = 1;
            else if (hooligansDifficulty > 2 && hooligansDifficulty < 5)
                thugNumbers = 2;
            else if (hooligansDifficulty > 4 && hooligansDifficulty < 7)
                thugNumbers = 3;
            else if (hooligansDifficulty > 6 && hooligansDifficulty < 9)
                thugNumbers = 4;
            else thugNumbers = 5;

            //spawnowanie dresiarzy
            Random rng = new Random();
            for (int i = 0; i < thugNumbers; i++)
            { 
                PictureBox thug = new PictureBox();
                thug.Size = new Size(58, 39);
                thug.Image = global::UfoDigger.Properties.Resources.dresiarze;
                thug.BackColor = Color.Transparent;

                int maxX = this.ClientSize.Width - thug.Width;
                int maxY = this.ClientSize.Height - thug.Height;
                int x = rng.Next(0, Math.Max(1, maxX));
                int y = rng.Next(0, Math.Max(1, maxY));

                thug.Location = new Point(x, y);

                this.Controls.Add(thug);
                thugsList.Add(thug);
                thug.BringToFront();
            }
            thugsTimer.Interval = 200;
            thugsTimer.Tick += ThugsTimer_Tick;
            thugsTimer.Start();
        }

        private void ThugsTimer_Tick(object sender, EventArgs e)
        {
            foreach (var thug in thugsList)
            {
                MoveTorwards(thug, deliveryCar1.Location, 15);
            }
        }

        private void MoveTorwards(PictureBox thug, Point target, int speed)
        {
            Point current = thug.Location;

            int dx = target.X - current.X;
            int dy = target.Y - current.Y;

            double distance = Math.Sqrt(dx * dx + dy * dy);
            if (distance < 1) FightWithThugs();

            double stepX = dx / distance * speed;
            double stepY = dy / distance * speed;

            int newX = (int)(current.X + stepX);
            int newY = (int)(current.Y + stepY);

            thug.Location = new Point(newX, newY);
        }

        private void FightWithThugs()
        {
            ThugsFight thugsFight = new ThugsFight();
            thugsTimer.Stop();
            timer1.Stop();
            checkIfItsFightTime = false;
            thugsFight.Show();

            thugsFight.FormClosed += async (s, args) =>
            {
                timer1.Start();
                await Task.Delay(3000);
                checkIfItsFightTime = true;
                thugsTimer.Start();
            };
        }

        private void SpawnFuelCanisters()
        {
            throw new NotImplementedException();
        }

        private void SpawnHouses(int pizzasToDeliver)
        {
            Random rng = new Random();

            for (int i = 0; i < pizzasToDeliver; i++)
            {
                PictureBox house = new PictureBox();
                house.Size = new Size(50, 50);
                house.Image = global::UfoDigger.Properties.Resources.house;

                //losowy spawn point
                int maxX = this.ClientSize.Width - house.Width;
                int maxY = this.ClientSize.Height - house.Height;
                int x = rng.Next(0, Math.Max(1, maxX));
                int y = rng.Next(0, Math.Max(1, maxY - 50)); //-50 zeby bylo miejsce na UI

                house.Location = new Point(x, y);

                Label label = new Label();
                label.Text = "press X to deliver";
                label.BackColor = Color.Yellow;
                label.Location = new Point(x - 25, y + 50);
                label.Visible = false;

                this.Controls.Add(house);
                this.Controls.Add(label);
                housesList.Add(house);
                housesLabel.Add(label);
                house.BringToFront();
                label.BringToFront();
            }
        }

        private void DeliveryTime_FormClosing(object sender, FormClosingEventArgs e)
        {
            //czyszczenie listy domow przy zamknieciu okna
            if (housesList.Count > 0) 
            {
                PictureBox house = housesList[0];
                Label lab = housesLabel[0];
                for (int i = 0; i < housesList.Count; i++)
                {                    
                    this.Controls.Remove(house);
                    this.Controls.Remove(lab);
                    house.Dispose();
                    lab.Dispose();
                    housesList.RemoveAt(0);
                    housesLabel.RemoveAt(0);
                }
            }
            //czyszczenie listy dresiarzy przy zamknieciu okna
            for (int i = 0; i < thugsList.Count; i++)
            {
                this.Controls.Remove(thugsList[0]);
                thugsList[0].Dispose();
                thugsList.RemoveAt(0);
            }
        }

        private void Update(object sender, EventArgs e)
        {
            //sprawdzanie czy auto jest przy domu i czy dresiarze sa przy aucie
            var carIntersectsHouse = housesList.FirstOrDefault(house =>
                deliveryCar1.pictureBox1.RectangleToScreen(deliveryCar1.pictureBox1.ClientRectangle)
                .IntersectsWith(house.RectangleToScreen(house.ClientRectangle)));
 
            var thugIntersectsCar = thugsList.FirstOrDefault(thug =>
                deliveryCar1.pictureBox1.RectangleToScreen(deliveryCar1.pictureBox1.ClientRectangle)
                .IntersectsWith(thug.RectangleToScreen(thug.ClientRectangle)));

            if (carIntersectsHouse != null)
            {
                int index = housesList.IndexOf(carIntersectsHouse);
                housesLabel[index].Visible = true;

                if ((GetAsyncKeyState(Keys.X) & 0x8000) != 0)
                {
                    DeliverDaPizza(index);
                }
            }

            else makeLabelsInvisible();

            if (thugIntersectsCar != null && checkIfItsFightTime) 
            {
                FightWithThugs();
            }

            moneyL.Text = money.ToString();
        }

        private void DeliverDaPizza(int id)
        {
            //otrzymaj zaplate za dostawe
            money += payedPerPizza;

            //usun dom i label
            PictureBox house = housesList[id];
            Label lab = housesLabel[id];
            this.Controls.Remove(house);
            this.Controls.Remove(lab);
            house.Dispose();
            lab.Dispose();
            housesList.RemoveAt(id);
            housesLabel.RemoveAt(id);

        }

        private void makeLabelsInvisible()
        {
            foreach (var labl in housesLabel)
            {  labl.Visible = false; }
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
