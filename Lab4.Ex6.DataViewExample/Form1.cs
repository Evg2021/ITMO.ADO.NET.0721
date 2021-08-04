using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Ex6.DataViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DataView customersProductsDataView;
        DataView customersDataView;

        private void Form1_Load(object sender, EventArgs e)
        {
            customersProductsTableAdapter1.Fill(apressFinancialDataSet1.CustomersProducts);
            customersTableAdapter1.Fill(apressFinancialDataSet1.Customers);
            customersDataView = new DataView(apressFinancialDataSet1.CustomersProducts);
            customersProductsDataView = new DataView(apressFinancialDataSet1.Customers);
            customersDataView.Sort = "CustomerID";
            CustomersGrid.DataSource = customersDataView;

        }

        private void SetDataViewPropertiesButton_Click(object sender, EventArgs e)
        {
            customersDataView.Sort = SortTextBox.Text;
            customersDataView.RowFilter = FilterTextBox.Text;

        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            DataRowView newCustomerRow = customersDataView.AddNew();
            newCustomerRow["CustomerTitleId"] = "6";
            newCustomerRow["CustomerFirstName"] = "Evgenii";
            newCustomerRow["CustomerLastName"] = "Kannunikov";
            newCustomerRow["AddressId"] = 7813;
            newCustomerRow["AccountNumber"] = "987654321";
            newCustomerRow["ClearBalance"] = (decimal)55.87;
            newCustomerRow["UnclearBalance"] = 93.70;
            newCustomerRow["AccountTypeId"] = 3;
            newCustomerRow["DateAdded"] = DateTime.Today;
            newCustomerRow.EndEdit();
        }

        private void GetOrdersButton_Click(object sender, EventArgs e)
        {
            string selectedCustomerID = (string)CustomersGrid.SelectedCells[0].OwningRow.Cells["CustomerID"].Value;
            DataRowView selectedRow = customersDataView[customersDataView.Find(selectedCustomerID)];
            customersDataView = selectedRow.CreateChildView(apressFinancialDataSet1.Relations["Customers_CustomersProducts"]);
            OrdersGrid.DataSource = customersDataView;
        }
    }
}
