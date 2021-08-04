using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Ex02.DataBindingSimple
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource customersBindingSource;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(apressFinancialDataSet1.Customers);
            customersBindingSource = new BindingSource(apressFinancialDataSet1, "Customers");
            CustomerIDTextBox.DataBindings.Add("Text", customersBindingSource, "CustomerID");
            CustomerNameTextBox.DataBindings.Add("Text", customersBindingSource, "CustomerName");
        }

        private void PreviousButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            customersBindingSource.MoveNext();
        }
    }
}
