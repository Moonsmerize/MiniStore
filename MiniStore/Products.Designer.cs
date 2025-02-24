namespace MiniStore
{
    partial class Products
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
            newProductBtn = new CustomBtn();
            dgvProducts = new DataGridView();
            productId = new DataGridViewTextBoxColumn();
            productName = new DataGridViewTextBoxColumn();
            productCategory = new DataGridViewTextBoxColumn();
            productPrice = new DataGridViewTextBoxColumn();
            productStock = new DataGridViewTextBoxColumn();
            productRegistrationNum = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvProducts).BeginInit();
            SuspendLayout();
            // 
            // newProductBtn
            // 
            newProductBtn.BackColor = Color.FromArgb(69, 92, 198);
            newProductBtn.BackgroundColor = Color.FromArgb(69, 92, 198);
            newProductBtn.BorderColor = Color.PaleVioletRed;
            newProductBtn.BorderRadius = 20;
            newProductBtn.BorderSize = 0;
            newProductBtn.FlatAppearance.BorderSize = 0;
            newProductBtn.FlatStyle = FlatStyle.Flat;
            newProductBtn.ForeColor = Color.White;
            newProductBtn.Location = new Point(313, 355);
            newProductBtn.Name = "newProductBtn";
            newProductBtn.Size = new Size(150, 40);
            newProductBtn.TabIndex = 1;
            newProductBtn.Text = "New Product";
            newProductBtn.TextColor = Color.White;
            newProductBtn.UseVisualStyleBackColor = false;
            newProductBtn.Click += newProductBtn_Click;
            // 
            // dgvProducts
            // 
            dgvProducts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProducts.Columns.AddRange(new DataGridViewColumn[] { productId, productName, productCategory, productPrice, productStock, productRegistrationNum });
            dgvProducts.Location = new Point(67, 114);
            dgvProducts.Name = "dgvProducts";
            dgvProducts.Size = new Size(643, 150);
            dgvProducts.TabIndex = 2;
            // 
            // productId
            // 
            productId.HeaderText = "ID";
            productId.Name = "productId";
            // 
            // productName
            // 
            productName.HeaderText = "Name";
            productName.Name = "productName";
            // 
            // productCategory
            // 
            productCategory.HeaderText = "Category";
            productCategory.Name = "productCategory";
            // 
            // productPrice
            // 
            productPrice.HeaderText = "Price";
            productPrice.Name = "productPrice";
            // 
            // productStock
            // 
            productStock.HeaderText = "Stock";
            productStock.Name = "productStock";
            // 
            // productRegistrationNum
            // 
            productRegistrationNum.HeaderText = "Registration Number";
            productRegistrationNum.Name = "productRegistrationNum";
            // 
            // Products
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dgvProducts);
            Controls.Add(newProductBtn);
            Name = "Products";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            ((System.ComponentModel.ISupportInitialize)dgvProducts).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private CustomBtn newProductBtn;
        private DataGridView dgvProducts;
        private DataGridViewTextBoxColumn productId;
        private DataGridViewTextBoxColumn productName;
        private DataGridViewTextBoxColumn productCategory;
        private DataGridViewTextBoxColumn productPrice;
        private DataGridViewTextBoxColumn productStock;
        private DataGridViewTextBoxColumn productRegistrationNum;
    }
}