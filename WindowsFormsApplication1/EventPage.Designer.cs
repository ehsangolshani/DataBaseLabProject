namespace WindowsFormsApplication1
{
    partial class EventPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.eventID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventSubject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.teamNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.eventLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // backMainB
            // 
            this.backMainB.Location = new System.Drawing.Point(22, 289);
            this.backMainB.Name = "backMainB";
            this.backMainB.Size = new System.Drawing.Size(125, 37);
            this.backMainB.TabIndex = 1;
            this.backMainB.Text = "صفحه اصلی";
            this.backMainB.UseVisualStyleBackColor = true;
            this.backMainB.Click += new System.EventHandler(this.backMainB_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.eventID,
            this.eventSubject,
            this.teamNo,
            this.eventDate,
            this.eventLocation});
            this.dataGridView1.Location = new System.Drawing.Point(22, 37);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(680, 246);
            this.dataGridView1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "لیست رویدادهای مدرسه";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(158, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 37);
            this.button1.TabIndex = 4;
            this.button1.Text = "اضافه کردن رویداد";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // eventID
            // 
            this.eventID.HeaderText = "شناسه";
            this.eventID.MinimumWidth = 115;
            this.eventID.Name = "eventID";
            this.eventID.ReadOnly = true;
            this.eventID.Width = 115;
            // 
            // eventSubject
            // 
            this.eventSubject.HeaderText = "موضوع رویداد";
            this.eventSubject.MinimumWidth = 130;
            this.eventSubject.Name = "eventSubject";
            this.eventSubject.ReadOnly = true;
            this.eventSubject.Width = 130;
            // 
            // teamNo
            // 
            this.teamNo.FillWeight = 150F;
            this.teamNo.HeaderText = "تعداد تیم های شرکت کننده";
            this.teamNo.MinimumWidth = 130;
            this.teamNo.Name = "teamNo";
            this.teamNo.ReadOnly = true;
            this.teamNo.Width = 130;
            // 
            // eventDate
            // 
            this.eventDate.HeaderText = "روز برگزاری";
            this.eventDate.MinimumWidth = 130;
            this.eventDate.Name = "eventDate";
            this.eventDate.ReadOnly = true;
            this.eventDate.Width = 130;
            // 
            // eventLocation
            // 
            this.eventLocation.FillWeight = 150F;
            this.eventLocation.HeaderText = "محل برگزاری";
            this.eventLocation.MinimumWidth = 130;
            this.eventLocation.Name = "eventLocation";
            this.eventLocation.ReadOnly = true;
            this.eventLocation.Width = 130;
            // 
            // EventPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.backMainB);
            this.Name = "EventPage";
            this.Text = "EventPage";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backMainB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventID;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventSubject;
        private System.Windows.Forms.DataGridViewTextBoxColumn teamNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn eventLocation;
    }
}