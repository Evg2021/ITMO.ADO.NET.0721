using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Ex01.DataSet
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void GetCustomersButton_Click(object sender, EventArgs e)
        {
            ApresDataSet ApresDataset1 = new ApresDataSet();
            ApresDataSetTableAdapters.CustomersTableAdapter
                CustomersTableAdapter1 =
                new ApresDataSetTableAdapters.CustomersTableAdapter();
            CustomersTableAdapter1.Fill(ApresDataset1.Customers);
            foreach (ApresDataSet.CustomersRow NWCustomer in ApresDataset1.Customers.Rows)
            {
                CustomersListBox.Items.Add(NWCustomer.AddressId);
            }

        }
    }
}
