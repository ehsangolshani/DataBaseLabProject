namespace WindowsFormsApplication1
{
    partial class MainPage
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
            this.employeeB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.teachersB = new System.Windows.Forms.Button();
            this.gradesB = new System.Windows.Forms.Button();
            this.examsB = new System.Windows.Forms.Button();
            this.eventsB = new System.Windows.Forms.Button();
            this.financeB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // employeeB
            // 
            this.employeeB.Location = new System.Drawing.Point(590, 46);
            this.employeeB.Name = "employeeB";
            this.employeeB.Size = new System.Drawing.Size(111, 79);
            this.employeeB.TabIndex = 0;
            this.employeeB.Text = "کارمندان";
            this.employeeB.UseVisualStyleBackColor = true;
            this.employeeB.Click += new System.EventHandler(this.employeeB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(594, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "سیستم مدیریت مدرسه ";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // teachersB
            // 
            this.teachersB.Location = new System.Drawing.Point(590, 138);
            this.teachersB.Name = "teachersB";
            this.teachersB.Size = new System.Drawing.Size(111, 79);
            this.teachersB.TabIndex = 2;
            this.teachersB.Text = "دبیران";
            this.teachersB.UseVisualStyleBackColor = true;
            this.teachersB.Click += new System.EventHandler(this.teachersB_Click);
            // 
            // gradesB
            // 
            this.gradesB.Location = new System.Drawing.Point(590, 233);
            this.gradesB.Name = "gradesB";
            this.gradesB.Size = new System.Drawing.Size(111, 79);
            this.gradesB.TabIndex = 3;
            this.gradesB.Text = "پایه های تحصیلی";
            this.gradesB.UseVisualStyleBackColor = true;
            this.gradesB.Click += new System.EventHandler(this.gradesB_Click);
            // 
            // examsB
            // 
            this.examsB.Location = new System.Drawing.Point(450, 233);
            this.examsB.Name = "examsB";
            this.examsB.Size = new System.Drawing.Size(111, 79);
            this.examsB.TabIndex = 4;
            this.examsB.Text = "امتحانات";
            this.examsB.UseVisualStyleBackColor = true;
            this.examsB.Click += new System.EventHandler(this.examsB_Click);
            // 
            // eventsB
            // 
            this.eventsB.Location = new System.Drawing.Point(450, 138);
            this.eventsB.Name = "eventsB";
            this.eventsB.Size = new System.Drawing.Size(111, 79);
            this.eventsB.TabIndex = 5;
            this.eventsB.Text = "رویداد ها";
            this.eventsB.UseVisualStyleBackColor = true;
            this.eventsB.Click += new System.EventHandler(this.eventsB_Click);
            // 
            // financeB
            // 
            this.financeB.Location = new System.Drawing.Point(450, 46);
            this.financeB.Name = "financeB";
            this.financeB.Size = new System.Drawing.Size(111, 79);
            this.financeB.TabIndex = 6;
            this.financeB.Text = "بخش مالی";
            this.financeB.UseVisualStyleBackColor = true;
            this.financeB.Click += new System.EventHandler(this.financeB_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(732, 338);
            this.Controls.Add(this.financeB);
            this.Controls.Add(this.eventsB);
            this.Controls.Add(this.examsB);
            this.Controls.Add(this.gradesB);
            this.Controls.Add(this.teachersB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeB);
            this.Name = "MainPage";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "MainPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button employeeB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button teachersB;
        private System.Windows.Forms.Button gradesB;
        private System.Windows.Forms.Button examsB;
        private System.Windows.Forms.Button eventsB;
        private System.Windows.Forms.Button financeB;
    }
}

