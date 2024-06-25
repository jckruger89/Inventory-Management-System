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
    public partial class AddProduct : Form
    {
        public static BindingList<Part> partsNeeded = new BindingList<Part>();
        public AddProduct()
        {
            InitializeComponent();
            addProductAllPartsDGV.DataSource = Inventory.allParts;
            addProductAssPartsDGV.DataSource = partsNeeded;
            addProductAllPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductAssPartsDGV.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            addProductAllPartsDGV.ReadOnly = true;
            addProductAssPartsDGV.ReadOnly = true;
            addProductAllPartsDGV.AllowUserToAddRows = false;
            addProductAssPartsDGV.AllowUserToAddRows = false;
        }

        private void addProductCancelBtn_Click(object sender, EventArgs e)
        {
            this.Close(); // Close Add Product form without saving
        }

        private void addProductAddBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = addProductAllPartsDGV.CurrentRow.Index;
                if (addProductAllPartsDGV.Rows[index].Selected == true)
                {
                    Part selection = Inventory.allParts[index];

                    int targetPartID = selection.PartID;

                    bool partExists = partsNeeded.Any(part => part.PartID == targetPartID); //Using LINQ method Any() to check condition

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

        private void addProductDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = addProductAssPartsDGV.CurrentRow.Index;
                Part selection = partsNeeded[index];
                if (addProductAssPartsDGV.Rows[index].Selected == true)
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

        private void addProductSaveBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string name = addProductNameTB.Text;
                decimal price = Convert.ToDecimal(addProductCostTB.Text);
                int instock = Convert.ToInt32(addProductInvTB.Text);
                int min = Convert.ToInt32(addProductMinTB.Text);
                int max = Convert.ToInt32(addProductMaxTB.Text);
                bool good = false;
                if (min > max)
                    MessageBox.Show("Error: Min should be less than the Max.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (instock > max || instock < min)
                    MessageBox.Show("Out of Range Error: Inventory should be between the Min & Max values.", "Out of Range Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (min < max && instock <= max && instock >= min)
                    good = true;
                if (name == "" || price == 0 || min == 0 || max == 0 || instock == 0)
                    MessageBox.Show($"Product not saved: Please fill out all fields marked with an asterisk*", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (good && name != "" && price != 0 && min != 0 && max != 0 && instock != 0)
                {
                    Product newProduct = new Product(name, price, instock, min, max);
                    Inventory.AddProduct(newProduct);
                    foreach (Part selectedPart in partsNeeded)
                    {
                        newProduct.associatedParts.Add(selectedPart);
                    }                
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Product not saved: Please fill out all input fields marked with an asterisk* | Error: {ex.Message}", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Close();
        }           
   
        private void addProductSearchBtn_Click(object sender, EventArgs e)
        {
            addProductAllPartsDGV.ClearSelection();
            addProductAllPartsDGV.MultiSelect = true;
            string searchText = addProductSearchTextBox.Text;

            int counter = 0;

            if (searchText != "")
            {
                for (int i = 0; i < Inventory.allParts.Count; i++)
                {
                    if (Inventory.allParts[i].Name.ToUpper().Contains(searchText.ToUpper()))
                    {
                        addProductAllPartsDGV.Rows[i].Selected = true;
                        addProductAllPartsDGV.CurrentCell = addProductAllPartsDGV.Rows[i].Cells[0];

                    }
                    else if (Inventory.allParts[i].PartID.ToString().Contains(searchText))
                    {
                        addProductAllPartsDGV.Rows[i].Selected = true;
                        addProductAllPartsDGV.CurrentCell = addProductAllPartsDGV.Rows[i].Cells[0];
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
        private void addProductIDTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void addProductInvTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void addProductCostTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.DecimalValueCheck(sender, e);
        }

        private void addProductMaxTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }

        private void addProductMinTB_TextChanged(object sender, EventArgs e)
        {
            AddPart.NumericValueCheck(sender, e);
        }
    }
}
