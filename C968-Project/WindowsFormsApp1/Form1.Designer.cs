namespace WindowsFormsApp1
{
    partial class Form1
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
            this.partsBox = new System.Windows.Forms.ListBox();
            this.productsBox = new System.Windows.Forms.ListBox();
            this.partsDelete = new System.Windows.Forms.Button();
            this.partsModify = new System.Windows.Forms.Button();
            this.partsAdd = new System.Windows.Forms.Button();
            this.productDelete = new System.Windows.Forms.Button();
            this.productModify = new System.Windows.Forms.Button();
            this.productAdd = new System.Windows.Forms.Button();
            this.exitApp = new System.Windows.Forms.Button();
            this.productsLabel = new System.Windows.Forms.Label();
            this.partsLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // partsBox
            // 
            this.partsBox.FormattingEnabled = true;
            this.partsBox.ItemHeight = 16;
            this.partsBox.Location = new System.Drawing.Point(12, 62);
            this.partsBox.Name = "partsBox";
            this.partsBox.Size = new System.Drawing.Size(562, 324);
            this.partsBox.TabIndex = 0;
            this.partsBox.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // productsBox
            // 
            this.productsBox.FormattingEnabled = true;
            this.productsBox.ItemHeight = 16;
            this.productsBox.Location = new System.Drawing.Point(580, 62);
            this.productsBox.Name = "productsBox";
            this.productsBox.Size = new System.Drawing.Size(562, 324);
            this.productsBox.TabIndex = 1;
            // 
            // partsDelete
            // 
            this.partsDelete.Location = new System.Drawing.Point(499, 392);
            this.partsDelete.Name = "partsDelete";
            this.partsDelete.Size = new System.Drawing.Size(75, 23);
            this.partsDelete.TabIndex = 2;
            this.partsDelete.Text = "Delete";
            this.partsDelete.UseVisualStyleBackColor = true;
            // 
            // partsModify
            // 
            this.partsModify.Location = new System.Drawing.Point(418, 392);
            this.partsModify.Name = "partsModify";
            this.partsModify.Size = new System.Drawing.Size(75, 23);
            this.partsModify.TabIndex = 3;
            this.partsModify.Text = "Modify";
            this.partsModify.UseVisualStyleBackColor = true;
            // 
            // partsAdd
            // 
            this.partsAdd.Location = new System.Drawing.Point(337, 392);
            this.partsAdd.Name = "partsAdd";
            this.partsAdd.Size = new System.Drawing.Size(75, 23);
            this.partsAdd.TabIndex = 4;
            this.partsAdd.Text = "Add";
            this.partsAdd.UseVisualStyleBackColor = true;
            // 
            // productDelete
            // 
            this.productDelete.Location = new System.Drawing.Point(1067, 392);
            this.productDelete.Name = "productDelete";
            this.productDelete.Size = new System.Drawing.Size(75, 23);
            this.productDelete.TabIndex = 5;
            this.productDelete.Text = "Delete";
            this.productDelete.UseVisualStyleBackColor = true;
            this.productDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // productModify
            // 
            this.productModify.Location = new System.Drawing.Point(986, 392);
            this.productModify.Name = "productModify";
            this.productModify.Size = new System.Drawing.Size(75, 23);
            this.productModify.TabIndex = 6;
            this.productModify.Text = "Modify";
            this.productModify.UseVisualStyleBackColor = true;
            this.productModify.Click += new System.EventHandler(this.button5_Click);
            // 
            // productAdd
            // 
            this.productAdd.Location = new System.Drawing.Point(905, 392);
            this.productAdd.Name = "productAdd";
            this.productAdd.Size = new System.Drawing.Size(75, 23);
            this.productAdd.TabIndex = 7;
            this.productAdd.Text = "Add";
            this.productAdd.UseVisualStyleBackColor = true;
            this.productAdd.Click += new System.EventHandler(this.button6_Click);
            // 
            // exitApp
            // 
            this.exitApp.Location = new System.Drawing.Point(1067, 422);
            this.exitApp.Name = "exitApp";
            this.exitApp.Size = new System.Drawing.Size(75, 23);
            this.exitApp.TabIndex = 8;
            this.exitApp.Text = "Exit";
            this.exitApp.UseVisualStyleBackColor = true;
            // 
            // productsLabel
            // 
            this.productsLabel.AutoSize = true;
            this.productsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productsLabel.Location = new System.Drawing.Point(799, 9);
            this.productsLabel.Name = "productsLabel";
            this.productsLabel.Size = new System.Drawing.Size(142, 36);
            this.productsLabel.TabIndex = 9;
            this.productsLabel.Text = "Products";
            // 
            // partsLabel
            // 
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.Location = new System.Drawing.Point(250, 9);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(89, 36);
            this.partsLabel.TabIndex = 10;
            this.partsLabel.Text = "Parts";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 471);
            this.Controls.Add(this.partsLabel);
            this.Controls.Add(this.productsLabel);
            this.Controls.Add(this.exitApp);
            this.Controls.Add(this.productAdd);
            this.Controls.Add(this.productModify);
            this.Controls.Add(this.productDelete);
            this.Controls.Add(this.partsAdd);
            this.Controls.Add(this.partsModify);
            this.Controls.Add(this.partsDelete);
            this.Controls.Add(this.productsBox);
            this.Controls.Add(this.partsBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox partsBox;
        private System.Windows.Forms.ListBox productsBox;
        private System.Windows.Forms.Button partsDelete;
        private System.Windows.Forms.Button partsModify;
        private System.Windows.Forms.Button partsAdd;
        private System.Windows.Forms.Button productDelete;
        private System.Windows.Forms.Button productModify;
        private System.Windows.Forms.Button productAdd;
        private System.Windows.Forms.Button exitApp;
        private System.Windows.Forms.Label productsLabel;
        private System.Windows.Forms.Label partsLabel;
    }
}

