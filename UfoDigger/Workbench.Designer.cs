namespace UfoDigger
{
    partial class Workbench
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
            this.label1 = new System.Windows.Forms.Label();
            this.upgradeListBox = new System.Windows.Forms.ListBox();
            this.moneyLabel = new System.Windows.Forms.Label();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.labelCarSpeed = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Noto Sans JP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "Upgrades";
            // 
            // upgradeListBox
            // 
            this.upgradeListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.upgradeListBox.FormattingEnabled = true;
            this.upgradeListBox.ItemHeight = 51;
            this.upgradeListBox.Location = new System.Drawing.Point(399, 162);
            this.upgradeListBox.Name = "upgradeListBox";
            this.upgradeListBox.Size = new System.Drawing.Size(590, 259);
            this.upgradeListBox.TabIndex = 1;
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Font = new System.Drawing.Font("Noto Sans JP", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneyLabel.Location = new System.Drawing.Point(361, 22);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(286, 87);
            this.moneyLabel.TabIndex = 2;
            this.moneyLabel.Text = "Money: 0";
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Noto Sans JP", 25.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.Location = new System.Drawing.Point(49, 451);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(920, 64);
            this.instructionsLabel.TabIndex = 3;
            this.instructionsLabel.Text = "Use W/S to move, P to upgrade, Esc to close\r\n";
            // 
            // labelCarSpeed
            // 
            this.labelCarSpeed.AutoSize = true;
            this.labelCarSpeed.Location = new System.Drawing.Point(122, 92);
            this.labelCarSpeed.Name = "labelCarSpeed";
            this.labelCarSpeed.Size = new System.Drawing.Size(0, 16);
            this.labelCarSpeed.TabIndex = 4;
            // 
            // Workbench
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelCarSpeed);
            this.Controls.Add(this.instructionsLabel);
            this.Controls.Add(this.moneyLabel);
            this.Controls.Add(this.upgradeListBox);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Workbench";
            this.Text = "Workbench";
            this.Load += new System.EventHandler(this.Workbench_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox upgradeListBox;
        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Label labelCarSpeed;
    }
}