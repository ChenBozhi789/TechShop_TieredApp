namespace WinFormsApp.Admin_App.Forms
{
    partial class AddItemForm
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
            txtLMD = new TextBox();
            lblDescription = new Label();
            txtStock = new TextBox();
            txtPrice = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            lblStock = new Label();
            lblPrice = new Label();
            lblType = new Label();
            lblBrand = new Label();
            lblName = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            lblLMD = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // txtLMD
            // 
            txtLMD.Location = new Point(220, 426);
            txtLMD.Name = "txtLMD";
            txtLMD.Size = new Size(151, 27);
            txtLMD.TabIndex = 23;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(59, 295);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(220, 245);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(151, 27);
            txtStock.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(220, 195);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 20;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(220, 148);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 19;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(220, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 18;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(59, 252);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 20);
            lblStock.TabIndex = 17;
            lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(59, 202);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 20);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price (NZD)";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(59, 148);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 15;
            lblType.Text = "Type";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(59, 89);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 20);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(59, 34);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(220, 34);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 12;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(59, 318);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(312, 90);
            txtDescription.TabIndex = 24;
            // 
            // lblLMD
            // 
            lblLMD.AutoSize = true;
            lblLMD.Location = new Point(59, 433);
            lblLMD.Name = "lblLMD";
            lblLMD.Size = new Size(149, 20);
            lblLMD.TabIndex = 25;
            lblLMD.Text = "Last Modified Time";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(152, 481);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(271, 481);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 34);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(432, 527);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblLMD);
            Controls.Add(txtDescription);
            Controls.Add(txtLMD);
            Controls.Add(lblDescription);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblType);
            Controls.Add(lblBrand);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "AddItemForm";
            Text = "AddItemForm";
            Load += AddItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtLMD;
        private Label lblDescription;
        private TextBox txtStock;
        private TextBox txtPrice;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label lblStock;
        private Label lblPrice;
        private Label lblType;
        private Label lblBrand;
        private Label lblName;
        private TextBox txtName;
        private TextBox txtDescription;
        private Label lblLMD;
        private Button btnSave;
        private Button btnCancel;
    }
}