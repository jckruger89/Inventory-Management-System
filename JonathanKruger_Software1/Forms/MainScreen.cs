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
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            productDGV.DataSource = Inventory.products;
            partDGV.DataSource = Inventory.allParts;
            partDGV.AllowUserToAddRows = false;
            productDGV.AllowUserToAddRows = false;         
        }
        private void partsBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            partDGV.ClearSelection();
        }

        private void productBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            productDGV.ClearSelection();
        }

        private void partsAddBtn_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            addPart.ShowDialog(); // Opens Add Part Form
        }

        private void partsModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyPart modPart = new ModifyPart();

            if (partDGV.CurrentRow.DataBoundItem.GetType() == typeof(Inhouse))
            {
                Inhouse temp = partDGV.CurrentRow.DataBoundItem as Inhouse;
                modPart.PopulateFormInhouse(temp);
                modPart.ShowDialog();
            }
            else if(partDGV.CurrentRow.DataBoundItem.GetType() == typeof(Outsourced))
            {
                Outsourced temp = partDGV.CurrentRow.DataBoundItem as Outsourced;
                modPart.PopulateFormOutsourced(temp);
                modPart.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }

        private void productsModifyBtn_Click(object sender, EventArgs e)
        {
            ModifyProduct modProduct = new ModifyProduct();

            if (productDGV.CurrentRow.DataBoundItem.GetType() == typeof(Product))
            {
                Product temp = productDGV.CurrentRow.DataBoundItem as Product;
                modProduct.PopulateProductForm(temp);
                modProduct.ShowDialog();
            }
            else
            {
                MessageBox.Show("No row selected");
            }
        }
        private void productsAddBtn_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            AddProduct.partsNeeded.Clear();
            addProduct.ShowDialog();
        }
        private void invMgtSysExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void productsDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                int index = productDGV.CurrentRow.Index;
                Product selection = Inventory.products[index];

                if (productDGV.Rows[index].Selected == true)
                {
                    if (selection.associatedParts.Count == 0)
                    {
                        DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (dialogresult == DialogResult.Yes)
                            Inventory.RemoveProduct(selection.ProductID);
                    }
                    else
                    {
                        MessageBox.Show("ERROR: Cannot Delete, Product has an associated part", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("No row selected");
                }
            }

            catch (NullReferenceException ex)
            {
                MessageBox.Show($"Error: {ex.Message} | No more products to delete");
            }
        }

        private void productsSearchBtn_Click(object sender, EventArgs e)
        {
            productDGV.ClearSelection();
            productDGV.MultiSelect = true;
            string searchText = productsTextBox.Text;
         
            int counter = 0;

            if (searchText != "")
            {
                for (int i = 0; i < Inventory.products.Count; i++)
                {
                    if (Inventory.products[i].Name.ToUpper().Contains(searchText.ToUpper()))
                    {
                        productDGV.Rows[i].Selected = true;
                        productDGV.CurrentCell = productDGV.Rows[i].Cells[0];
                    }
                    else if (Inventory.products[i].ProductID.ToString().Contains(searchText))
                    {
                        productDGV.Rows[i].Selected = true;
                        productDGV.CurrentCell = productDGV.Rows[i].Cells[0];
                    }
                    else
                    {
                        counter++;
                        if (counter == Inventory.products.Count)
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

        private void partsDeleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                 int index = partDGV.CurrentRow.Index;
                 Part selection = Inventory.allParts[index];

                if (partDGV.Rows[index].Selected == true)
                {
                    DialogResult dialogresult = MessageBox.Show("Are you sure you want to delete?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (dialogresult == DialogResult.Yes)
                    {
                        Inventory.DeletePart(selection);
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

        private void partsSearchBtn_Click(object sender, EventArgs e)
        {
             partDGV.ClearSelection();
             partDGV.MultiSelect = true;
             string searchText = partsTextBox.Text;
             int counter = 0;

            if (searchText != "")
            {
                for (int i = 0; i < Inventory.allParts.Count; i++)
                {
                    if (Inventory.allParts[i].Name.ToUpper().Contains(searchText.ToUpper()))
                    {
                        //partDGV.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen; //Code for if I decide to change the row color later
                        partDGV.Rows[i].Selected = true;
                        partDGV.CurrentCell = partDGV.Rows[i].Cells[0];
                    }
                    else if (Inventory.allParts[i].PartID.ToString().Contains(searchText))
                    {
                        // partDGV.DefaultCellStyle.SelectionBackColor = Color.LightSeaGreen;
                        partDGV.Rows[i].Selected = true;
                        partDGV.CurrentCell = partDGV.Rows[i].Cells[0];
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
        }  
}
    




        
    

