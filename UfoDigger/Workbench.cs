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
        private string[] upgradeNames = {"Speed", "Trunk Capacity", "Fuel"};
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
            for (int i = 0; i < upgradeNames.Length; i++)
            {
                string prefix = (i == selectedUpgrade) ? "> " : "  ";
                int level = GetUpgradeLevels(i);
                string costText = (level >= 10) ? "MAX" : $"${GetUpgradeCost(level)}";
                string line = $"{prefix}{upgradeNames[i]} (Level {level}) [{costText}]";
                upgradeListBox.Items.Add(line);
            }
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
            if (e.KeyCode == Keys.W)
            {
                // Move up in the upgrade list
                selectedUpgrade = (selectedUpgrade - 1 + upgradeNames.Length) % upgradeNames.Length;
                UpdateWB();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.S)
            {
                // Move down in the upgrade list
                selectedUpgrade = (selectedUpgrade + 1) % upgradeNames.Length;
                UpdateWB();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.P)
            {
                // Try to upgrade the selected upgrade
                TryUpgradeSelected();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                // Close the workbench when Escape is pressed
                this.Close();
                e.Handled = true;
            }
        }

        private void TryUpgradeSelected()
        {
            int currentLevel = GetUpgradeLevels(selectedUpgrade);

            if (currentLevel >= 10)
            {
                MessageBox.Show("This upgrade is already at max level!", "Upgrade", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int cost = GetUpgradeCost(currentLevel);
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
                        mainForm.carTrunkCapacity += 1;
                        break;
                    case 2:
                        mainForm.fuelUpgradeLvl = Math.Min(currentLevel + 1, 10);
                        mainForm.fuelTankCapacity += 2;
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
