using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Lab4.Ex04.DataAdapterProgramm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private SqlConnection ApressFinanceConnection = new SqlConnection("Data Source=(LENOVO);Initial Catalog=ApressFinance;Integrated Security=True");
        private SqlDataAdapter SqlDataAdapter1;
        private DataSet ApressFinanceDataset = new DataSet("Apress");
        private DataTable CustomersTable = new DataTable("Customers");
        private void Form1_Load(object sender, EventArgs e)
        {
            SqlDataAdapter1 = new SqlDataAdapter("SELECT * FROM Customers", ApressFinanceConnection);
            ApressFinanceDataset.Tables.Add(CustomersTable);
            SqlDataAdapter1.Fill(ApressFinanceDataset.Tables["Customers"]);
            dataGridView1.DataSource = ApressFinanceDataset.Tables["Customers"];
            SqlCommandBuilder commands = new SqlCommandBuilder(SqlDataAdapter1);
            ApressFinanceDataset.EndInit();
            SqlDataAdapter1.Update(ApressFinanceDataset.Tables["Customers"]);

        }
    }
}
