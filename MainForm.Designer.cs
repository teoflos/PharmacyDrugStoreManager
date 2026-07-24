namespace PharmacyDrugStoreManager
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private TableLayoutPanel buttonLayout;
        private Label lblTitle;
        private Button btnDisplayAll;
        private Button btnDisplaySingle;
        private Button btnAdd;
        private Button btnSearch;
        private Button btnSort;
        private Button btnBusinessLogic;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnExit;
        private DataGridView dgvDisplay;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            buttonLayout = new TableLayoutPanel();
            lblTitle = new Label();
            btnDisplayAll = new Button();
            btnDisplaySingle = new Button();
            btnAdd = new Button();
            btnSearch = new Button();
            btnSort = new Button();
            btnBusinessLogic = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnExit = new Button();
            dgvDisplay = new DataGridView();
            mainLayout.SuspendLayout();
            buttonLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).BeginInit();
            SuspendLayout();

           
            mainLayout.ColumnCount = 2;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 220F));
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(buttonLayout, 0, 1);
            mainLayout.Controls.Add(dgvDisplay, 1, 1);
            mainLayout.Controls.Add(lblTitle, 0, 0);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(10);
            mainLayout.RowCount = 2;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.Size = new Size(1000, 650);
            mainLayout.TabIndex = 0;

            mainLayout.SetColumnSpan(lblTitle, 2);
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(13, 10);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(974, 60);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHARMACY DRUG STORE MANAGER";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            buttonLayout.ColumnCount = 1;
            buttonLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            buttonLayout.Controls.Add(btnDisplayAll, 0, 0);
            buttonLayout.Controls.Add(btnDisplaySingle, 0, 1);
            buttonLayout.Controls.Add(btnAdd, 0, 2);
            buttonLayout.Controls.Add(btnSearch, 0, 3);
            buttonLayout.Controls.Add(btnSort, 0, 4);
            buttonLayout.Controls.Add(btnBusinessLogic, 0, 5);
            buttonLayout.Controls.Add(btnDelete, 0, 6);
            buttonLayout.Controls.Add(btnUpdate, 0, 7);
            buttonLayout.Controls.Add(btnExit, 0, 8);
            buttonLayout.Dock = DockStyle.Fill;
            buttonLayout.Location = new Point(13, 70);
            buttonLayout.Name = "buttonLayout";
            buttonLayout.RowCount = 9;
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 11.11F));
            buttonLayout.Size = new Size(200, 570);
            buttonLayout.TabIndex = 1;

            // 
            // Buttons
            // 
            btnDisplayAll.Dock = DockStyle.Fill;
            btnDisplayAll.Font = new Font("Segoe UI", 10F);
            btnDisplayAll.Location = new Point(3, 3);
            btnDisplayAll.Name = "btnDisplayAll";
            btnDisplayAll.Size = new Size(194, 57);
            btnDisplayAll.TabIndex = 0;
            btnDisplayAll.Text = "1. Display All Data";
            btnDisplayAll.UseVisualStyleBackColor = true;
            btnDisplayAll.Click += btnDisplayAll_Click;

            btnDisplaySingle.Dock = DockStyle.Fill;
            btnDisplaySingle.Font = new Font("Segoe UI", 10F);
            btnDisplaySingle.Location = new Point(3, 66);
            btnDisplaySingle.Name = "btnDisplaySingle";
            btnDisplaySingle.Size = new Size(194, 57);
            btnDisplaySingle.TabIndex = 1;
            btnDisplaySingle.Text = "2. Display Single";
            btnDisplaySingle.UseVisualStyleBackColor = true;
            btnDisplaySingle.Click += btnDisplaySingle_Click;

            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Font = new Font("Segoe UI", 10F);
            btnAdd.Location = new Point(3, 129);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(194, 57);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "3. Add New Data";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;

            btnSearch.Dock = DockStyle.Fill;
            btnSearch.Font = new Font("Segoe UI", 10F);
            btnSearch.Location = new Point(3, 192);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(194, 57);
            btnSearch.TabIndex = 3;
            btnSearch.Text = "4. Search Data";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;

            btnSort.Dock = DockStyle.Fill;
            btnSort.Font = new Font("Segoe UI", 10F);
            btnSort.Location = new Point(3, 255);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(194, 57);
            btnSort.TabIndex = 4;
            btnSort.Text = "5. Sort Data";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;

            btnBusinessLogic.Dock = DockStyle.Fill;
            btnBusinessLogic.Font = new Font("Segoe UI", 10F);
            btnBusinessLogic.Location = new Point(3, 318);
            btnBusinessLogic.Name = "btnBusinessLogic";
            btnBusinessLogic.Size = new Size(194, 57);
            btnBusinessLogic.TabIndex = 5;
            btnBusinessLogic.Text = "6. Business Logic";
            btnBusinessLogic.UseVisualStyleBackColor = true;
            btnBusinessLogic.Click += btnBusinessLogic_Click;

            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Font = new Font("Segoe UI", 10F);
            btnDelete.Location = new Point(3, 381);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(194, 57);
            btnDelete.TabIndex = 6;
            btnDelete.Text = "7. Delete Data";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;

            btnUpdate.Dock = DockStyle.Fill;
            btnUpdate.Font = new Font("Segoe UI", 10F);
            btnUpdate.Location = new Point(3, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(194, 57);
            btnUpdate.TabIndex = 7;
            btnUpdate.Text = "8. Update Data";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;

            btnExit.Dock = DockStyle.Fill;
            btnExit.Font = new Font("Segoe UI", 10F);
            btnExit.ForeColor = Color.Red;
            btnExit.Location = new Point(3, 507);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 57);
            btnExit.TabIndex = 8;
            btnExit.Text = "9. Exit";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;

            dgvDisplay.Dock = DockStyle.Fill;
            dgvDisplay.Location = new Point(233, 70);
            dgvDisplay.Name = "dgvDisplay";
            dgvDisplay.RowHeadersWidth = 51;
            dgvDisplay.Size = new Size(754, 570);
            dgvDisplay.TabIndex = 2;

           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 650);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(700, 450);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pharmacy Drug Store Manager";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            buttonLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDisplay).EndInit();
            ResumeLayout(false);
        }
    }
}