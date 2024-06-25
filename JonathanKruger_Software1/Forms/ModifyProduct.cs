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
    public partial class ModifyProduct : Form
    {
        public ModifyProduct()
        {
            InitializeComponent();
            modifyProdAllPartsDGV.DataSource = Inventory.allParts;
            modifyProdAllPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProdAssPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            modifyProdAllPartsDGV.ReadOnly = true;
            modifyProdAssPartsDGV.ReadOnly = true;
            modifyProdAllPartsDGV.AllowUserToAddRows = false;
            modifyProdAssPartsDGV.AllowUserToAddRows = false;
        }

        public void PopulateProductForm(Product prod)
        {
            modifyProdIDTB.Text = Convert.ToString(prod.ProductID);
            modifyProdNameTB.Text = prod.Name;
            modifyProdCostTB.Text = Convert.ToString(prod.Price);
            modifyProdInvTB.Text = Convert.ToString(prod.InStock);
            modifyProdMinTB.Text = Convert.ToString(prod.Min);
            modifyProdMaxTB.Text = Convert.ToString(prod.Max);

            modifyProdIDTB.BackColor = SystemColors.ControlLight;

            AddProduct.partsNeeded = prod.associatedParts;
            modifyProdAssPartsDGV.DataSource = AddProduct.partsNeeded;
        }

        private void modifyProdCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void modifyProdDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = modifyProdAssPartsDGV.CurrentRow.Index;
                Part selection = AddProduct.partsNeeded[index];
                if (modifyProdAssPartsDGV.Rows[index].Selected == true)
                {
                    DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.Yes)
                    {
                        Product.RemoveAssociatedPart(selection.PartID);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected");
                }
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error: {ex.Message} | No more parts to delete");
            }
        }

        private void modifyProdAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = modifyProdAllPartsDGV.CurrentRow.Index;
                if (modifyProdAllPartsDGV.Rows[index].Selected == true)
                {
                    Part selection = Inventory.allParts[index];

                    int targetPartID = selection.PartID;

                    bool partExists = AddProduct.partsNeeded.Any(part => part.PartID == targetPartID); //Using LINQ method Any() to check condition

                    if (partExists)
                    {
                        MessageBox.Show("Part has already been added to product");
                    }
                    else
                    {
                        Product.AddAssociatedPart(selection);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected");
                }
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error: {ex.Message} | No more parts to add");
            }
        }

        private void modifyProdSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(modifyProdIDTB.Text);
                string name = modifyProdNameTB.Text;
                decimal price = Convert.ToDecimal(modifyProdCostTB.Text);
                int instock = Convert.ToInt32(modifyProdInvTB.Text);
                int min = Convert.ToInt32(modifyProdMinTB.Text);
                int max = Convert.ToInt32(modifyProdMaxTB.Text);

                bool good = false;
                if (min > max)
                    MessageBox.Show("Error: Min should be less than the Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (instock > max || instock < min)
                    MessageBox.Show("Out of Range Error: Inventory should be between the Min & Max values.", "Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (min < max && instock <= max && instock >= min)
                    good = true;
                if (good && name != "" && price != 0 && min != 0 && max != 0 && instock != 0)
                {
                    Product newProduct = new Product(id, name, price, instock, min, max);

                    foreach (Part selectedPart in AddProduct.partsNeeded)
                    {
                        newProduct.associatedParts.Add(selectedPart);
                    }
                    Inventory.UpdateProduct(id, newProduct);
                }
                if (name == "" || price == 0 || min == 0 || max == 0 || instock == 0)
                    MessageBox.Show($"Product not saved: Please fill out all input fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Product not saved: Please fill out all input fields marked with an asterisk* | Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }

        private void modifyProdSearchBtn_Click(object sender, EventArgs e)
        {
            modifyProdAllPartsDGV.ClearSelection();
            modifyProdAllPartsDGV.MultiSelect = true;
            string searchText = modifyProdSearchTextBox.Text;

            int counter = 0;

            if (searchText != "")
            {
                for (int i = 0; i < Inventory.allParts.Count; i++)
                {
                    if (Inventory.allParts[i].Name.ToUpper().Contains(searchText.ToUpper()))
                    {
                        modifyProdAllPartsDGV.Rows[i].Selected = true;
                        modifyProdAllPartsDGV.CurrentCell = modifyProdAllPartsDGV.Rows[i].Cells[0];

                    }
                    else if (Inventory.allParts[i].PartID.ToString().Contains(searchText))
                    {
                        modifyProdAllPartsDGV.Rows[i].Selected = true;
                        modifyProdAllPartsDGV.CurrentCell = modifyProdAllPartsDGV.Rows[i].Cells[0];

                    }
                    else
                    {
                        counter++;
                        if (counter == Inventory.allParts.Count)
                        {
                            MessageBox.Show("No results found");
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("No search entered");
            }
        }

        //Change Events
        private void modifyProdIDTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyProdInvTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyProdCostTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.DecimalValueCheck(sender, e);
        }

        private void modifyProdMaxTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void modifyProdMinTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }
    }
}
