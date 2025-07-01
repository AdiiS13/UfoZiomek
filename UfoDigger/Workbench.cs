using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger
{
    public partial class Workbench : Form
    {

        // Reference to the Form1 (garage) to access variables like money and car stats
        private Form1 mainForm;

        // Arrays to hold upgrade names and their levels
        private string[] upgradeNames = { "Speed", "Trunk Capacity", "Fuel" };
        private int selectedUpgrade = 0;

        public Workbench(Form1 form)
        {
            InitializeComponent();

            // Store the reference to the main form
            mainForm = form;

            this.KeyPreview = true;
            this.KeyDown += Workbench_KeyDown;
        }

        private void Workbench_Load(object sender, EventArgs e)
        {
            // Updates the workbench display when it loads
            UpdateWB();
        }

        private void UpdateWB()
        {
            moneyLabel.Text = $"Money: ${mainForm.amountOfMoney}";
            upgradeListBox.Items.Clear();

            // Add upgrades to the list box
            for (int i = 0; i < upgradeNames.Length; i++)
            {
                string prefix = (i == selectedUpgrade) ? "> " : "  ";
                int level = GetUpgradeLevels(i);
                string costText = (level < 10) ? $"${GetUpgradeCost(level + 1)}" : "MAX";
                string line = $"{prefix}{upgradeNames[i]} (Level {level}) [{costText}]";
                upgradeListBox.Items.Add(line);
            }

            // Add Fuel Refill option
            int fuelRefillIndex = upgradeNames.Length;
            string fuelRefillPrefix = (selectedUpgrade == fuelRefillIndex) ? "> " : "  ";
            string fuelRefillStatus = (mainForm.fuelTankStatus < mainForm.fuelTankCapacity) ? "$50" : "FULL";
            string fuelRefillLine = $"{fuelRefillPrefix}Fuel Refill [{fuelRefillStatus}]";
            upgradeListBox.Items.Add(fuelRefillLine);

            // Add UFO Repair Part option
            string ufoPrefix = (selectedUpgrade == fuelRefillIndex + 1) ? "> " : "  ";
            string ufoStatus = mainForm.ufoPart ? "BOUGHT" : "$1000";
            string ufoLine = $"{ufoPrefix}UFO Repair Part [{ufoStatus}]";
            upgradeListBox.Items.Add(ufoLine);

            // Adjust selection if needed
            upgradeListBox.SelectedIndex = selectedUpgrade;
        }

        // Retrieves the current level of the upgrade based on the index
        private int GetUpgradeLevels(int index)
        {
            switch (index)
            {
                case 0: return mainForm.speedUpgradeLvl;
                case 1: return mainForm.trunkUpgradeLvl;
                case 2: return mainForm.fuelUpgradeLvl;
                default: return 0;
            }
        }

        // Calculates the cost of upgrading to the next level
        private int GetUpgradeCost(int currentLevel)
        {
            if (currentLevel >= 1 && currentLevel <= 4)
                return currentLevel * 5;
            else if (currentLevel >= 5 && currentLevel <= 7)
                return currentLevel * 10;
            else if (currentLevel >= 8 && currentLevel <= 10)
                return currentLevel * 15;
            else
                return 0;
        }

        // Handles keyboard inputs for navigating and upgrading
        private void Workbench_KeyDown(object sender, KeyEventArgs e)
        {
            int optionsCount = upgradeNames.Length + 2; // +2 for Fuel Refill and UFO Repair Part
            if (e.KeyCode == Keys.W)
            {
                selectedUpgrade = (selectedUpgrade - 1 + optionsCount) % optionsCount;
                UpdateWB();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                selectedUpgrade = (selectedUpgrade + 1) % optionsCount;
                UpdateWB();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.P)
            {
                TryUpgradeSelected();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                this.Close();
                e.Handled = true;
            }
        }

        private void TryUpgradeSelected()
        {
            int fuelRefillIndex = upgradeNames.Length; 
            int ufoIndex = upgradeNames.Length + 1;

            // Fuel Refill logic
            if (selectedUpgrade == fuelRefillIndex)
            {
                if (mainForm.fuelTankStatus >= mainForm.fuelTankCapacity)
                {
                    MessageBox.Show("Fuel tank is already full!", "Fuel Refill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mainForm.amountOfMoney < 50)
                {
                    MessageBox.Show("Not enough money to refill fuel!", "Fuel Refill", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                mainForm.amountOfMoney -= 50;
                mainForm.fuelTankStatus = mainForm.fuelTankCapacity;
                MessageBox.Show("Fuel tank refilled!", "Fuel Refill", MessageBoxButtons.OK, MessageBoxIcon.Information);
                UpdateWB();
                return;
            }

            // UFO Repair Part logic
            if (selectedUpgrade == ufoIndex)
            {
                if (mainForm.ufoPart)
                {
                    MessageBox.Show("You have already bought the UFO Repair Part!", "Already Bought", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (mainForm.amountOfMoney >= 1000)
                {
                    mainForm.amountOfMoney -= 1000;
                    mainForm.ufoPart = true;
                    MessageBox.Show("You bought the UFO Repair Part! The game is now over.", "Congratulations!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Application.Exit();
                }
                else
                {
                    MessageBox.Show("Not enough money to buy the UFO Repair Part!", "Purchase Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                UpdateWB();
                return;
            }

            // Upgrade logic for Speed, Trunk Capacity, and Fuel
            int currentLevel = GetUpgradeLevels(selectedUpgrade);

            if (currentLevel >= 10)
            {
                MessageBox.Show("This upgrade is already at max level!", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            int cost = GetUpgradeCost(currentLevel + 1); // Calculate the cost for the next level upgrade
            if (mainForm.amountOfMoney >= cost)
            {
                mainForm.amountOfMoney -= cost;

                switch (selectedUpgrade)
                {
                    case 0:
                        mainForm.speedUpgradeLvl = Math.Min(currentLevel + 1, 10);
                        mainForm.carSpeed += 5;
                        break;
                    case 1:
                        mainForm.trunkUpgradeLvl = Math.Min(currentLevel + 1, 10);
                        mainForm.carTrunkCapacity = mainForm.trunkUpgradeLvl;
                        break;
                    case 2:
                        if (mainForm.fuelUpgradeLvl < 10)
                        {
                            mainForm.fuelUpgradeLvl = Math.Min(currentLevel + 1, 10);
                            mainForm.fuelTankCapacity += 50;
                            mainForm.fuelTankStatus = mainForm.fuelTankCapacity;
                        }
                        break;
                }
                UpdateWB();
            }
            else
            {
                MessageBox.Show("Not enough money to upgrade!", "Upgrade Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
