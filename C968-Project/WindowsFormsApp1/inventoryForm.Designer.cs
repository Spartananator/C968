namespace WindowsFormsApp1
{
    partial class inventoryForm
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
            this.exitApp = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.productAdd = new System.Windows.Forms.Button();
            this.productModify = new System.Windows.Forms.Button();
            this.productDelete = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.partsAdd = new System.Windows.Forms.Button();
            this.partsModify = new System.Windows.Forms.Button();
            this.partsDelete = new System.Windows.Forms.Button();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.productsGrid = new System.Windows.Forms.DataGridView();
            this.productID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productInventory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partsLabel = new System.Windows.Forms.Label();
            this.productsLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // exitApp
            // 
            this.exitApp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.exitApp.Location = new System.Drawing.Point(1225, 524);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(75, 23);
            this.exitApp.TabIndex = 8;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.9716F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.056807F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.9716F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.partsGrid, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.productsGrid, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.partsLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.productsLabel, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(35, 32);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1265, 486);
            this.tableLayoutPanel1.TabIndex = 13;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.productAdd);
            this.panel2.Controls.Add(this.productModify);
            this.panel2.Controls.Add(this.productDelete);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(648, 459);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 24);
            this.panel2.TabIndex = 14;
            // 
            // productAdd
            // 
            this.productAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productAdd.Location = new System.Drawing.Point(374, 0);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(75, 23);
            this.productAdd.TabIndex = 10;
            this.productAdd.Text = "Add";
            this.productAdd.UseVisualStyleBackColor = true;
            this.productAdd.Click += new System.EventHandler(this.productAdd_Click);
            // 
            // productModify
            // 
            this.productModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productModify.Location = new System.Drawing.Point(455, 0);
            this.productModify.Name = "productModify";
            this.productModify.Size = new System.Drawing.Size(75, 23);
            this.productModify.TabIndex = 9;
            this.productModify.Text = "Modify";
            this.productModify.UseVisualStyleBackColor = true;
            this.productModify.Click += new System.EventHandler(this.productModify_Click);
            // 
            // productDelete
            // 
            this.productDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.productDelete.Location = new System.Drawing.Point(536, 0);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(75, 23);
            this.productDelete.TabIndex = 8;
            this.productDelete.Text = "Delete";
            this.productDelete.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.partsAdd);
            this.panel1.Controls.Add(this.partsModify);
            this.panel1.Controls.Add(this.partsDelete);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 24);
            this.panel1.TabIndex = 16;
            // 
            // partsAdd
            // 
            this.partsAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partsAdd.Location = new System.Drawing.Point(373, 0);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(75, 23);
            this.partsAdd.TabIndex = 7;
            this.partsAdd.Text = "Add";
            this.partsAdd.UseVisualStyleBackColor = true;
            this.partsAdd.Click += new System.EventHandler(this.partsAdd_Click);
            // 
            // partsModify
            // 
            this.partsModify.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partsModify.Location = new System.Drawing.Point(454, 0);
            this.partsModify.Name = "partsModify";
            this.partsModify.Size = new System.Drawing.Size(75, 23);
            this.partsModify.TabIndex = 6;
            this.partsModify.Text = "Modify";
            this.partsModify.UseVisualStyleBackColor = true;
            this.partsModify.Click += new System.EventHandler(this.partsModify_Click);
            // 
            // partsDelete
            // 
            this.partsDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.partsDelete.Location = new System.Drawing.Point(535, 0);
            this.partsDelete.Name = "partsDelete";
            this.partsDelete.Size = new System.Drawing.Size(75, 23);
            this.partsDelete.TabIndex = 5;
            this.partsDelete.Text = "Delete";
            this.partsDelete.UseVisualStyleBackColor = true;
            // 
            // partsGrid
            // 
            this.partsGrid.AllowUserToAddRows = false;
            this.partsGrid.AllowUserToDeleteRows = false;
            this.partsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.partsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Location = new System.Drawing.Point(3, 48);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.RowHeadersVisible = false;
            this.partsGrid.RowHeadersWidth = 51;
            this.partsGrid.RowTemplate.Height = 24;
            this.partsGrid.Size = new System.Drawing.Size(613, 405);
            this.partsGrid.TabIndex = 13;
            // 
            // productsGrid
            // 
            this.productsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.productsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.productsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productID,
            this.productName,
            this.productInventory,
            this.productPrice,
            this.productMin,
            this.productMax});
            this.productsGrid.Location = new System.Drawing.Point(648, 48);
            this.productsGrid.Name = "productsGrid";
            this.productsGrid.RowHeadersVisible = false;
            this.productsGrid.RowHeadersWidth = 51;
            this.productsGrid.RowTemplate.Height = 24;
            this.productsGrid.Size = new System.Drawing.Size(614, 405);
            this.productsGrid.TabIndex = 15;
            // 
            // productID
            // 
            this.productID.HeaderText = "Product ID";
            this.productID.MinimumWidth = 6;
            this.productID.Name = "productID";
            // 
            // productName
            // 
            this.productName.HeaderText = "Name";
            this.productName.MinimumWidth = 6;
            this.productName.Name = "productName";
            // 
            // productInventory
            // 
            this.productInventory.HeaderText = "Inventory";
            this.productInventory.MinimumWidth = 6;
            this.productInventory.Name = "productInventory";
            // 
            // productPrice
            // 
            this.productPrice.HeaderText = "Price";
            this.productPrice.MinimumWidth = 6;
            this.productPrice.Name = "productPrice";
            // 
            // productMin
            // 
            this.productMin.HeaderText = "Min";
            this.productMin.MinimumWidth = 6;
            this.productMin.Name = "productMin";
            // 
            // productMax
            // 
            this.productMax.HeaderText = "Max";
            this.productMax.MinimumWidth = 6;
            this.productMax.Name = "productMax";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(3, 0);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(613, 45);
            this.partsLabel.TabIndex = 17;
            this.partsLabel.Text = "Parts";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(648, 0);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(614, 45);
            this.productsLabel.TabIndex = 18;
            this.productsLabel.Text = "Products";
            this.productsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // inventoryForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1339, 563);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.exitApp);
            this.Name = "inventoryForm";
            this.Text = "Inventory";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.DataGridView productsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn productID;
        private System.Windows.Forms.DataGridViewTextBoxColumn productName;
        private System.Windows.Forms.DataGridViewTextBoxColumn productInventory;
        private System.Windows.Forms.DataGridViewTextBoxColumn productPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn productMax;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button partsModify;
        private System.Windows.Forms.Button partsDelete;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button productAdd;
        private System.Windows.Forms.Button productModify;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label productsLabel;
    }
}

