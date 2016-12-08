namespace WindowsFormsApplication1
{
    partial class EmployeePage
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
            System.Windows.Forms.Button editٍEmployeeSpecB;
            this.backMainB = new System.Windows.Forms.Button();
            this.searchEmployeeTB = new System.Windows.Forms.TextBox();
            this.searchEmployeeB = new System.Windows.Forms.Button();
            this.employeeGV = new System.Windows.Forms.DataGridView();
            this.addEmployeeB = new System.Windows.Forms.Button();
            this.removeEmployeeB = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            editٍEmployeeSpecB = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).BeginInit();
            this.SuspendLayout();
            // 
            // editٍEmployeeSpecB
            // 
            editٍEmployeeSpecB.Location = new System.Drawing.Point(176, 269);
            editٍEmployeeSpecB.Name = "editٍEmployeeSpecB";
            editٍEmployeeSpecB.Size = new System.Drawing.Size(165, 44);
            editٍEmployeeSpecB.TabIndex = 14;
            editٍEmployeeSpecB.Text = "ویرایش مشخصات";
            editٍEmployeeSpecB.UseVisualStyleBackColor = true;
            editٍEmployeeSpecB.Click += new System.EventHandler(this.editٍEmployeeSpecB_Click);
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(21, 269);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(149, 44);
            this.backMainB.TabIndex = 0;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // searchEmployeeTB
            // 
            this.searchEmployeeTB.Location = new System.Drawing.Point(502, 12);
            this.searchEmployeeTB.Name = "searchEmployeeTB";
            this.searchEmployeeTB.Size = new System.Drawing.Size(203, 20);
            this.searchEmployeeTB.TabIndex = 11;
            // 
            // searchEmployeeB
            // 
            this.searchEmployeeB.Location = new System.Drawing.Point(502, 38);
            this.searchEmployeeB.Name = "searchEmployeeB";
            this.searchEmployeeB.Size = new System.Drawing.Size(203, 33);
            this.searchEmployeeB.TabIndex = 10;
            this.searchEmployeeB.Text = "جستجو با شماره پرسنلی";
            this.searchEmployeeB.UseVisualStyleBackColor = true;
            // 
            // employeeGV
            // 
            this.employeeGV.AllowUserToAddRows = false;
            this.employeeGV.AllowUserToDeleteRows = false;
            this.employeeGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.employeeGV.Location = new System.Drawing.Point(21, 12);
            this.employeeGV.Name = "employeeGV";
            this.employeeGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.employeeGV.Size = new System.Drawing.Size(475, 251);
            this.employeeGV.TabIndex = 8;
            this.employeeGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.employeeGV_CellContentClick);
            // 
            // addEmployeeB
            // 
            this.addEmployeeB.Location = new System.Drawing.Point(502, 269);
            this.addEmployeeB.Name = "addEmployeeB";
            this.addEmployeeB.Size = new System.Drawing.Size(203, 44);
            this.addEmployeeB.TabIndex = 9;
            this.addEmployeeB.Text = "اضافه کردن کارمند";
            this.addEmployeeB.UseVisualStyleBackColor = true;
            this.addEmployeeB.Click += new System.EventHandler(this.addEmployeeB_Click);
            // 
            // removeEmployeeB
            // 
            this.removeEmployeeB.Location = new System.Drawing.Point(347, 269);
            this.removeEmployeeB.Name = "removeEmployeeB";
            this.removeEmployeeB.Size = new System.Drawing.Size(149, 44);
            this.removeEmployeeB.TabIndex = 15;
            this.removeEmployeeB.Text = "حذف کارمند";
            this.removeEmployeeB.UseVisualStyleBackColor = true;
            this.removeEmployeeB.Click += new System.EventHandler(this.removeEmployeeB_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "کد پرسنلی";
            this.Column1.MinimumWidth = 80;
            this.Column1.Name = "Column1";
            this.Column1.Width = 90;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "کد ملی";
            this.Column2.MinimumWidth = 80;
            this.Column2.Name = "Column2";
            this.Column2.Width = 90;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "سطح تحصیلات";
            this.Column3.MinimumWidth = 80;
            this.Column3.Name = "Column3";
            this.Column3.Width = 90;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "سطح تحصیلات";
            this.Column4.MinimumWidth = 80;
            this.Column4.Name = "Column4";
            this.Column4.Width = 90;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "جنسیت";
            this.Column5.MinimumWidth = 80;
            this.Column5.Name = "Column5";
            this.Column5.Width = 90;
            // 
            // EmployeePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.removeEmployeeB);
            this.Controls.Add(editٍEmployeeSpecB);
            this.Controls.Add(this.searchEmployeeTB);
            this.Controls.Add(this.searchEmployeeB);
            this.Controls.Add(this.addEmployeeB);
            this.Controls.Add(this.employeeGV);
            this.Controls.Add(this.backMainB);
            this.Name = "EmployeePage";
            this.Text = "EmployeePage";
            this.Load += new System.EventHandler(this.EmployeePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.employeeGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.TextBox searchEmployeeTB;
        private System.Windows.Forms.Button searchEmployeeB;
        private System.Windows.Forms.DataGridView employeeGV;
        private System.Windows.Forms.Button addEmployeeB;
        private System.Windows.Forms.Button removeEmployeeB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}