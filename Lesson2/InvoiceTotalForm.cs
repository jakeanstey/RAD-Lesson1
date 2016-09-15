using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lesson2
{
    public partial class InvoiceTotalForm : Form
    {
        public InvoiceTotalForm()
        {
            InitializeComponent();
        }

        private void InvoiceTotalForm_Load(object sender, EventArgs e)
        {
            ResetSubtotalTextbox();
        }

        private void ResetSubtotalTextbox()
        {
            subtotalTextBox.Focus();
            subtotalTextBox.Text = "0";
            subtotalTextBox.SelectAll();
        }

        /// <summary>
        /// Calculate button event handler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // Local variables
            const double DiscountPercent = 0.1;
            double Subtotal;
            double DiscountAmount;
            double Total;

            try
            {
                // read values from the text boxes
                // Convert the values from strings to doubles
                Subtotal = Convert.ToDouble(subtotalTextBox.Text);
                DiscountAmount = Subtotal * DiscountPercent;
                Total = Subtotal - DiscountAmount;

                discountAmountTextbox.Text = DiscountAmount.ToString("C2");
                totalTextbox.Text = Total.ToString("C2");
            }
            catch (Exception exception)
            {
                MessageBox.Show("Invalid Data Entered", "Input Error");
                Debug.WriteLine(exception.Message);
                ResetSubtotalTextbox();
            }
            

            // DiscountAmount = Subtotal x 0.1

            // Total = Subtotal - DiscountAmount

            // Display DiscountAmount in related text box

            // Display Total in related Text Box
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
