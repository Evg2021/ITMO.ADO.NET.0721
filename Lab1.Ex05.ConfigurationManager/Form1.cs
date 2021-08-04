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

namespace Lab1.Ex05.ConfigurationManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.connection1.StateChange += new StateChangeEventHandler(this.connection_StateChange);
        }

        OleDbConnection connection1 = new OleDbConnection();
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

        private void CreateConnection()
        {
            try
            {
                if (connection1.State != ConnectionState.Open)
                {
                    connection1.ConnectionString = testConnect;
                    connection1.Open();
                    MessageBox.Show("Connection to database has been establised successfully");
                }
                else
                    MessageBox.Show("Connection to database is already active");
            }
            catch (OleDbException XcpSQL)
            {
                foreach (OleDbError se in XcpSQL.Errors)
                {
                    MessageBox.Show(se.Message, "SQL Error code " + se.NativeError,
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception Xcp)
            {
                MessageBox.Show(Xcp.Message, "Unexpected exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MenuItemDBConnect_Click(object sender, EventArgs e)
        {
            CreateConnection();
        }

        private void MenuItemDBDisconnect_Click(object sender, EventArgs e)
        {
            if (connection1.State == ConnectionState.Open)
            {
                connection1.Close();
                MessageBox.Show("Connection to database is closed");
            }
            else
                MessageBox.Show("Connection to database is already closed");
        }

        private void connection_StateChange(object sender, StateChangeEventArgs e)
        {
            MenuItemDBConnect.Enabled =
                (e.CurrentState == ConnectionState.Closed);
            MenuItemDBDisconnect.Enabled =
                (e.CurrentState == ConnectionState.Open);
        }

        private void MenuItemConnectionsList_Click(object sender, EventArgs e)
        {
            ConnectionStringSettings myConStr = new ConnectionStringSettings();
            ConnectionStringSettingsCollection settings = ConfigurationManager.ConnectionStrings;

            if (settings != null)
            {
                foreach (ConnectionStringSettings css in settings)
                {
                    MessageBox.Show("name = " + css.Name);
                    MessageBox.Show("providerName = " + css.ProviderName);
                    MessageBox.Show("connectionString = " + css.ConnectionString);
                }
            }
        }

        private void buttonQty_Click(object sender, EventArgs e)
        {
            if (connection1.State == ConnectionState.Closed)
            {
                MessageBox.Show("Please connect to Database first");
                return;
            }

            OleDbCommand cmdQty = new OleDbCommand();
            cmdQty.Connection = connection1;
            cmdQty.CommandText = "SELECT count(*) FROM CustomerDetails.FinancialProducts";
            int productQty = (int)cmdQty.ExecuteScalar();
            labelQty.Text = productQty.ToString();
        }

        private void buttonList_Click(object sender, EventArgs e)
        {
            if (connection1.State == ConnectionState.Closed)
            {
                MessageBox.Show("Please connect to Database first");
                return;
            }

            OleDbCommand cmdList = connection1.CreateCommand();
            cmdList.CommandText = "SELECT ProductName FROM CustomerDetails.FinancialProducts";
            OleDbDataReader reader = cmdList.ExecuteReader();

            while (reader.Read())
                listViewProducts.Items.Add(reader["ProductName"].ToString());
        }

        private void buttonTran_Click(object sender, EventArgs e)
        {
            CreateConnection();
            OleDbTransaction OleTran = connection1.BeginTransaction();
            OleDbCommand cmdTran = connection1.CreateCommand();
            cmdTran.Transaction = OleTran;

            try
            {
                cmdTran.CommandText = "INSERT INTO CustomerDetails.FinancialProducts (ProductId, ProductName) " +
                    "VALUES(6, 'blank fp_2')";
                cmdTran.ExecuteNonQuery();
                cmdTran.CommandText = "INSERT INTO CustomerDetails.FinancialProducts (ProductId, ProductName) " +
                    "VALUES(7, 'blank fp_3')";
                cmdTran.ExecuteNonQuery();
                OleTran.Commit();
                MessageBox.Show("Both records were written to Database");
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
                try
                {
                    OleTran.Rollback();
                }
                catch (Exception exRollback)
                {
                    MessageBox.Show(exRollback.Message);
                }
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            listViewProducts.Items.Clear();
        }
    }
}
