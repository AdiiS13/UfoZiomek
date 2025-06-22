using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UfoDigger.GameObjects;
using System.Runtime.InteropServices;

namespace UfoDigger
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        private static extern short GetAsyncKeyState(Keys vKeys);

        public int amountOfMoney = 10;
        public int carSpeed = 10;
        public int carTrunkCapacity = 5;
        public int carTrunkPizzaInside = 0;
        public int fuelTankCapacity = 5;
        public int numberOfUpgrades = 0;
        public int singlePizzaValue = 5;
        DeliveryCar deliveryCar = new DeliveryCar();
        public bool hasPizzaInHand = false;
        public bool hasFullTrunk = false;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //włączenie czytania klawiszy
            KeyPreview = true;
            MakeLabelsInvisible();
            deliveryCar.timerCarMovement.Stop();
        }

        private void OnKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Core.KeyUp)
                Core.IsUp = true;
            
            if (e.KeyCode == Core.KeyDown)
                Core.IsDown = true;

            if(e.KeyCode == Core.KeyLeft)
                Core.IsLeft = true;

            if(e.KeyCode == Core.KeyRight)
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

        private void Update(object sender, EventArgs e)
        {
            //sprawdzanie czy gracz znajduje się w pobliżu obiektów, z kt może wejść w interakcję
            if (player1.pictureBox1.RectangleToScreen(player1.pictureBox1.ClientRectangle).IntersectsWith(pictureBoxCar.RectangleToScreen(pictureBoxCar.ClientRectangle)))
            {
                if (hasPizzaInHand) //jak ma pizze w ręce to może ją tylko odłożyć
                {
                    labelPutDownPizza.Visible = true;
                    if ((GetAsyncKeyState(Keys.O) & 0x8000) != 0)
                    {
                        PizzaInteractions("o");
                        carTrunkPizzaInside ++;
                    }
                }
                else if (carTrunkPizzaInside > 0) //jak nie ma pizzy w ręce to może przewieźć te co ma zapakowane
                {
                    labelDelivery.Visible = true;
                    if ((GetAsyncKeyState(Keys.C) & 0x8000) != 0)
                        CarInteractions();
                }
            }
            //jak nie ma pizzy w ręce to może wziąć pizzę
            else if (!hasPizzaInHand && player1.pictureBox1.RectangleToScreen(player1.pictureBox1.ClientRectangle).IntersectsWith(pictureBoxPizzaTable.RectangleToScreen(pictureBoxPizzaTable.ClientRectangle))) 
            {
                labelPickupPizza.Visible = true;
                if ((GetAsyncKeyState(Keys.P) & 0x8000) != 0)
                    PizzaInteractions("p");
            }
            //jak nie ma pizzy w ręce ORAZ nie ma pełnego bagażnika to może odebrać telefon i przyjąć zamówienie
            else if (!hasPizzaInHand && !hasFullTrunk && player1.pictureBox1.RectangleToScreen(player1.pictureBox1.ClientRectangle).IntersectsWith(pictureBoxPhone.RectangleToScreen(pictureBoxPhone.ClientRectangle)))
            {
                labelPhone.Visible = true;
                if ((GetAsyncKeyState(Keys.R) & 0x8000) != 0)
                    PhoneInteractions();
            }
            else if (player1.pictureBox1.RectangleToScreen(player1.pictureBox1.ClientRectangle).IntersectsWith(pictureBoxWorkbench.RectangleToScreen(pictureBoxWorkbench.ClientRectangle)))
            {
                labelWorkbench.Visible = true;
                if ((GetAsyncKeyState(Keys.E) & 0x8000) != 0)
                    WorkbenchInteractions();
            }
            else
                MakeLabelsInvisible();
        }

        

        private void WorkbenchInteractions()
        {
            Workbench workbench = new Workbench();

            timerForm1.Enabled = false;
            player1.timerUpdate.Enabled = false;
            //pokazuje okienko z dostępnymi ulepszeniami
            workbench.Show(this);
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
        }

        private void PhoneInteractions()
        {
            timerForm1.Enabled = false;
            player1.timerUpdate.Enabled = false;
            //TU TREŚĆ FUNKCJI z jakimś przyjmowaniem zamówień
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
        }

        private void PizzaInteractions(string x)
        {
            timerForm1.Enabled = false;
            player1.timerUpdate.Enabled = false;
            //podnoszenie i odkładanie pizzy
            switch (x)
            {
                case "p":
                    player1.pictureBox1.Image = global::UfoDigger.Properties.Resources.pizzatmp;
                    hasPizzaInHand = true;
                    break;
                case "o":
                    player1.pictureBox1.Image = global::UfoDigger.Properties.Resources.alien_bubble;
                    hasPizzaInHand = false;
                    labelPutDownPizza.Visible = false;
                    break;
            }
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
        }
        private void CarInteractions()
        {
            DeliveryTime deliveryTime = new DeliveryTime();

            timerForm1.Enabled = false;
            player1.timerUpdate.Enabled = false;
            deliveryCar.timerCarMovement.Start();

            //przekazanie danych do dostawy
            deliveryTime.money = amountOfMoney;
            deliveryTime.houseCount = carTrunkPizzaInside;
            deliveryTime.pizzaInTrunk = carTrunkPizzaInside;
            deliveryTime.trunkSize = carTrunkCapacity;
            deliveryTime.numberOfUpgrades = numberOfUpgrades;
            deliveryTime.payedPerPizza = singlePizzaValue;

            //odczyt danych po zamknieciu okienka
            deliveryTime.FormClosed += (s, args) =>
            {
                amountOfMoney = deliveryTime.money;
            };
                        
            //pokazuje okienko z losowo wygenerowaną mapą dostawy - tam się jeździ i dostarcza

            deliveryTime.Show(this);
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
        }
        
        private void MakeLabelsInvisible()
        {
            labelWorkbench.Visible = false;
            labelPickupPizza.Visible = false;
            labelPutDownPizza.Visible = false; 
            labelDelivery.Visible = false;
            labelPhone.Visible = false;
        }
    }
}
