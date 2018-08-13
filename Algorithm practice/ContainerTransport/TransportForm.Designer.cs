﻿namespace ContainerTransport
{
    partial class TransportForm
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
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.groupBoxContainers = new System.Windows.Forms.GroupBox();
            this.numericUpDownCooled = new System.Windows.Forms.NumericUpDown();
            this.labelcooled = new System.Windows.Forms.Label();
            this.labelvaluable = new System.Windows.Forms.Label();
            this.numericUpDownValuable = new System.Windows.Forms.NumericUpDown();
            this.labelnormal = new System.Windows.Forms.Label();
            this.numericUpDownNormal = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelmax_weight = new System.Windows.Forms.Label();
            this.numericUpDownMax_weight = new System.Windows.Forms.NumericUpDown();
            this.groupBoxContainers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCooled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValuable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormal)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax_weight)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(13, 269);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(202, 64);
            this.buttonCalculate.TabIndex = 0;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // groupBoxContainers
            // 
            this.groupBoxContainers.Controls.Add(this.numericUpDownNormal);
            this.groupBoxContainers.Controls.Add(this.labelnormal);
            this.groupBoxContainers.Controls.Add(this.numericUpDownValuable);
            this.groupBoxContainers.Controls.Add(this.labelvaluable);
            this.groupBoxContainers.Controls.Add(this.labelcooled);
            this.groupBoxContainers.Controls.Add(this.numericUpDownCooled);
            this.groupBoxContainers.Location = new System.Drawing.Point(13, 22);
            this.groupBoxContainers.Name = "groupBoxContainers";
            this.groupBoxContainers.Size = new System.Drawing.Size(202, 137);
            this.groupBoxContainers.TabIndex = 1;
            this.groupBoxContainers.TabStop = false;
            this.groupBoxContainers.Text = "Number of Containers";
            // 
            // numericUpDownCooled
            // 
            this.numericUpDownCooled.Location = new System.Drawing.Point(75, 39);
            this.numericUpDownCooled.Name = "numericUpDownCooled";
            this.numericUpDownCooled.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownCooled.TabIndex = 0;
            // 
            // labelcooled
            // 
            this.labelcooled.AutoSize = true;
            this.labelcooled.Location = new System.Drawing.Point(6, 41);
            this.labelcooled.Name = "labelcooled";
            this.labelcooled.Size = new System.Drawing.Size(52, 17);
            this.labelcooled.TabIndex = 1;
            this.labelcooled.Text = "Cooled";
            // 
            // labelvaluable
            // 
            this.labelvaluable.AutoSize = true;
            this.labelvaluable.Location = new System.Drawing.Point(6, 67);
            this.labelvaluable.Name = "labelvaluable";
            this.labelvaluable.Size = new System.Drawing.Size(63, 17);
            this.labelvaluable.TabIndex = 2;
            this.labelvaluable.Text = "Valuable";
            // 
            // numericUpDownValuable
            // 
            this.numericUpDownValuable.Location = new System.Drawing.Point(75, 65);
            this.numericUpDownValuable.Name = "numericUpDownValuable";
            this.numericUpDownValuable.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownValuable.TabIndex = 3;
            // 
            // labelnormal
            // 
            this.labelnormal.AutoSize = true;
            this.labelnormal.Location = new System.Drawing.Point(6, 95);
            this.labelnormal.Name = "labelnormal";
            this.labelnormal.Size = new System.Drawing.Size(53, 17);
            this.labelnormal.TabIndex = 4;
            this.labelnormal.Text = "Normal";
            // 
            // numericUpDownNormal
            // 
            this.numericUpDownNormal.Location = new System.Drawing.Point(75, 93);
            this.numericUpDownNormal.Name = "numericUpDownNormal";
            this.numericUpDownNormal.Size = new System.Drawing.Size(65, 22);
            this.numericUpDownNormal.TabIndex = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.numericUpDownMax_weight);
            this.groupBox1.Controls.Add(this.labelmax_weight);
            this.groupBox1.Location = new System.Drawing.Point(13, 166);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 88);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ship";
            // 
            // labelmax_weight
            // 
            this.labelmax_weight.AutoSize = true;
            this.labelmax_weight.Location = new System.Drawing.Point(9, 42);
            this.labelmax_weight.Name = "labelmax_weight";
            this.labelmax_weight.Size = new System.Drawing.Size(77, 17);
            this.labelmax_weight.TabIndex = 0;
            this.labelmax_weight.Text = "Max weight";
            // 
            // numericUpDownMax_weight
            // 
            this.numericUpDownMax_weight.Location = new System.Drawing.Point(92, 40);
            this.numericUpDownMax_weight.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDownMax_weight.Name = "numericUpDownMax_weight";
            this.numericUpDownMax_weight.Size = new System.Drawing.Size(104, 22);
            this.numericUpDownMax_weight.TabIndex = 1;
            // 
            // TransportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxContainers);
            this.Controls.Add(this.buttonCalculate);
            this.Name = "TransportForm";
            this.Text = "Form1";
            this.groupBoxContainers.ResumeLayout(false);
            this.groupBoxContainers.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCooled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownValuable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormal)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax_weight)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.GroupBox groupBoxContainers;
        private System.Windows.Forms.NumericUpDown numericUpDownNormal;
        private System.Windows.Forms.Label labelnormal;
        private System.Windows.Forms.NumericUpDown numericUpDownValuable;
        private System.Windows.Forms.Label labelvaluable;
        private System.Windows.Forms.Label labelcooled;
        private System.Windows.Forms.NumericUpDown numericUpDownCooled;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownMax_weight;
        private System.Windows.Forms.Label labelmax_weight;
    }
}
