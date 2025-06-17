namespace WinFormsApp.Admin_App.Forms
{
    partial class EditItemForm
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
            btnCancel = new Button();
            btnSave = new Button();
            lblLMD = new Label();
            txtDescription = new TextBox();
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
            SuspendLayout();
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(263, 473);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 34);
            btnCancel.TabIndex = 43;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // lblLMD
            // 
            lblLMD.AutoSize = true;
            lblLMD.Location = new Point(51, 425);
            lblLMD.Name = "lblLMD";
            lblLMD.Size = new Size(149, 20);
            lblLMD.TabIndex = 41;
            lblLMD.Text = "Last Modified Time";
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(51, 310);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(312, 90);
            txtDescription.TabIndex = 40;
            // 
            // txtLMD
            // 
            txtLMD.Location = new Point(212, 418);
            txtLMD.Name = "txtLMD";
            txtLMD.Size = new Size(151, 27);
            txtLMD.TabIndex = 39;
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(51, 287);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 38;
            lblDescription.Text = "Description";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(212, 237);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(151, 27);
            txtStock.TabIndex = 37;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(212, 187);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 36;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(212, 140);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(151, 28);
            comboBox2.TabIndex = 35;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(212, 78);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 34;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(51, 244);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 20);
            lblStock.TabIndex = 33;
            lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(51, 194);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 20);
            lblPrice.TabIndex = 32;
            lblPrice.Text = "Price (NZD)";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(51, 140);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 31;
            lblType.Text = "Type";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(51, 81);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 20);
            lblBrand.TabIndex = 30;
            lblBrand.Text = "Brand";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(51, 26);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 29;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(212, 26);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 28;
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(426, 534);
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
            Name = "EditItemForm";
            Text = "EditItemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancel;
        private Button btnSave;
        private Label lblLMD;
        private TextBox txtDescription;
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
    }
}