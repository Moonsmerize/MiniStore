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
    public partial class Products : Form
    {
        private int id = 0;
        public Products()
        {
            InitializeComponent();
        }

        private void newProductBtn_Click(object sender, EventArgs e)
        {
            AddProduct newProduct = new AddProduct();
            newProduct.Visible = true;
        }

        public void AddProduct(string name,string category,double price,int stock,string registrationNum) 
        {
            dgvProducts.Rows.Add(id++,name,category,price,stock,registrationNum);
        }
    }
}
