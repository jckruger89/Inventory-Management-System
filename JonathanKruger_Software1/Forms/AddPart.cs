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
    public partial class AddPart : Form
    {
        public AddPart()
        {
            InitializeComponent();
        }

        //exception handling methods
        public static void NumericValueCheck(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                int result = Convert.ToInt32(textBox.Text);
                textBox.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Please enter a numeric value.");
            }
            catch (OverflowException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Input entered is Too large OR Too small, please try again");
            }
        }
        public static void StringValueCheck(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                string result = textBox.Text;
                textBox.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Please enter a string value.");
            }
            catch (OverflowException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Input entered is Too large OR Too small, please try again");
            }
        }
        public static void DecimalValueCheck(object sender, EventArgs e)
        {
            TextBox textBox = (TextBox)sender;
            try
            {
                decimal result = Convert.ToDecimal(textBox.Text);
                textBox.BackColor = SystemColors.Window;
            }
            catch (FormatException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Please enter a decimal value.");
            }
            catch (OverflowException)
            {
                textBox.BackColor = Color.Red;
                MessageBox.Show("Error: Input entered is Too large OR Too small, please try again");
            }
        }

        private void addPartCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Closes Add Part Form without adding new part
        }

        private void addPartSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = addPartNameTB.Text;
                decimal price = Convert.ToDecimal(addPartCostTB.Text);
                int instock = Convert.ToInt32(addPartInvTB.Text);
                int min = Convert.ToInt32(addPartMinTB.Text);
                int max = Convert.ToInt32(addPartMaxTB.Text);
                bool good = false;

                if (min > max)
                        MessageBox.Show("Error: Min should be less than the Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (instock >= max || instock <= min)
                        MessageBox.Show("Out of Range Error: Inventory should be between the Min & Max values.", "Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (min < max && instock < max && instock > min)
                        good = true;
                if (good && name != "" && price != 0 && min != 0 && max != 0 && instock != 0)
                {
                    if (addPartInhouseRadioBtn.Checked)
                    {
                        int machineId = Convert.ToInt32(addPartTypeIDTB.Text);
                        if (machineId != 0)
                        {
                            Inhouse inhouse = new Inhouse(name, price, instock, min, max, machineId);
                            Inventory.AddPart(inhouse);
                        }
                        else
                            MessageBox.Show($"Part not saved: Please fill out all fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    if (addPartOutsourcedRadioBtn.Checked)
                    {
                        string companyName = addPartTypeIDTB.Text;
                        if (companyName != "")
                        {
                            Outsourced outsourced = new Outsourced(name, price, instock, min, max, companyName);
                            Inventory.AddPart(outsourced);
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
        private void addPartOutsourcedRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            addPartTypeIDLabel.Text = "Company Name";
        }

        private void addPartInhouseRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            addPartTypeIDLabel.Text = "Machine ID*";
        }

        private void addPartIDTB_TextChanged(object sender, EventArgs e)
        {
            NumericValueCheck(sender, e);
        }

        private void addPartInvTB_TextChanged(object sender, EventArgs e)
        {
            NumericValueCheck(sender, e);
        }

        private void addPartCostTB_TextChanged(object sender, EventArgs e)
        {
            DecimalValueCheck(sender, e);
        }

        private void addPartMaxTB_TextChanged(object sender, EventArgs e)
        {
            NumericValueCheck(sender, e);
        }

        private void addPartMinTB_TextChanged(object sender, EventArgs e)
        {
            NumericValueCheck(sender, e);
        }

        private void addPartTypeIDTB_TextChanged(object sender, EventArgs e)
        {
            if (addPartInhouseRadioBtn.Checked)
            {
                NumericValueCheck(sender, e);
            }
            if (addPartOutsourcedRadioBtn.Checked)
            {
                StringValueCheck(sender, e);
            }
        }
    }
}
