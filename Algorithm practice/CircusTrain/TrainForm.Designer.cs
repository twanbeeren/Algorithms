namespace CircusTrain
{
    partial class TrainForm
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
            this.groupBoxAddAnimal = new System.Windows.Forms.GroupBox();
            this.buttonRandomize = new System.Windows.Forms.Button();
            this.buttonAddAnimal = new System.Windows.Forms.Button();
            this.comboBoxSize = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDiet = new System.Windows.Forms.ComboBox();
            this.labelDiet = new System.Windows.Forms.Label();
            this.listBoxAnimals = new System.Windows.Forms.ListBox();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.flpWagons = new System.Windows.Forms.FlowLayoutPanel();
            this.buttonClear = new System.Windows.Forms.Button();
            this.groupBoxAddAnimal.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAddAnimal
            // 
            this.groupBoxAddAnimal.Controls.Add(this.buttonRandomize);
            this.groupBoxAddAnimal.Controls.Add(this.buttonAddAnimal);
            this.groupBoxAddAnimal.Controls.Add(this.comboBoxSize);
            this.groupBoxAddAnimal.Controls.Add(this.label1);
            this.groupBoxAddAnimal.Controls.Add(this.comboBoxDiet);
            this.groupBoxAddAnimal.Controls.Add(this.labelDiet);
            this.groupBoxAddAnimal.Location = new System.Drawing.Point(13, 13);
            this.groupBoxAddAnimal.Name = "groupBoxAddAnimal";
            this.groupBoxAddAnimal.Size = new System.Drawing.Size(272, 181);
            this.groupBoxAddAnimal.TabIndex = 0;
            this.groupBoxAddAnimal.TabStop = false;
            this.groupBoxAddAnimal.Text = "Add animal";
            // 
            // buttonRandomize
            // 
            this.buttonRandomize.Location = new System.Drawing.Point(169, 124);
            this.buttonRandomize.Name = "buttonRandomize";
            this.buttonRandomize.Size = new System.Drawing.Size(92, 34);
            this.buttonRandomize.TabIndex = 5;
            this.buttonRandomize.Text = "Randomize";
            this.buttonRandomize.UseVisualStyleBackColor = true;
            this.buttonRandomize.Click += new System.EventHandler(this.buttonRandomize_Click);
            // 
            // buttonAddAnimal
            // 
            this.buttonAddAnimal.Location = new System.Drawing.Point(83, 124);
            this.buttonAddAnimal.Name = "buttonAddAnimal";
            this.buttonAddAnimal.Size = new System.Drawing.Size(79, 34);
            this.buttonAddAnimal.TabIndex = 4;
            this.buttonAddAnimal.Text = "Add";
            this.buttonAddAnimal.UseVisualStyleBackColor = true;
            this.buttonAddAnimal.Click += new System.EventHandler(this.buttonAddAnimal_Click);
            // 
            // comboBoxSize
            // 
            this.comboBoxSize.FormattingEnabled = true;
            this.comboBoxSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large"});
            this.comboBoxSize.Location = new System.Drawing.Point(83, 79);
            this.comboBoxSize.Name = "comboBoxSize";
            this.comboBoxSize.Size = new System.Drawing.Size(129, 24);
            this.comboBoxSize.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Size";
            // 
            // comboBoxDiet
            // 
            this.comboBoxDiet.FormattingEnabled = true;
            this.comboBoxDiet.Items.AddRange(new object[] {
            "Herbivore",
            "Carnivore"});
            this.comboBoxDiet.Location = new System.Drawing.Point(83, 35);
            this.comboBoxDiet.Name = "comboBoxDiet";
            this.comboBoxDiet.Size = new System.Drawing.Size(129, 24);
            this.comboBoxDiet.TabIndex = 1;
            // 
            // labelDiet
            // 
            this.labelDiet.AutoSize = true;
            this.labelDiet.Location = new System.Drawing.Point(6, 38);
            this.labelDiet.Name = "labelDiet";
            this.labelDiet.Size = new System.Drawing.Size(33, 17);
            this.labelDiet.TabIndex = 0;
            this.labelDiet.Text = "Diet";
            // 
            // listBoxAnimals
            // 
            this.listBoxAnimals.FormattingEnabled = true;
            this.listBoxAnimals.ItemHeight = 16;
            this.listBoxAnimals.Location = new System.Drawing.Point(13, 213);
            this.listBoxAnimals.Name = "listBoxAnimals";
            this.listBoxAnimals.Size = new System.Drawing.Size(185, 260);
            this.listBoxAnimals.TabIndex = 1;
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.Location = new System.Drawing.Point(206, 265);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(79, 44);
            this.buttonCalculate.TabIndex = 2;
            this.buttonCalculate.Text = "Calculate";
            this.buttonCalculate.UseVisualStyleBackColor = true;
            this.buttonCalculate.Click += new System.EventHandler(this.buttonCalculate_Click);
            // 
            // flpWagons
            // 
            this.flpWagons.AutoScroll = true;
            this.flpWagons.Location = new System.Drawing.Point(312, 13);
            this.flpWagons.Name = "flpWagons";
            this.flpWagons.Size = new System.Drawing.Size(735, 519);
            this.flpWagons.TabIndex = 3;
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(206, 213);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(79, 46);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // TrainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 544);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.flpWagons);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.listBoxAnimals);
            this.Controls.Add(this.groupBoxAddAnimal);
            this.Name = "TrainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.TrainForm_Load);
            this.groupBoxAddAnimal.ResumeLayout(false);
            this.groupBoxAddAnimal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAddAnimal;
        private System.Windows.Forms.ComboBox comboBoxDiet;
        private System.Windows.Forms.Label labelDiet;
        private System.Windows.Forms.ComboBox comboBoxSize;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonRandomize;
        private System.Windows.Forms.Button buttonAddAnimal;
        private System.Windows.Forms.ListBox listBoxAnimals;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.FlowLayoutPanel flpWagons;
        private System.Windows.Forms.Button buttonClear;
    }
}

