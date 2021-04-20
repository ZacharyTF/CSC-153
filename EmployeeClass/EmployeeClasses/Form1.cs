using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;

namespace EmployeeClasses
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Employee> employees = new List<Employee>();
        private void btnDisplay_Click(object sender, EventArgs e)
        {
            employees.Add(new Employee("Susan Meyers", 47899, "Accounting", "Vice President"));
            employees.Add(new Employee("Marke Jones", 39119));
            employees.Add(new Employee());
            DisplayEmployees();
        }

        private void DisplayEmployees()
        {
            txtOutput.Clear();
            foreach (Employee e in employees)
            {
                txtOutput.Text += e.ToString();
                txtOutput.Text += Environment.NewLine;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            employees[1].Department = "IT";
            employees[1].Position = "Programmer";

            employees[2].Name = "Joy Rogers";
            employees[2].Id = 81774;
            employees[2].Department = "Manufacturing";
            employees[2].Position = "Engineer";

            DisplayEmployees();
        }
    }
}
