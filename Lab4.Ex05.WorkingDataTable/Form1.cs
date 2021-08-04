using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4.Ex05.WorkingDataTable
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void sqlDataAdapter1_RowUpdated(object sender, System.Data.SqlClient.SqlRowUpdatedEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomersDataGridView.DataSource = apressFinancialDataSet.Customers;
            CustomersDataGridView.MultiSelect = false;
            CustomersDataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
            CustomersDataGridView.EditMode = DataGridViewEditMode.EditProgrammatically;

        }

        private void FillTableButton_Click(object sender, EventArgs e)
        {
            sqlDataAdapter1.Fill(apressFinancialDataSet.Customers);
        }

        private void AddRowButton_Click(object sender, EventArgs e)
        {
            ApressFinancialDataSet.CustomersRow NewRow = (ApressFinancialDataSet.CustomersRow)apressFinancialDataSet.Customers.NewRow();
            NewRow.CustomerId = 7;
            NewRow.CustomerTitleId = 2;
            NewRow.CustomerFirstName = "Steve";
            NewRow.CustomerOtherInitials = "C";
            NewRow.CustomerLastName = "Rogers";
            NewRow.AddressId = 178;
            NewRow.AccountNumber = "40702810";
            NewRow.AccountTypeId = 5;
            NewRow.CleareBalance = 100;
            NewRow.UncleareBalance = 120;
            
            try
            {
                apressFinancialDataSet.Customers.Rows.Add(NewRow);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Add Row Failed");
            }

        }
        private ApressFinancialDataSet.CustomersRow GetSelectedRow()
        {
            String SelectedCustomerId = CustomersDataGridView.CurrentRow.Cells["CustomerID"].Value.ToString();
            ApressFinancialDataSet.CustomersRow SelectedRow = apressFinancialDataSet.Customers.FindByCustomerId(SelectedCustomerId);
            return SelectedRow;
        }

        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
        private void UpdateRowVersionDisplay()
        {
            try
            {
                CurrentDRVTextBox.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Current].ToString();
            }
            catch (Exception ex)
            {
                CurrentDRVTextBox.Text = ex.Message;
            }
            try
            {
                OriginalDRVTextBox.Text = GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name, DataRowVersion.Original].ToString();
            }
            catch (Exception ex)
            {
                OriginalDRVTextBox.Text = ex.Message;
            }
            RowStateTextBox.Text = GetSelectedRow().RowState.ToString();
        }

        private void UpdateValueButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow()[CustomersDataGridView.CurrentCell.OwningColumn.Name] = CellValueTextBox.Text; UpdateRowVersionDisplay();

        }

        private void CustomersDataGridView_Click(object sender, EventArgs e)
        {
            CellValueTextBox.Text = CustomersDataGridView.CurrentCell.Value.ToString();
            UpdateRowVersionDisplay();
        }

        private void AcceptChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().AcceptChanges();
            UpdateRowVersionDisplay();

        }

        private void RejectChangesButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().RejectChanges();
            UpdateRowVersionDisplay();

        }
    }
}
