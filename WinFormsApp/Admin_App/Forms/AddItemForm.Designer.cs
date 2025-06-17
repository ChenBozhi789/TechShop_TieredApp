namespace DataAccessLayer.Models.Admin_App.Forms
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
            txtDescription = new TextBox();
            lblLMD = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            lblCPU = new Label();
            lblGPU = new Label();
            lblBatteryLife = new Label();
            lblWeight = new Label();
            lblCoolSystem = new Label();
            lblPower = new Label();
            lblTowerSize = new Label();
            txtCPU = new TextBox();
            txtGPU = new TextBox();
            txtBatteryLife = new TextBox();
            txtWeight = new TextBox();
            txtTowerSize = new TextBox();
            txtPower = new TextBox();
            txtCoolSystem = new TextBox();
            lblMemory = new Label();
            txtMemory = new TextBox();
            lblDesktop = new Label();
            lblLaptop = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // lblDescription
            // 
            lblDescription.AutoSize = true;
            lblDescription.Location = new Point(57, 280);
            lblDescription.Name = "lblDescription";
            lblDescription.Size = new Size(93, 20);
            lblDescription.TabIndex = 22;
            lblDescription.Text = "Description";
            // 
            // txtStock
            // 
            txtStock.Location = new Point(218, 230);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(151, 27);
            txtStock.TabIndex = 21;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(218, 180);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(151, 27);
            txtPrice.TabIndex = 20;
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Location = new Point(218, 133);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(151, 28);
            cmbType.TabIndex = 19;
            cmbType.SelectedIndexChanged += cmbType_SelectedIndexChanged;
            // 
            // cmbBrand
            // 
            cmbBrand.FormattingEnabled = true;
            cmbBrand.Location = new Point(218, 70);
            cmbBrand.Name = "cmbBrand";
            cmbBrand.Size = new Size(151, 28);
            cmbBrand.TabIndex = 18;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(57, 237);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(50, 20);
            lblStock.TabIndex = 17;
            lblStock.Text = "Stock";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(57, 187);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(91, 20);
            lblPrice.TabIndex = 16;
            lblPrice.Text = "Price (NZD)";
            // 
            // lblType
            // 
            lblType.AutoSize = true;
            lblType.Location = new Point(57, 133);
            lblType.Name = "lblType";
            lblType.Size = new Size(45, 20);
            lblType.TabIndex = 15;
            lblType.Text = "Type";
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Location = new Point(57, 74);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(51, 20);
            lblBrand.TabIndex = 14;
            lblBrand.Text = "Brand";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(57, 19);
            lblName.Name = "lblName";
            lblName.Size = new Size(52, 20);
            lblName.TabIndex = 13;
            lblName.Text = "Name";
            // 
            // txtName
            // 
            txtName.Location = new Point(218, 19);
            txtName.Name = "txtName";
            txtName.Size = new Size(151, 27);
            txtName.TabIndex = 12;
            txtName.TextChanged += textBox1_TextChanged;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(57, 303);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(312, 90);
            txtDescription.TabIndex = 24;
            // 
            // lblLMD
            // 
            lblLMD.AutoSize = true;
            lblLMD.Location = new Point(57, 418);
            lblLMD.Name = "lblLMD";
            lblLMD.Size = new Size(149, 20);
            lblLMD.TabIndex = 25;
            lblLMD.Text = "Last Modified Time";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(150, 466);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 34);
            btnSave.TabIndex = 26;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(269, 466);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(100, 34);
            btnCancel.TabIndex = 27;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // lblCPU
            // 
            lblCPU.AutoSize = true;
            lblCPU.Location = new Point(431, 59);
            lblCPU.Name = "lblCPU";
            lblCPU.Size = new Size(39, 20);
            lblCPU.TabIndex = 28;
            lblCPU.Text = "CPU";
            // 
            // lblGPU
            // 
            lblGPU.AutoSize = true;
            lblGPU.Location = new Point(431, 106);
            lblGPU.Name = "lblGPU";
            lblGPU.Size = new Size(40, 20);
            lblGPU.TabIndex = 29;
            lblGPU.Text = "GPU";
            // 
            // lblBatteryLife
            // 
            lblBatteryLife.AutoSize = true;
            lblBatteryLife.Location = new Point(431, 247);
            lblBatteryLife.Name = "lblBatteryLife";
            lblBatteryLife.Size = new Size(91, 20);
            lblBatteryLife.TabIndex = 30;
            lblBatteryLife.Text = "Battery Life";
            // 
            // lblWeight
            // 
            lblWeight.AutoSize = true;
            lblWeight.Location = new Point(431, 294);
            lblWeight.Name = "lblWeight";
            lblWeight.Size = new Size(62, 20);
            lblWeight.TabIndex = 31;
            lblWeight.Text = "Weight";
            // 
            // lblCoolSystem
            // 
            lblCoolSystem.AutoSize = true;
            lblCoolSystem.Location = new Point(431, 482);
            lblCoolSystem.Name = "lblCoolSystem";
            lblCoolSystem.Size = new Size(123, 20);
            lblCoolSystem.TabIndex = 34;
            lblCoolSystem.Text = "Cooling System";
            // 
            // lblPower
            // 
            lblPower.AutoSize = true;
            lblPower.Location = new Point(431, 435);
            lblPower.Name = "lblPower";
            lblPower.Size = new Size(175, 20);
            lblPower.TabIndex = 33;
            lblPower.Text = "Power Supply Wattage";
            // 
            // lblTowerSize
            // 
            lblTowerSize.AutoSize = true;
            lblTowerSize.Location = new Point(431, 388);
            lblTowerSize.Name = "lblTowerSize";
            lblTowerSize.Size = new Size(88, 20);
            lblTowerSize.TabIndex = 32;
            lblTowerSize.Text = "Tower Size";
            // 
            // txtCPU
            // 
            txtCPU.Location = new Point(521, 56);
            txtCPU.Name = "txtCPU";
            txtCPU.Size = new Size(151, 27);
            txtCPU.TabIndex = 35;
            // 
            // txtGPU
            // 
            txtGPU.Location = new Point(521, 108);
            txtGPU.Name = "txtGPU";
            txtGPU.Size = new Size(151, 27);
            txtGPU.TabIndex = 36;
            // 
            // txtBatteryLife
            // 
            txtBatteryLife.Location = new Point(524, 244);
            txtBatteryLife.Name = "txtBatteryLife";
            txtBatteryLife.Size = new Size(151, 27);
            txtBatteryLife.TabIndex = 37;
            // 
            // txtWeight
            // 
            txtWeight.Location = new Point(521, 292);
            txtWeight.Name = "txtWeight";
            txtWeight.Size = new Size(151, 27);
            txtWeight.TabIndex = 38;
            // 
            // txtTowerSize
            // 
            txtTowerSize.Location = new Point(524, 385);
            txtTowerSize.Name = "txtTowerSize";
            txtTowerSize.Size = new Size(151, 27);
            txtTowerSize.TabIndex = 39;
            // 
            // txtPower
            // 
            txtPower.Location = new Point(612, 435);
            txtPower.Name = "txtPower";
            txtPower.Size = new Size(151, 27);
            txtPower.TabIndex = 40;
            // 
            // txtCoolSystem
            // 
            txtCoolSystem.Location = new Point(556, 479);
            txtCoolSystem.Name = "txtCoolSystem";
            txtCoolSystem.Size = new Size(151, 27);
            txtCoolSystem.TabIndex = 41;
            // 
            // lblMemory
            // 
            lblMemory.AutoSize = true;
            lblMemory.Location = new Point(431, 153);
            lblMemory.Name = "lblMemory";
            lblMemory.Size = new Size(71, 20);
            lblMemory.TabIndex = 42;
            lblMemory.Text = "Memory";
            // 
            // txtMemory
            // 
            txtMemory.Location = new Point(521, 154);
            txtMemory.Name = "txtMemory";
            txtMemory.Size = new Size(151, 27);
            txtMemory.TabIndex = 43;
            // 
            // lblDesktop
            // 
            lblDesktop.AutoSize = true;
            lblDesktop.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblDesktop.Location = new Point(431, 341);
            lblDesktop.Name = "lblDesktop";
            lblDesktop.Size = new Size(80, 24);
            lblDesktop.TabIndex = 44;
            lblDesktop.Text = "Desktop";
            // 
            // lblLaptop
            // 
            lblLaptop.AutoSize = true;
            lblLaptop.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblLaptop.Location = new Point(431, 200);
            lblLaptop.Name = "lblLaptop";
            lblLaptop.Size = new Size(69, 24);
            lblLaptop.TabIndex = 45;
            lblLaptop.Text = "Laptop";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 11F, FontStyle.Bold);
            label1.Location = new Point(431, 19);
            label1.Name = "label1";
            label1.Size = new Size(78, 26);
            label1.TabIndex = 46;
            label1.Text = "Deatils";
            // 
            // AddItemForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 523);
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
            Name = "AddItemForm";
            Text = "AddItemForm";
            Load += AddItemForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private TextBox txtDescription;
        private Label lblLMD;
        private Button btnSave;
        private Button btnCancel;
        private Label lblCPU;
        private Label lblGPU;
        private Label lblBatteryLife;
        private Label lblWeight;
        private Label lblCoolSystem;
        private Label lblPower;
        private Label lblTowerSize;
        private TextBox txtCPU;
        private TextBox txtGPU;
        private TextBox txtBatteryLife;
        private TextBox txtWeight;
        private TextBox txtTowerSize;
        private TextBox txtPower;
        private TextBox txtCoolSystem;
        private Label lblMemory;
        private TextBox txtMemory;
        private Label lblDesktop;
        private Label lblLaptop;
        private Label label1;
    }
}