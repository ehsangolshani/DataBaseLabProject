namespace WindowsFormsApplication1
{
    partial class LowMoneyPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.backMainB = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.studentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentFirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentLastName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.studentID,
            this.studentFirstName,
            this.studentLastName,
            this.credit});
            this.dataGridView1.Location = new System.Drawing.Point(12, 32);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(699, 252);
            this.dataGridView1.TabIndex = 6;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(551, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "حساب مالی دانش آموزان بدهکار";
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(12, 290);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(125, 36);
            this.backMainB.TabIndex = 9;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(143, 290);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 36);
            this.button1.TabIndex = 10;
            this.button1.Text = "صفحه قبل";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // studentID
            // 
            this.studentID.HeaderText = "کد دانش آموزی";
            this.studentID.MinimumWidth = 150;
            this.studentID.Name = "studentID";
            this.studentID.ReadOnly = true;
            this.studentID.Width = 170;
            // 
            // studentFirstName
            // 
            this.studentFirstName.HeaderText = "نام";
            this.studentFirstName.MinimumWidth = 150;
            this.studentFirstName.Name = "studentFirstName";
            this.studentFirstName.ReadOnly = true;
            this.studentFirstName.Width = 170;
            // 
            // studentLastName
            // 
            this.studentLastName.HeaderText = "نام خانوادگی";
            this.studentLastName.MinimumWidth = 150;
            this.studentLastName.Name = "studentLastName";
            this.studentLastName.ReadOnly = true;
            this.studentLastName.Width = 170;
            // 
            // credit
            // 
            this.credit.HeaderText = "اعتبار حساب";
            this.credit.MinimumWidth = 150;
            this.credit.Name = "credit";
            this.credit.ReadOnly = true;
            this.credit.Width = 170;
            // 
            // LowMoneyPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.backMainB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "LowMoneyPage";
            this.Text = "LowMoneyPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentFirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn studentLastName;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
    }
}