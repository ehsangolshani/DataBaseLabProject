namespace WindowsFormsApplication1
{
    partial class ExamPage
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
            this.components = new System.ComponentModel.Container();
            this.showAndMarkParticipatorsB = new System.Windows.Forms.Button();
            this.searchExamTB = new System.Windows.Forms.TextBox();
            this.searchExamB = new System.Windows.Forms.Button();
            this.addExamB = new System.Windows.Forms.Button();
            this.examsGV = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.showAbsentsB = new System.Windows.Forms.Button();
            this.removeSelectedExamB = new System.Windows.Forms.Button();
            this.backMainB = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.examsGV)).BeginInit();
            this.SuspendLayout();
            // 
            // showAndMarkParticipatorsB
            // 
            this.showAndMarkParticipatorsB.Location = new System.Drawing.Point(201, 269);
            this.showAndMarkParticipatorsB.Name = "showAndMarkParticipatorsB";
            this.showAndMarkParticipatorsB.Size = new System.Drawing.Size(286, 44);
            this.showAndMarkParticipatorsB.TabIndex = 18;
            this.showAndMarkParticipatorsB.Text = "مشاهده و نمره دهی به شرکت کنندگان";
            this.showAndMarkParticipatorsB.UseVisualStyleBackColor = true;
            this.showAndMarkParticipatorsB.Click += new System.EventHandler(this.showAndMarkParticipatorsB_Click);
            // 
            // searchExamTB
            // 
            this.searchExamTB.Location = new System.Drawing.Point(493, 12);
            this.searchExamTB.Name = "searchExamTB";
            this.searchExamTB.Size = new System.Drawing.Size(203, 20);
            this.searchExamTB.TabIndex = 17;
            // 
            // searchExamB
            // 
            this.searchExamB.Location = new System.Drawing.Point(493, 38);
            this.searchExamB.Name = "searchExamB";
            this.searchExamB.Size = new System.Drawing.Size(203, 32);
            this.searchExamB.TabIndex = 16;
            this.searchExamB.Text = "جستجو با شناسه امتحان";
            this.searchExamB.UseVisualStyleBackColor = true;
            this.searchExamB.Click += new System.EventHandler(this.searchExamB_Click);
            // 
            // addExamB
            // 
            this.addExamB.Location = new System.Drawing.Point(493, 169);
            this.addExamB.Name = "addExamB";
            this.addExamB.Size = new System.Drawing.Size(203, 44);
            this.addExamB.TabIndex = 15;
            this.addExamB.Text = "اضافه کردن امتحان";
            this.addExamB.UseVisualStyleBackColor = true;
            this.addExamB.Click += new System.EventHandler(this.addExamB_Click);
            // 
            // examsGV
            // 
            this.examsGV.AllowUserToAddRows = false;
            this.examsGV.AllowUserToDeleteRows = false;
            this.examsGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.examsGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.examsGV.Location = new System.Drawing.Point(12, 12);
            this.examsGV.Name = "examsGV";
            this.examsGV.ReadOnly = true;
            this.examsGV.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.examsGV.Size = new System.Drawing.Size(475, 251);
            this.examsGV.TabIndex = 14;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // showAbsentsB
            // 
            this.showAbsentsB.Location = new System.Drawing.Point(493, 269);
            this.showAbsentsB.Name = "showAbsentsB";
            this.showAbsentsB.Size = new System.Drawing.Size(203, 44);
            this.showAbsentsB.TabIndex = 19;
            this.showAbsentsB.Text = "مشاهده لیست غایبین امتحان";
            this.showAbsentsB.UseVisualStyleBackColor = true;
            this.showAbsentsB.Click += new System.EventHandler(this.showAbsentsB_Click);
            // 
            // removeSelectedExamB
            // 
            this.removeSelectedExamB.Location = new System.Drawing.Point(493, 219);
            this.removeSelectedExamB.Name = "removeSelectedExamB";
            this.removeSelectedExamB.Size = new System.Drawing.Size(203, 44);
            this.removeSelectedExamB.TabIndex = 20;
            this.removeSelectedExamB.Text = "حذف امتحان";
            this.removeSelectedExamB.UseVisualStyleBackColor = true;
            this.removeSelectedExamB.Click += new System.EventHandler(this.removeSelectedExamB_Click);
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(12, 269);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(183, 44);
            this.backMainB.TabIndex = 21;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "شناسه امتحان";
            this.Column1.MinimumWidth = 150;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "عنوان درس";
            this.Column2.MinimumWidth = 150;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 150;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "نوبت";
            this.Column3.MinimumWidth = 150;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 150;
            // 
            // ExamPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.backMainB);
            this.Controls.Add(this.removeSelectedExamB);
            this.Controls.Add(this.showAbsentsB);
            this.Controls.Add(this.showAndMarkParticipatorsB);
            this.Controls.Add(this.searchExamTB);
            this.Controls.Add(this.searchExamB);
            this.Controls.Add(this.addExamB);
            this.Controls.Add(this.examsGV);
            this.Name = "ExamPage";
            this.Text = "ExamPage";
            ((System.ComponentModel.ISupportInitialize)(this.examsGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button showAndMarkParticipatorsB;
        private System.Windows.Forms.TextBox searchExamTB;
        private System.Windows.Forms.Button searchExamB;
        private System.Windows.Forms.Button addExamB;
        private System.Windows.Forms.DataGridView examsGV;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Button showAbsentsB;
        private System.Windows.Forms.Button removeSelectedExamB;
        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}