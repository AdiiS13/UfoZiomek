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
            this.deliveryCar1 = new UfoDigger.DeliveryCar();
            this.SuspendLayout();
            // 
            // deliveryCar1
            // 
            this.deliveryCar1.Location = new System.Drawing.Point(155, 138);
            this.deliveryCar1.Name = "deliveryCar1";
            this.deliveryCar1.Size = new System.Drawing.Size(109, 103);
            this.deliveryCar1.TabIndex = 0;
            // 
            // DeliveryTime
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.deliveryCar1);
            this.KeyPreview = true;
            this.Name = "DeliveryTime";
            this.Text = "DeliveryTime";
            this.Load += new System.EventHandler(this.DeliveryTime_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private DeliveryCar deliveryCar1;
    }
}