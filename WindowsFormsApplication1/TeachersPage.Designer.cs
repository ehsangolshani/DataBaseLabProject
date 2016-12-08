namespace WindowsFormsApplication1
{
    partial class TeachersPage
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
            this.backMainB = new System.Windows.Forms.Button();
            this.searchTeacherB = new System.Windows.Forms.Button();
            this.searchTeacherTB = new System.Windows.Forms.TextBox();
            this.showTeacherSpecB = new System.Windows.Forms.Button();
            this.addNewCourseForTeacherB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.addNewTeacherB = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(21, 271);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(137, 44);
            this.backMainB.TabIndex = 2;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // searchTeacherB
            // 
            this.searchTeacherB.Location = new System.Drawing.Point(502, 38);
            this.searchTeacherB.Name = "searchTeacherB";
            this.searchTeacherB.Size = new System.Drawing.Size(207, 32);
            this.searchTeacherB.TabIndex = 5;
            this.searchTeacherB.Text = "جستجو با شماره پرسنلی";
            this.searchTeacherB.UseVisualStyleBackColor = true;
            // 
            // searchTeacherTB
            // 
            this.searchTeacherTB.Location = new System.Drawing.Point(502, 12);
            this.searchTeacherTB.Name = "searchTeacherTB";
            this.searchTeacherTB.Size = new System.Drawing.Size(207, 20);
            this.searchTeacherTB.TabIndex = 6;
            // 
            // showTeacherSpecB
            // 
            this.showTeacherSpecB.Location = new System.Drawing.Point(164, 271);
            this.showTeacherSpecB.Name = "showTeacherSpecB";
            this.showTeacherSpecB.Size = new System.Drawing.Size(189, 44);
            this.showTeacherSpecB.TabIndex = 7;
            this.showTeacherSpecB.Text = "ویرایش مشخصات";
            this.showTeacherSpecB.UseVisualStyleBackColor = true;
            // 
            // addNewCourseForTeacherB
            // 
            this.addNewCourseForTeacherB.Location = new System.Drawing.Point(502, 271);
            this.addNewCourseForTeacherB.Name = "addNewCourseForTeacherB";
            this.addNewCourseForTeacherB.Size = new System.Drawing.Size(207, 44);
            this.addNewCourseForTeacherB.TabIndex = 10;
            this.addNewCourseForTeacherB.Text = "اراعه درس جدید";
            this.addNewCourseForTeacherB.UseVisualStyleBackColor = true;
            this.addNewCourseForTeacherB.Click += new System.EventHandler(this.addNewCourseForTeacherB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(359, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 44);
            this.button1.TabIndex = 14;
            this.button1.Text = "حذف معلم";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // addNewTeacherB
            // 
            this.addNewTeacherB.Location = new System.Drawing.Point(502, 221);
            this.addNewTeacherB.Name = "addNewTeacherB";
            this.addNewTeacherB.Size = new System.Drawing.Size(207, 44);
            this.addNewTeacherB.TabIndex = 15;
            this.addNewTeacherB.Text = "افزودن معلم جدید";
            this.addNewTeacherB.UseVisualStyleBackColor = true;
            this.addNewTeacherB.Click += new System.EventHandler(this.addNewTeacherB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridView1.Location = new System.Drawing.Point(21, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(475, 255);
            this.dataGridView1.TabIndex = 46;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "کد پرسنلی";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "نام";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نام خانوادگی";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "کد ملی";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "تاریخ تولد";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "سطح تحصیلات";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "رشته تحصیلی";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "دروس تدریسی";
            this.Column8.MinimumWidth = 150;
            this.Column8.Name = "Column8";
            this.Column8.Width = 150;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "مواد درسی";
            this.Column9.MinimumWidth = 150;
            this.Column9.Name = "Column9";
            this.Column9.Width = 150;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "وضعیت تاهل";
            this.Column10.Name = "Column10";
            // 
            // Column11
            // 
            this.Column11.HeaderText = "جنسیت";
            this.Column11.Name = "Column11";
            // 
            // Column12
            // 
            this.Column12.HeaderText = "شماره تلفن ثابت";
            this.Column12.Name = "Column12";
            // 
            // Column13
            // 
            this.Column13.HeaderText = "شماره تلفن همراه";
            this.Column13.Name = "Column13";
            // 
            // Column14
            // 
            this.Column14.HeaderText = "نشانی محل سکونت";
            this.Column14.MinimumWidth = 150;
            this.Column14.Name = "Column14";
            this.Column14.Width = 150;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "کد پستی";
            this.Column15.Name = "Column15";
            // 
            // TeachersPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.addNewTeacherB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.addNewCourseForTeacherB);
            this.Controls.Add(this.showTeacherSpecB);
            this.Controls.Add(this.searchTeacherTB);
            this.Controls.Add(this.searchTeacherB);
            this.Controls.Add(this.backMainB);
            this.Name = "TeachersPage";
            this.Text = "TeachersPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.Button searchTeacherB;
        private System.Windows.Forms.TextBox searchTeacherTB;
        private System.Windows.Forms.Button showTeacherSpecB;
        private System.Windows.Forms.Button addNewCourseForTeacherB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button addNewTeacherB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
    }
}