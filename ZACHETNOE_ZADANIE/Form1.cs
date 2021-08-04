using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;

namespace ZACHETNOE_ZADANIE
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
            this.connection.StateChange += new System.Data.StateChangeEventHandler(this.connection_StateChange);


        }
        static string GetConnectionStringByName(string name)
        {
            string returnValue = null;
            ConnectionStringSettings settings =
                ConfigurationManager.ConnectionStrings[name];
            if (settings != null)
                returnValue = settings.ConnectionString;
            return returnValue;
        }

        string testConnect = GetConnectionStringByName("DBConnect.ApressConnectionString");
        private void подключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                if (connection.State != ConnectionState.Open)
                {
                    connection.ConnectionString = testConnect;
                    connection.Open();
                    MessageBox.Show("Соединение с базой данных выполнено успешно");
                }
                else
                    MessageBox.Show("Соединение с базой данных уже установлено");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message,
                    "SQL Error code " + se.NativeError,
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
            }

            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected Exception",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        
        private void отключитьсяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
                MessageBox.Show("Соединение с базой данных закрыто");
            }
            else
                MessageBox.Show("Соединение с базой данных уже закрыто");
        }

        private void connection_StateChange(object sender, System.Data.StateChangeEventArgs e)
        {
            подключитьсяToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            отключитьсяToolStripMenuItem.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (connection.State == ConnectionState.Closed)
            {
                MessageBox.Show("Сначала подключитесь к базе данных!");
                return;
            }
            OleDbCommand command = connection.CreateCommand();
            command.CommandText = "SELECT ProductName FROM CustomerDetails.FinancialProducts";
            OleDbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                listView1.Items.Add(reader["ProductName"].ToString());
            }

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
            NewRow.DateAdded = DateTime.Today;

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
            String SelectedCustomerId = customersDataGridView.CurrentRow.Cells["CustomerId"].Value.ToString();
            ApressFinancialDataSet.CustomersRow SelectedRow = apressFinancialDataSet.Customers.FindByCustomerId(Convert.ToInt64(SelectedCustomerId));
            return SelectedRow;
        }
        private void DeleteRowButton_Click(object sender, EventArgs e)
        {
            GetSelectedRow().Delete();
        }
    }
}
