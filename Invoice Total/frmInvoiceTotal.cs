using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Total
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal subtotal = Validate(txtSubtotal);
            // decimal subtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;
            if (subtotal >= 500)
            {
                discountPercent = .2m;
            }
            else if (subtotal >= 250 && subtotal < 500)
            {
                discountPercent = .15m;
            }
            else if  (subtotal >= 100 && subtotal <250)
            {
                discountPercent = .1m;
            }
            decimal discountAmount = subtotal * discountPercent;
            decimal invoiceTotal = subtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = invoiceTotal.ToString("c");
            txtTotal.Text = invoiceTotal.ToString("c");
            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private decimal Validate(TextBox t)
        {
            decimal no;
            Decimal.TryParse(t.Text, out no);
            return no;
        }
        private void txtSubtotal_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Return)
            {
                btnCalculate.PerformClick();
                e.Handled = true;
            }
                }

        private void btnAboutMe_Click(object sender, EventArgs e)
        {
            frmAboutMe f = new frmAboutMe();
            this.Hide();
            f.ShowDialog();
            this.Show();

        }

        private void txtSubtotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
