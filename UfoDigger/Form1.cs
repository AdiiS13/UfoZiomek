﻿using System;
using System.Media;
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

        public int amountOfMoney = 1000; // Current value is only for testing purposes, remember to change it later!!!
        public int carSpeed = 10;
        public int carTrunkCapacity = 1;
        public int carTrunkPizzaInside = 0;
        public int fuelTankCapacity = 100;
        public int fuelTankStatus = 0; // Saves the current fuel level
        public int numberOfUpgrades = 0;
        public int singlePizzaValue = 5;
        DeliveryCar deliveryCar = new DeliveryCar();
        public bool hasPizzaInHand = false;
        public bool hasFullTrunk = false;

        public bool ufoPart = false;
        public int finalUpgradeDone = 50;

        //Saves the upgrade levels for the car
        public int speedUpgradeLvl = 1;
        public int trunkUpgradeLvl = 1;
        public int fuelUpgradeLvl = 1;

        //Keeps track of the opened forms
        private Workbench workbenchForm;
        private DeliveryTime deliveryTimeForm;


        SoundPlayer bgm = new SoundPlayer(global::UfoDigger.Properties.Resources.KSHMR_fx11);
        SoundPlayer phone = new SoundPlayer(global::UfoDigger.Properties.Resources.KSHMR_fx08);

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Set the fuel tank status to full at the start
            fuelTankStatus = fuelTankCapacity;


            bgm.PlayLooping();

            KeyPreview = true;
            MakeLabelsInvisible();
            deliveryCar.timerCarMovement.Stop();
            UpdateFuelLabel(); // Initialize the label
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
                        // Check the trunk capacity
                        if ((carTrunkPizzaInside) < carTrunkCapacity)
                        {
                            PizzaInteractions("o");
                            carTrunkPizzaInside += 1;
                        }
                        else
                        {
                            // Trunk is full, just put the pizza back (remove from hand)
                            PizzaInteractions("o");
                            MessageBox.Show("The trunk is full! Pizza was put back.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        // Always update the trunk space label
                        labelTrunkSpace.Text = $"Available space: {carTrunkPizzaInside}/{carTrunkCapacity}";
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

            if (ufoPart)
            {

                //przypomnienie co 5s ze telefon zadzwonil
                if (finalUpgradeDone > 50)
                {
                    phone.Play();
                    finalUpgradeDone = 0;
                    MessageBox.Show("Telefon właśnie zadzwonił! :O chyba powinienem odebrać", "WUT Telefon?!");
                }
            }
            finalUpgradeDone++;
            // Update the trunk space label
            labelTrunkSpace.Text = $"Available space: {carTrunkPizzaInside}/{carTrunkCapacity}";
        }

        void WorkbenchInteractions()
        {
            Core.ResetMovement(); // Reset movement keys before switching forms
            // Check if the workbench form is already open
            if (workbenchForm == null || workbenchForm.IsDisposed)
            {
                // If not, create a new instance of the Workbench form
                workbenchForm = new Workbench(this);

                timerForm1.Enabled = false;
                player1.timerUpdate.Enabled = false;

                // Pass the necessary data to the workbench form
                workbenchForm.FormClosed += (s, args) =>
                {
                    UpdateFuelLabel();
                    workbenchForm = null; // Allow opening again after close
                    Core.ResetMovement(); // Reset again on close
                };

                workbenchForm.Show(this);
            }
            else
            {
                workbenchForm.Focus();
            }
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
        }

        private void PhoneInteractions()
        {
            timerForm1.Enabled = false;
            player1.timerUpdate.Enabled = false;
            //TU TREŚĆ FUNKCJI z jakimś przyjmowaniem zamówień
            if (!ufoPart)
            {
                MessageBox.Show("Telefon, relikt przeszłości... Na szczęście wszystko teraz odbywa się przez aplikację, nie trzeba czekać na to aż klient zadzwoni, a ja mogę dostarczyć tyle pizzy ile mi się zmieści do bagażnika :D", "głuchy telefon", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                DialogResult res = MessageBox.Show("Nareszcie udało mi się naprawić statek! W końcu mogę wrócić do domu!", "Koniec gry", MessageBoxButtons.OKCancel, MessageBoxIcon.Asterisk);
                if (res == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
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
            Core.ResetMovement(); // Reset movement keys before switching forms
            //check if the delivery time form is already open
            if (deliveryTimeForm == null || deliveryTimeForm.IsDisposed)
            {
                deliveryTimeForm = new DeliveryTime(this);

                bgm.Stop();
                timerForm1.Enabled = false;
                player1.timerUpdate.Enabled = false;
                deliveryCar.timerCarMovement.Start();

                // przekazanie danych do dostawy
                deliveryTimeForm.money = amountOfMoney;
                deliveryTimeForm.houseCount = carTrunkPizzaInside;
                deliveryTimeForm.pizzaInTrunk = carTrunkPizzaInside;
                deliveryTimeForm.trunkSize = carTrunkCapacity;
                deliveryTimeForm.fuelTankCapacity = fuelTankCapacity;
                deliveryTimeForm.fuelTankStatus = fuelTankStatus;
                deliveryTimeForm.numberOfUpgrades = numberOfUpgrades;
                deliveryTimeForm.payedPerPizza = singlePizzaValue;
                deliveryTimeForm.carSpeed = carSpeed;

                // Handle the form closed event to update the main form variables
                deliveryTimeForm.FormClosed += (s, args) =>
                {
                    amountOfMoney = deliveryTimeForm.money;
                    fuelTankStatus = deliveryTimeForm.fuelTankStatus;
                    fuelTankCapacity = deliveryTimeForm.fuelTankCapacity;
                    if (deliveryTimeForm.ShouldResetTrunk)
                        carTrunkPizzaInside = 0;
                    UpdateFuelLabel();
                    bgm.PlayLooping();
                    deliveryTimeForm = null; // Allow opening again after close
                    Core.ResetMovement(); // Reset again on close
                };

                deliveryTimeForm.Show(this);
            }
            else
            {
                // If the form is already open, just focus on it
                deliveryTimeForm.Focus();
            }
            timerForm1.Enabled = true;
            player1.timerUpdate.Enabled = true;
            this.carSpeed = deliveryTimeForm.carSpeed;
        }
        
        private void MakeLabelsInvisible()
        {
            labelWorkbench.Visible = false;
            labelPickupPizza.Visible = false;
            labelPutDownPizza.Visible = false; 
            labelDelivery.Visible = false;
            labelPhone.Visible = false;
        }

        // Updates the fuel label to show the current fuel status
        private void UpdateFuelLabel()
        {
            labelFuelLeft.Text = $"Fuel: {fuelTankStatus}/{fuelTankCapacity}";
        }
    }
}
