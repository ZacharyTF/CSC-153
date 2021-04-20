using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

/**
* 04/17/2021
* CSC 153
* Zachary Fegan
* This program will demonstrate how to read elements in a(n) array and how to organize the array's elements accordingly, Sum, Average, Highest value, and/or Lowest value
*/

namespace Sales_Analysis
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double GetAveragePrice(double[] inputArray)
        {
            double outputAverage = 0;
            double total = 0;

            for (int index = 0; index < inputArray.Length; index++)
            {
                total += inputArray[index];
            }

            outputAverage = total / inputArray.Length;

            return outputAverage;
        }

        private double GetHighestPrice(double[] inputArray)
        {
            double outputHighest = inputArray[0];

            for (int index = 1; index < inputArray.Length; index++)
            {
                if (inputArray[index] > outputHighest)
                {
                    outputHighest = inputArray[index];
                }
            }
            return outputHighest;
        }

        private double GetLowestPrice(double[] inputArray)
        {
            double outputLowest = inputArray[0];

            for (int index = 1; index < inputArray.Length; index++)
            {
                if (inputArray[index] < outputLowest)
                {
                    outputLowest = inputArray[index];
                }
            }
            return outputLowest;
        }

        private double GetSumPrice(double[] inputArray)
        {
            double total = 0;
            double outputSum = 0;

            for (int index = 0; index < inputArray.Length; index++)
            {
                total += inputArray[index];
            }
            outputSum = total;

            return outputSum;
        }

        private void displayButton_Click(object sender, EventArgs e)
        {
            double[] prices = { 1245.67, 1189.55, 1098.72, 1456.88, 2109.34, 1987.55, 1872.36 };
            
            foreach (double price in prices)
            {
                displayListBox.Items.Add(price.ToString("c"));
            }

            averageLabel.Text = GetAveragePrice(prices).ToString("c");
            maximumLabel.Text = GetHighestPrice(prices).ToString("c");
            minimumLabel.Text = GetLowestPrice(prices).ToString("c");
            sumLabel.Text = GetSumPrice(prices).ToString("c");
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
