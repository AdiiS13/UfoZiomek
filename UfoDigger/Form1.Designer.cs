namespace UfoDigger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.pictureBoxWorkbench = new System.Windows.Forms.PictureBox();
            this.pictureBoxPhone = new System.Windows.Forms.PictureBox();
            this.pictureBoxPizzaTable = new System.Windows.Forms.PictureBox();
            this.timerForm1 = new System.Windows.Forms.Timer(this.components);
            this.labelWorkbench = new System.Windows.Forms.Label();
            this.labelPickupPizza = new System.Windows.Forms.Label();
            this.labelPutDownPizza = new System.Windows.Forms.Label();
            this.labelDelivery = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.player1 = new UfoDigger.GameObjects.Player();
            this.labelTrunkSpace = new System.Windows.Forms.Label();
            this.labelFuelLeft = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorkbench)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizzaTable)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.Image = global::UfoDigger.Properties.Resources.autotmp;
            this.pictureBoxCar.Location = new System.Drawing.Point(388, 372);
            this.pictureBoxCar.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(667, 308);
            this.pictureBoxCar.TabIndex = 1;
            this.pictureBoxCar.TabStop = false;
            // 
            // pictureBoxWorkbench
            // 
            this.pictureBoxWorkbench.Image = global::UfoDigger.Properties.Resources.workbenchtmp;
            this.pictureBoxWorkbench.Location = new System.Drawing.Point(521, 2);
            this.pictureBoxWorkbench.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxWorkbench.Name = "pictureBoxWorkbench";
            this.pictureBoxWorkbench.Size = new System.Drawing.Size(533, 308);
            this.pictureBoxWorkbench.TabIndex = 2;
            this.pictureBoxWorkbench.TabStop = false;
            // 
            // pictureBoxPhone
            // 
            this.pictureBoxPhone.Image = global::UfoDigger.Properties.Resources.phonetmp;
            this.pictureBoxPhone.Location = new System.Drawing.Point(291, 2);
            this.pictureBoxPhone.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPhone.Name = "pictureBoxPhone";
            this.pictureBoxPhone.Size = new System.Drawing.Size(223, 154);
            this.pictureBoxPhone.TabIndex = 3;
            this.pictureBoxPhone.TabStop = false;
            // 
            // pictureBoxPizzaTable
            // 
            this.pictureBoxPizzaTable.Image = global::UfoDigger.Properties.Resources.pizzatmp;
            this.pictureBoxPizzaTable.Location = new System.Drawing.Point(16, 2);
            this.pictureBoxPizzaTable.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxPizzaTable.Name = "pictureBoxPizzaTable";
            this.pictureBoxPizzaTable.Size = new System.Drawing.Size(267, 246);
            this.pictureBoxPizzaTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxPizzaTable.TabIndex = 4;
            this.pictureBoxPizzaTable.TabStop = false;
            // 
            // timerForm1
            // 
            this.timerForm1.Enabled = true;
            this.timerForm1.Tick += new System.EventHandler(this.Update);
            // 
            // labelWorkbench
            // 
            this.labelWorkbench.AutoSize = true;
            this.labelWorkbench.BackColor = System.Drawing.Color.Yellow;
            this.labelWorkbench.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWorkbench.Location = new System.Drawing.Point(633, 118);
            this.labelWorkbench.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWorkbench.Name = "labelWorkbench";
            this.labelWorkbench.Size = new System.Drawing.Size(303, 39);
            this.labelWorkbench.TabIndex = 5;
            this.labelWorkbench.Text = "press E to upgrade";
            // 
            // labelPickupPizza
            // 
            this.labelPickupPizza.AutoSize = true;
            this.labelPickupPizza.BackColor = System.Drawing.Color.Yellow;
            this.labelPickupPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPickupPizza.Location = new System.Drawing.Point(43, 144);
            this.labelPickupPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPickupPizza.Name = "labelPickupPizza";
            this.labelPickupPizza.Size = new System.Drawing.Size(204, 78);
            this.labelPickupPizza.TabIndex = 6;
            this.labelPickupPizza.Text = "press P to\r\npickup order";
            // 
            // labelPutDownPizza
            // 
            this.labelPutDownPizza.AutoSize = true;
            this.labelPutDownPizza.BackColor = System.Drawing.Color.Yellow;
            this.labelPutDownPizza.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPutDownPizza.Location = new System.Drawing.Point(424, 480);
            this.labelPutDownPizza.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPutDownPizza.Name = "labelPutDownPizza";
            this.labelPutDownPizza.Size = new System.Drawing.Size(243, 78);
            this.labelPutDownPizza.TabIndex = 7;
            this.labelPutDownPizza.Text = "press O to\r\nput down order";
            // 
            // labelDelivery
            // 
            this.labelDelivery.AutoSize = true;
            this.labelDelivery.BackColor = System.Drawing.Color.Yellow;
            this.labelDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelivery.Location = new System.Drawing.Point(697, 480);
            this.labelDelivery.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDelivery.Name = "labelDelivery";
            this.labelDelivery.Size = new System.Drawing.Size(206, 78);
            this.labelDelivery.TabIndex = 8;
            this.labelDelivery.Text = "press C to\r\ndeliver order";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.BackColor = System.Drawing.Color.Yellow;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPhone.Location = new System.Drawing.Point(296, 100);
            this.labelPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(220, 78);
            this.labelPhone.TabIndex = 9;
            this.labelPhone.Text = "press R to\r\npickup phone";
            // 
            // player1
            // 
            this.player1.Location = new System.Drawing.Point(109, 465);
            this.player1.Margin = new System.Windows.Forms.Padding(4);
            this.player1.Name = "player1";
            this.player1.Size = new System.Drawing.Size(85, 79);
            this.player1.TabIndex = 0;
            // 
            // labelTrunkSpace
            // 
            this.labelTrunkSpace.AutoSize = true;
            this.labelTrunkSpace.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrunkSpace.Location = new System.Drawing.Point(55, 533);
            this.labelTrunkSpace.Name = "labelTrunkSpace";
            this.labelTrunkSpace.Size = new System.Drawing.Size(204, 25);
            this.labelTrunkSpace.TabIndex = 10;
            this.labelTrunkSpace.Text = "Available trunk space:";
            // 
            // labelFuelLeft
            // 
            this.labelFuelLeft.AutoSize = true;
            this.labelFuelLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelLeft.Location = new System.Drawing.Point(55, 580);
            this.labelFuelLeft.Name = "labelFuelLeft";
            this.labelFuelLeft.Size = new System.Drawing.Size(150, 25);
            this.labelFuelLeft.TabIndex = 11;
            this.labelFuelLeft.Text = "Fuel in the tank:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 690);
            this.Controls.Add(this.labelFuelLeft);
            this.Controls.Add(this.labelTrunkSpace);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelDelivery);
            this.Controls.Add(this.labelPutDownPizza);
            this.Controls.Add(this.labelPickupPizza);
            this.Controls.Add(this.labelWorkbench);
            this.Controls.Add(this.player1);
            this.Controls.Add(this.pictureBoxPizzaTable);
            this.Controls.Add(this.pictureBoxPhone);
            this.Controls.Add(this.pictureBoxWorkbench);
            this.Controls.Add(this.pictureBoxCar);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWorkbench)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPizzaTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.PictureBox pictureBoxWorkbench;
        private System.Windows.Forms.PictureBox pictureBoxPhone;
        private System.Windows.Forms.PictureBox pictureBoxPizzaTable;
        private GameObjects.Player player1;
        private System.Windows.Forms.Timer timerForm1;
        private System.Windows.Forms.Label labelWorkbench;
        private System.Windows.Forms.Label labelPickupPizza;
        private System.Windows.Forms.Label labelPutDownPizza;
        private System.Windows.Forms.Label labelDelivery;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelTrunkSpace;
        private System.Windows.Forms.Label labelFuelLeft;
    }
}

