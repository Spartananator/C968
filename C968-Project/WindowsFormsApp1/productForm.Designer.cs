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
            this.partsAvailableGrid = new System.Windows.Forms.DataGridView();
            this.partsInProduct = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partAddProduct = new System.Windows.Forms.Button();
            this.partRemoveProduct = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.confirmProduct = new System.Windows.Forms.Button();
            this.cancelProduct = new System.Windows.Forms.Button();
            this.productParts = new System.Windows.Forms.Label();
            this.availableParts = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.searchProductPartsBox = new System.Windows.Forms.TextBox();
            this.searchProductParts = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.labelMin = new System.Windows.Forms.Label();
            this.labelMax = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelInventory = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.idBox = new System.Windows.Forms.TextBox();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.inventoryBox = new System.Windows.Forms.TextBox();
            this.costBox = new System.Windows.Forms.TextBox();
            this.maxBox = new System.Windows.Forms.TextBox();
            this.minBox = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.productFormType = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsAvailableGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsInProduct)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.partsAvailableGrid, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.partsInProduct, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.productParts, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.availableParts, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(439, 31);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(876, 663);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // partsAvailableGrid
            // 
            this.partsAvailableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsAvailableGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsAvailableGrid.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsAvailableGrid.Location = new System.Drawing.Point(4, 91);
            this.partsAvailableGrid.Margin = new System.Windows.Forms.Padding(4);
            this.partsAvailableGrid.MultiSelect = false;
            this.partsAvailableGrid.Name = "partsAvailableGrid";
            this.partsAvailableGrid.ReadOnly = true;
            this.partsAvailableGrid.RowHeadersWidth = 51;
            this.partsAvailableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsAvailableGrid.Size = new System.Drawing.Size(868, 212);
            this.partsAvailableGrid.TabIndex = 0;
            // 
            // partsInProduct
            // 
            this.partsInProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsInProduct.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsInProduct.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.partsInProduct.Location = new System.Drawing.Point(4, 385);
            this.partsInProduct.Margin = new System.Windows.Forms.Padding(4);
            this.partsInProduct.Name = "partsInProduct";
            this.partsInProduct.ReadOnly = true;
            this.partsInProduct.RowHeadersWidth = 51;
            this.partsInProduct.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsInProduct.Size = new System.Drawing.Size(868, 212);
            this.partsInProduct.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.partAddProduct);
            this.panel1.Controls.Add(this.partRemoveProduct);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(4, 311);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(868, 41);
            this.panel1.TabIndex = 2;
            // 
            // partAddProduct
            // 
            this.partAddProduct.AutoSize = true;
            this.partAddProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partAddProduct.Location = new System.Drawing.Point(452, 5);
            this.partAddProduct.Margin = new System.Windows.Forms.Padding(4);
            this.partAddProduct.Name = "partAddProduct";
            this.partAddProduct.Size = new System.Drawing.Size(24, 26);
            this.partAddProduct.TabIndex = 1;
            this.partAddProduct.Text = "↓";
            this.partAddProduct.UseVisualStyleBackColor = true;
            this.partAddProduct.Click += new System.EventHandler(this.partAddProduct_Click);
            // 
            // partRemoveProduct
            // 
            this.partRemoveProduct.AutoSize = true;
            this.partRemoveProduct.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.partRemoveProduct.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.partRemoveProduct.Location = new System.Drawing.Point(413, 5);
            this.partRemoveProduct.Margin = new System.Windows.Forms.Padding(4);
            this.partRemoveProduct.Name = "partRemoveProduct";
            this.partRemoveProduct.Size = new System.Drawing.Size(24, 26);
            this.partRemoveProduct.TabIndex = 0;
            this.partRemoveProduct.Text = "↑";
            this.partRemoveProduct.UseVisualStyleBackColor = true;
            this.partRemoveProduct.Click += new System.EventHandler(this.partRemoveProduct_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.confirmProduct);
            this.panel2.Controls.Add(this.cancelProduct);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 605);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(868, 54);
            this.panel2.TabIndex = 3;
            // 
            // confirmProduct
            // 
            this.confirmProduct.Location = new System.Drawing.Point(656, 23);
            this.confirmProduct.Margin = new System.Windows.Forms.Padding(4);
            this.confirmProduct.Name = "confirmProduct";
            this.confirmProduct.Size = new System.Drawing.Size(100, 28);
            this.confirmProduct.TabIndex = 1;
            this.confirmProduct.Text = "Confirm";
            this.confirmProduct.UseVisualStyleBackColor = true;
            this.confirmProduct.Click += new System.EventHandler(this.confirmProduct_Click);
            // 
            // cancelProduct
            // 
            this.cancelProduct.Location = new System.Drawing.Point(764, 23);
            this.cancelProduct.Margin = new System.Windows.Forms.Padding(4);
            this.cancelProduct.Name = "cancelProduct";
            this.cancelProduct.Size = new System.Drawing.Size(100, 28);
            this.cancelProduct.TabIndex = 0;
            this.cancelProduct.Text = "Cancel";
            this.cancelProduct.UseVisualStyleBackColor = true;
            this.cancelProduct.Click += new System.EventHandler(this.cancelProduct_Click);
            // 
            // productParts
            // 
            this.productParts.AutoSize = true;
            this.productParts.Location = new System.Drawing.Point(4, 356);
            this.productParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productParts.Name = "productParts";
            this.productParts.Size = new System.Drawing.Size(174, 16);
            this.productParts.TabIndex = 4;
            this.productParts.Text = "Associated parts for product";
            // 
            // availableParts
            // 
            this.availableParts.AutoSize = true;
            this.availableParts.Location = new System.Drawing.Point(4, 62);
            this.availableParts.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.availableParts.Name = "availableParts";
            this.availableParts.Size = new System.Drawing.Size(228, 16);
            this.availableParts.TabIndex = 5;
            this.availableParts.Text = "Parts in system ready for association.";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.searchProductPartsBox);
            this.panel3.Controls.Add(this.searchProductParts);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(4, 4);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(868, 54);
            this.panel3.TabIndex = 6;
            // 
            // searchProductPartsBox
            // 
            this.searchProductPartsBox.Location = new System.Drawing.Point(521, 20);
            this.searchProductPartsBox.Margin = new System.Windows.Forms.Padding(4);
            this.searchProductPartsBox.Name = "searchProductPartsBox";
            this.searchProductPartsBox.Size = new System.Drawing.Size(341, 22);
            this.searchProductPartsBox.TabIndex = 1;
            this.searchProductPartsBox.TextChanged += new System.EventHandler(this.searchProductPartsBox_TextChanged);
            // 
            // searchProductParts
            // 
            this.searchProductParts.Location = new System.Drawing.Point(413, 16);
            this.searchProductParts.Margin = new System.Windows.Forms.Padding(4);
            this.searchProductParts.Name = "searchProductParts";
            this.searchProductParts.Size = new System.Drawing.Size(100, 28);
            this.searchProductParts.TabIndex = 0;
            this.searchProductParts.Text = "Search";
            this.searchProductParts.UseVisualStyleBackColor = true;
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
            this.tableLayoutPanel2.Controls.Add(this.idBox, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.nameBox, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.inventoryBox, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.costBox, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.maxBox, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.minBox, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.labelID, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(47, 209);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 6;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel2.Size = new System.Drawing.Size(384, 298);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // labelMin
            // 
            this.labelMin.AutoSize = true;
            this.labelMin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMin.Location = new System.Drawing.Point(13, 242);
            this.labelMin.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelMin.Name = "labelMin";
            this.labelMin.Size = new System.Drawing.Size(61, 44);
            this.labelMin.TabIndex = 11;
            this.labelMin.Text = "Min";
            this.labelMin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelMax
            // 
            this.labelMax.AutoSize = true;
            this.labelMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMax.Location = new System.Drawing.Point(13, 196);
            this.labelMax.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelMax.Name = "labelMax";
            this.labelMax.Size = new System.Drawing.Size(61, 22);
            this.labelMax.TabIndex = 10;
            this.labelMax.Text = "Max";
            this.labelMax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPrice.Location = new System.Drawing.Point(13, 150);
            this.labelPrice.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(61, 22);
            this.labelPrice.TabIndex = 9;
            this.labelPrice.Text = "Price";
            this.labelPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelInventory.Location = new System.Drawing.Point(13, 104);
            this.labelInventory.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(61, 22);
            this.labelInventory.TabIndex = 8;
            this.labelInventory.Text = "Inventory";
            this.labelInventory.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelName.Location = new System.Drawing.Point(13, 58);
            this.labelName.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(61, 22);
            this.labelName.TabIndex = 7;
            this.labelName.Text = "Name";
            this.labelName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // idBox
            // 
            this.idBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.idBox.Enabled = false;
            this.idBox.Location = new System.Drawing.Point(78, 12);
            this.idBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.idBox.Name = "idBox";
            this.idBox.Size = new System.Drawing.Size(302, 22);
            this.idBox.TabIndex = 0;
            // 
            // nameBox
            // 
            this.nameBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.nameBox.Location = new System.Drawing.Point(78, 58);
            this.nameBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(302, 22);
            this.nameBox.TabIndex = 1;
            // 
            // inventoryBox
            // 
            this.inventoryBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.inventoryBox.Location = new System.Drawing.Point(78, 104);
            this.inventoryBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.inventoryBox.Name = "inventoryBox";
            this.inventoryBox.Size = new System.Drawing.Size(302, 22);
            this.inventoryBox.TabIndex = 2;
            // 
            // costBox
            // 
            this.costBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.costBox.Location = new System.Drawing.Point(78, 150);
            this.costBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.costBox.Name = "costBox";
            this.costBox.Size = new System.Drawing.Size(302, 22);
            this.costBox.TabIndex = 3;
            // 
            // maxBox
            // 
            this.maxBox.BackColor = System.Drawing.SystemColors.Window;
            this.maxBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.maxBox.Location = new System.Drawing.Point(78, 196);
            this.maxBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.maxBox.Name = "maxBox";
            this.maxBox.Size = new System.Drawing.Size(302, 22);
            this.maxBox.TabIndex = 4;
            // 
            // minBox
            // 
            this.minBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minBox.Location = new System.Drawing.Point(78, 242);
            this.minBox.Margin = new System.Windows.Forms.Padding(4, 12, 4, 12);
            this.minBox.Name = "minBox";
            this.minBox.Size = new System.Drawing.Size(302, 22);
            this.minBox.TabIndex = 5;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelID.Location = new System.Drawing.Point(13, 12);
            this.labelID.Margin = new System.Windows.Forms.Padding(13, 12, 0, 12);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(61, 22);
            this.labelID.TabIndex = 6;
            this.labelID.Text = "ID";
            this.labelID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // productFormType
            // 
            this.productFormType.AutoSize = true;
            this.productFormType.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productFormType.Location = new System.Drawing.Point(47, 31);
            this.productFormType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.productFormType.Name = "productFormType";
            this.productFormType.Size = new System.Drawing.Size(152, 29);
            this.productFormType.TabIndex = 2;
            this.productFormType.Text = "Add Product";
            // 
            // productForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1356, 724);
            this.Controls.Add(this.productFormType);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "productForm";
            this.Text = "Form2";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsAvailableGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partsInProduct)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
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
        private System.Windows.Forms.TextBox idBox;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.TextBox inventoryBox;
        private System.Windows.Forms.TextBox costBox;
        private System.Windows.Forms.TextBox maxBox;
        private System.Windows.Forms.TextBox minBox;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.DataGridView partsAvailableGrid;
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