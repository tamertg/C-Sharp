namespace InvoiceTotal
{
    public partial class FrmInvoiceTotal : Form
    {
        public FrmInvoiceTotal()
        {
            InitializeComponent();
        }
        private void calculateButton_click(object sender, EventArgs e)
        {
            try
            {
                double subTotal = double.Parse(subTotalTextbox.Text);
                if (subTotal > 0 && subTotal <= 10000)
                {
                    double discountPrcent = double.Parse(discountPercentTextbox.Text) / 100;
                    if (discountPrcent > 0 && discountPrcent < 100)
                    {
                        double discountAmount = subTotal * discountPrcent;
                        double netTotal = subTotal - discountAmount;

                        discountPercentTextbox.Text = discountPrcent.ToString("P1");
                        discountAmountTextbox.Text = discountAmount.ToString("N2");
                        totalTextbox.Text = netTotal.ToString("N2");
                    }
                    else
                    {
                        MessageBox.Show("Please enter valid numbers in the textboxes.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter numbers between 1 to 10000 in the subTotal.");
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in the discount Percent.");
            }
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            subTotalTextbox.Text = string.Empty;
            discountPercentTextbox.Text = string.Empty;
            discountAmountTextbox.Text = string.Empty;
            totalTextbox.Text = string.Empty;
        }
    }
}
