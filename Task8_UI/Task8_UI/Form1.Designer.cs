namespace Task8_UI
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewCustomerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addNewShipmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSelect = new System.Windows.Forms.ComboBox();
            this.Shipment_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Shipment_ID,
            this.Address,
            this.Order_ID,
            this.Status});
            this.dataGridView1.Location = new System.Drawing.Point(12, 34);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(515, 212);
            this.dataGridView1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addingToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(540, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addingToolStripMenuItem
            // 
            this.addingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewCustomerToolStripMenuItem,
            this.addNewOrderToolStripMenuItem,
            this.addNewShipmentToolStripMenuItem});
            this.addingToolStripMenuItem.Name = "addingToolStripMenuItem";
            this.addingToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.addingToolStripMenuItem.Text = "Adding";
            // 
            // addNewCustomerToolStripMenuItem
            // 
            this.addNewCustomerToolStripMenuItem.Name = "addNewCustomerToolStripMenuItem";
            this.addNewCustomerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewCustomerToolStripMenuItem.Text = "Add new Customer";
            // 
            // addNewOrderToolStripMenuItem
            // 
            this.addNewOrderToolStripMenuItem.Name = "addNewOrderToolStripMenuItem";
            this.addNewOrderToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewOrderToolStripMenuItem.Text = "Add new Order";
            // 
            // addNewShipmentToolStripMenuItem
            // 
            this.addNewShipmentToolStripMenuItem.Name = "addNewShipmentToolStripMenuItem";
            this.addNewShipmentToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.addNewShipmentToolStripMenuItem.Text = "Add new Shipment";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Shipments";
            // 
            // cmbSelect
            // 
            this.cmbSelect.FormattingEnabled = true;
            this.cmbSelect.Location = new System.Drawing.Point(96, 258);
            this.cmbSelect.Name = "cmbSelect";
            this.cmbSelect.Size = new System.Drawing.Size(121, 21);
            this.cmbSelect.TabIndex = 6;
            // 
            // Shipment_ID
            // 
            this.Shipment_ID.HeaderText = "Shipment ID";
            this.Shipment_ID.Name = "Shipment_ID";
            // 
            // Address
            // 
            this.Address.HeaderText = "Address";
            this.Address.Name = "Address";
            // 
            // Order_ID
            // 
            this.Order_ID.HeaderText = "Order ID";
            this.Order_ID.Name = "Order_ID";
            // 
            // Status
            // 
            this.Status.HeaderText = "Shipment Status";
            this.Status.Name = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 294);
            this.Controls.Add(this.cmbSelect);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewCustomerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addNewShipmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSelect;
        private System.Windows.Forms.DataGridViewTextBoxColumn Shipment_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}

