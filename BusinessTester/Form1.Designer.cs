namespace DALTester
{
    partial class Form1
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
            btnAddBrand = new Button();
            txtName = new TextBox();
            txtCountry = new TextBox();
            label1 = new Label();
            Description = new Label();
            txtManufacturer = new TextBox();
            txtWebsite = new TextBox();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // btnAddBrand
            // 
            btnAddBrand.Location = new Point(166, 361);
            btnAddBrand.Name = "btnAddBrand";
            btnAddBrand.Size = new Size(167, 51);
            btnAddBrand.TabIndex = 0;
            btnAddBrand.Text = "ADD BRAND";
            btnAddBrand.UseVisualStyleBackColor = true;
            btnAddBrand.Click += btnAddBrand_Click;
            // 
            // txtName
            // 
            txtName.Location = new Point(270, 202);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 1;
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(270, 78);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(125, 27);
            txtCountry.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(190, 210);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 3;
            label1.Text = "Name";
            // 
            // Description
            // 
            Description.AutoSize = true;
            Description.Location = new Point(178, 78);
            Description.Name = "Description";
            Description.Size = new Size(67, 20);
            Description.TabIndex = 4;
            Description.Text = "Country";
            // 
            // txtManufacturer
            // 
            txtManufacturer.Location = new Point(270, 150);
            txtManufacturer.Name = "txtManufacturer";
            txtManufacturer.Size = new Size(125, 27);
            txtManufacturer.TabIndex = 5;
            // 
            // txtWebsite
            // 
            txtWebsite.Location = new Point(270, 265);
            txtWebsite.Name = "txtWebsite";
            txtWebsite.Size = new Size(125, 27);
            txtWebsite.TabIndex = 6;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 157);
            label2.Name = "label2";
            label2.Size = new Size(107, 20);
            label2.TabIndex = 7;
            label2.Text = "Manufacturer";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 265);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 8;
            label3.Text = "Website ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txtWebsite);
            Controls.Add(txtManufacturer);
            Controls.Add(Description);
            Controls.Add(label1);
            Controls.Add(txtCountry);
            Controls.Add(txtName);
            Controls.Add(btnAddBrand);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAddBrand;
        private TextBox txtName;
        private TextBox txtCountry;
        private Label label1;
        private Label Description;
        private TextBox txtManufacturer;
        private TextBox txtWebsite;
        private Label label2;
        private Label label3;
    }
}
