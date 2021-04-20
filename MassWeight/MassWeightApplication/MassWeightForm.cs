using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/**
* 03/22/2021
* CSC 153
* Zachary Fegan
* This program is used as an application to allow the user to enter an object's mass an then calculate the object's weight in Newtons.
*/

namespace MassWeightApplication
{
    public partial class MassWeightForm : Form
    {
        public MassWeightForm()
        {
            InitializeComponent();
        }

        private void calculateWeightButton_Click(object sender, EventArgs e)
        {
            try
            {
                const decimal newts = 9.8m;
                const decimal heavyWeight = 1000.0m;
                const decimal lightWeight = 10.0m;

                decimal mass;
                decimal weight;

                mass = decimal.Parse(massTextBox.Text);

                weight = mass * newts;

                weightLabel.Text = (weight.ToString() + "n");
                
                if (weight >= heavyWeight)
                {
                    heavyIndicatorLabel.Text = "Object is too heavy";
                }
                else if (weight <= lightWeight) 
                {
                    heavyIndicatorLabel.Text = "Object is too light";
                }
                else
                {
                    heavyIndicatorLabel.Text = "Object is within weight range";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            


        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            massTextBox.Text = "";
            weightLabel.Text = "";
            heavyIndicatorLabel.Text = "";

            massTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
