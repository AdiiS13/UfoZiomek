using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UfoDigger
{
    public partial class DeliverySummary : Form
    {
        // This form displays the summary of the delivery after the DeliveryTime form is closed.
        private Form _deliveryTimeForm;
        private Form1 _mainForm;

        public DeliverySummary(Form deliveryTimeForm, Form1 mainForm)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += DeliverySummary_KeyDown;
            _deliveryTimeForm = deliveryTimeForm;
            _mainForm = mainForm;

            // Close DeliveryTime form if it's still open
            if (_deliveryTimeForm != null && !_deliveryTimeForm.IsDisposed)
            {
                _deliveryTimeForm.Close();
            }

            // Handle FormClosed event to reset carTrunkPizzaInside
            this.FormClosed += DeliverySummary_FormClosed;
        }

        private void DeliverySummary_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Reset the carTrunkPizzaInside to 0 when the summary form is closed
            if (_mainForm != null)
            {
                _mainForm.carTrunkPizzaInside = 0;
            }
        }

        // Information to be displayed in the summary, more needed to be added
        public void ShowSummary(int pizzasDelivered, int moneyEarned, string status)
        {
            listSummary.Items.Clear();
            listSummary.Items.Add($"Pizzas delivered: {pizzasDelivered}");
            listSummary.Items.Add($"Money earned: {moneyEarned}");
            listSummary.Items.Add($"Summary Status: {status}");
        }

        private void DeliverySummary_KeyDown(object sender, KeyEventArgs e)
        {
            // Close the form when the space key is pressed
            if (e.KeyCode == Keys.Space)
            {
                this.Close();
            }
        }
    }
}
