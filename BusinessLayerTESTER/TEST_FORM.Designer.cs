namespace BusinessLayerTESTER
{
    partial class TEST_FORM
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label3 = new Label();
            label2 = new Label();
            txtWebsite = new TextBox();
            txtManufacturer = new TextBox();
            Description = new Label();
            label1 = new Label();
            txtCountry = new TextBox();
            txtName = new TextBox();
            btnAddBrand = new Button();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(70, 246);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 17;
            label3.Text = "Website ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(70, 138);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 16;
            label2.Text = "Manufacturer";
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(202, 246);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(125, 27);
            txtWebsite.TabIndex = 15;
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(202, 131);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(125, 27);
            txtManufacturer.TabIndex = 14;
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(110, 59);
            Description.Name = "Description";
            Description.Size = new Size(67, 20);
            Description.TabIndex = 13;
            Description.Text = "Country";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(122, 191);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 12;
            label1.Text = "Name";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(202, 59);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 11;
            // 
            // txtName
            // 
            txtName.Location = new Point(202, 183);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 10;
            // 
            // btnAddBrand
            // 
            btnAddBrand.Location = new Point(98, 342);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(167, 51);
            btnAddBrand.TabIndex = 9;
            btnAddBrand.Text = "ADD BRAND";
            btnAddBrand.UseVisualStyleBackColor = true;
            btnAddBrand.Click += btnAddBrand_Click_1;
            // 
            // TEST_FORM
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtWebsite);
            Controls.Add(txtManufacturer);
            Controls.Add(Description);
            Controls.Add(label1);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(btnAddBrand);
            Name = "TEST_FORM";
            Text = "Form1";
            Click += Form1_Click;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private TextBox txtWebsite;
        private TextBox txtManufacturer;
        private Label Description;
        private Label label1;
        private TextBox txtCountry;
        private TextBox txtName;
        private Button btnAddBrand;
    }
}
