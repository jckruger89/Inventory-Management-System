using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JonathanKruger_Software1
{
    public partial class ModifyPart : Form
    {
        
        public ModifyPart()
        {
            InitializeComponent();
        }

        private void modifyCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyInhouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartTypeIDLabel.Text = "Machine ID*";
        }

        private void modifyOutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            modifyPartTypeIDLabel.Text = "Company Name";
        }

        public void PopulateFormInhouse(Inhouse part)
        {
            modifyIDTB.Text = Convert.ToString(part.PartID);
            modifyNameTB.Text = part.Name;
            modifyCostTB.Text = Convert.ToString(part.Price);
            modifyInvTB.Text = Convert.ToString(part.InStock);
            modifyMinTB.Text = Convert.ToString(part.Min);
            modifyMaxTB.Text = Convert.ToString(part.Max);

            modifyPartTypeIDLabel.Text = "Machine ID";
            modifyPartTypeIDTB.Text = Convert.ToString(part.MachineID);
            modifyIDTB.BackColor = SystemColors.ControlLight;
            modifyInhouseRadioBtn.Checked = true;
        }
        public void PopulateFormOutsourced(Outsourced part)
        {
            modifyIDTB.Text = Convert.ToString(part.PartID);
            modifyNameTB.Text = part.Name;
            modifyCostTB.Text = Convert.ToString(part.Price);
            modifyInvTB.Text = Convert.ToString(part.InStock);
            modifyMinTB.Text = Convert.ToString(part.Min);
            modifyMaxTB.Text = Convert.ToString(part.Max);

            modifyPartTypeIDLabel.Text = "Company Name";
            modifyPartTypeIDTB.Text = part.CompanyName;
            modifyIDTB.BackColor = SystemColors.ControlLight;
            modifyOutsourcedRadioBtn.Checked = true;
        }
    
        private void modifySaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(modifyIDTB.Text);
                string name = modifyNameTB.Text;
                decimal price = Convert.ToDecimal(modifyCostTB.Text);
                int instock = Convert.ToInt32(modifyInvTB.Text);
                int min = Convert.ToInt32(modifyMinTB.Text);
                int max = Convert.ToInt32(modifyMaxTB.Text);

                bool good = false;
                if (min > max)
                        MessageBox.Show("Error: Min should be less than the Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (instock >= max || instock <= min)
                        MessageBox.Show("Out of Range Error: Inventory should be between the Min & Max values.", "Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (min < max && instock < max && instock > min)
                        good = true;
                if (good && name != "" && price != 0 && min != 0 && max != 0 && instock != 0)
                {
                    if (modifyInhouseRadioBtn.Checked)
                    {
                        int machineId = Convert.ToInt32(modifyPartTypeIDTB.Text);
                        if (machineId != 0)
                        {
                            Inhouse inhouse = new Inhouse(id, name, price, instock, min, max, machineId);
                            Inventory.UpdatePart(id, inhouse);
                        }
                        else
                            MessageBox.Show($"Part not saved: Please fill out all fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    if (modifyOutsourcedRadioBtn.Checked)
                    {
                        string companyName = modifyPartTypeIDTB.Text;
                        if (companyName != "")
                        {
                            Outsourced outsourced = new Outsourced(id, name, price, instock, min, max, companyName);
                            Inventory.UpdatePart(id, outsourced);
                        }
                        else
                            MessageBox.Show($"Part not saved: Please fill out all fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                if (name == "" || price == 0 || min == 0 || max == 0 || instock == 0)
                    MessageBox.Show($"Part not saved: Please fill out all fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Part not saved: Please fill out all input fields marked with an asterisk* | Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        //Change Events
        private void modifyIDTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyInvTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyCostTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.DecimalValueCheck(sender, e);
        }

        private void modifyMaxTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyMinTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyPartTypeIDTB_TextChanged(object sender, EventArgs e)
        {
            if (modifyInhouseRadioBtn.Checked)
            {
                AddPart.NumericValueCheck(sender, e);
            }
            if (modifyOutsourcedRadioBtn.Checked)
            {
                AddPart.StringValueCheck(sender, e);
            }
        }

        private void modifyNameTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.StringValueCheck(sender, e);
        }
    }
}
