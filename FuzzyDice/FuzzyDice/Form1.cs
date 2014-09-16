using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FuzzyDice
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }

        private void button1_Click(object sender, EventArgs e)
        {
    
        }

        private void wbQuantity_TextChanged(object sender, EventArgs e)
        {
            double price, quantity;
            decimal total;
            double subTotal;
            if (this.wbCheck.Checked)
            {
                quantity = Convert.ToDouble(wbQuantity.Text);
                price = 6.25;
                total = Convert.ToDecimal(price * quantity);
                this.wbTotal.Text = Convert.ToString("$" + total);
                subText.Text = Convert.ToString(total);
                
            }
        }

        private void rbQuantity_TextChanged(object sender, EventArgs e)
        {
            double price, quantity;
            decimal total;
            double subTotal;
            if (this.rbCheck.Checked)
            {
                quantity = Convert.ToDouble(rbQuantity.Text);
                price = 5.00;
                total = Convert.ToDecimal(price * quantity);
                this.rbTotal.Text = Convert.ToString("$" + total);
                subText.Text += Convert.ToString(total);
               
            }
        }

        private void bbQuantity_TextChanged(object sender, EventArgs e)
        {
            double price, quantity;
            decimal total;
         
            if (bbCheck.Checked)
            {
                quantity = Convert.ToDouble(bbQuantity.Text);
                price = 7.50;
                total = Convert.ToDecimal(price * quantity);
                bbTotal.Text = Convert.ToString("$" + total);
                
                subText.Text = Convert.ToString(total);
            }

        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            double total;
            total = 1.75 ;
            taxText.Text = Convert.ToString(total);
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            double total;
            total = 1.50;
            shipText.Text = Convert.ToString(total);
            
        }

        private void totalText_TextChanged(object sender, EventArgs e)
        {
            double total;
            double totalWb = Convert.ToDouble(wbTotal.Text);
            double totalRb = Convert.ToDouble(rbTotal.Text);
            double totalBb = Convert.ToDouble(bbTotal.Text);

            total = (totalBb + totalRb + totalWb) * 1.75 * 1.50;
            totalText.Text = Convert.ToString(total);
        }
     
    }
}
