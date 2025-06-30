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
            this.deliveryCar1 = new UfoDigger.DeliveryCar();
            this.label1 = new System.Windows.Forms.Label();
            this.moneyL = new System.Windows.Forms.Label();
            this.labelTrunkStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.Update);
            // 
            // deliveryCar1
            // 
            this.deliveryCar1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.deliveryCar1.BackColor = System.Drawing.Color.Transparent;
            this.deliveryCar1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.deliveryCar1.Location = new System.Drawing.Point(207, 170);
            this.deliveryCar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.deliveryCar1.Name = "deliveryCar1";
            this.deliveryCar1.Size = new System.Drawing.Size(133, 123);
            this.deliveryCar1.TabIndex = 0;
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
            // DeliveryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UfoDigger.Properties.Resources.grassland;
            this.ClientSize = new System.Drawing.Size(1344, 1055);
            this.Controls.Add(this.labelTrunkStatus);
            this.Controls.Add(this.moneyL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryCar1);
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DeliveryTime";
            this.Text = "DeliveryTime";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeliveryTime_FormClosing);
            this.Load += new System.EventHandler(this.DeliveryTime_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DeliveryCar deliveryCar1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label moneyL;
        private System.Windows.Forms.Label labelTrunkStatus;
    }
}