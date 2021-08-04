
namespace Lab5.Ex02.DataBindingSimple
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
            this.apressFinancialDataSet1 = new Lab5.Ex02.DataBindingSimple.ApressFinancialDataSet();
            this.customersTableAdapter1 = new Lab5.Ex02.DataBindingSimple.ApressFinancialDataSetTableAdapters.CustomersTableAdapter();
            this.CustomerIDTextBox = new System.Windows.Forms.TextBox();
            this.CustomerNameTextBox = new System.Windows.Forms.TextBox();
            this.PreviousButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.apressFinancialDataSet2 = new Lab5.Ex02.DataBindingSimple.ApressFinancialDataSet();
            this.apressFinancialDataSet3 = new Lab5.Ex02.DataBindingSimple.ApressFinancialDataSet();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // apressFinancialDataSet1
            // 
            this.apressFinancialDataSet1.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customersTableAdapter1
            // 
            this.customersTableAdapter1.ClearBeforeFill = true;
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.Location = new System.Drawing.Point(97, 115);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerIDTextBox.TabIndex = 0;
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.Location = new System.Drawing.Point(295, 115);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.CustomerNameTextBox.TabIndex = 1;
            // 
            // PreviousButton
            // 
            this.PreviousButton.Location = new System.Drawing.Point(97, 206);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(100, 23);
            this.PreviousButton.TabIndex = 2;
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.UseVisualStyleBackColor = true;
            this.PreviousButton.Click += new System.EventHandler(this.PreviousButton_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(295, 206);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 23);
            this.NextButton.TabIndex = 3;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.NextButton_Click);
            // 
            // apressFinancialDataSet2
            // 
            this.apressFinancialDataSet2.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // apressFinancialDataSet3
            // 
            this.apressFinancialDataSet3.DataSetName = "ApressFinancialDataSet";
            this.apressFinancialDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.PreviousButton);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apressFinancialDataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ApressFinancialDataSet apressFinancialDataSet1;
        private ApressFinancialDataSetTableAdapters.CustomersTableAdapter customersTableAdapter1;
        private System.Windows.Forms.TextBox CustomerIDTextBox;
        private System.Windows.Forms.TextBox CustomerNameTextBox;
        private System.Windows.Forms.Button PreviousButton;
        private System.Windows.Forms.Button NextButton;
        private ApressFinancialDataSet apressFinancialDataSet2;
        private ApressFinancialDataSet apressFinancialDataSet3;
    }
}

