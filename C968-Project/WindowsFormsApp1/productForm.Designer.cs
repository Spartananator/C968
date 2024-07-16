namespace WindowsFormsApp1
{
    partial class productForm
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.partsInProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partRemoveProduct = new System.Windows.Forms.Button();
            this.partAddProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cancelProduct = new System.Windows.Forms.Button();
            this.confirmProduct = new System.Windows.Forms.Button();
            this.productFormType = new System.Windows.Forms.Label();
            this.productParts = new System.Windows.Forms.Label();
            this.availableParts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchProductParts = new System.Windows.Forms.Button();
            this.searchProductPartsBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsInProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.partsGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.partsInProduct, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.productParts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.availableParts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(329, 25);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 539);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.labelMin, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelMax, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.labelPrice, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.labelInventory, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.labelName, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox1, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBox2, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBox3, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.textBox4, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBox5, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.textBox6, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelID, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(35, 170);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(288, 242);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMin.Location = new System.Drawing.Point(10, 210);
            this.labelMin.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(51, 22);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMax.Location = new System.Drawing.Point(10, 170);
            this.labelMax.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(51, 20);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Max";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Location = new System.Drawing.Point(10, 130);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(51, 20);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInventory.Location = new System.Drawing.Point(10, 90);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(51, 20);
            this.labelInventory.TabIndex = 8;
            this.labelInventory.Text = "Inventory";
            this.labelInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(10, 50);
            this.labelName.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(51, 20);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox1.Location = new System.Drawing.Point(64, 10);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox2.Location = new System.Drawing.Point(64, 50);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(221, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox3.Location = new System.Drawing.Point(64, 90);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(221, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox4.Location = new System.Drawing.Point(64, 130);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(221, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.SystemColors.Window;
            this.textBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox5.Location = new System.Drawing.Point(64, 170);
            this.textBox5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(221, 20);
            this.textBox5.TabIndex = 4;
            // 
            // textBox6
            // 
            this.textBox6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox6.Location = new System.Drawing.Point(64, 210);
            this.textBox6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 10);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(221, 20);
            this.textBox6.TabIndex = 5;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(10, 10);
            this.labelID.Margin = new System.Windows.Forms.Padding(10, 10, 0, 10);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(51, 20);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // partsGrid
            // 
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsGrid.Location = new System.Drawing.Point(3, 73);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.Size = new System.Drawing.Size(651, 173);
            this.partsGrid.TabIndex = 0;
            // 
            // partsInProduct
            // 
            this.partsInProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsInProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsInProduct.Location = new System.Drawing.Point(3, 312);
            this.partsInProduct.Name = "partsInProduct";
            this.partsInProduct.Size = new System.Drawing.Size(651, 173);
            this.partsInProduct.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.partAddProduct);
            this.panel1.Controls.Add(this.partRemoveProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 252);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(651, 34);
            this.panel1.TabIndex = 2;
            // 
            // partRemoveProduct
            // 
            this.partRemoveProduct.AutoSize = true;
            this.partRemoveProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partRemoveProduct.Location = new System.Drawing.Point(310, 4);
            this.partRemoveProduct.Name = "partRemoveProduct";
            this.partRemoveProduct.Size = new System.Drawing.Size(23, 23);
            this.partRemoveProduct.TabIndex = 0;
            this.partRemoveProduct.Text = "↑";
            this.partRemoveProduct.UseVisualStyleBackColor = true;
            // 
            // partAddProduct
            // 
            this.partAddProduct.AutoSize = true;
            this.partAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partAddProduct.Location = new System.Drawing.Point(339, 4);
            this.partAddProduct.Name = "partAddProduct";
            this.partAddProduct.Size = new System.Drawing.Size(23, 23);
            this.partAddProduct.TabIndex = 1;
            this.partAddProduct.Text = "↓";
            this.partAddProduct.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmProduct);
            this.panel2.Controls.Add(this.cancelProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 491);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(651, 45);
            this.panel2.TabIndex = 3;
            // 
            // cancelProduct
            // 
            this.cancelProduct.Location = new System.Drawing.Point(573, 19);
            this.cancelProduct.Name = "cancelProduct";
            this.cancelProduct.Size = new System.Drawing.Size(75, 23);
            this.cancelProduct.TabIndex = 0;
            this.cancelProduct.Text = "Cancel";
            this.cancelProduct.UseVisualStyleBackColor = true;
            // 
            // confirmProduct
            // 
            this.confirmProduct.Location = new System.Drawing.Point(492, 19);
            this.confirmProduct.Name = "confirmProduct";
            this.confirmProduct.Size = new System.Drawing.Size(75, 23);
            this.confirmProduct.TabIndex = 1;
            this.confirmProduct.Text = "Confirm";
            this.confirmProduct.UseVisualStyleBackColor = true;
            // 
            // productFormType
            // 
            this.productFormType.AutoSize = true;
            this.productFormType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFormType.Location = new System.Drawing.Point(35, 25);
            this.productFormType.Name = "productFormType";
            this.productFormType.Size = new System.Drawing.Size(120, 25);
            this.productFormType.TabIndex = 2;
            this.productFormType.Text = "Add Product";
            // 
            // productParts
            // 
            this.productParts.AutoSize = true;
            this.productParts.Location = new System.Drawing.Point(3, 289);
            this.productParts.Name = "productParts";
            this.productParts.Size = new System.Drawing.Size(139, 13);
            this.productParts.TabIndex = 4;
            this.productParts.Text = "Associated parts for product";
            // 
            // availableParts
            // 
            this.availableParts.AutoSize = true;
            this.availableParts.Location = new System.Drawing.Point(3, 50);
            this.availableParts.Name = "availableParts";
            this.availableParts.Size = new System.Drawing.Size(180, 13);
            this.availableParts.TabIndex = 5;
            this.availableParts.Text = "Parts in system ready for association.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchProductPartsBox);
            this.panel3.Controls.Add(this.searchProductParts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(651, 44);
            this.panel3.TabIndex = 6;
            // 
            // searchProductParts
            // 
            this.searchProductParts.Location = new System.Drawing.Point(310, 13);
            this.searchProductParts.Name = "searchProductParts";
            this.searchProductParts.Size = new System.Drawing.Size(75, 23);
            this.searchProductParts.TabIndex = 0;
            this.searchProductParts.Text = "Search";
            this.searchProductParts.UseVisualStyleBackColor = true;
            // 
            // searchProductPartsBox
            // 
            this.searchProductPartsBox.Location = new System.Drawing.Point(391, 16);
            this.searchProductPartsBox.Name = "searchProductPartsBox";
            this.searchProductPartsBox.Size = new System.Drawing.Size(257, 20);
            this.searchProductPartsBox.TabIndex = 1;
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 588);
            this.Controls.Add(this.productFormType);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "productForm";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsInProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label labelMin;
        private System.Windows.Forms.Label labelMax;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.DataGridView partsInProduct;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button partAddProduct;
        private System.Windows.Forms.Button partRemoveProduct;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button confirmProduct;
        private System.Windows.Forms.Button cancelProduct;
        public System.Windows.Forms.Label productFormType;
        private System.Windows.Forms.Label productParts;
        private System.Windows.Forms.Label availableParts;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox searchProductPartsBox;
        private System.Windows.Forms.Button searchProductParts;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}