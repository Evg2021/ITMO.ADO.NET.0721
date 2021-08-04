
namespace Lab4.Ex05.WorkingDataTable
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CustomersDataGridView = new System.Windows.Forms.DataGridView();
            this.apressFinancialDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apressFinancialDataSet = new Lab4.Ex05.WorkingDataTable.ApressFinancialDataSet();
            this.FillTableButton = new System.Windows.Forms.Button();
            this.sqlSelectCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlConnection1 = new System.Data.SqlClient.SqlConnection();
            this.sqlInsertCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlUpdateCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDeleteCommand1 = new System.Data.SqlClient.SqlCommand();
            this.sqlDataAdapter1 = new System.Data.SqlClient.SqlDataAdapter();
            this.AddRowButton = new System.Windows.Forms.Button();
            this.DeleteRowButton = new System.Windows.Forms.Button();
            this.UpdateValueButton = new System.Windows.Forms.Button();
            this.AcceptChangesButton = new System.Windows.Forms.Button();
            this.RejectChangesButton = new System.Windows.Forms.Button();
            this.CellValueTextBox = new System.Windows.Forms.TextBox();
            this.OriginalDRVTextBox = new System.Windows.Forms.TextBox();
            this.CurrentDRVTextBox = new System.Windows.Forms.TextBox();
            this.RowStateTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomersDataGridView
            // 
            this.CustomersDataGridView.AutoGenerateColumns = false;
            this.CustomersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustomersDataGridView.DataSource = this.apressFinancialDataSetBindingSource;
            this.CustomersDataGridView.Location = new System.Drawing.Point(147, 12);
            this.CustomersDataGridView.Name = "CustomersDataGridView";
            this.CustomersDataGridView.Size = new System.Drawing.Size(412, 98);
            this.CustomersDataGridView.TabIndex = 0;
            this.CustomersDataGridView.Click += new System.EventHandler(this.CustomersDataGridView_Click);
            // 
            // apressFinancialDataSetBindingSource
            // 
            this.apressFinancialDataSetBindingSource.DataSource = this.apressFinancialDataSet;
            this.apressFinancialDataSetBindingSource.Position = 0;
            // 
            // apressFinancialDataSet
            // 
            this.apressFinancialDataSet.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FillTableButton
            // 
            this.FillTableButton.Location = new System.Drawing.Point(44, 122);
            this.FillTableButton.Name = "FillTableButton";
            this.FillTableButton.Size = new System.Drawing.Size(75, 23);
            this.FillTableButton.TabIndex = 1;
            this.FillTableButton.Text = "Fill Table";
            this.FillTableButton.UseVisualStyleBackColor = true;
            this.FillTableButton.Click += new System.EventHandler(this.FillTableButton_Click);
            // 
            // sqlSelectCommand1
            // 
            this.sqlSelectCommand1.CommandText = "SELECT * FROM CustomerDetails.Customers";
            this.sqlSelectCommand1.Connection = this.sqlConnection1;
            // 
            // sqlConnection1
            // 
            this.sqlConnection1.ConnectionString = "Data Source=LENOVO;Initial Catalog=ApressFinancial;Integrated Security=True";
            this.sqlConnection1.FireInfoMessageEventOnUserErrors = false;
            // 
            // sqlInsertCommand1
            // 
            this.sqlInsertCommand1.CommandText = resources.GetString("sqlInsertCommand1.CommandText");
            this.sqlInsertCommand1.Connection = this.sqlConnection1;
            this.sqlInsertCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.Int, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@CleareBalance", System.Data.SqlDbType.Money, 0, "CleareBalance"),
            new System.Data.SqlClient.SqlParameter("@UncleareBalance", System.Data.SqlDbType.Money, 0, "UncleareBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded")});
            // 
            // sqlUpdateCommand1
            // 
            this.sqlUpdateCommand1.CommandText = resources.GetString("sqlUpdateCommand1.CommandText");
            this.sqlUpdateCommand1.Connection = this.sqlConnection1;
            this.sqlUpdateCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@CustomerTitleId", System.Data.SqlDbType.Int, 0, "CustomerTitleId"),
            new System.Data.SqlClient.SqlParameter("@CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, "CustomerFirstName"),
            new System.Data.SqlClient.SqlParameter("@CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, "CustomerOtherInitials"),
            new System.Data.SqlClient.SqlParameter("@CustomerLastName", System.Data.SqlDbType.NVarChar, 0, "CustomerLastName"),
            new System.Data.SqlClient.SqlParameter("@AddressId", System.Data.SqlDbType.BigInt, 0, "AddressId"),
            new System.Data.SqlClient.SqlParameter("@AccountNumber", System.Data.SqlDbType.NChar, 0, "AccountNumber"),
            new System.Data.SqlClient.SqlParameter("@AccountTypeId", System.Data.SqlDbType.Int, 0, "AccountTypeId"),
            new System.Data.SqlClient.SqlParameter("@CleareBalance", System.Data.SqlDbType.Money, 0, "CleareBalance"),
            new System.Data.SqlClient.SqlParameter("@UncleareBalance", System.Data.SqlDbType.Money, 0, "UncleareBalance"),
            new System.Data.SqlClient.SqlParameter("@DateAdded", System.Data.SqlDbType.Date, 0, "DateAdded"),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UncleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UncleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@CustomerId", System.Data.SqlDbType.BigInt, 8, "CustomerId")});
            // 
            // sqlDeleteCommand1
            // 
            this.sqlDeleteCommand1.CommandText = resources.GetString("sqlDeleteCommand1.CommandText");
            this.sqlDeleteCommand1.Connection = this.sqlConnection1;
            this.sqlDeleteCommand1.Parameters.AddRange(new System.Data.SqlClient.SqlParameter[] {
            new System.Data.SqlClient.SqlParameter("@Original_CustomerId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerTitleId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerTitleId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerFirstName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerFirstName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@IsNull_CustomerOtherInitials", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, true, null, "", "", ""),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerOtherInitials", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerOtherInitials", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CustomerLastName", System.Data.SqlDbType.NVarChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CustomerLastName", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AddressId", System.Data.SqlDbType.BigInt, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AddressId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountNumber", System.Data.SqlDbType.NChar, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountNumber", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_AccountTypeId", System.Data.SqlDbType.Int, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "AccountTypeId", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_CleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "CleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_UncleareBalance", System.Data.SqlDbType.Money, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "UncleareBalance", System.Data.DataRowVersion.Original, null),
            new System.Data.SqlClient.SqlParameter("@Original_DateAdded", System.Data.SqlDbType.Date, 0, System.Data.ParameterDirection.Input, false, ((byte)(0)), ((byte)(0)), "DateAdded", System.Data.DataRowVersion.Original, null)});
            // 
            // sqlDataAdapter1
            // 
            this.sqlDataAdapter1.DeleteCommand = this.sqlDeleteCommand1;
            this.sqlDataAdapter1.InsertCommand = this.sqlInsertCommand1;
            this.sqlDataAdapter1.SelectCommand = this.sqlSelectCommand1;
            this.sqlDataAdapter1.TableMappings.AddRange(new System.Data.Common.DataTableMapping[] {
            new System.Data.Common.DataTableMapping("Table", "Customers", new System.Data.Common.DataColumnMapping[] {
                        new System.Data.Common.DataColumnMapping("CustomerId", "CustomerId"),
                        new System.Data.Common.DataColumnMapping("CustomerTitleId", "CustomerTitleId"),
                        new System.Data.Common.DataColumnMapping("CustomerFirstName", "CustomerFirstName"),
                        new System.Data.Common.DataColumnMapping("CustomerOtherInitials", "CustomerOtherInitials"),
                        new System.Data.Common.DataColumnMapping("CustomerLastName", "CustomerLastName"),
                        new System.Data.Common.DataColumnMapping("AddressId", "AddressId"),
                        new System.Data.Common.DataColumnMapping("AccountNumber", "AccountNumber"),
                        new System.Data.Common.DataColumnMapping("AccountTypeId", "AccountTypeId"),
                        new System.Data.Common.DataColumnMapping("CleareBalance", "CleareBalance"),
                        new System.Data.Common.DataColumnMapping("UncleareBalance", "UncleareBalance"),
                        new System.Data.Common.DataColumnMapping("DateAdded", "DateAdded")})});
            this.sqlDataAdapter1.UpdateCommand = this.sqlUpdateCommand1;
            this.sqlDataAdapter1.RowUpdated += new System.Data.SqlClient.SqlRowUpdatedEventHandler(this.sqlDataAdapter1_RowUpdated);
            // 
            // AddRowButton
            // 
            this.AddRowButton.Location = new System.Drawing.Point(44, 163);
            this.AddRowButton.Name = "AddRowButton";
            this.AddRowButton.Size = new System.Drawing.Size(75, 23);
            this.AddRowButton.TabIndex = 2;
            this.AddRowButton.Text = "Add Row";
            this.AddRowButton.UseVisualStyleBackColor = true;
            this.AddRowButton.Click += new System.EventHandler(this.AddRowButton_Click);
            // 
            // DeleteRowButton
            // 
            this.DeleteRowButton.Location = new System.Drawing.Point(44, 213);
            this.DeleteRowButton.Name = "DeleteRowButton";
            this.DeleteRowButton.Size = new System.Drawing.Size(75, 23);
            this.DeleteRowButton.TabIndex = 3;
            this.DeleteRowButton.Text = "Del Row";
            this.DeleteRowButton.UseVisualStyleBackColor = true;
            this.DeleteRowButton.Click += new System.EventHandler(this.DeleteRowButton_Click);
            // 
            // UpdateValueButton
            // 
            this.UpdateValueButton.Location = new System.Drawing.Point(158, 212);
            this.UpdateValueButton.Name = "UpdateValueButton";
            this.UpdateValueButton.Size = new System.Drawing.Size(94, 24);
            this.UpdateValueButton.TabIndex = 4;
            this.UpdateValueButton.Text = "Update Value";
            this.UpdateValueButton.UseVisualStyleBackColor = true;
            this.UpdateValueButton.Click += new System.EventHandler(this.UpdateValueButton_Click);
            // 
            // AcceptChangesButton
            // 
            this.AcceptChangesButton.Location = new System.Drawing.Point(283, 211);
            this.AcceptChangesButton.Name = "AcceptChangesButton";
            this.AcceptChangesButton.Size = new System.Drawing.Size(98, 23);
            this.AcceptChangesButton.TabIndex = 5;
            this.AcceptChangesButton.Text = "Accept Changes";
            this.AcceptChangesButton.UseVisualStyleBackColor = true;
            this.AcceptChangesButton.Click += new System.EventHandler(this.AcceptChangesButton_Click);
            // 
            // RejectChangesButton
            // 
            this.RejectChangesButton.Location = new System.Drawing.Point(411, 211);
            this.RejectChangesButton.Name = "RejectChangesButton";
            this.RejectChangesButton.Size = new System.Drawing.Size(98, 23);
            this.RejectChangesButton.TabIndex = 6;
            this.RejectChangesButton.Text = "Reject Changes";
            this.RejectChangesButton.UseVisualStyleBackColor = true;
            this.RejectChangesButton.Click += new System.EventHandler(this.RejectChangesButton_Click);
            // 
            // CellValueTextBox
            // 
            this.CellValueTextBox.Location = new System.Drawing.Point(158, 125);
            this.CellValueTextBox.Name = "CellValueTextBox";
            this.CellValueTextBox.Size = new System.Drawing.Size(100, 20);
            this.CellValueTextBox.TabIndex = 7;
            // 
            // OriginalDRVTextBox
            // 
            this.OriginalDRVTextBox.Location = new System.Drawing.Point(158, 165);
            this.OriginalDRVTextBox.Name = "OriginalDRVTextBox";
            this.OriginalDRVTextBox.Size = new System.Drawing.Size(100, 20);
            this.OriginalDRVTextBox.TabIndex = 8;
            // 
            // CurrentDRVTextBox
            // 
            this.CurrentDRVTextBox.Location = new System.Drawing.Point(338, 124);
            this.CurrentDRVTextBox.Name = "CurrentDRVTextBox";
            this.CurrentDRVTextBox.Size = new System.Drawing.Size(100, 20);
            this.CurrentDRVTextBox.TabIndex = 9;
            // 
            // RowStateTextBox
            // 
            this.RowStateTextBox.Location = new System.Drawing.Point(338, 166);
            this.RowStateTextBox.Name = "RowStateTextBox";
            this.RowStateTextBox.Size = new System.Drawing.Size(100, 20);
            this.RowStateTextBox.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RowStateTextBox);
            this.Controls.Add(this.CurrentDRVTextBox);
            this.Controls.Add(this.OriginalDRVTextBox);
            this.Controls.Add(this.CellValueTextBox);
            this.Controls.Add(this.RejectChangesButton);
            this.Controls.Add(this.AcceptChangesButton);
            this.Controls.Add(this.UpdateValueButton);
            this.Controls.Add(this.DeleteRowButton);
            this.Controls.Add(this.AddRowButton);
            this.Controls.Add(this.FillTableButton);
            this.Controls.Add(this.CustomersDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustomersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView CustomersDataGridView;
        private System.Windows.Forms.BindingSource apressFinancialDataSetBindingSource;
        private ApressFinancialDataSet apressFinancialDataSet;
        private System.Windows.Forms.Button FillTableButton;
        private System.Data.SqlClient.SqlCommand sqlSelectCommand1;
        private System.Data.SqlClient.SqlConnection sqlConnection1;
        private System.Data.SqlClient.SqlCommand sqlInsertCommand1;
        private System.Data.SqlClient.SqlCommand sqlUpdateCommand1;
        private System.Data.SqlClient.SqlCommand sqlDeleteCommand1;
        private System.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
        private System.Windows.Forms.Button AddRowButton;
        private System.Windows.Forms.Button DeleteRowButton;
        private System.Windows.Forms.Button UpdateValueButton;
        private System.Windows.Forms.Button AcceptChangesButton;
        private System.Windows.Forms.Button RejectChangesButton;
        private System.Windows.Forms.TextBox CellValueTextBox;
        private System.Windows.Forms.TextBox OriginalDRVTextBox;
        private System.Windows.Forms.TextBox CurrentDRVTextBox;
        private System.Windows.Forms.TextBox RowStateTextBox;
    }
}

