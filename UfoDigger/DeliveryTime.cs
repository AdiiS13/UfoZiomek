using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
        public int fuelTankCapacity { get; set; }
        public int fuelTankStatus { get; set; }

        public int carSpeed { get; set; }

        public bool ShouldResetTrunk => pizzaInTrunk > 0;

        private List<PictureBox> housesList = new List<PictureBox>();
        private List<Label> housesLabel = new List<Label>();
        private List<PictureBox> canisterList = new List<PictureBox>();
        private List<Label> canisterLabel = new List<Label>();
        private List<PictureBox> thugsList = new List<PictureBox>();
        private Timer thugsTimer = new Timer();
        private bool checkIfItsFightTime = true;
        private bool fuelSpawned = false;
        private int canistersInTrunk = 0;

        private Timer fuelTimer = new Timer();
        private int currentFuel;

        // Tracking stats
        private int pizzasDelivered = 0;
        private int moneyEarned = 0;
        private string deliveryStatus = "";

        private Form1 mainForm; // Reference to the main form

        // Reference to other forms to keep track if they are open
        private Workbench workbenchForm = null;
        private DeliveryTime deliveryTimeForm = null;

        public DeliveryTime(Form1 mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
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
            moneyL.Text = money.ToString();

            // Set up fuel gauge and save fuel tank state
            fuelGauge.Maximum = fuelTankCapacity;
            currentFuel = fuelTankStatus;
            fuelGauge.Value = currentFuel;
            labelFuelStatus.Text = $"Fuel: {currentFuel}/{fuelTankCapacity}";

            // Set up fuel timer to tick every 1 second
            fuelTimer.Interval = 1000; // 1 second
            fuelTimer.Tick += FuelTimer_Tick;
            fuelTimer.Start();

            SpawnFuelCanisters();
            SpawnHouses(houseCount);
            SpawnThugs(numberOfUpgrades);
            deliveryCar1.speed = carSpeed;
        }

        // Tick event for the fuel timer and checks fuel level
        private void FuelTimer_Tick(object sender, EventArgs e)
        {
            if (currentFuel > 5)
            {
                currentFuel -= 5;
                fuelGauge.Value = currentFuel;
            }
            else
            {
                currentFuel = 0;
                fuelGauge.Value = 0;
                fuelTimer.Stop();
                deliveryStatus = "Out of fuel";
                ShowSummaryAndClose();
            }
            labelFuelStatus.Text = $"Fuel: {currentFuel}/{fuelTankCapacity}";
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
            Core.ResetMovement(); // Prevent stuck movement when fight starts
            ThugsFight thugsFight = new ThugsFight();
            thugsTimer.Stop();
            timer1.Stop();
            checkIfItsFightTime = false;
            fuelTimer.Stop();

            thugsFight.Show();

            thugsFight.FormClosed += async (s, args) =>
            {
                timer1.Start();
                fuelTimer.Start();
                string fightResult = thugsFight.didUfoWon;
                if (fightResult == "L")
                {
                    money = money / 2;
                    moneyL.Text = money.ToString();
                    currentFuel = currentFuel / 2;
                }
                await Task.Delay(3000);
                checkIfItsFightTime = true;
                thugsTimer.Start();
            };
        }

        private void SpawnFuelCanisters()
        {
            if (!fuelSpawned)
            {
                Random rng = new Random();

                for (int i = 0; (houseCount * 2) > i; i++)
                {
                    PictureBox fuelC = new PictureBox();
                    fuelC.Size = new Size(50, 50);
                    fuelC.Image = global::UfoDigger.Properties.Resources.canister;
                    int maxX = this.ClientSize.Width - fuelC.Width;
                    int maxY = this.ClientSize.Height - fuelC.Height;
                    int x = rng.Next(0, Math.Max(1, maxX));
                    int y = rng.Next(0, Math.Max(1, maxY - 50)); //-50 zeby bylo miejsce na UI

                    fuelC.Location = new Point(x, y);
                    fuelC.SizeMode = PictureBoxSizeMode.Zoom;

                    Label label = new Label();
                    label.Text = "press F to pick up";
                    label.BackColor = Color.Yellow;
                    label.Location = new Point(x - 25, y + 50);
                    label.Visible = false;

                    this.Controls.Add(fuelC);
                    this.Controls.Add(label);
                    canisterList.Add(fuelC);
                    canisterLabel.Add(label);
                    fuelC.BringToFront();
                    label.BringToFront();
                    fuelSpawned = true;
                }
            }
        }

        private void SpawnHouses(int pizzasToDeliver)
        {
            Random rng = new Random();

            for (int i = 0; pizzasToDeliver > i; i++)
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
            // Stop the fuel timer
            fuelTimer.Stop();

            // Save the current fuel level to the property
            fuelTankStatus = currentFuel;

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

            var carIntersectsCanister = canisterList.FirstOrDefault(fuelC =>
                deliveryCar1.pictureBox1.RectangleToScreen(deliveryCar1.pictureBox1.ClientRectangle)
                .IntersectsWith(fuelC.RectangleToScreen(fuelC.ClientRectangle)));

            if (canisterList.Count > 0 && canistersInTrunk > 0 )
            {
                if ((GetAsyncKeyState(Keys.Z) & 0x8000) != 0)
                {
                    TankTheFuel();
                }
            }

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

            if (carIntersectsCanister != null && trunkSize > (pizzaInTrunk + canistersInTrunk)) 
            {
                int ind = canisterList.IndexOf(carIntersectsCanister);
                canisterLabel[ind].Visible = true;

                if ((GetAsyncKeyState(Keys.F) & 0x8000) != 0)
                {
                    PickUpCanister(ind);
                }
            }

            if (thugIntersectsCar != null && checkIfItsFightTime) 
            {
                FightWithThugs();
            }

            moneyL.Text = money.ToString();
            // Update the trunk status label
            labelTrunkStatus.Text = $"Pizzas in Trunk: {pizzaInTrunk}/{trunkSize}";
            canisterNumberLabel.Text = $"Canisters in Trunk: {canistersInTrunk}";
        }

        private void TankTheFuel()
        {
            currentFuel += 10;
            canistersInTrunk--;
        }

        private void PickUpCanister(int id)
        {
            //currentFuel += 5;
            canistersInTrunk++;

            //remove trash
            PictureBox can = canisterList[id];
            Label lab = canisterLabel[id];
            this.Controls.Remove(can);
            this.Controls.Remove(lab);
            can.Dispose();
            lab.Dispose();
            canisterList.RemoveAt(id);
            canisterLabel.RemoveAt(id);
        }

        private void DeliverDaPizza(int id)
        {
            money += payedPerPizza;
            moneyEarned += payedPerPizza;
            pizzasDelivered++;

            if (pizzaInTrunk > 0)
                pizzaInTrunk--;

            // Remove house and label
            PictureBox house = housesList[id];
            Label lab = housesLabel[id];
            this.Controls.Remove(house);
            this.Controls.Remove(lab);
            house.Dispose();
            lab.Dispose();
            housesList.RemoveAt(id);
            housesLabel.RemoveAt(id);

            // If all pizzas delivered
            if (pizzaInTrunk == 0 && housesList.Count == 0)
            {
                deliveryStatus = "Delivered all pizzas";
                ShowSummaryAndClose();
            }

            // Update trunk status label
            labelTrunkStatus.Text = $"Pizzas in Trunk: {pizzaInTrunk}/{trunkSize}";
        }

        // Show summary and close the form
        private void ShowSummaryAndClose()
        {
            int pizzas = pizzasDelivered;
            int money = moneyEarned;
            string status = deliveryStatus;

            // Schedule the summary form to open before closing this form
            this.Invoke((Action)(() =>
            {
                var summary = new DeliverySummary(this, mainForm); // mainForm is your Form1 instance
                summary.ShowSummary(pizzas, money, status);
                summary.ShowDialog();
            }));

            // Close this form after the summary dialog is shown
            this.Close();
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
