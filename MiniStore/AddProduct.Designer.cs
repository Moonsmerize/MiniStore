namespace MiniStore
{
    partial class AddProduct
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
            nameTxtBox = new TextBox();
            nameLbl = new Label();
            label1 = new Label();
            priceTxtBox = new TextBox();
            label2 = new Label();
            stockTxtBox = new TextBox();
            label3 = new Label();
            registrationNumberTxtBox = new TextBox();
            categoryCB = new ComboBox();
            label4 = new Label();
            addBtn = new CustomBtn();
            panel1 = new Panel();
            minimarketLbl = new Label();
            label5 = new Label();
            closeBtn = new CustomBtn();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // nameTxtBox
            // 
            nameTxtBox.Location = new Point(212, 97);
            nameTxtBox.Name = "nameTxtBox";
            nameTxtBox.Size = new Size(174, 23);
            nameTxtBox.TabIndex = 0;
            // 
            // nameLbl
            // 
            nameLbl.AutoSize = true;
            nameLbl.BackColor = Color.White;
            nameLbl.ForeColor = Color.Black;
            nameLbl.Location = new Point(212, 79);
            nameLbl.Name = "nameLbl";
            nameLbl.Size = new Size(42, 15);
            nameLbl.TabIndex = 1;
            nameLbl.Text = "Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.ForeColor = Color.Black;
            label1.Location = new Point(212, 206);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Price:";
            // 
            // priceTxtBox
            // 
            priceTxtBox.Location = new Point(212, 224);
            priceTxtBox.Name = "priceTxtBox";
            priceTxtBox.Size = new Size(174, 23);
            priceTxtBox.TabIndex = 2;
            priceTxtBox.KeyPress += priceTxtBox_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.Black;
            label2.Location = new Point(212, 270);
            label2.Name = "label2";
            label2.Size = new Size(39, 15);
            label2.TabIndex = 5;
            label2.Text = "Stock:";
            // 
            // stockTxtBox
            // 
            stockTxtBox.Location = new Point(212, 288);
            stockTxtBox.Name = "stockTxtBox";
            stockTxtBox.Size = new Size(174, 23);
            stockTxtBox.TabIndex = 4;
            stockTxtBox.KeyPress += stockTxtBox_KeyPress;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.Black;
            label3.Location = new Point(212, 335);
            label3.Name = "label3";
            label3.Size = new Size(120, 15);
            label3.TabIndex = 7;
            label3.Text = "Registration Number:";
            // 
            // registrationNumberTxtBox
            // 
            registrationNumberTxtBox.Location = new Point(212, 353);
            registrationNumberTxtBox.Name = "registrationNumberTxtBox";
            registrationNumberTxtBox.Size = new Size(174, 23);
            registrationNumberTxtBox.TabIndex = 6;
            // 
            // categoryCB
            // 
            categoryCB.FormattingEnabled = true;
            categoryCB.Items.AddRange(new object[] { "Fruits", "Vegetables", "Personal Care", "Farmacy", "Canned Food", "Candy" });
            categoryCB.Location = new Point(212, 160);
            categoryCB.Name = "categoryCB";
            categoryCB.Size = new Size(174, 23);
            categoryCB.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.Black;
            label4.Location = new Point(212, 142);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 9;
            label4.Text = "Category";
            // 
            // addBtn
            // 
            addBtn.BackColor = Color.FromArgb(69, 92, 198);
            addBtn.BackgroundColor = Color.FromArgb(69, 92, 198);
            addBtn.BorderColor = Color.PaleVioletRed;
            addBtn.BorderRadius = 20;
            addBtn.BorderSize = 0;
            addBtn.FlatAppearance.BorderSize = 0;
            addBtn.FlatStyle = FlatStyle.Flat;
            addBtn.ForeColor = Color.White;
            addBtn.Location = new Point(212, 400);
            addBtn.Name = "addBtn";
            addBtn.Size = new Size(174, 40);
            addBtn.TabIndex = 10;
            addBtn.Text = "Add";
            addBtn.TextColor = Color.White;
            addBtn.UseVisualStyleBackColor = false;
            addBtn.Click += addBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(69, 92, 198);
            panel1.Controls.Add(minimarketLbl);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(134, 452);
            panel1.TabIndex = 11;
            // 
            // minimarketLbl
            // 
            minimarketLbl.AutoSize = true;
            minimarketLbl.BackColor = Color.FromArgb(69, 92, 198);
            minimarketLbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            minimarketLbl.ForeColor = Color.White;
            minimarketLbl.Location = new Point(4, 9);
            minimarketLbl.Name = "minimarketLbl";
            minimarketLbl.Size = new Size(127, 30);
            minimarketLbl.TabIndex = 14;
            minimarketLbl.Text = "Minimarket";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(69, 92, 198);
            label5.Location = new Point(153, 19);
            label5.Name = "label5";
            label5.Size = new Size(281, 37);
            label5.TabIndex = 12;
            label5.Text = "Product Information";
            // 
            // closeBtn
            // 
            closeBtn.BackColor = Color.Transparent;
            closeBtn.BackgroundColor = Color.Transparent;
            closeBtn.BorderColor = Color.PaleVioletRed;
            closeBtn.BorderRadius = 0;
            closeBtn.BorderSize = 0;
            closeBtn.FlatAppearance.BorderSize = 0;
            closeBtn.FlatStyle = FlatStyle.Flat;
            closeBtn.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            closeBtn.ForeColor = Color.FromArgb(69, 92, 198);
            closeBtn.Location = new Point(455, 0);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(50, 38);
            closeBtn.TabIndex = 13;
            closeBtn.Text = "x";
            closeBtn.TextColor = Color.FromArgb(69, 92, 198);
            closeBtn.UseVisualStyleBackColor = false;
            closeBtn.Click += closeBtn_Click;
            // 
            // AddProduct
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(496, 452);
            Controls.Add(closeBtn);
            Controls.Add(label5);
            Controls.Add(panel1);
            Controls.Add(addBtn);
            Controls.Add(label4);
            Controls.Add(categoryCB);
            Controls.Add(label3);
            Controls.Add(registrationNumberTxtBox);
            Controls.Add(label2);
            Controls.Add(stockTxtBox);
            Controls.Add(label1);
            Controls.Add(priceTxtBox);
            Controls.Add(nameLbl);
            Controls.Add(nameTxtBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddProduct";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddProduct";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox nameTxtBox;
        private Label nameLbl;
        private Label label1;
        private TextBox priceTxtBox;
        private Label label2;
        private TextBox stockTxtBox;
        private Label label3;
        private TextBox registrationNumberTxtBox;
        private ComboBox categoryCB;
        private Label label4;
        private CustomBtn addBtn;
        private Panel panel1;
        private Label label5;
        private CustomBtn closeBtn;
        private Label minimarketLbl;
    }
}