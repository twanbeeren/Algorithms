namespace PancakeSorter
{
    partial class PancakeForm
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
            this.labelpancakes = new System.Windows.Forms.Label();
            this.numericUpDownCntPancakes = new System.Windows.Forms.NumericUpDown();
            this.buttonSortPancakes = new System.Windows.Forms.Button();
            this.listBoxpancakes = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCntPancakes)).BeginInit();
            this.SuspendLayout();
            // 
            // labelpancakes
            // 
            this.labelpancakes.AutoSize = true;
            this.labelpancakes.Location = new System.Drawing.Point(13, 13);
            this.labelpancakes.Name = "labelpancakes";
            this.labelpancakes.Size = new System.Drawing.Size(140, 17);
            this.labelpancakes.TabIndex = 0;
            this.labelpancakes.Text = "Number of Pancakes";
            // 
            // numericUpDownCntPancakes
            // 
            this.numericUpDownCntPancakes.Location = new System.Drawing.Point(16, 44);
            this.numericUpDownCntPancakes.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCntPancakes.Name = "numericUpDownCntPancakes";
            this.numericUpDownCntPancakes.Size = new System.Drawing.Size(68, 22);
            this.numericUpDownCntPancakes.TabIndex = 1;
            // 
            // buttonSortPancakes
            // 
            this.buttonSortPancakes.Location = new System.Drawing.Point(16, 89);
            this.buttonSortPancakes.Name = "buttonSortPancakes";
            this.buttonSortPancakes.Size = new System.Drawing.Size(137, 42);
            this.buttonSortPancakes.TabIndex = 2;
            this.buttonSortPancakes.Text = "Sort Pancakes";
            this.buttonSortPancakes.UseVisualStyleBackColor = true;
            this.buttonSortPancakes.Click += new System.EventHandler(this.buttonSortPancakes_Click);
            // 
            // listBoxpancakes
            // 
            this.listBoxpancakes.FormattingEnabled = true;
            this.listBoxpancakes.ItemHeight = 16;
            this.listBoxpancakes.Location = new System.Drawing.Point(248, 13);
            this.listBoxpancakes.Name = "listBoxpancakes";
            this.listBoxpancakes.Size = new System.Drawing.Size(263, 196);
            this.listBoxpancakes.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 265);
            this.Controls.Add(this.listBoxpancakes);
            this.Controls.Add(this.buttonSortPancakes);
            this.Controls.Add(this.numericUpDownCntPancakes);
            this.Controls.Add(this.labelpancakes);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCntPancakes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelpancakes;
        private System.Windows.Forms.NumericUpDown numericUpDownCntPancakes;
        private System.Windows.Forms.Button buttonSortPancakes;
        private System.Windows.Forms.ListBox listBoxpancakes;
    }
}

