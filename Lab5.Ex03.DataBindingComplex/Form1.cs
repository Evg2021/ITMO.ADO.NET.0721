using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Ex03.DataBindingComplex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BindGridButton_Click(object sender, EventArgs e)
        {
            customersTableAdapter1.Fill(apressFinancialDataSet1.Customers);
            BindingSource productsBindingSource = new BindingSource(apressFinancialDataSet1, "Products");
            CustomersGrid.DataSource = productsBindingSource;
            bindingNavigator1.BindingSource = productsBindingSource;
        }
    }
}
