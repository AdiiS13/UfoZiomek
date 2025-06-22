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
            this.deliveryCar1.Location = new System.Drawing.Point(155, 138);
            this.deliveryCar1.Name = "deliveryCar1";
            this.deliveryCar1.Size = new System.Drawing.Size(100, 100);
            this.deliveryCar1.TabIndex = 0;
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
            // DeliveryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::UfoDigger.Properties.Resources.grassland;
            this.ClientSize = new System.Drawing.Size(1008, 985);
            this.Controls.Add(this.moneyL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deliveryCar1);
            this.KeyPreview = true;
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
    }
}