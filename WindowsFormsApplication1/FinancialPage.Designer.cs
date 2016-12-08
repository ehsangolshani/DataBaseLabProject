namespace WindowsFormsApplication1
{
    partial class FinancialPage
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(33, 289);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(142, 37);
            this.backMainB.TabIndex = 2;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(560, 301);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "موجودی حساب مالی مدرسه ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(495, 301);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "20000   ريال";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.studentFirstName,
            this.studentLastName,
            this.credit});
            this.dataGridView1.Location = new System.Drawing.Point(33, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(664, 242);
            this.dataGridView1.TabIndex = 5;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "کد دانش آموزی";
            this.studentID.MinimumWidth = 130;
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Width = 130;
            // 
            // studentFirstName
            // 
            this.studentFirstName.HeaderText = "نام";
            this.studentFirstName.MinimumWidth = 150;
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.ReadOnly = true;
            this.studentFirstName.Width = 150;
            // 
            // studentLastName
            // 
            this.studentLastName.HeaderText = "نام خانوادگی";
            this.studentLastName.MinimumWidth = 170;
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.ReadOnly = true;
            this.studentLastName.Width = 170;
            // 
            // credit
            // 
            this.credit.HeaderText = "اعتبار حساب";
            this.credit.MinimumWidth = 170;
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Width = 170;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(541, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "اعتبار حساب مجازی دانش آموزان";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(213, 37);
            this.button1.TabIndex = 7;
            this.button1.Text = "مشاهده حساب دانش آموزان بدهکار";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FinancialPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.backMainB);
            this.Name = "FinancialPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "FinancialPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
    }
}