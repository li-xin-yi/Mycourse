namespace Mycourse
{
    partial class DisplaySelectedCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DisplaySelectedCourse));
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.CourseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbcount = new System.Windows.Forms.Label();
            this.lbcredit = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcourse
            // 
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CourseNo,
            this.SubNo,
            this.CourseName,
            this.credit,
            this.Teacher,
            this.Class,
            this.audience});
            this.dgvcourse.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvcourse.Location = new System.Drawing.Point(7, 12);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.RowTemplate.Height = 23;
            this.dgvcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcourse.Size = new System.Drawing.Size(852, 414);
            this.dgvcourse.TabIndex = 2;
            this.dgvcourse.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvcourse_CellContentClick);
            this.dgvcourse.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcourse_CellMouseDown);
            // 
            // CourseNo
            // 
            this.CourseNo.DataPropertyName = "CourseNo";
            this.CourseNo.HeaderText = "课程号";
            this.CourseNo.Name = "CourseNo";
            // 
            // SubNo
            // 
            this.SubNo.DataPropertyName = "SubNo";
            this.SubNo.HeaderText = "课序号";
            this.SubNo.Name = "SubNo";
            this.SubNo.Width = 70;
            // 
            // CourseName
            // 
            this.CourseName.DataPropertyName = "CourseName";
            this.CourseName.HeaderText = "课程名";
            this.CourseName.Name = "CourseName";
            this.CourseName.Width = 200;
            // 
            // credit
            // 
            this.credit.DataPropertyName = "CourseCredit";
            this.credit.HeaderText = "学分";
            this.credit.Name = "credit";
            this.credit.Width = 70;
            // 
            // Teacher
            // 
            this.Teacher.DataPropertyName = "Teacher";
            this.Teacher.HeaderText = "教师";
            this.Teacher.Name = "Teacher";
            // 
            // Class
            // 
            this.Class.DataPropertyName = "Type";
            this.Class.HeaderText = "属性";
            this.Class.Name = "Class";
            this.Class.Width = 80;
            // 
            // audience
            // 
            this.audience.DataPropertyName = "Cclass";
            this.audience.HeaderText = "班级";
            this.audience.Name = "audience";
            this.audience.Width = 200;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.查看ToolStripMenuItem,
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            this.contextMenuStrip1.Click += new System.EventHandler(this.contextMenuStrip1_Click);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 438);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "已选科目：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 476);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "总学分：";
            // 
            // lbcount
            // 
            this.lbcount.AutoSize = true;
            this.lbcount.Location = new System.Drawing.Point(165, 438);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(41, 12);
            this.lbcount.TabIndex = 5;
            this.lbcount.Text = "label3";
            // 
            // lbcredit
            // 
            this.lbcredit.AutoSize = true;
            this.lbcredit.Location = new System.Drawing.Point(165, 476);
            this.lbcredit.Name = "lbcredit";
            this.lbcredit.Size = new System.Drawing.Size(41, 12);
            this.lbcredit.TabIndex = 6;
            this.lbcredit.Text = "label4";
            // 
            // DisplaySelectedCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(871, 507);
            this.Controls.Add(this.lbcredit);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DisplaySelectedCourse";
            this.Opacity = 0.9D;
            this.Text = "已选课程";
            this.Load += new System.EventHandler(this.DisplaySelectedCourse_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.DisplaySelectedCourse_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label lbcredit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn audience;
    }
}