namespace JonathanKruger_Software1
{
    partial class AddProduct
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
            this.addProductAllPartsDGV = new System.Windows.Forms.DataGridView();
            this.addProductAssPartsDGV = new System.Windows.Forms.DataGridView();
            this.addProductCostTB = new System.Windows.Forms.TextBox();
            this.addProductCostLabel = new System.Windows.Forms.Label();
            this.addProductMinTB = new System.Windows.Forms.TextBox();
            this.addProductMinLabel = new System.Windows.Forms.Label();
            this.addProductMaxTB = new System.Windows.Forms.TextBox();
            this.addProductMaxlabel = new System.Windows.Forms.Label();
            this.addProductInvTB = new System.Windows.Forms.TextBox();
            this.addProductInventoryLabel = new System.Windows.Forms.Label();
            this.addProductNameTB = new System.Windows.Forms.TextBox();
            this.addProductNameLabel = new System.Windows.Forms.Label();
            this.addProductIDTB = new System.Windows.Forms.TextBox();
            this.addProductIDLabel = new System.Windows.Forms.Label();
            this.addProductSearchTextBox = new System.Windows.Forms.TextBox();
            this.addProductSearchBtn = new System.Windows.Forms.Button();
            this.addProductAllPartsLabel = new System.Windows.Forms.Label();
            this.invMgtSysLabel = new System.Windows.Forms.Label();
            this.addProductAssPartsLabel = new System.Windows.Forms.Label();
            this.addProductDeleteBtn = new System.Windows.Forms.Button();
            this.addProductAddBtn = new System.Windows.Forms.Button();
            this.addProductCancelBtn = new System.Windows.Forms.Button();
            this.addProductSaveBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAllPartsDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssPartsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductAllPartsDGV
            // 
            this.addProductAllPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductAllPartsDGV.Location = new System.Drawing.Point(617, 77);
            this.addProductAllPartsDGV.Name = "addProductAllPartsDGV";
            this.addProductAllPartsDGV.RowHeadersWidth = 51;
            this.addProductAllPartsDGV.RowTemplate.Height = 24;
            this.addProductAllPartsDGV.Size = new System.Drawing.Size(600, 205);
            this.addProductAllPartsDGV.TabIndex = 0;
            // 
            // addProductAssPartsDGV
            // 
            this.addProductAssPartsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addProductAssPartsDGV.Location = new System.Drawing.Point(618, 373);
            this.addProductAssPartsDGV.Name = "addProductAssPartsDGV";
            this.addProductAssPartsDGV.RowHeadersWidth = 51;
            this.addProductAssPartsDGV.RowTemplate.Height = 24;
            this.addProductAssPartsDGV.Size = new System.Drawing.Size(600, 205);
            this.addProductAssPartsDGV.TabIndex = 1;
            // 
            // addProductCostTB
            // 
            this.addProductCostTB.Location = new System.Drawing.Point(173, 347);
            this.addProductCostTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductCostTB.Name = "addProductCostTB";
            this.addProductCostTB.Size = new System.Drawing.Size(168, 26);
            this.addProductCostTB.TabIndex = 5;
            this.addProductCostTB.TextChanged += new System.EventHandler(this.addProductCostTB_TextChanged);
            // 
            // addProductCostLabel
            // 
            this.addProductCostLabel.AutoSize = true;
            this.addProductCostLabel.Location = new System.Drawing.Point(49, 350);
            this.addProductCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductCostLabel.Name = "addProductCostLabel";
            this.addProductCostLabel.Size = new System.Drawing.Size(104, 20);
            this.addProductCostLabel.TabIndex = 48;
            this.addProductCostLabel.Text = "Price / Cost*";
            // 
            // addProductMinTB
            // 
            this.addProductMinTB.Location = new System.Drawing.Point(371, 398);
            this.addProductMinTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductMinTB.Name = "addProductMinTB";
            this.addProductMinTB.Size = new System.Drawing.Size(84, 26);
            this.addProductMinTB.TabIndex = 7;
            this.addProductMinTB.TextChanged += new System.EventHandler(this.addProductMinTB_TextChanged);
            // 
            // addProductMinLabel
            // 
            this.addProductMinLabel.AutoSize = true;
            this.addProductMinLabel.Location = new System.Drawing.Point(307, 401);
            this.addProductMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductMinLabel.Name = "addProductMinLabel";
            this.addProductMinLabel.Size = new System.Drawing.Size(42, 20);
            this.addProductMinLabel.TabIndex = 46;
            this.addProductMinLabel.Text = "Min*";
            // 
            // addProductMaxTB
            // 
            this.addProductMaxTB.Location = new System.Drawing.Point(173, 398);
            this.addProductMaxTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductMaxTB.Name = "addProductMaxTB";
            this.addProductMaxTB.Size = new System.Drawing.Size(85, 26);
            this.addProductMaxTB.TabIndex = 6;
            this.addProductMaxTB.TextChanged += new System.EventHandler(this.addProductMaxTB_TextChanged);
            // 
            // addProductMaxlabel
            // 
            this.addProductMaxlabel.AutoSize = true;
            this.addProductMaxlabel.Location = new System.Drawing.Point(107, 398);
            this.addProductMaxlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductMaxlabel.Name = "addProductMaxlabel";
            this.addProductMaxlabel.Size = new System.Drawing.Size(46, 20);
            this.addProductMaxlabel.TabIndex = 44;
            this.addProductMaxlabel.Text = "Max*";
            // 
            // addProductInvTB
            // 
            this.addProductInvTB.Location = new System.Drawing.Point(173, 295);
            this.addProductInvTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductInvTB.Name = "addProductInvTB";
            this.addProductInvTB.Size = new System.Drawing.Size(168, 26);
            this.addProductInvTB.TabIndex = 4;
            this.addProductInvTB.TextChanged += new System.EventHandler(this.addProductInvTB_TextChanged);
            // 
            // addProductInventoryLabel
            // 
            this.addProductInventoryLabel.AutoSize = true;
            this.addProductInventoryLabel.Location = new System.Drawing.Point(71, 298);
            this.addProductInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductInventoryLabel.Name = "addProductInventoryLabel";
            this.addProductInventoryLabel.Size = new System.Drawing.Size(82, 20);
            this.addProductInventoryLabel.TabIndex = 42;
            this.addProductInventoryLabel.Text = "Inventory*";
            // 
            // addProductNameTB
            // 
            this.addProductNameTB.Location = new System.Drawing.Point(173, 247);
            this.addProductNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductNameTB.Name = "addProductNameTB";
            this.addProductNameTB.Size = new System.Drawing.Size(168, 26);
            this.addProductNameTB.TabIndex = 3;
            // 
            // addProductNameLabel
            // 
            this.addProductNameLabel.AutoSize = true;
            this.addProductNameLabel.Location = new System.Drawing.Point(94, 250);
            this.addProductNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductNameLabel.Name = "addProductNameLabel";
            this.addProductNameLabel.Size = new System.Drawing.Size(59, 20);
            this.addProductNameLabel.TabIndex = 40;
            this.addProductNameLabel.Text = "Name*";
            // 
            // addProductIDTB
            // 
            this.addProductIDTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addProductIDTB.Location = new System.Drawing.Point(173, 197);
            this.addProductIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.addProductIDTB.Name = "addProductIDTB";
            this.addProductIDTB.ReadOnly = true;
            this.addProductIDTB.Size = new System.Drawing.Size(168, 26);
            this.addProductIDTB.TabIndex = 2;
            this.addProductIDTB.TextChanged += new System.EventHandler(this.addProductIDTB_TextChanged);
            // 
            // addProductIDLabel
            // 
            this.addProductIDLabel.AutoSize = true;
            this.addProductIDLabel.Location = new System.Drawing.Point(121, 200);
            this.addProductIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductIDLabel.Name = "addProductIDLabel";
            this.addProductIDLabel.Size = new System.Drawing.Size(26, 20);
            this.addProductIDLabel.TabIndex = 38;
            this.addProductIDLabel.Text = "ID";
            // 
            // addProductSearchTextBox
            // 
            this.addProductSearchTextBox.Location = new System.Drawing.Point(998, 26);
            this.addProductSearchTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.addProductSearchTextBox.Name = "addProductSearchTextBox";
            this.addProductSearchTextBox.Size = new System.Drawing.Size(179, 26);
            this.addProductSearchTextBox.TabIndex = 1;
            // 
            // addProductSearchBtn
            // 
            this.addProductSearchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductSearchBtn.Location = new System.Drawing.Point(890, 24);
            this.addProductSearchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.addProductSearchBtn.Name = "addProductSearchBtn";
            this.addProductSearchBtn.Size = new System.Drawing.Size(100, 28);
            this.addProductSearchBtn.TabIndex = 52;
            this.addProductSearchBtn.Text = "Search";
            this.addProductSearchBtn.UseVisualStyleBackColor = true;
            this.addProductSearchBtn.Click += new System.EventHandler(this.addProductSearchBtn_Click);
            // 
            // addProductAllPartsLabel
            // 
            this.addProductAllPartsLabel.AutoSize = true;
            this.addProductAllPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductAllPartsLabel.Location = new System.Drawing.Point(612, 21);
            this.addProductAllPartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductAllPartsLabel.Name = "addProductAllPartsLabel";
            this.addProductAllPartsLabel.Size = new System.Drawing.Size(179, 25);
            this.addProductAllPartsLabel.TabIndex = 51;
            this.addProductAllPartsLabel.Text = "All Candidate Parts";
            // 
            // invMgtSysLabel
            // 
            this.invMgtSysLabel.AutoSize = true;
            this.invMgtSysLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)), true);
            this.invMgtSysLabel.Location = new System.Drawing.Point(13, 21);
            this.invMgtSysLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.invMgtSysLabel.Name = "invMgtSysLabel";
            this.invMgtSysLabel.Size = new System.Drawing.Size(145, 29);
            this.invMgtSysLabel.TabIndex = 50;
            this.invMgtSysLabel.Text = "Add Product";
            // 
            // addProductAssPartsLabel
            // 
            this.addProductAssPartsLabel.AutoSize = true;
            this.addProductAssPartsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addProductAssPartsLabel.Location = new System.Drawing.Point(619, 329);
            this.addProductAssPartsLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.addProductAssPartsLabel.Name = "addProductAssPartsLabel";
            this.addProductAssPartsLabel.Size = new System.Drawing.Size(319, 25);
            this.addProductAssPartsLabel.TabIndex = 54;
            this.addProductAssPartsLabel.Text = "Parts Associated With This Product";
            // 
            // addProductDeleteBtn
            // 
            this.addProductDeleteBtn.Location = new System.Drawing.Point(1092, 599);
            this.addProductDeleteBtn.Name = "addProductDeleteBtn";
            this.addProductDeleteBtn.Size = new System.Drawing.Size(85, 26);
            this.addProductDeleteBtn.TabIndex = 56;
            this.addProductDeleteBtn.Text = "Delete";
            this.addProductDeleteBtn.UseVisualStyleBackColor = true;
            this.addProductDeleteBtn.Click += new System.EventHandler(this.addProductDeleteBtn_Click);
            // 
            // addProductAddBtn
            // 
            this.addProductAddBtn.Location = new System.Drawing.Point(1088, 298);
            this.addProductAddBtn.Name = "addProductAddBtn";
            this.addProductAddBtn.Size = new System.Drawing.Size(89, 26);
            this.addProductAddBtn.TabIndex = 55;
            this.addProductAddBtn.Text = "Add";
            this.addProductAddBtn.UseVisualStyleBackColor = true;
            this.addProductAddBtn.Click += new System.EventHandler(this.addProductAddBtn_Click);
            // 
            // addProductCancelBtn
            // 
            this.addProductCancelBtn.Location = new System.Drawing.Point(1093, 642);
            this.addProductCancelBtn.Name = "addProductCancelBtn";
            this.addProductCancelBtn.Size = new System.Drawing.Size(85, 26);
            this.addProductCancelBtn.TabIndex = 58;
            this.addProductCancelBtn.Text = "Cancel";
            this.addProductCancelBtn.UseVisualStyleBackColor = true;
            this.addProductCancelBtn.Click += new System.EventHandler(this.addProductCancelBtn_Click);
            // 
            // addProductSaveBtn
            // 
            this.addProductSaveBtn.Location = new System.Drawing.Point(966, 642);
            this.addProductSaveBtn.Name = "addProductSaveBtn";
            this.addProductSaveBtn.Size = new System.Drawing.Size(89, 26);
            this.addProductSaveBtn.TabIndex = 57;
            this.addProductSaveBtn.Text = "Save";
            this.addProductSaveBtn.UseVisualStyleBackColor = true;
            this.addProductSaveBtn.Click += new System.EventHandler(this.addProductSaveBtn_Click);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 698);
            this.Controls.Add(this.addProductCancelBtn);
            this.Controls.Add(this.addProductSaveBtn);
            this.Controls.Add(this.addProductDeleteBtn);
            this.Controls.Add(this.addProductAddBtn);
            this.Controls.Add(this.addProductAssPartsLabel);
            this.Controls.Add(this.addProductSearchTextBox);
            this.Controls.Add(this.addProductSearchBtn);
            this.Controls.Add(this.addProductAllPartsLabel);
            this.Controls.Add(this.invMgtSysLabel);
            this.Controls.Add(this.addProductCostTB);
            this.Controls.Add(this.addProductCostLabel);
            this.Controls.Add(this.addProductMinTB);
            this.Controls.Add(this.addProductMinLabel);
            this.Controls.Add(this.addProductMaxTB);
            this.Controls.Add(this.addProductMaxlabel);
            this.Controls.Add(this.addProductInvTB);
            this.Controls.Add(this.addProductInventoryLabel);
            this.Controls.Add(this.addProductNameTB);
            this.Controls.Add(this.addProductNameLabel);
            this.Controls.Add(this.addProductIDTB);
            this.Controls.Add(this.addProductIDLabel);
            this.Controls.Add(this.addProductAssPartsDGV);
            this.Controls.Add(this.addProductAllPartsDGV);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddProduct";
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.addProductAllPartsDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addProductAssPartsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView addProductAllPartsDGV;
        private System.Windows.Forms.DataGridView addProductAssPartsDGV;
        private System.Windows.Forms.TextBox addProductCostTB;
        private System.Windows.Forms.Label addProductCostLabel;
        private System.Windows.Forms.TextBox addProductMinTB;
        private System.Windows.Forms.Label addProductMinLabel;
        private System.Windows.Forms.TextBox addProductMaxTB;
        private System.Windows.Forms.Label addProductMaxlabel;
        private System.Windows.Forms.TextBox addProductInvTB;
        private System.Windows.Forms.Label addProductInventoryLabel;
        private System.Windows.Forms.TextBox addProductNameTB;
        private System.Windows.Forms.Label addProductNameLabel;
        private System.Windows.Forms.TextBox addProductIDTB;
        private System.Windows.Forms.Label addProductIDLabel;
        private System.Windows.Forms.TextBox addProductSearchTextBox;
        private System.Windows.Forms.Button addProductSearchBtn;
        private System.Windows.Forms.Label addProductAllPartsLabel;
        private System.Windows.Forms.Label invMgtSysLabel;
        private System.Windows.Forms.Label addProductAssPartsLabel;
        private System.Windows.Forms.Button addProductDeleteBtn;
        private System.Windows.Forms.Button addProductAddBtn;
        private System.Windows.Forms.Button addProductCancelBtn;
        private System.Windows.Forms.Button addProductSaveBtn;
    }
}