namespace ClothingSales
{
    public partial class Form1 : Form
    {
        private int numberOfTransaction;
        private decimal totalAmount;
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            decimal discountRate = 0.1m, price, extendedPrice, discount, amountDue;
            int quantaty;

            try
            { 
            quantaty = int.Parse(quantatyTextbox.Text);
            price = decimal.Parse(priceTextbox.Text);
            extendedPrice = quantaty * price;
            discount = discountRate * extendedPrice;
            amountDue = extendedPrice - discount;

            totalAmount += amountDue;
            numberOfTransaction++;

            extendedPriceTextbox.Text = extendedPrice.ToString("c");
            DiscountTextbox.Text = discount.ToString("c");
            amountDueTextbox.Text = amountDue.ToString("c");
            totalAmountTextbox.Text = totalAmount.ToString("c");
            noOfTransactionTextbox.Text = numberOfTransaction.ToString("n0");

            quantatyTextbox.Clear();
            priceTextbox.Clear();
            }
            catch (FormatException)
            {
                MessageBox.Show("Please enter valid numbers in the textboxes.");
            }
            catch (OverflowException)
            {
                MessageBox.Show("The number entered is too large or too small.");
            }
        }

        private void exitbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearAllButton_Click(object sender, EventArgs e)
        {
            quantatyTextbox.Text = string.Empty;
            priceTextbox.Text = string.Empty;
            extendedPriceTextbox.Text = string.Empty;
            DiscountTextbox.Text = string.Empty;
            amountDueTextbox.Text = string.Empty;
            totalAmountTextbox.Text = string.Empty;
            noOfTransactionTextbox.Text= string.Empty;
        }
    }
}
