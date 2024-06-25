namespace JonathanKruger_Software1
{
    partial class MainScreen
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.productDGV = new System.Windows.Forms.DataGridView();
            this.productsColProductID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productsColMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partDGV = new System.Windows.Forms.DataGridView();
            this.partsColPartID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsColInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsColPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsColMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsColMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.invMgtSysLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.partsSearchBtn = new System.Windows.Forms.Button();
            this.partsTextBox = new System.Windows.Forms.TextBox();
            this.productsTextBox = new System.Windows.Forms.TextBox();
            this.productsSearchBtn = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partsAddBtn = new System.Windows.Forms.Button();
            this.partsModifyBtn = new System.Windows.Forms.Button();
            this.partsDeleteBtn = new System.Windows.Forms.Button();
            this.productsDeleteBtn = new System.Windows.Forms.Button();
            this.productsModifyBtn = new System.Windows.Forms.Button();
            this.productsAddBtn = new System.Windows.Forms.Button();
            this.invMgtSysExitBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // productDGV
            // 
            this.productDGV.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.productDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.productDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productsColProductID,
            this.productsColName,
            this.productsColInventory,
            this.productsColPrice,
            this.productsColMin,
            this.productsColMax});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.productDGV.DefaultCellStyle = dataGridViewCellStyle2;
            this.productDGV.Location = new System.Drawing.Point(653, 148);
            this.productDGV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.productDGV.MultiSelect = false;
            this.productDGV.Name = "productDGV";
            this.productDGV.ReadOnly = true;
            this.productDGV.RowHeadersWidth = 51;
            this.productDGV.RowTemplate.Height = 24;
            this.productDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productDGV.Size = new System.Drawing.Size(600, 369);
            this.productDGV.TabIndex = 0;
            this.productDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.productBindingComplete);
            // 
            // productsColProductID
            // 
            this.productsColProductID.DataPropertyName = "ProductID";
            this.productsColProductID.HeaderText = "Product ID";
            this.productsColProductID.MinimumWidth = 6;
            this.productsColProductID.Name = "productsColProductID";
            this.productsColProductID.ReadOnly = true;
            this.productsColProductID.Width = 125;
            // 
            // productsColName
            // 
            this.productsColName.DataPropertyName = "Name";
            this.productsColName.HeaderText = "Name";
            this.productsColName.MinimumWidth = 6;
            this.productsColName.Name = "productsColName";
            this.productsColName.ReadOnly = true;
            this.productsColName.Width = 125;
            // 
            // productsColInventory
            // 
            this.productsColInventory.DataPropertyName = "InStock";
            this.productsColInventory.HeaderText = "Inventory";
            this.productsColInventory.MinimumWidth = 6;
            this.productsColInventory.Name = "productsColInventory";
            this.productsColInventory.ReadOnly = true;
            this.productsColInventory.Width = 80;
            // 
            // productsColPrice
            // 
            this.productsColPrice.DataPropertyName = "Price";
            this.productsColPrice.HeaderText = "Price";
            this.productsColPrice.MinimumWidth = 6;
            this.productsColPrice.Name = "productsColPrice";
            this.productsColPrice.ReadOnly = true;
            this.productsColPrice.Width = 80;
            // 
            // productsColMin
            // 
            this.productsColMin.DataPropertyName = "Min";
            this.productsColMin.HeaderText = "Min";
            this.productsColMin.MinimumWidth = 6;
            this.productsColMin.Name = "productsColMin";
            this.productsColMin.ReadOnly = true;
            this.productsColMin.Width = 60;
            // 
            // productsColMax
            // 
            this.productsColMax.DataPropertyName = "Max";
            this.productsColMax.HeaderText = "Max";
            this.productsColMax.MinimumWidth = 6;
            this.productsColMax.Name = "productsColMax";
            this.productsColMax.ReadOnly = true;
            this.productsColMax.Width = 60;
            // 
            // partDGV
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.partDGV.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.partDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.partsColPartID,
            this.partsColName,
            this.partsColInventory,
            this.partsColPrice,
            this.partsColMin,
            this.partsColMax});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.partDGV.DefaultCellStyle = dataGridViewCellStyle4;
            this.partDGV.Location = new System.Drawing.Point(17, 148);
            this.partDGV.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.partDGV.MultiSelect = false;
            this.partDGV.Name = "partDGV";
            this.partDGV.ReadOnly = true;
            this.partDGV.RowHeadersWidth = 51;
            this.partDGV.RowTemplate.Height = 24;
            this.partDGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partDGV.Size = new System.Drawing.Size(600, 369);
            this.partDGV.TabIndex = 1;
            this.partDGV.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.partsBindingComplete);
            // 
            // partsColPartID
            // 
            this.partsColPartID.DataPropertyName = "PartID";
            this.partsColPartID.HeaderText = "Part ID";
            this.partsColPartID.MinimumWidth = 6;
            this.partsColPartID.Name = "partsColPartID";
            this.partsColPartID.ReadOnly = true;
            this.partsColPartID.Width = 125;
            // 
            // partsColName
            // 
            this.partsColName.DataPropertyName = "Name";
            this.partsColName.HeaderText = "Name";
            this.partsColName.MinimumWidth = 6;
            this.partsColName.Name = "partsColName";
            this.partsColName.ReadOnly = true;
            this.partsColName.Width = 125;
            // 
            // partsColInventory
            // 
            this.partsColInventory.DataPropertyName = "InStock";
            this.partsColInventory.HeaderText = "Inventory";
            this.partsColInventory.MinimumWidth = 6;
            this.partsColInventory.Name = "partsColInventory";
            this.partsColInventory.ReadOnly = true;
            this.partsColInventory.Width = 80;
            // 
            // partsColPrice
            // 
            this.partsColPrice.DataPropertyName = "Price";
            this.partsColPrice.HeaderText = "Price";
            this.partsColPrice.MinimumWidth = 6;
            this.partsColPrice.Name = "partsColPrice";
            this.partsColPrice.ReadOnly = true;
            this.partsColPrice.Width = 80;
            // 
            // partsColMin
            // 
            this.partsColMin.DataPropertyName = "Min";
            this.partsColMin.HeaderText = "Min";
            this.partsColMin.MinimumWidth = 6;
            this.partsColMin.Name = "partsColMin";
            this.partsColMin.ReadOnly = true;
            this.partsColMin.Width = 60;
            // 
            // partsColMax
            // 
            this.partsColMax.DataPropertyName = "Max";
            this.partsColMax.HeaderText = "Max";
            this.partsColMax.MinimumWidth = 6;
            this.partsColMax.Name = "partsColMax";
            this.partsColMax.ReadOnly = true;
            this.partsColMax.Width = 60;
            // 
            // invMgtSysLabel
            // 
            this.invMgtSysLabel.AutoSize = true;
            this.invMgtSysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.invMgtSysLabel.Location = new System.Drawing.Point(12, 22);
            this.invMgtSysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invMgtSysLabel.Name = "invMgtSysLabel";
            this.invMgtSysLabel.Size = new System.Drawing.Size(340, 29);
            this.invMgtSysLabel.TabIndex = 2;
            this.invMgtSysLabel.Text = "Inventory Management System";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(16, 108);
            this.partsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(57, 25);
            this.partsLabel.TabIndex = 3;
            this.partsLabel.Text = "Parts";
            // 
            // partsSearchBtn
            // 
            this.partsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsSearchBtn.Location = new System.Drawing.Point(284, 98);
            this.partsSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.partsSearchBtn.Name = "partsSearchBtn";
            this.partsSearchBtn.Size = new System.Drawing.Size(100, 28);
            this.partsSearchBtn.TabIndex = 4;
            this.partsSearchBtn.Text = "Search";
            this.partsSearchBtn.UseVisualStyleBackColor = true;
            this.partsSearchBtn.Click += new System.EventHandler(this.partsSearchBtn_Click);
            // 
            // partsTextBox
            // 
            this.partsTextBox.Location = new System.Drawing.Point(392, 100);
            this.partsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.partsTextBox.Name = "partsTextBox";
            this.partsTextBox.Size = new System.Drawing.Size(179, 22);
            this.partsTextBox.TabIndex = 5;
            // 
            // productsTextBox
            // 
            this.productsTextBox.Location = new System.Drawing.Point(1034, 98);
            this.productsTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.productsTextBox.Name = "productsTextBox";
            this.productsTextBox.Size = new System.Drawing.Size(179, 22);
            this.productsTextBox.TabIndex = 7;
            // 
            // productsSearchBtn
            // 
            this.productsSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsSearchBtn.Location = new System.Drawing.Point(926, 96);
            this.productsSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productsSearchBtn.Name = "productsSearchBtn";
            this.productsSearchBtn.Size = new System.Drawing.Size(100, 28);
            this.productsSearchBtn.TabIndex = 6;
            this.productsSearchBtn.Text = "Search";
            this.productsSearchBtn.UseVisualStyleBackColor = true;
            this.productsSearchBtn.Click += new System.EventHandler(this.productsSearchBtn_Click);
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(647, 112);
            this.productsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(89, 25);
            this.productsLabel.TabIndex = 8;
            this.productsLabel.Text = "Products";
            // 
            // partsAddBtn
            // 
            this.partsAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsAddBtn.Location = new System.Drawing.Point(221, 539);
            this.partsAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.partsAddBtn.Name = "partsAddBtn";
            this.partsAddBtn.Size = new System.Drawing.Size(100, 28);
            this.partsAddBtn.TabIndex = 9;
            this.partsAddBtn.Text = "Add";
            this.partsAddBtn.UseVisualStyleBackColor = true;
            this.partsAddBtn.Click += new System.EventHandler(this.partsAddBtn_Click);
            // 
            // partsModifyBtn
            // 
            this.partsModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsModifyBtn.Location = new System.Drawing.Point(345, 539);
            this.partsModifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.partsModifyBtn.Name = "partsModifyBtn";
            this.partsModifyBtn.Size = new System.Drawing.Size(100, 28);
            this.partsModifyBtn.TabIndex = 10;
            this.partsModifyBtn.Text = "Modify";
            this.partsModifyBtn.UseVisualStyleBackColor = true;
            this.partsModifyBtn.Click += new System.EventHandler(this.partsModifyBtn_Click);
            // 
            // partsDeleteBtn
            // 
            this.partsDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsDeleteBtn.Location = new System.Drawing.Point(471, 539);
            this.partsDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.partsDeleteBtn.Name = "partsDeleteBtn";
            this.partsDeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.partsDeleteBtn.TabIndex = 11;
            this.partsDeleteBtn.Text = "Delete";
            this.partsDeleteBtn.UseVisualStyleBackColor = true;
            this.partsDeleteBtn.Click += new System.EventHandler(this.partsDeleteBtn_Click);
            // 
            // productsDeleteBtn
            // 
            this.productsDeleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsDeleteBtn.Location = new System.Drawing.Point(1113, 539);
            this.productsDeleteBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productsDeleteBtn.Name = "productsDeleteBtn";
            this.productsDeleteBtn.Size = new System.Drawing.Size(100, 28);
            this.productsDeleteBtn.TabIndex = 14;
            this.productsDeleteBtn.Text = "Delete";
            this.productsDeleteBtn.UseVisualStyleBackColor = true;
            this.productsDeleteBtn.Click += new System.EventHandler(this.productsDeleteBtn_Click);
            // 
            // productsModifyBtn
            // 
            this.productsModifyBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsModifyBtn.Location = new System.Drawing.Point(986, 539);
            this.productsModifyBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productsModifyBtn.Name = "productsModifyBtn";
            this.productsModifyBtn.Size = new System.Drawing.Size(100, 28);
            this.productsModifyBtn.TabIndex = 13;
            this.productsModifyBtn.Text = "Modify";
            this.productsModifyBtn.UseVisualStyleBackColor = true;
            this.productsModifyBtn.Click += new System.EventHandler(this.productsModifyBtn_Click);
            // 
            // productsAddBtn
            // 
            this.productsAddBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsAddBtn.Location = new System.Drawing.Point(862, 539);
            this.productsAddBtn.Margin = new System.Windows.Forms.Padding(4);
            this.productsAddBtn.Name = "productsAddBtn";
            this.productsAddBtn.Size = new System.Drawing.Size(100, 28);
            this.productsAddBtn.TabIndex = 12;
            this.productsAddBtn.Text = "Add";
            this.productsAddBtn.UseVisualStyleBackColor = true;
            this.productsAddBtn.Click += new System.EventHandler(this.productsAddBtn_Click);
            // 
            // invMgtSysExitBtn
            // 
            this.invMgtSysExitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invMgtSysExitBtn.Location = new System.Drawing.Point(1113, 588);
            this.invMgtSysExitBtn.Margin = new System.Windows.Forms.Padding(4);
            this.invMgtSysExitBtn.Name = "invMgtSysExitBtn";
            this.invMgtSysExitBtn.Size = new System.Drawing.Size(100, 28);
            this.invMgtSysExitBtn.TabIndex = 15;
            this.invMgtSysExitBtn.Text = "Exit";
            this.invMgtSysExitBtn.UseVisualStyleBackColor = true;
            this.invMgtSysExitBtn.Click += new System.EventHandler(this.invMgtSysExitBtn_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 631);
            this.Controls.Add(this.invMgtSysExitBtn);
            this.Controls.Add(this.productsDeleteBtn);
            this.Controls.Add(this.productsModifyBtn);
            this.Controls.Add(this.productsAddBtn);
            this.Controls.Add(this.partsDeleteBtn);
            this.Controls.Add(this.partsModifyBtn);
            this.Controls.Add(this.partsAddBtn);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.productsTextBox);
            this.Controls.Add(this.productsSearchBtn);
            this.Controls.Add(this.partsTextBox);
            this.Controls.Add(this.partsSearchBtn);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.invMgtSysLabel);
            this.Controls.Add(this.partDGV);
            this.Controls.Add(this.productDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 2, 5, 2);
            this.Name = "MainScreen";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.productDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView productDGV;
        private System.Windows.Forms.DataGridView partDGV;
        private System.Windows.Forms.Label invMgtSysLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button partsSearchBtn;
        private System.Windows.Forms.TextBox partsTextBox;
        private System.Windows.Forms.TextBox productsTextBox;
        private System.Windows.Forms.Button productsSearchBtn;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Button partsAddBtn;
        private System.Windows.Forms.Button partsModifyBtn;
        private System.Windows.Forms.Button partsDeleteBtn;
        private System.Windows.Forms.Button productsDeleteBtn;
        private System.Windows.Forms.Button productsModifyBtn;
        private System.Windows.Forms.Button productsAddBtn;
        private System.Windows.Forms.Button invMgtSysExitBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColPartID;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn partsColMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColProductID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productsColMax;
    }
}

