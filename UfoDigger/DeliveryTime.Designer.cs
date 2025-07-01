namespace UfoDigger
{
    partial class DeliveryTime
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.moneyL = new System.Windows.Forms.Label();
            this.labelTrunkStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.fuelGauge = new System.Windows.Forms.ProgressBar();
            this.labelFuelStatus = new System.Windows.Forms.Label();
            this.deliveryCar1 = new UfoDigger.DeliveryCar();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money:";
            // 
            // moneyL
            // 
            this.moneyL.AutoSize = true;
            this.moneyL.BackColor = System.Drawing.Color.Transparent;
            this.moneyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyL.ForeColor = System.Drawing.Color.Gold;
            this.moneyL.Location = new System.Drawing.Point(23, 47);
            this.moneyL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.moneyL.Name = "moneyL";
            this.moneyL.Size = new System.Drawing.Size(37, 39);
            this.moneyL.TabIndex = 2;
            this.moneyL.Text = "0";
            // 
            // labelTrunkStatus
            // 
            this.labelTrunkStatus.AutoSize = true;
            this.labelTrunkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrunkStatus.Location = new System.Drawing.Point(230, 23);
            this.labelTrunkStatus.Name = "labelTrunkStatus";
            this.labelTrunkStatus.Size = new System.Drawing.Size(245, 32);
            this.labelTrunkStatus.TabIndex = 3;
            this.labelTrunkStatus.Text = "Pizzas in the trunk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UfoDigger.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(100, 698);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UfoDigger.Properties.Resources.canister;
            this.pictureBox2.Location = new System.Drawing.Point(292, 698);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // fuelGauge
            // 
            this.fuelGauge.Location = new System.Drawing.Point(600, 755);
            this.fuelGauge.Name = "fuelGauge";
            this.fuelGauge.Size = new System.Drawing.Size(661, 59);
            this.fuelGauge.TabIndex = 6;
            this.fuelGauge.Value = 100;
            // 
            // labelFuelStatus
            // 
            this.labelFuelStatus.AutoSize = true;
            this.labelFuelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelStatus.Location = new System.Drawing.Point(613, 773);
            this.labelFuelStatus.Name = "labelFuelStatus";
            this.labelFuelStatus.Size = new System.Drawing.Size(100, 25);
            this.labelFuelStatus.TabIndex = 7;
            this.labelFuelStatus.Text = "fuel status";
            // 
            // deliveryCar1
            // 
            this.deliveryCar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deliveryCar1.BackColor = System.Drawing.Color.Transparent;
            this.deliveryCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deliveryCar1.Location = new System.Drawing.Point(207, 170);
            this.deliveryCar1.Margin = new System.Windows.Forms.Padding(4);
            this.deliveryCar1.Name = "deliveryCar1";
            this.deliveryCar1.Size = new System.Drawing.Size(133, 123);
            this.deliveryCar1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(173, 675);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(58, 56);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "X";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(374, 671);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(58, 56);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Z";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(89, 688);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(120, 120);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(279, 689);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(120, 120);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // DeliveryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UfoDigger.Properties.Resources.grassland;
            this.ClientSize = new System.Drawing.Size(1344, 1055);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelFuelStatus);
            this.Controls.Add(this.fuelGauge);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.labelTrunkStatus);
            this.Controls.Add(this.moneyL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryCar1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox4);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DeliveryTime";
            this.Text = "DeliveryTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeliveryTime_FormClosing);
            this.Load += new System.EventHandler(this.DeliveryTime_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeliveryCar deliveryCar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyL;
        private System.Windows.Forms.Label labelTrunkStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ProgressBar fuelGauge;
        private System.Windows.Forms.Label labelFuelStatus;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}