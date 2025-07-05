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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.deliveryCar1 = new UfoDigger.DeliveryCar();
            this.canisterNumberLabel = new System.Windows.Forms.Label();
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
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Money:";
            // 
            // moneyL
            // 
            this.moneyL.AutoSize = true;
            this.moneyL.BackColor = System.Drawing.Color.Transparent;
            this.moneyL.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyL.ForeColor = System.Drawing.Color.Gold;
            this.moneyL.Location = new System.Drawing.Point(17, 38);
            this.moneyL.Name = "moneyL";
            this.moneyL.Size = new System.Drawing.Size(30, 31);
            this.moneyL.TabIndex = 2;
            this.moneyL.Text = "0";
            // 
            // labelTrunkStatus
            // 
            this.labelTrunkStatus.AutoSize = true;
            this.labelTrunkStatus.BackColor = System.Drawing.Color.Transparent;
            this.labelTrunkStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrunkStatus.ForeColor = System.Drawing.Color.Gold;
            this.labelTrunkStatus.Location = new System.Drawing.Point(199, 19);
            this.labelTrunkStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTrunkStatus.Name = "labelTrunkStatus";
            this.labelTrunkStatus.Size = new System.Drawing.Size(190, 26);
            this.labelTrunkStatus.TabIndex = 3;
            this.labelTrunkStatus.Text = "Pizzas in the trunk";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UfoDigger.Properties.Resources.pizza;
            this.pictureBox1.Location = new System.Drawing.Point(50, 794);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 52);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UfoDigger.Properties.Resources.canister;
            this.pictureBox2.Location = new System.Drawing.Point(122, 794);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(52, 52);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // fuelGauge
            // 
            this.fuelGauge.Location = new System.Drawing.Point(501, 798);
            this.fuelGauge.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.fuelGauge.Name = "fuelGauge";
            this.fuelGauge.Size = new System.Drawing.Size(496, 48);
            this.fuelGauge.TabIndex = 6;
            this.fuelGauge.Value = 100;
            // 
            // labelFuelStatus
            // 
            this.labelFuelStatus.AutoSize = true;
            this.labelFuelStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuelStatus.Location = new System.Drawing.Point(511, 813);
            this.labelFuelStatus.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFuelStatus.Name = "labelFuelStatus";
            this.labelFuelStatus.Size = new System.Drawing.Size(83, 20);
            this.labelFuelStatus.TabIndex = 7;
            this.labelFuelStatus.Text = "fuel status";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(87, 788);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(20, 26);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "X";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(165, 788);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(21, 26);
            this.textBox2.TabIndex = 9;
            this.textBox2.Text = "Z";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(50, 798);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(46, 48);
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Location = new System.Drawing.Point(122, 794);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(52, 52);
            this.pictureBox4.TabIndex = 11;
            this.pictureBox4.TabStop = false;
            // 
            // deliveryCar1
            // 
            this.deliveryCar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deliveryCar1.BackColor = System.Drawing.Color.Transparent;
            this.deliveryCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deliveryCar1.Location = new System.Drawing.Point(155, 138);
            this.deliveryCar1.Name = "deliveryCar1";
            this.deliveryCar1.Size = new System.Drawing.Size(100, 100);
            this.deliveryCar1.TabIndex = 0;
            // 
            // canisterNumberLabel
            // 
            this.canisterNumberLabel.AutoSize = true;
            this.canisterNumberLabel.BackColor = System.Drawing.Color.Transparent;
            this.canisterNumberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.canisterNumberLabel.ForeColor = System.Drawing.Color.Gold;
            this.canisterNumberLabel.Location = new System.Drawing.Point(172, 45);
            this.canisterNumberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.canisterNumberLabel.Name = "canisterNumberLabel";
            this.canisterNumberLabel.Size = new System.Drawing.Size(217, 26);
            this.canisterNumberLabel.TabIndex = 12;
            this.canisterNumberLabel.Text = "Canisters in the trunk";
            // 
            // DeliveryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UfoDigger.Properties.Resources.grassland;
            this.ClientSize = new System.Drawing.Size(1008, 857);
            this.Controls.Add(this.canisterNumberLabel);
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
        private System.Windows.Forms.Label canisterNumberLabel;
    }
}