using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * 02-17-2021
 * CSC 153
 * Zachary Fegan
 * Retail Price Calculator Create an application that lets the user enter an item’s wholesale cost and its markup percentage. It should then display the item’s retail price.
 */

namespace Reetail_Price_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double wholesale;
            double markup;

            if (double.TryParse(textBox1.Text, out wholesale) && double.TryParse(textBox2.Text, out markup))
            {
                double retailPrice;
                retailPrice = CalculateRetail(wholesale, markup);
                textBox3.Text = retailPrice.ToString("C");
            }
            else
                MessageBox.Show("Please enter valid numbers", "Invalid Input");

        }

        private double CalculateRetail(double wholesale, double markup)
        {
            double markupPercent = markup / 100;
            double retailPrice;

            retailPrice = wholesale + (wholesale * markupPercent);
            return retailPrice;
        }
    }
}
