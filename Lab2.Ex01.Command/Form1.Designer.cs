
namespace Lab02.Ex01.Command
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.соединениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemDisConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemListConnect = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.соединениеToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // соединениеToolStripMenuItem
            // 
            this.соединениеToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemConnect,
            this.MenuItemDisConnect,
            this.MenuItemListConnect});
            this.соединениеToolStripMenuItem.Name = "соединениеToolStripMenuItem";
            this.соединениеToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.соединениеToolStripMenuItem.Text = "Соединение";
            // 
            // MenuItemConnect
            // 
            this.MenuItemConnect.Name = "MenuItemConnect";
            this.MenuItemConnect.Size = new System.Drawing.Size(184, 22);
            this.MenuItemConnect.Text = "Подключить";
            this.MenuItemConnect.Click += new System.EventHandler(this.MenuItemConnect_Click);
            // 
            // MenuItemDisConnect
            // 
            this.MenuItemDisConnect.Name = "MenuItemDisConnect";
            this.MenuItemDisConnect.Size = new System.Drawing.Size(184, 22);
            this.MenuItemDisConnect.Text = "Отключить";
            this.MenuItemDisConnect.Click += new System.EventHandler(this.MenuItemDisConnect_Click);
            // 
            // MenuItemListConnect
            // 
            this.MenuItemListConnect.Name = "MenuItemListConnect";
            this.MenuItemListConnect.Size = new System.Drawing.Size(184, 22);
            this.MenuItemListConnect.Text = "Список соединений";
            this.MenuItemListConnect.Click += new System.EventHandler(this.MenuItemListConnect_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 50);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Список продуктов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Список продуктов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ToolStripMenuItem соединениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuItemConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemDisConnect;
        private System.Windows.Forms.ToolStripMenuItem MenuItemListConnect;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

