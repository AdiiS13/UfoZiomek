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
        private int[] upgradeLevels = {1, 1, 1};
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
            // Update the labels and list box with current values
            moneyLabel.Text = $"Money: ${mainForm.amountOfMoney}";
            
            upgradeListBox.Items.Clear();
            // Populate the list box with upgrade names and levels
            for (int i = 0; i < upgradeNames.Length; i++)
            {
                string prefix = (i == selectedUpgrade) ? "> " : "  ";
                string line = $"{prefix}{upgradeNames[i]} (Level {upgradeLevels[i]})";
                upgradeListBox.Items.Add(line);
            }
            // Highlight the selected upgrade
            upgradeListBox.SelectedIndex = selectedUpgrade;
        }

        // Handles keyboard input for navigating and upgrading
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
        }
        // Attempts to upgrade the selected upgrade - work in progress
        private void TryUpgradeSelected()
        {
            // Test if the selected upgrade can be upgraded
            int currentLevel = upgradeLevels[selectedUpgrade];
            int cost = 1 + currentLevel * 2; // example cost formula
            // Check if the player has enough money to upgrade
            if (mainForm.amountOfMoney >= cost)
            {
                mainForm.amountOfMoney -= cost;
                upgradeLevels[selectedUpgrade] = currentLevel + 1;
                UpdateWB();
            }
            else
            {
                // Show a message if not enough money
                MessageBox.Show("Not enough money to upgrade!", "Upgrade Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


    }
}
