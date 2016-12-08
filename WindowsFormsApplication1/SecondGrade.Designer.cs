namespace WindowsFormsApplication1
{
    partial class SecondGrade
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentNationalCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(21, 288);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(125, 38);
            this.backMainB.TabIndex = 4;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(152, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 38);
            this.button1.TabIndex = 5;
            this.button1.Text = "صفحه قبل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.studentName,
            this.studentLastName,
            this.studentNationalCode});
            this.dataGridView1.Location = new System.Drawing.Point(21, 39);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(674, 241);
            this.dataGridView1.TabIndex = 9;
            // 
            // studentID
            // 
            this.studentID.HeaderText = "کد دانش آموزی";
            this.studentID.MinimumWidth = 150;
            this.studentID.Name = "studentID";
            this.studentID.Width = 150;
            // 
            // studentName
            // 
            this.studentName.HeaderText = "نام";
            this.studentName.MinimumWidth = 150;
            this.studentName.Name = "studentName";
            this.studentName.Width = 150;
            // 
            // studentLastName
            // 
            this.studentLastName.HeaderText = "نام خانوادگی";
            this.studentLastName.MinimumWidth = 180;
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.Width = 180;
            // 
            // studentNationalCode
            // 
            this.studentNationalCode.HeaderText = "کد ملی";
            this.studentNationalCode.MinimumWidth = 150;
            this.studentNationalCode.Name = "studentNationalCode";
            this.studentNationalCode.Width = 150;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(555, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "دانش آموزان پایه دوم تحصیلی";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(570, 288);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(125, 38);
            this.button2.TabIndex = 11;
            this.button2.Text = "مشاوران پایه دوم";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(439, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 38);
            this.button3.TabIndex = 12;
            this.button3.Text = "دبیران پایه دوم";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // SecondGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backMainB);
            this.Name = "SecondGrade";
            this.Text = "SecondGrade";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentNationalCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}