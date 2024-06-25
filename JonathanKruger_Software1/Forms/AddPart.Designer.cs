namespace JonathanKruger_Software1
{
    partial class AddPart
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
            this.addPartInhouseLabel = new System.Windows.Forms.Label();
            this.addPartInhouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.addPartOutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.addPartIDLabel = new System.Windows.Forms.Label();
            this.addPartIDTB = new System.Windows.Forms.TextBox();
            this.addPartNameTB = new System.Windows.Forms.TextBox();
            this.addpartNameLabel = new System.Windows.Forms.Label();
            this.addPartInvTB = new System.Windows.Forms.TextBox();
            this.addPartInventoryLabel = new System.Windows.Forms.Label();
            this.addPartMaxTB = new System.Windows.Forms.TextBox();
            this.addPartMaxlabel = new System.Windows.Forms.Label();
            this.addPartMinTB = new System.Windows.Forms.TextBox();
            this.addPartMinLabel = new System.Windows.Forms.Label();
            this.addPartTypeIDTB = new System.Windows.Forms.TextBox();
            this.addPartTypeIDLabel = new System.Windows.Forms.Label();
            this.addPartSaveBtn = new System.Windows.Forms.Button();
            this.addPartCancelBtn = new System.Windows.Forms.Button();
            this.addPartCostTB = new System.Windows.Forms.TextBox();
            this.addPartCostLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addPartInhouseLabel
            // 
            this.addPartInhouseLabel.AutoSize = true;
            this.addPartInhouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartInhouseLabel.Location = new System.Drawing.Point(12, 9);
            this.addPartInhouseLabel.Name = "addPartInhouseLabel";
            this.addPartInhouseLabel.Size = new System.Drawing.Size(105, 29);
            this.addPartInhouseLabel.TabIndex = 0;
            this.addPartInhouseLabel.Text = "Add Part";
            // 
            // addPartInhouseRadioBtn
            // 
            this.addPartInhouseRadioBtn.AutoSize = true;
            this.addPartInhouseRadioBtn.Location = new System.Drawing.Point(172, 14);
            this.addPartInhouseRadioBtn.Name = "addPartInhouseRadioBtn";
            this.addPartInhouseRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.addPartInhouseRadioBtn.TabIndex = 1;
            this.addPartInhouseRadioBtn.TabStop = true;
            this.addPartInhouseRadioBtn.Text = "In-House";
            this.addPartInhouseRadioBtn.UseVisualStyleBackColor = true;
            this.addPartInhouseRadioBtn.CheckedChanged += new System.EventHandler(this.addPartInhouseRadioBtn_CheckedChanged);
            // 
            // addPartOutsourcedRadioBtn
            // 
            this.addPartOutsourcedRadioBtn.AutoSize = true;
            this.addPartOutsourcedRadioBtn.Location = new System.Drawing.Point(318, 13);
            this.addPartOutsourcedRadioBtn.Name = "addPartOutsourcedRadioBtn";
            this.addPartOutsourcedRadioBtn.Size = new System.Drawing.Size(117, 24);
            this.addPartOutsourcedRadioBtn.TabIndex = 2;
            this.addPartOutsourcedRadioBtn.TabStop = true;
            this.addPartOutsourcedRadioBtn.Text = "Outsourced";
            this.addPartOutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.addPartOutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.addPartOutsourcedRadioBtn_CheckedChanged);
            // 
            // addPartIDLabel
            // 
            this.addPartIDLabel.AutoSize = true;
            this.addPartIDLabel.Location = new System.Drawing.Point(131, 81);
            this.addPartIDLabel.Name = "addPartIDLabel";
            this.addPartIDLabel.Size = new System.Drawing.Size(26, 20);
            this.addPartIDLabel.TabIndex = 3;
            this.addPartIDLabel.Text = "ID";
            // 
            // addPartIDTB
            // 
            this.addPartIDTB.BackColor = System.Drawing.SystemColors.ControlLight;
            this.addPartIDTB.Location = new System.Drawing.Point(191, 78);
            this.addPartIDTB.Name = "addPartIDTB";
            this.addPartIDTB.ReadOnly = true;
            this.addPartIDTB.Size = new System.Drawing.Size(160, 26);
            this.addPartIDTB.TabIndex = 3;
            this.addPartIDTB.TextChanged += new System.EventHandler(this.addPartIDTB_TextChanged);
            // 
            // addPartNameTB
            // 
            this.addPartNameTB.Location = new System.Drawing.Point(191, 134);
            this.addPartNameTB.Name = "addPartNameTB";
            this.addPartNameTB.Size = new System.Drawing.Size(160, 26);
            this.addPartNameTB.TabIndex = 4;
            // 
            // addpartNameLabel
            // 
            this.addpartNameLabel.AutoSize = true;
            this.addpartNameLabel.Location = new System.Drawing.Point(104, 137);
            this.addpartNameLabel.Name = "addpartNameLabel";
            this.addpartNameLabel.Size = new System.Drawing.Size(59, 20);
            this.addpartNameLabel.TabIndex = 5;
            this.addpartNameLabel.Text = "Name*";
            // 
            // addPartInvTB
            // 
            this.addPartInvTB.Location = new System.Drawing.Point(191, 187);
            this.addPartInvTB.Name = "addPartInvTB";
            this.addPartInvTB.Size = new System.Drawing.Size(160, 26);
            this.addPartInvTB.TabIndex = 5;
            this.addPartInvTB.TextChanged += new System.EventHandler(this.addPartInvTB_TextChanged);
            // 
            // addPartInventoryLabel
            // 
            this.addPartInventoryLabel.AutoSize = true;
            this.addPartInventoryLabel.Location = new System.Drawing.Point(81, 190);
            this.addPartInventoryLabel.Name = "addPartInventoryLabel";
            this.addPartInventoryLabel.Size = new System.Drawing.Size(82, 20);
            this.addPartInventoryLabel.TabIndex = 7;
            this.addPartInventoryLabel.Text = "Inventory*";
            // 
            // addPartMaxTB
            // 
            this.addPartMaxTB.Location = new System.Drawing.Point(191, 291);
            this.addPartMaxTB.Name = "addPartMaxTB";
            this.addPartMaxTB.Size = new System.Drawing.Size(79, 26);
            this.addPartMaxTB.TabIndex = 7;
            this.addPartMaxTB.TextChanged += new System.EventHandler(this.addPartMaxTB_TextChanged);
            // 
            // addPartMaxlabel
            // 
            this.addPartMaxlabel.AutoSize = true;
            this.addPartMaxlabel.Location = new System.Drawing.Point(117, 291);
            this.addPartMaxlabel.Name = "addPartMaxlabel";
            this.addPartMaxlabel.Size = new System.Drawing.Size(46, 20);
            this.addPartMaxlabel.TabIndex = 9;
            this.addPartMaxlabel.Text = "Max*";
            // 
            // addPartMinTB
            // 
            this.addPartMinTB.Location = new System.Drawing.Point(399, 291);
            this.addPartMinTB.Name = "addPartMinTB";
            this.addPartMinTB.Size = new System.Drawing.Size(80, 26);
            this.addPartMinTB.TabIndex = 8;
            this.addPartMinTB.TextChanged += new System.EventHandler(this.addPartMinTB_TextChanged);
            // 
            // addPartMinLabel
            // 
            this.addPartMinLabel.AutoSize = true;
            this.addPartMinLabel.Location = new System.Drawing.Point(335, 294);
            this.addPartMinLabel.Name = "addPartMinLabel";
            this.addPartMinLabel.Size = new System.Drawing.Size(42, 20);
            this.addPartMinLabel.TabIndex = 11;
            this.addPartMinLabel.Text = "Min*";
            // 
            // addPartTypeIDTB
            // 
            this.addPartTypeIDTB.Location = new System.Drawing.Point(191, 341);
            this.addPartTypeIDTB.Name = "addPartTypeIDTB";
            this.addPartTypeIDTB.Size = new System.Drawing.Size(160, 26);
            this.addPartTypeIDTB.TabIndex = 9;
            this.addPartTypeIDTB.TextChanged += new System.EventHandler(this.addPartTypeIDTB_TextChanged);
            // 
            // addPartTypeIDLabel
            // 
            this.addPartTypeIDLabel.AutoSize = true;
            this.addPartTypeIDLabel.Location = new System.Drawing.Point(63, 344);
            this.addPartTypeIDLabel.Name = "addPartTypeIDLabel";
            this.addPartTypeIDLabel.Size = new System.Drawing.Size(100, 20);
            this.addPartTypeIDLabel.TabIndex = 13;
            this.addPartTypeIDLabel.Text = "Machine ID*";
            // 
            // addPartSaveBtn
            // 
            this.addPartSaveBtn.Location = new System.Drawing.Point(285, 390);
            this.addPartSaveBtn.Name = "addPartSaveBtn";
            this.addPartSaveBtn.Size = new System.Drawing.Size(89, 26);
            this.addPartSaveBtn.TabIndex = 10;
            this.addPartSaveBtn.Text = "Save";
            this.addPartSaveBtn.UseVisualStyleBackColor = true;
            this.addPartSaveBtn.Click += new System.EventHandler(this.addPartSaveBtn_Click);
            // 
            // addPartCancelBtn
            // 
            this.addPartCancelBtn.Location = new System.Drawing.Point(412, 390);
            this.addPartCancelBtn.Name = "addPartCancelBtn";
            this.addPartCancelBtn.Size = new System.Drawing.Size(85, 26);
            this.addPartCancelBtn.TabIndex = 11;
            this.addPartCancelBtn.Text = "Cancel";
            this.addPartCancelBtn.UseVisualStyleBackColor = true;
            this.addPartCancelBtn.Click += new System.EventHandler(this.addPartCancelBtn_Click);
            // 
            // addPartCostTB
            // 
            this.addPartCostTB.Location = new System.Drawing.Point(191, 238);
            this.addPartCostTB.Name = "addPartCostTB";
            this.addPartCostTB.Size = new System.Drawing.Size(160, 26);
            this.addPartCostTB.TabIndex = 6;
            this.addPartCostTB.TextChanged += new System.EventHandler(this.addPartCostTB_TextChanged);
            // 
            // addPartCostLabel
            // 
            this.addPartCostLabel.AutoSize = true;
            this.addPartCostLabel.Location = new System.Drawing.Point(59, 241);
            this.addPartCostLabel.Name = "addPartCostLabel";
            this.addPartCostLabel.Size = new System.Drawing.Size(104, 20);
            this.addPartCostLabel.TabIndex = 17;
            this.addPartCostLabel.Text = "Price / Cost*";
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 437);
            this.Controls.Add(this.addPartCostTB);
            this.Controls.Add(this.addPartCostLabel);
            this.Controls.Add(this.addPartCancelBtn);
            this.Controls.Add(this.addPartSaveBtn);
            this.Controls.Add(this.addPartTypeIDTB);
            this.Controls.Add(this.addPartTypeIDLabel);
            this.Controls.Add(this.addPartMinTB);
            this.Controls.Add(this.addPartMinLabel);
            this.Controls.Add(this.addPartMaxTB);
            this.Controls.Add(this.addPartMaxlabel);
            this.Controls.Add(this.addPartInvTB);
            this.Controls.Add(this.addPartInventoryLabel);
            this.Controls.Add(this.addPartNameTB);
            this.Controls.Add(this.addpartNameLabel);
            this.Controls.Add(this.addPartIDTB);
            this.Controls.Add(this.addPartIDLabel);
            this.Controls.Add(this.addPartOutsourcedRadioBtn);
            this.Controls.Add(this.addPartInhouseRadioBtn);
            this.Controls.Add(this.addPartInhouseLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddPart";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartInhouseLabel;
        private System.Windows.Forms.RadioButton addPartInhouseRadioBtn;
        private System.Windows.Forms.RadioButton addPartOutsourcedRadioBtn;
        private System.Windows.Forms.Label addPartIDLabel;
        private System.Windows.Forms.TextBox addPartIDTB;
        private System.Windows.Forms.TextBox addPartNameTB;
        private System.Windows.Forms.Label addpartNameLabel;
        private System.Windows.Forms.TextBox addPartInvTB;
        private System.Windows.Forms.Label addPartInventoryLabel;
        private System.Windows.Forms.TextBox addPartMaxTB;
        private System.Windows.Forms.Label addPartMaxlabel;
        private System.Windows.Forms.TextBox addPartMinTB;
        private System.Windows.Forms.Label addPartMinLabel;
        private System.Windows.Forms.TextBox addPartTypeIDTB;
        private System.Windows.Forms.Label addPartTypeIDLabel;
        private System.Windows.Forms.Button addPartSaveBtn;
        private System.Windows.Forms.Button addPartCancelBtn;
        private System.Windows.Forms.TextBox addPartCostTB;
        private System.Windows.Forms.Label addPartCostLabel;
    }
}