namespace ClothingSales
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            calculateButton = new Button();
            clearAllButton = new Button();
            exitbutton = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            quantatyTextbox = new TextBox();
            priceTextbox = new TextBox();
            extendedPriceTextbox = new TextBox();
            DiscountTextbox = new TextBox();
            amountDueTextbox = new TextBox();
            totalAmountTextbox = new TextBox();
            noOfTransactionTextbox = new TextBox();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            SuspendLayout();
            // 
            // calculateButton
            // 
            calculateButton.Location = new Point(402, 78);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(75, 23);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearAllButton
            // 
            clearAllButton.Location = new Point(402, 117);
            clearAllButton.Name = "clearAllButton";
            clearAllButton.Size = new Size(75, 23);
            clearAllButton.TabIndex = 3;
            clearAllButton.Text = "Clear All";
            clearAllButton.UseVisualStyleBackColor = true;
            clearAllButton.Click += clearAllButton_Click;
            // 
            // exitbutton
            // 
            exitbutton.Location = new Point(402, 152);
            exitbutton.Name = "exitbutton";
            exitbutton.Size = new Size(75, 23);
            exitbutton.TabIndex = 4;
            exitbutton.Text = "Exit";
            exitbutton.UseVisualStyleBackColor = true;
            exitbutton.Click += exitbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HotTrack;
            label1.Font = new Font("Segoe UI", 30F);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(72, 9);
            label1.Name = "label1";
            label1.Size = new Size(275, 54);
            label1.TabIndex = 3;
            label1.Text = "Clothing Sales";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 104);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 4;
            label2.Text = "Number Of Items:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 143);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 5;
            label3.Text = "Price:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(30, 182);
            label4.Name = "label4";
            label4.Size = new Size(88, 15);
            label4.TabIndex = 6;
            label4.Text = "Extended Price:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(30, 251);
            label5.Name = "label5";
            label5.Size = new Size(90, 15);
            label5.TabIndex = 7;
            label5.Text = "Discount (10%):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(30, 290);
            label6.Name = "label6";
            label6.Size = new Size(78, 15);
            label6.TabIndex = 8;
            label6.Text = "Amount Due:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(39, 350);
            label7.Name = "label7";
            label7.Size = new Size(82, 15);
            label7.TabIndex = 9;
            label7.Text = "Total Amount:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 389);
            label8.Name = "label8";
            label8.Size = new Size(108, 15);
            label8.TabIndex = 10;
            label8.Text = "No. Of Transaction:";
            // 
            // quantatyTextbox
            // 
            quantatyTextbox.Location = new Point(233, 101);
            quantatyTextbox.Name = "quantatyTextbox";
            quantatyTextbox.Size = new Size(100, 23);
            quantatyTextbox.TabIndex = 0;
            // 
            // priceTextbox
            // 
            priceTextbox.Location = new Point(233, 140);
            priceTextbox.Name = "priceTextbox";
            priceTextbox.Size = new Size(100, 23);
            priceTextbox.TabIndex = 1;
            // 
            // extendedPriceTextbox
            // 
            extendedPriceTextbox.Enabled = false;
            extendedPriceTextbox.Location = new Point(233, 179);
            extendedPriceTextbox.Name = "extendedPriceTextbox";
            extendedPriceTextbox.Size = new Size(100, 23);
            extendedPriceTextbox.TabIndex = 13;
            // 
            // DiscountTextbox
            // 
            DiscountTextbox.Enabled = false;
            DiscountTextbox.Location = new Point(233, 248);
            DiscountTextbox.Name = "DiscountTextbox";
            DiscountTextbox.Size = new Size(100, 23);
            DiscountTextbox.TabIndex = 14;
            // 
            // amountDueTextbox
            // 
            amountDueTextbox.Enabled = false;
            amountDueTextbox.Location = new Point(233, 287);
            amountDueTextbox.Name = "amountDueTextbox";
            amountDueTextbox.Size = new Size(100, 23);
            amountDueTextbox.TabIndex = 15;
            // 
            // totalAmountTextbox
            // 
            totalAmountTextbox.Enabled = false;
            totalAmountTextbox.Location = new Point(233, 347);
            totalAmountTextbox.Name = "totalAmountTextbox";
            totalAmountTextbox.Size = new Size(100, 23);
            totalAmountTextbox.TabIndex = 16;
            // 
            // noOfTransactionTextbox
            // 
            noOfTransactionTextbox.Enabled = false;
            noOfTransactionTextbox.Location = new Point(233, 386);
            noOfTransactionTextbox.Name = "noOfTransactionTextbox";
            noOfTransactionTextbox.Size = new Size(100, 23);
            noOfTransactionTextbox.TabIndex = 17;
            // 
            // groupBox1
            // 
            groupBox1.Location = new Point(12, 78);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(344, 134);
            groupBox1.TabIndex = 18;
            groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(12, 220);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(344, 100);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            groupBox3.Location = new Point(12, 328);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(344, 100);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Summary";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(498, 438);
            Controls.Add(noOfTransactionTextbox);
            Controls.Add(totalAmountTextbox);
            Controls.Add(amountDueTextbox);
            Controls.Add(DiscountTextbox);
            Controls.Add(extendedPriceTextbox);
            Controls.Add(priceTextbox);
            Controls.Add(quantatyTextbox);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(exitbutton);
            Controls.Add(clearAllButton);
            Controls.Add(calculateButton);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Clothing Sales";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button calculateButton;
        private Button clearAllButton;
        private Button exitbutton;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox quantatyTextbox;
        private TextBox priceTextbox;
        private TextBox extendedPriceTextbox;
        private TextBox DiscountTextbox;
        private TextBox amountDueTextbox;
        private TextBox totalAmountTextbox;
        private TextBox noOfTransactionTextbox;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
    }
}
