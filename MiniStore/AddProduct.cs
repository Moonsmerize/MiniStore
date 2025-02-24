using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniStore
{
    public partial class AddProduct : Form
    {
        int id = 0;
        
        public AddProduct()
        {
            InitializeComponent();
        }

        private void AddProduct_Load(object sender, EventArgs e)
        {

        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (nameTxtBox.Text != "" && priceTxtBox.Text != "" && categoryCB.Text != "" && registrationNumberTxtBox.Text != "" && stockTxtBox.Text != "")
            {
                Products product = new Products();
                product.AddProduct(Convert.ToString(id), nameTxtBox.Text, categoryCB.Text, priceTxtBox.Text, stockTxtBox.Text, registrationNumberTxtBox.Text);
                MessageBox.Show("Product succesfully added");
            }
            else 
            {
                MessageBox.Show("All fields must be filled");
            }
        }

        private void priceTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
            if (e.KeyChar == '.' && (sender as TextBox).Text.IndexOf('.') > -1)
            {
                e.Handled = true;
            }
        }

        private void stockTxtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        
    }
}
