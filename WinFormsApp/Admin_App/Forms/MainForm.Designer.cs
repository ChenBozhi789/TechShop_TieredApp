namespace DataAccessLayer.Models.Admin_App.Forms
{
    partial class MainForm
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
            label4 = new Label();
            label5 = new Label();
            cmbFilter = new ComboBox();
            cmbSortBy = new ComboBox();
            dataGridView = new DataGridView();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            lblManufacturer = new Label();
            lblCountry = new Label();
            lblWebsite = new Label();
            cmbSelection = new ComboBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label4.Location = new Point(391, 31);
            label4.Name = "label4";
            label4.Size = new Size(54, 19);
            label4.TabIndex = 3;
            label4.Text = "Filter: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 134);
            label5.Location = new Point(623, 31);
            label5.Name = "label5";
            label5.Size = new Size(71, 19);
            label5.TabIndex = 4;
            label5.Text = "Sort by: ";
            // 
            // cmbFilter
            // 
            cmbFilter.FormattingEnabled = true;
            cmbFilter.Location = new Point(450, 26);
            cmbFilter.Name = "cmbFilter";
            cmbFilter.Size = new Size(151, 28);
            cmbFilter.TabIndex = 5;
            // 
            // cmbSortBy
            // 
            cmbSortBy.FormattingEnabled = true;
            cmbSortBy.Location = new Point(694, 26);
            cmbSortBy.Name = "cmbSortBy";
            cmbSortBy.Size = new Size(151, 28);
            cmbSortBy.TabIndex = 6;
            cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
            // 
            // dataGridView
            // 
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Location = new Point(23, 73);
            dataGridView.Name = "dataGridView";
            dataGridView.RowHeadersWidth = 51;
            dataGridView.Size = new Size(822, 334);
            dataGridView.TabIndex = 7;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnAdd.Location = new Point(457, 426);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(108, 39);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "ADD";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnEdit.Location = new Point(597, 426);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(108, 39);
            btnEdit.TabIndex = 11;
            btnEdit.Text = "EDIT";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Microsoft YaHei UI", 9F, FontStyle.Bold);
            btnDelete.Location = new Point(737, 426);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(108, 39);
            btnDelete.TabIndex = 12;
            btnDelete.Text = "DELETE";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblManufacturer.Location = new Point(868, 73);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(127, 24);
            lblManufacturer.TabIndex = 13;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblCountry
            // 
            lblCountry.AutoSize = true;
            lblCountry.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblCountry.Location = new Point(868, 122);
            lblCountry.Name = "lblCountry";
            lblCountry.Size = new Size(78, 24);
            lblCountry.TabIndex = 14;
            lblCountry.Text = "Country";
            // 
            // lblWebsite
            // 
            lblWebsite.AutoSize = true;
            lblWebsite.Font = new Font("Microsoft YaHei UI", 10F, FontStyle.Bold);
            lblWebsite.Location = new Point(868, 165);
            lblWebsite.Name = "lblWebsite";
            lblWebsite.Size = new Size(79, 24);
            lblWebsite.TabIndex = 15;
            lblWebsite.Text = "Website";
            // 
            // cmbSelection
            // 
            cmbSelection.FormattingEnabled = true;
            cmbSelection.Location = new Point(193, 26);
            cmbSelection.Name = "cmbSelection";
            cmbSelection.Size = new Size(164, 28);
            cmbSelection.TabIndex = 16;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Calibri", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 28);
            label2.Name = "label2";
            label2.Size = new Size(164, 24);
            label2.TabIndex = 17;
            label2.Text = "Category selection";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1235, 478);
            Controls.Add(label2);
            Controls.Add(cmbSelection);
            Controls.Add(lblWebsite);
            Controls.Add(lblCountry);
            Controls.Add(lblManufacturer);
            Controls.Add(btnDelete);
            Controls.Add(btnEdit);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView);
            Controls.Add(cmbSortBy);
            Controls.Add(cmbFilter);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label4;
        private Label label5;
        private ComboBox cmbFilter;
        private ComboBox cmbSortBy;
        private DataGridView dataGridView;
        private Button btnAdd;
        private Button btnEdit;
        private Button btnDelete;
        private Label lblManufacturer;
        private Label lblCountry;
        private Label lblWebsite;
        private ComboBox cmbSelection;
        private Label label2;
    }
}