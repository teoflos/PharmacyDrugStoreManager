namespace PharmacyDrugStoreManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TableLayoutPanel mainLayout;
        private Label lblTitle;
        private Label lblSubTitle;
        private TextBox txtGroup;
        private Label lblDate;
        private Button btnStart;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            mainLayout = new TableLayoutPanel();
            lblTitle = new Label();
            lblSubTitle = new Label();
            txtGroup = new TextBox();
            lblDate = new Label();
            btnStart = new Button();
            mainLayout.SuspendLayout();
            SuspendLayout();

            
            mainLayout.ColumnCount = 1;
            mainLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainLayout.Controls.Add(lblTitle, 0, 0);
            mainLayout.Controls.Add(lblSubTitle, 0, 1);
            mainLayout.Controls.Add(txtGroup, 0, 2);
            mainLayout.Controls.Add(lblDate, 0, 3);
            mainLayout.Controls.Add(btnStart, 0, 4);
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.Location = new Point(0, 0);
            mainLayout.Name = "mainLayout";
            mainLayout.Padding = new Padding(20);
            mainLayout.RowCount = 5;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 50F));
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 80F));
            mainLayout.Size = new Size(800, 500);
            mainLayout.TabIndex = 0;


            lblTitle.AutoSize = true;
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTitle.ForeColor = Color.DarkBlue;
            lblTitle.Location = new Point(23, 20);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(754, 80);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "PHARMACY DRUG STORE MANAGER";
            lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

           
            lblSubTitle.AutoSize = true;
            lblSubTitle.Dock = DockStyle.Fill;
            lblSubTitle.Font = new Font("Segoe UI", 14F);
            lblSubTitle.ForeColor = Color.Gray;
            lblSubTitle.Location = new Point(23, 100);
            lblSubTitle.Name = "lblSubTitle";
            lblSubTitle.Size = new Size(754, 50);
            lblSubTitle.TabIndex = 1;
            lblSubTitle.Text = "Welcome to the Pharmacy Drug Store Management System";
            lblSubTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            
            txtGroup.BackColor = Color.White;
            txtGroup.BorderStyle = BorderStyle.None;
            txtGroup.Dock = DockStyle.Fill;
            txtGroup.Font = new Font("Segoe UI", 12F);
            txtGroup.Location = new Point(23, 150);
            txtGroup.Multiline = true;
            txtGroup.Name = "txtGroup";
            txtGroup.ReadOnly = true;
            txtGroup.Size = new Size(754, 150);
            txtGroup.TabIndex = 2;
            txtGroup.Text = "Group Members:\r\n1. HAYMANOT G/MICHAEL\r\n2. TEOFILOS MELESE\r\n3. SARON ZELALEM\r\n4. LEUL DEREJE\r\n5. SELOME AYTADEG";
            txtGroup.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;

            lblDate.AutoSize = true;
            lblDate.Dock = DockStyle.Fill;
            lblDate.Font = new Font("Segoe UI", 12F);
            lblDate.Location = new Point(23, 300);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(754, 50);
            lblDate.TabIndex = 3;
            lblDate.Text = "Submission Date: July 25, 2026";
            lblDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

         
            btnStart.Anchor = AnchorStyles.None;
            btnStart.Font = new Font("Segoe UI", 14F);
            btnStart.Location = new Point(270, 360);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(260, 50);
            btnStart.TabIndex = 4;
            btnStart.Text = "Press Any Key to Continue...";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;

           
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 500);
            Controls.Add(mainLayout);
            FormBorderStyle = FormBorderStyle.Sizable;
            MinimumSize = new Size(600, 400);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Welcome";
            mainLayout.ResumeLayout(false);
            mainLayout.PerformLayout();
            ResumeLayout(false);
        }
    }
}