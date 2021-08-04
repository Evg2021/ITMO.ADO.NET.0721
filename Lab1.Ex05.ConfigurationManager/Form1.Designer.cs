
namespace Lab1.Ex05.ConfigurationManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemDB = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDBConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDBDisconnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnectionsList = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonQty = new System.Windows.Forms.Button();
            this.labelQty = new System.Windows.Forms.Label();
            this.buttonList = new System.Windows.Forms.Button();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.columnProdName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonTran = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDB});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 40);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuItemDB
            // 
            this.MenuItemDB.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemDBConnect,
            this.MenuItemDBDisconnect,
            this.MenuItemConnectionsList});
            this.MenuItemDB.Name = "MenuItemDB";
            this.MenuItemDB.Size = new System.Drawing.Size(192, 36);
            this.MenuItemDB.Text = "DB connection";
            // 
            // MenuItemDBConnect
            // 
            this.MenuItemDBConnect.Name = "MenuItemDBConnect";
            this.MenuItemDBConnect.Size = new System.Drawing.Size(359, 44);
            this.MenuItemDBConnect.Text = "Connect";
            this.MenuItemDBConnect.Click += new System.EventHandler(this.MenuItemDBConnect_Click);
            // 
            // MenuItemDBDisconnect
            // 
            this.MenuItemDBDisconnect.Name = "MenuItemDBDisconnect";
            this.MenuItemDBDisconnect.Size = new System.Drawing.Size(359, 44);
            this.MenuItemDBDisconnect.Text = "Disconnect";
            this.MenuItemDBDisconnect.Click += new System.EventHandler(this.MenuItemDBDisconnect_Click);
            // 
            // MenuItemConnectionsList
            // 
            this.MenuItemConnectionsList.Name = "MenuItemConnectionsList";
            this.MenuItemConnectionsList.Size = new System.Drawing.Size(359, 44);
            this.MenuItemConnectionsList.Text = "List of connections";
            this.MenuItemConnectionsList.Click += new System.EventHandler(this.MenuItemConnectionsList_Click);
            // 
            // buttonQty
            // 
            this.buttonQty.Location = new System.Drawing.Point(37, 74);
            this.buttonQty.Name = "buttonQty";
            this.buttonQty.Size = new System.Drawing.Size(156, 61);
            this.buttonQty.TabIndex = 1;
            this.buttonQty.Text = "Prouct Qty";
            this.buttonQty.UseVisualStyleBackColor = true;
            this.buttonQty.Click += new System.EventHandler(this.buttonQty_Click);
            // 
            // labelQty
            // 
            this.labelQty.AutoSize = true;
            this.labelQty.Location = new System.Drawing.Point(237, 78);
            this.labelQty.Name = "labelQty";
            this.labelQty.Size = new System.Drawing.Size(72, 40);
            this.labelQty.TabIndex = 2;
            this.labelQty.Text = "Qty";
            // 
            // buttonList
            // 
            this.buttonList.Location = new System.Drawing.Point(37, 166);
            this.buttonList.Name = "buttonList";
            this.buttonList.Size = new System.Drawing.Size(156, 58);
            this.buttonList.TabIndex = 3;
            this.buttonList.Text = "Product List";
            this.buttonList.UseVisualStyleBackColor = true;
            this.buttonList.Click += new System.EventHandler(this.buttonList_Click);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnProdName});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(242, 166);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(307, 244);
            this.listViewProducts.TabIndex = 4;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // columnProdName
            // 
            this.columnProdName.Text = "Product name";
            this.columnProdName.Width = 147;
            // 
            // buttonTran
            // 
            this.buttonTran.Location = new System.Drawing.Point(602, 73);
            this.buttonTran.Name = "buttonTran";
            this.buttonTran.Size = new System.Drawing.Size(155, 62);
            this.buttonTran.TabIndex = 5;
            this.buttonTran.Text = "Transaction";
            this.buttonTran.UseVisualStyleBackColor = true;
            this.buttonTran.Click += new System.EventHandler(this.buttonTran_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(37, 277);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(155, 65);
            this.buttonClear.TabIndex = 6;
            this.buttonClear.Text = "Clear List";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonTran);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.buttonList);
            this.Controls.Add(this.labelQty);
            this.Controls.Add(this.buttonQty);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDB;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDBDisconnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDBConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnectionsList;
        private System.Windows.Forms.Button buttonQty;
        private System.Windows.Forms.Label labelQty;
        private System.Windows.Forms.Button buttonList;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader columnProdName;
        private System.Windows.Forms.Button buttonTran;
        private System.Windows.Forms.Button buttonClear;
    }
}

