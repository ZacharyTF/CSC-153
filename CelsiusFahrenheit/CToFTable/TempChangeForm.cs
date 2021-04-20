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
* 3-29-2021
* CSC 153
* Zachary Fegan
* This program will diaplay a table of 
*/

namespace CToFTable
{
    public partial class TempChangeForm : Form
    {
        public TempChangeForm()
        {
            InitializeComponent();
        }

        private void DisplayTableButton_Click(object sender, EventArgs e)
        {
            int celsius = 0;
            decimal fahrenheit;

            while (celsius <= 20)
            {
                fahrenheit = ((9 / 5) * celsius) + 32;

                celsiusListBox.Items.Add("Celsius: " + celsius);
                fahrenheitListBox.Items.Add("Fahrenheit: " + fahrenheit);

                celsius++;
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
