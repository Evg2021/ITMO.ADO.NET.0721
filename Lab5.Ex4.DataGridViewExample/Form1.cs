using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5.Ex4.DataGridViewExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.apressFinancialDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'apressFinancialDataSet.Customers' table. You can move, or remove it, as needed.
            this.customersTableAdapter.Fill(this.apressFinancialDataSet.Customers);
            DataColumn FLName = new DataColumn("FLName");
            FLName.Expression = "CustomerFirstName + ',' + CustomerLastName";
            apressFinancialDataSet.Customers.Columns.Add(FLName);

        }

        private void AddColumnButton_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn FLNameColumn = new DataGridViewTextBoxColumn();
            FLNameColumn.Name = "FLNameColumn";
            FLNameColumn.HeaderText = "FLName";
            FLNameColumn.DataPropertyName = "FLname";
            customersDataGridView.Columns.Add(FLNameColumn);

        }

        private void DeleteColumnButton_Click(object sender, EventArgs e)
        {
            try
            {
                customersDataGridView.Columns.Remove("FLNameColumn");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void GetClickedCellButton_Click(object sender, EventArgs e)
        {
            string CurrentCellInfo;
            CurrentCellInfo = customersDataGridView.CurrentCell.Value.ToString() + Environment.NewLine;
            CurrentCellInfo += "Column: " + customersDataGridView.CurrentCell.OwningColumn.DataPropertyName + Environment.NewLine;
            CurrentCellInfo += "Column Index: " + customersDataGridView.CurrentCell.ColumnIndex.ToString() + Environment.NewLine;
            CurrentCellInfo += "Row Index: " + customersDataGridView.CurrentCell.RowIndex.ToString() + Environment.NewLine;
            label1.Text = CurrentCellInfo;
        }
        private void customersDataGridView_CellValidating_1(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (customersDataGridView.Columns[e.ColumnIndex].DataPropertyName == "ContactName")
            {
                if (e.FormattedValue.ToString() == "")
                {
                    customersDataGridView.Rows[e.RowIndex].ErrorText =
                        "ContactName is a required field";
                    e.Cancel = true;
                }
                else
                    customersDataGridView.Rows[e.RowIndex].ErrorText = "";
            }
        }

        private void ApplyStyleButton_Click(object sender, EventArgs e)
        {
            customersDataGridView.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;
        }
    }
}
