namespace CookBook.UI
{
    partial class IngredientsForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            WeightNum = new NumericUpDown();
            KcalPer100gNum = new NumericUpDown();
            PricePer100gNum = new NumericUpDown();
            AddTofridgeBtn = new Button();
            NametextBox = new TextBox();
            TypeTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)WeightNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(61, 78);
            label1.Name = "label1";
            label1.Size = new Size(56, 30);
            label1.TabIndex = 0;
            label1.Text = "Type";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 146);
            label2.Name = "label2";
            label2.Size = new Size(109, 30);
            label2.TabIndex = 1;
            label2.Text = "Weight (g)";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 221);
            label3.Name = "label3";
            label3.Size = new Size(114, 30);
            label3.TabIndex = 2;
            label3.Text = "Kcal (100g)";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(61, 290);
            label4.Name = "label4";
            label4.Size = new Size(121, 30);
            label4.TabIndex = 3;
            label4.Text = "Price (100g)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 20);
            label5.Name = "label5";
            label5.Size = new Size(69, 30);
            label5.TabIndex = 4;
            label5.Text = "Name";
            // 
            // WeightNum
            // 
            WeightNum.DecimalPlaces = 2;
            WeightNum.Location = new Point(236, 144);
            WeightNum.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            WeightNum.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            WeightNum.Name = "WeightNum";
            WeightNum.Size = new Size(257, 35);
            WeightNum.TabIndex = 7;
            WeightNum.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // KcalPer100gNum
            // 
            KcalPer100gNum.DecimalPlaces = 2;
            KcalPer100gNum.Location = new Point(236, 219);
            KcalPer100gNum.Maximum = new decimal(new int[] { 900, 0, 0, 0 });
            KcalPer100gNum.Name = "KcalPer100gNum";
            KcalPer100gNum.Size = new Size(257, 35);
            KcalPer100gNum.TabIndex = 8;
            // 
            // PricePer100gNum
            // 
            PricePer100gNum.DecimalPlaces = 2;
            PricePer100gNum.Location = new Point(236, 288);
            PricePer100gNum.Maximum = new decimal(new int[] { 9999999, 0, 0, 0 });
            PricePer100gNum.Name = "PricePer100gNum";
            PricePer100gNum.Size = new Size(257, 35);
            PricePer100gNum.TabIndex = 9;
            // 
            // AddTofridgeBtn
            // 
            AddTofridgeBtn.Location = new Point(236, 342);
            AddTofridgeBtn.Name = "AddTofridgeBtn";
            AddTofridgeBtn.Size = new Size(257, 47);
            AddTofridgeBtn.TabIndex = 10;
            AddTofridgeBtn.Text = "ADD to Fridge";
            AddTofridgeBtn.UseVisualStyleBackColor = true;
            AddTofridgeBtn.Click += AddTofridgeBtn_Click;
            // 
            // NametextBox
            // 
            NametextBox.Location = new Point(236, 15);
            NametextBox.Name = "NametextBox";
            NametextBox.Size = new Size(257, 35);
            NametextBox.TabIndex = 11;
            // 
            // TypeTextBox
            // 
            TypeTextBox.Location = new Point(236, 78);
            TypeTextBox.Name = "TypeTextBox";
            TypeTextBox.Size = new Size(257, 35);
            TypeTextBox.TabIndex = 12;
            // 
            // IngredientsForm
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(582, 506);
            Controls.Add(TypeTextBox);
            Controls.Add(NametextBox);
            Controls.Add(AddTofridgeBtn);
            Controls.Add(PricePer100gNum);
            Controls.Add(KcalPer100gNum);
            Controls.Add(WeightNum);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5, 6, 5, 6);
            Name = "IngredientsForm";
            Text = "My Fridge";
            ((System.ComponentModel.ISupportInitialize)WeightNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)KcalPer100gNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)PricePer100gNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox NametextBox;
        private NumericUpDown WeightNum;
        private NumericUpDown KcalPer100gNum;
        private NumericUpDown PricePer100gNum;
        private Button AddTofridgeBtn;
        private TextBox TypeTextBox;
    }
}