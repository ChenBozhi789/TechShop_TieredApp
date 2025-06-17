namespace DataAccessLayer.Models.Admin_App.Forms
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
            cmbType = new ComboBox();
            cmbBrand = new ComboBox();
            lblStock = new Label();
            lblPrice = new Label();
            lblType = new Label();
            lblBrand = new Label();
            lblName = new Label();
            txtName = new TextBox();
            label1 = new Label();
            lblLaptop = new Label();
            lblDesktop = new Label();
            txtMemory = new TextBox();
            lblMemory = new Label();
            txtCoolSystem = new TextBox();
            txtPower = new TextBox();
            txtTowerSize = new TextBox();
            txtWeight = new TextBox();
            txtBatteryLife = new TextBox();
            txtGPU = new TextBox();
            txtCPU = new TextBox();
            lblCoolSystem = new Label();
            lblPower = new Label();
            lblTowerSize = new Label();
            lblWeight = new Label();
            lblBatteryLife = new Label();
            lblGPU = new Label();
            lblCPU = new Label();
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
            btnCancel.Click += btnCancel_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(144, 473);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 42;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
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
            txtDescription.Size = new Size(441, 90);
            txtDescription.TabIndex = 40;
            // 
            // txtLMD
            // 
            txtLMD.Location = new Point(212, 418);
            txtLMD.Name = "txtLMD";
            txtLMD.Size = new Size(280, 27);
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
            txtStock.Location = new Point(169, 234);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(323, 27);
            txtStock.TabIndex = 37;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(169, 184);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(323, 27);
            txtPrice.TabIndex = 36;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(169, 137);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(323, 28);
            cmbType.TabIndex = 35;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(169, 75);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(323, 28);
            cmbBrand.TabIndex = 34;
            cmbBrand.SelectedIndexChanged += cmbBrand_SelectedIndexChanged;
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
            txtName.Location = new Point(169, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(323, 27);
            txtName.TabIndex = 28;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            label1.Location = new Point(540, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 26);
            label1.TabIndex = 65;
            label1.Text = "Deatils";
            // 
            // lblLaptop
            // 
            lblLaptop.AutoSize = true;
            lblLaptop.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblLaptop.Location = new Point(540, 200);
            lblLaptop.Name = "lblLaptop";
            lblLaptop.Size = new Size(69, 24);
            lblLaptop.TabIndex = 64;
            lblLaptop.Text = "Laptop";
            // 
            // lblDesktop
            // 
            lblDesktop.AutoSize = true;
            lblDesktop.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblDesktop.Location = new Point(540, 341);
            lblDesktop.Name = "lblDesktop";
            lblDesktop.Size = new Size(80, 24);
            lblDesktop.TabIndex = 63;
            lblDesktop.Text = "Desktop";
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(630, 154);
            txtMemory.Name = "txtMemory";
            txtMemory.Size = new Size(151, 27);
            txtMemory.TabIndex = 62;
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Location = new Point(540, 153);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(71, 20);
            lblMemory.TabIndex = 61;
            lblMemory.Text = "Memory";
            // 
            // txtCoolSystem
            // 
            txtCoolSystem.Location = new Point(665, 479);
            txtCoolSystem.Name = "txtCoolSystem";
            txtCoolSystem.Size = new Size(151, 27);
            txtCoolSystem.TabIndex = 60;
            // 
            // txtPower
            // 
            txtPower.Location = new Point(721, 435);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(151, 27);
            txtPower.TabIndex = 59;
            // 
            // txtTowerSize
            // 
            txtTowerSize.Location = new Point(633, 385);
            txtTowerSize.Name = "txtTowerSize";
            txtTowerSize.Size = new Size(151, 27);
            txtTowerSize.TabIndex = 58;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(630, 292);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(151, 27);
            txtWeight.TabIndex = 57;
            // 
            // txtBatteryLife
            // 
            txtBatteryLife.Location = new Point(633, 244);
            txtBatteryLife.Name = "txtBatteryLife";
            txtBatteryLife.Size = new Size(151, 27);
            txtBatteryLife.TabIndex = 56;
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(630, 108);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(151, 27);
            txtGPU.TabIndex = 55;
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(630, 56);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(151, 27);
            txtCPU.TabIndex = 54;
            // 
            // lblCoolSystem
            // 
            lblCoolSystem.AutoSize = true;
            lblCoolSystem.Location = new Point(540, 482);
            lblCoolSystem.Name = "lblCoolSystem";
            lblCoolSystem.Size = new Size(123, 20);
            lblCoolSystem.TabIndex = 53;
            lblCoolSystem.Text = "Cooling System";
            // 
            // lblPower
            // 
            lblPower.AutoSize = true;
            lblPower.Location = new Point(540, 435);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(175, 20);
            lblPower.TabIndex = 52;
            lblPower.Text = "Power Supply Wattage";
            // 
            // lblTowerSize
            // 
            lblTowerSize.AutoSize = true;
            lblTowerSize.Location = new Point(540, 388);
            lblTowerSize.Name = "lblTowerSize";
            lblTowerSize.Size = new Size(88, 20);
            lblTowerSize.TabIndex = 51;
            lblTowerSize.Text = "Tower Size";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(540, 294);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(62, 20);
            lblWeight.TabIndex = 50;
            lblWeight.Text = "Weight";
            // 
            // lblBatteryLife
            // 
            lblBatteryLife.AutoSize = true;
            lblBatteryLife.Location = new Point(540, 247);
            lblBatteryLife.Name = "lblBatteryLife";
            lblBatteryLife.Size = new Size(91, 20);
            lblBatteryLife.TabIndex = 49;
            lblBatteryLife.Text = "Battery Life";
            // 
            // lblGPU
            // 
            lblGPU.AutoSize = true;
            lblGPU.Location = new Point(540, 106);
            lblGPU.Name = "lblGPU";
            lblGPU.Size = new Size(40, 20);
            lblGPU.TabIndex = 48;
            lblGPU.Text = "GPU";
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(540, 59);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(39, 20);
            lblCPU.TabIndex = 47;
            lblCPU.Text = "CPU";
            // 
            // EditItemForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 534);
            Controls.Add(label1);
            Controls.Add(lblLaptop);
            Controls.Add(lblDesktop);
            Controls.Add(txtMemory);
            Controls.Add(lblMemory);
            Controls.Add(txtCoolSystem);
            Controls.Add(txtPower);
            Controls.Add(txtTowerSize);
            Controls.Add(txtWeight);
            Controls.Add(txtBatteryLife);
            Controls.Add(txtGPU);
            Controls.Add(txtCPU);
            Controls.Add(lblCoolSystem);
            Controls.Add(lblPower);
            Controls.Add(lblTowerSize);
            Controls.Add(lblWeight);
            Controls.Add(lblBatteryLife);
            Controls.Add(lblGPU);
            Controls.Add(lblCPU);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblLMD);
            Controls.Add(txtDescription);
            Controls.Add(txtLMD);
            Controls.Add(lblDescription);
            Controls.Add(txtStock);
            Controls.Add(txtPrice);
            Controls.Add(cmbType);
            Controls.Add(cmbBrand);
            Controls.Add(lblStock);
            Controls.Add(lblPrice);
            Controls.Add(lblType);
            Controls.Add(lblBrand);
            Controls.Add(lblName);
            Controls.Add(txtName);
            Name = "EditItemForm";
            Text = "EditItemForm";
            Load += EditItemForm_Load;
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
        private ComboBox cmbType;
        private ComboBox cmbBrand;
        private Label lblStock;
        private Label lblPrice;
        private Label lblType;
        private Label lblBrand;
        private Label lblName;
        private TextBox txtName;
        private Label label1;
        private Label lblLaptop;
        private Label lblDesktop;
        private TextBox txtMemory;
        private Label lblMemory;
        private TextBox txtCoolSystem;
        private TextBox txtPower;
        private TextBox txtTowerSize;
        private TextBox txtWeight;
        private TextBox txtBatteryLife;
        private TextBox txtGPU;
        private TextBox txtCPU;
        private Label lblCoolSystem;
        private Label lblPower;
        private Label lblTowerSize;
        private Label lblWeight;
        private Label lblBatteryLife;
        private Label lblGPU;
        private Label lblCPU;
    }
}