namespace WindowsFormsApplication1
{
    partial class ThirdGrade
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
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(28, 288);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(125, 38);
            this.backMainB.TabIndex = 4;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(159, 288);
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
            this.dataGridView1.Location = new System.Drawing.Point(28, 41);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(674, 241);
            this.dataGridView1.TabIndex = 15;
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
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(447, 288);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(125, 38);
            this.button4.TabIndex = 18;
            this.button4.Text = "دبیران پایه سوم";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(578, 288);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(125, 38);
            this.button5.TabIndex = 17;
            this.button5.Text = "مشاوران پایه سوم";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(563, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "دانش آموزان پایه سوم تحصیلی";
            // 
            // ThirdGrade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backMainB);
            this.Name = "ThirdGrade";
            this.Text = "ThirdGrade";
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
    }
}