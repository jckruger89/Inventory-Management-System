namespace JonathanKruger_Software1
{
    partial class ModifyPart
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
            this.modifyCostTB = new System.Windows.Forms.TextBox();
            this.modifyCostLabel = new System.Windows.Forms.Label();
            this.modifyCancelBtn = new System.Windows.Forms.Button();
            this.modifySaveBtn = new System.Windows.Forms.Button();
            this.modifyPartTypeIDTB = new System.Windows.Forms.TextBox();
            this.modifyPartTypeIDLabel = new System.Windows.Forms.Label();
            this.modifyMinTB = new System.Windows.Forms.TextBox();
            this.modifyMinLabel = new System.Windows.Forms.Label();
            this.modifyMaxTB = new System.Windows.Forms.TextBox();
            this.modifyMaxlabel = new System.Windows.Forms.Label();
            this.modifyInvTB = new System.Windows.Forms.TextBox();
            this.modifyInventoryLabel = new System.Windows.Forms.Label();
            this.modifyNameTB = new System.Windows.Forms.TextBox();
            this.modifyNameLabel = new System.Windows.Forms.Label();
            this.modifyIDTB = new System.Windows.Forms.TextBox();
            this.modifyIDLabel = new System.Windows.Forms.Label();
            this.modifyOutsourcedRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyInhouseRadioBtn = new System.Windows.Forms.RadioButton();
            this.modifyInhouseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // modifyCostTB
            // 
            this.modifyCostTB.Location = new System.Drawing.Point(184, 234);
            this.modifyCostTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyCostTB.Name = "modifyCostTB";
            this.modifyCostTB.Size = new System.Drawing.Size(168, 26);
            this.modifyCostTB.TabIndex = 25;
            this.modifyCostTB.TextChanged += new System.EventHandler(this.modifyCostTB_TextChanged);
            // 
            // modifyCostLabel
            // 
            this.modifyCostLabel.AutoSize = true;
            this.modifyCostLabel.Location = new System.Drawing.Point(60, 237);
            this.modifyCostLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyCostLabel.Name = "modifyCostLabel";
            this.modifyCostLabel.Size = new System.Drawing.Size(104, 20);
            this.modifyCostLabel.TabIndex = 25;
            this.modifyCostLabel.Text = "Price / Cost*";
            // 
            // modifyCancelBtn
            // 
            this.modifyCancelBtn.Location = new System.Drawing.Point(400, 383);
            this.modifyCancelBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyCancelBtn.Name = "modifyCancelBtn";
            this.modifyCancelBtn.Size = new System.Drawing.Size(106, 32);
            this.modifyCancelBtn.TabIndex = 30;
            this.modifyCancelBtn.Text = "Cancel";
            this.modifyCancelBtn.UseVisualStyleBackColor = true;
            this.modifyCancelBtn.Click += new System.EventHandler(this.modifyCancelBtn_Click);
            // 
            // modifySaveBtn
            // 
            this.modifySaveBtn.Location = new System.Drawing.Point(241, 383);
            this.modifySaveBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifySaveBtn.Name = "modifySaveBtn";
            this.modifySaveBtn.Size = new System.Drawing.Size(111, 32);
            this.modifySaveBtn.TabIndex = 29;
            this.modifySaveBtn.Text = "Save";
            this.modifySaveBtn.UseVisualStyleBackColor = true;
            this.modifySaveBtn.Click += new System.EventHandler(this.modifySaveBtn_Click);
            // 
            // modifyPartTypeIDTB
            // 
            this.modifyPartTypeIDTB.Location = new System.Drawing.Point(184, 336);
            this.modifyPartTypeIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyPartTypeIDTB.Name = "modifyPartTypeIDTB";
            this.modifyPartTypeIDTB.Size = new System.Drawing.Size(168, 26);
            this.modifyPartTypeIDTB.TabIndex = 28;
            this.modifyPartTypeIDTB.TextChanged += new System.EventHandler(this.modifyPartTypeIDTB_TextChanged);
            // 
            // modifyPartTypeIDLabel
            // 
            this.modifyPartTypeIDLabel.AutoSize = true;
            this.modifyPartTypeIDLabel.Location = new System.Drawing.Point(64, 339);
            this.modifyPartTypeIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyPartTypeIDLabel.Name = "modifyPartTypeIDLabel";
            this.modifyPartTypeIDLabel.Size = new System.Drawing.Size(100, 20);
            this.modifyPartTypeIDLabel.TabIndex = 28;
            this.modifyPartTypeIDLabel.Text = "Machine ID*";
            // 
            // modifyMinTB
            // 
            this.modifyMinTB.Location = new System.Drawing.Point(382, 285);
            this.modifyMinTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyMinTB.Name = "modifyMinTB";
            this.modifyMinTB.Size = new System.Drawing.Size(84, 26);
            this.modifyMinTB.TabIndex = 27;
            this.modifyMinTB.TextChanged += new System.EventHandler(this.modifyMinTB_TextChanged);
            // 
            // modifyMinLabel
            // 
            this.modifyMinLabel.AutoSize = true;
            this.modifyMinLabel.Location = new System.Drawing.Point(318, 288);
            this.modifyMinLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyMinLabel.Name = "modifyMinLabel";
            this.modifyMinLabel.Size = new System.Drawing.Size(42, 20);
            this.modifyMinLabel.TabIndex = 27;
            this.modifyMinLabel.Text = "Min*";
            // 
            // modifyMaxTB
            // 
            this.modifyMaxTB.Location = new System.Drawing.Point(184, 285);
            this.modifyMaxTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyMaxTB.Name = "modifyMaxTB";
            this.modifyMaxTB.Size = new System.Drawing.Size(85, 26);
            this.modifyMaxTB.TabIndex = 26;
            this.modifyMaxTB.TextChanged += new System.EventHandler(this.modifyMaxTB_TextChanged);
            // 
            // modifyMaxlabel
            // 
            this.modifyMaxlabel.AutoSize = true;
            this.modifyMaxlabel.Location = new System.Drawing.Point(118, 285);
            this.modifyMaxlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyMaxlabel.Name = "modifyMaxlabel";
            this.modifyMaxlabel.Size = new System.Drawing.Size(46, 20);
            this.modifyMaxlabel.TabIndex = 26;
            this.modifyMaxlabel.Text = "Max*";
            // 
            // modifyInvTB
            // 
            this.modifyInvTB.Location = new System.Drawing.Point(184, 182);
            this.modifyInvTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyInvTB.Name = "modifyInvTB";
            this.modifyInvTB.Size = new System.Drawing.Size(168, 26);
            this.modifyInvTB.TabIndex = 24;
            this.modifyInvTB.TextChanged += new System.EventHandler(this.modifyInvTB_TextChanged);
            // 
            // modifyInventoryLabel
            // 
            this.modifyInventoryLabel.AutoSize = true;
            this.modifyInventoryLabel.Location = new System.Drawing.Point(82, 185);
            this.modifyInventoryLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyInventoryLabel.Name = "modifyInventoryLabel";
            this.modifyInventoryLabel.Size = new System.Drawing.Size(82, 20);
            this.modifyInventoryLabel.TabIndex = 24;
            this.modifyInventoryLabel.Text = "Inventory*";
            // 
            // modifyNameTB
            // 
            this.modifyNameTB.Location = new System.Drawing.Point(184, 134);
            this.modifyNameTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyNameTB.Name = "modifyNameTB";
            this.modifyNameTB.Size = new System.Drawing.Size(168, 26);
            this.modifyNameTB.TabIndex = 23;
            this.modifyNameTB.TextChanged += new System.EventHandler(this.modifyNameTB_TextChanged);
            // 
            // modifyNameLabel
            // 
            this.modifyNameLabel.AutoSize = true;
            this.modifyNameLabel.Location = new System.Drawing.Point(105, 137);
            this.modifyNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyNameLabel.Name = "modifyNameLabel";
            this.modifyNameLabel.Size = new System.Drawing.Size(59, 20);
            this.modifyNameLabel.TabIndex = 23;
            this.modifyNameLabel.Text = "Name*";
            // 
            // modifyIDTB
            // 
            this.modifyIDTB.BackColor = System.Drawing.Color.LightGray;
            this.modifyIDTB.Location = new System.Drawing.Point(184, 84);
            this.modifyIDTB.Margin = new System.Windows.Forms.Padding(4);
            this.modifyIDTB.Name = "modifyIDTB";
            this.modifyIDTB.ReadOnly = true;
            this.modifyIDTB.Size = new System.Drawing.Size(168, 26);
            this.modifyIDTB.TabIndex = 22;
            this.modifyIDTB.TextChanged += new System.EventHandler(this.modifyIDTB_TextChanged);
            // 
            // modifyIDLabel
            // 
            this.modifyIDLabel.AutoSize = true;
            this.modifyIDLabel.Location = new System.Drawing.Point(132, 87);
            this.modifyIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyIDLabel.Name = "modifyIDLabel";
            this.modifyIDLabel.Size = new System.Drawing.Size(26, 20);
            this.modifyIDLabel.TabIndex = 22;
            this.modifyIDLabel.Text = "ID";
            // 
            // modifyOutsourcedRadioBtn
            // 
            this.modifyOutsourcedRadioBtn.AutoSize = true;
            this.modifyOutsourcedRadioBtn.Location = new System.Drawing.Point(349, 17);
            this.modifyOutsourcedRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyOutsourcedRadioBtn.Name = "modifyOutsourcedRadioBtn";
            this.modifyOutsourcedRadioBtn.Size = new System.Drawing.Size(117, 24);
            this.modifyOutsourcedRadioBtn.TabIndex = 21;
            this.modifyOutsourcedRadioBtn.TabStop = true;
            this.modifyOutsourcedRadioBtn.Text = "Outsourced";
            this.modifyOutsourcedRadioBtn.UseVisualStyleBackColor = true;
            this.modifyOutsourcedRadioBtn.CheckedChanged += new System.EventHandler(this.modifyOutsourcedRadioBtn_CheckedChanged);
            // 
            // modifyInhouseRadioBtn
            // 
            this.modifyInhouseRadioBtn.AutoSize = true;
            this.modifyInhouseRadioBtn.Location = new System.Drawing.Point(184, 17);
            this.modifyInhouseRadioBtn.Margin = new System.Windows.Forms.Padding(4);
            this.modifyInhouseRadioBtn.Name = "modifyInhouseRadioBtn";
            this.modifyInhouseRadioBtn.Size = new System.Drawing.Size(98, 24);
            this.modifyInhouseRadioBtn.TabIndex = 20;
            this.modifyInhouseRadioBtn.TabStop = true;
            this.modifyInhouseRadioBtn.Text = "In-House";
            this.modifyInhouseRadioBtn.UseVisualStyleBackColor = true;
            this.modifyInhouseRadioBtn.CheckedChanged += new System.EventHandler(this.modifyInhouseRadioBtn_CheckedChanged);
            // 
            // modifyInhouseLabel
            // 
            this.modifyInhouseLabel.AutoSize = true;
            this.modifyInhouseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifyInhouseLabel.Location = new System.Drawing.Point(15, 11);
            this.modifyInhouseLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.modifyInhouseLabel.Name = "modifyInhouseLabel";
            this.modifyInhouseLabel.Size = new System.Drawing.Size(133, 29);
            this.modifyInhouseLabel.TabIndex = 19;
            this.modifyInhouseLabel.Text = "Modify Part";
            // 
            // ModifyPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 437);
            this.Controls.Add(this.modifyCostTB);
            this.Controls.Add(this.modifyCostLabel);
            this.Controls.Add(this.modifyCancelBtn);
            this.Controls.Add(this.modifySaveBtn);
            this.Controls.Add(this.modifyPartTypeIDTB);
            this.Controls.Add(this.modifyPartTypeIDLabel);
            this.Controls.Add(this.modifyMinTB);
            this.Controls.Add(this.modifyMinLabel);
            this.Controls.Add(this.modifyMaxTB);
            this.Controls.Add(this.modifyMaxlabel);
            this.Controls.Add(this.modifyInvTB);
            this.Controls.Add(this.modifyInventoryLabel);
            this.Controls.Add(this.modifyNameTB);
            this.Controls.Add(this.modifyNameLabel);
            this.Controls.Add(this.modifyIDTB);
            this.Controls.Add(this.modifyIDLabel);
            this.Controls.Add(this.modifyOutsourcedRadioBtn);
            this.Controls.Add(this.modifyInhouseRadioBtn);
            this.Controls.Add(this.modifyInhouseLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ModifyPart";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox modifyCostTB;
        private System.Windows.Forms.Label modifyCostLabel;
        private System.Windows.Forms.Button modifyCancelBtn;
        private System.Windows.Forms.Button modifySaveBtn;
        private System.Windows.Forms.TextBox modifyPartTypeIDTB;
        private System.Windows.Forms.Label modifyPartTypeIDLabel;
        private System.Windows.Forms.TextBox modifyMinTB;
        private System.Windows.Forms.Label modifyMinLabel;
        private System.Windows.Forms.TextBox modifyMaxTB;
        private System.Windows.Forms.Label modifyMaxlabel;
        private System.Windows.Forms.TextBox modifyInvTB;
        private System.Windows.Forms.Label modifyInventoryLabel;
        private System.Windows.Forms.TextBox modifyNameTB;
        private System.Windows.Forms.Label modifyNameLabel;
        private System.Windows.Forms.TextBox modifyIDTB;
        private System.Windows.Forms.Label modifyIDLabel;
        private System.Windows.Forms.RadioButton modifyOutsourcedRadioBtn;
        private System.Windows.Forms.RadioButton modifyInhouseRadioBtn;
        private System.Windows.Forms.Label modifyInhouseLabel;
    }
}