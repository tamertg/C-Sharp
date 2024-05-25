namespace InvoiceTotal
{
    partial class FrmInvoiceTotal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInvoiceTotal));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            calculateButton = new Button();
            exitButton = new Button();
            clearButton = new Button();
            totalTextbox = new TextBox();
            discountAmountTextbox = new TextBox();
            discountPercentTextbox = new TextBox();
            subTotalTextbox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Flat;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 26);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 0;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label2.Location = new Point(12, 76);
            label2.Name = "label2";
            label2.Size = new Size(170, 30);
            label2.TabIndex = 1;
            label2.Text = "Discount Percent:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label3.Location = new Point(12, 125);
            label3.Name = "label3";
            label3.Size = new Size(159, 30);
            label3.TabIndex = 2;
            label3.Text = "Discount Amout";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic);
            label4.Location = new Point(12, 174);
            label4.Name = "label4";
            label4.Size = new Size(63, 30);
            label4.TabIndex = 3;
            label4.Text = "Total:";
            // 
            // calculateButton
            // 
            calculateButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            calculateButton.Location = new Point(30, 234);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(118, 45);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Calculate";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_click;
            // 
            // exitButton
            // 
            exitButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            exitButton.Location = new Point(115, 285);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(109, 39);
            exitButton.TabIndex = 4;
            exitButton.Text = "Exit";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // clearButton
            // 
            clearButton.Font = new Font("Segoe UI", 15.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            clearButton.Location = new Point(193, 234);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(108, 45);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // totalTextbox
            // 
            totalTextbox.Enabled = false;
            totalTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            totalTextbox.Location = new Point(223, 174);
            totalTextbox.Name = "totalTextbox";
            totalTextbox.Size = new Size(100, 33);
            totalTextbox.TabIndex = 7;
            // 
            // discountAmountTextbox
            // 
            discountAmountTextbox.Enabled = false;
            discountAmountTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountAmountTextbox.Location = new Point(223, 126);
            discountAmountTextbox.Name = "discountAmountTextbox";
            discountAmountTextbox.Size = new Size(100, 33);
            discountAmountTextbox.TabIndex = 8;
            // 
            // discountPercentTextbox
            // 
            discountPercentTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            discountPercentTextbox.Location = new Point(223, 77);
            discountPercentTextbox.Name = "discountPercentTextbox";
            discountPercentTextbox.Size = new Size(100, 33);
            discountPercentTextbox.TabIndex = 1;
            // 
            // subTotalTextbox
            // 
            subTotalTextbox.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            subTotalTextbox.Location = new Point(223, 27);
            subTotalTextbox.Name = "subTotalTextbox";
            subTotalTextbox.Size = new Size(100, 33);
            subTotalTextbox.TabIndex = 0;
            // 
            // FrmInvoiceTotal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(345, 349);
            Controls.Add(subTotalTextbox);
            Controls.Add(discountPercentTextbox);
            Controls.Add(discountAmountTextbox);
            Controls.Add(totalTextbox);
            Controls.Add(clearButton);
            Controls.Add(exitButton);
            Controls.Add(calculateButton);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = SystemColors.ControlText;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FrmInvoiceTotal";
            RightToLeft = RightToLeft.No;
            Text = "Invoice Total";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button calculateButton;
        private Button exitButton;
        private Button clearButton;
        private TextBox totalTextbox;
        private TextBox discountAmountTextbox;
        private TextBox discountPercentTextbox;
        private TextBox subTotalTextbox;
    }
}
