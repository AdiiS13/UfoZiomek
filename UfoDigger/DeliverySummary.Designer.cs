namespace UfoDigger
{
    partial class DeliverySummary
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
            this.labelDelivered = new System.Windows.Forms.Label();
            this.labelSummary = new System.Windows.Forms.Label();
            this.labelUndelivered = new System.Windows.Forms.Label();
            this.labelEarned = new System.Windows.Forms.Label();
            this.labelPenalty = new System.Windows.Forms.Label();
            this.labelTowing = new System.Windows.Forms.Label();
            this.labelLostToThugs = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.listSummary = new System.Windows.Forms.ListBox();
            this.labelContinue = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelDelivered
            // 
            this.labelDelivered.AutoSize = true;
            this.labelDelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDelivered.Location = new System.Drawing.Point(101, 90);
            this.labelDelivered.Name = "labelDelivered";
            this.labelDelivered.Size = new System.Drawing.Size(0, 29);
            this.labelDelivered.TabIndex = 0;
            // 
            // labelSummary
            // 
            this.labelSummary.AutoSize = true;
            this.labelSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSummary.Location = new System.Drawing.Point(202, 22);
            this.labelSummary.Name = "labelSummary";
            this.labelSummary.Size = new System.Drawing.Size(375, 51);
            this.labelSummary.TabIndex = 1;
            this.labelSummary.Text = "Delivery Summary";
            // 
            // labelUndelivered
            // 
            this.labelUndelivered.AutoSize = true;
            this.labelUndelivered.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUndelivered.Location = new System.Drawing.Point(101, 131);
            this.labelUndelivered.Name = "labelUndelivered";
            this.labelUndelivered.Size = new System.Drawing.Size(0, 29);
            this.labelUndelivered.TabIndex = 2;
            // 
            // labelEarned
            // 
            this.labelEarned.AutoSize = true;
            this.labelEarned.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEarned.Location = new System.Drawing.Point(101, 173);
            this.labelEarned.Name = "labelEarned";
            this.labelEarned.Size = new System.Drawing.Size(0, 29);
            this.labelEarned.TabIndex = 3;
            // 
            // labelPenalty
            // 
            this.labelPenalty.AutoSize = true;
            this.labelPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPenalty.Location = new System.Drawing.Point(101, 211);
            this.labelPenalty.Name = "labelPenalty";
            this.labelPenalty.Size = new System.Drawing.Size(0, 29);
            this.labelPenalty.TabIndex = 4;
            // 
            // labelTowing
            // 
            this.labelTowing.AutoSize = true;
            this.labelTowing.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTowing.Location = new System.Drawing.Point(101, 254);
            this.labelTowing.Name = "labelTowing";
            this.labelTowing.Size = new System.Drawing.Size(0, 29);
            this.labelTowing.TabIndex = 5;
            // 
            // labelLostToThugs
            // 
            this.labelLostToThugs.AutoSize = true;
            this.labelLostToThugs.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLostToThugs.Location = new System.Drawing.Point(101, 294);
            this.labelLostToThugs.Name = "labelLostToThugs";
            this.labelLostToThugs.Size = new System.Drawing.Size(0, 29);
            this.labelLostToThugs.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 332);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 7;
            // 
            // listSummary
            // 
            this.listSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listSummary.FormattingEnabled = true;
            this.listSummary.ItemHeight = 25;
            this.listSummary.Location = new System.Drawing.Point(106, 90);
            this.listSummary.Name = "listSummary";
            this.listSummary.Size = new System.Drawing.Size(595, 254);
            this.listSummary.TabIndex = 8;
            // 
            // labelContinue
            // 
            this.labelContinue.AutoSize = true;
            this.labelContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelContinue.Location = new System.Drawing.Point(229, 384);
            this.labelContinue.Name = "labelContinue";
            this.labelContinue.Size = new System.Drawing.Size(336, 32);
            this.labelContinue.TabIndex = 9;
            this.labelContinue.Text = "Press SPACE to continue";
            // 
            // DeliverySummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelContinue);
            this.Controls.Add(this.listSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelLostToThugs);
            this.Controls.Add(this.labelTowing);
            this.Controls.Add(this.labelPenalty);
            this.Controls.Add(this.labelEarned);
            this.Controls.Add(this.labelUndelivered);
            this.Controls.Add(this.labelSummary);
            this.Controls.Add(this.labelDelivered);
            this.Name = "DeliverySummary";
            this.Text = "DeliverySummary";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDelivered;
        private System.Windows.Forms.Label labelSummary;
        private System.Windows.Forms.Label labelUndelivered;
        private System.Windows.Forms.Label labelEarned;
        private System.Windows.Forms.Label labelPenalty;
        private System.Windows.Forms.Label labelTowing;
        private System.Windows.Forms.Label labelLostToThugs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listSummary;
        private System.Windows.Forms.Label labelContinue;
    }
}