namespace Mycourse
{
    partial class CourseSelect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CourseSelect));
            this.dgvcourse = new System.Windows.Forms.DataGridView();
            this.selection = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CourseNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Teacher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.audience = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.查看ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.选择ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtcourseno = new System.Windows.Forms.TextBox();
            this.txtsubno = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvcourse
            // 
            this.dgvcourse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvcourse.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.selection,
            this.CourseNo,
            this.SubNo,
            this.CourseName,
            this.credit,
            this.Teacher,
            this.Class,
            this.audience});
            this.dgvcourse.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvcourse.Location = new System.Drawing.Point(9, 108);
            this.dgvcourse.Name = "dgvcourse";
            this.dgvcourse.RowTemplate.Height = 23;
            this.dgvcourse.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvcourse.Size = new System.Drawing.Size(852, 414);
            this.dgvcourse.TabIndex = 1;
            this.dgvcourse.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvcourse_CellMouseDown);
            // 
            // selection
            // 
            this.selection.HeaderText = "";
            this.selection.Name = "selection";
            this.selection.Width = 30;
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
            this.credit.Width = 50;
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
            this.选择ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(99, 48);
            this.contextMenuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.contextMenuStrip1_ItemClicked);
            this.contextMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.contextMenuStrip1_MouseDown);
            // 
            // 查看ToolStripMenuItem
            // 
            this.查看ToolStripMenuItem.Name = "查看ToolStripMenuItem";
            this.查看ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.查看ToolStripMenuItem.Text = "查看";
            // 
            // 选择ToolStripMenuItem
            // 
            this.选择ToolStripMenuItem.Name = "选择ToolStripMenuItem";
            this.选择ToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
            this.选择ToolStripMenuItem.Text = "选择";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "课程号";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(251, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "课序号";
            // 
            // txtcourseno
            // 
            this.txtcourseno.Location = new System.Drawing.Point(66, 71);
            this.txtcourseno.Name = "txtcourseno";
            this.txtcourseno.Size = new System.Drawing.Size(142, 21);
            this.txtcourseno.TabIndex = 4;
            this.txtcourseno.TextChanged += new System.EventHandler(this.txtcourseno_TextChanged);
            // 
            // txtsubno
            // 
            this.txtsubno.Location = new System.Drawing.Point(333, 73);
            this.txtsubno.Name = "txtsubno";
            this.txtsubno.Size = new System.Drawing.Size(135, 21);
            this.txtsubno.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(517, 63);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(70, 39);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(47, 533);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 26);
            this.button2.TabIndex = 7;
            this.button2.Text = "全选";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(275, 533);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(145, 26);
            this.button3.TabIndex = 8;
            this.button3.Text = "清空";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(477, 532);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(146, 27);
            this.button4.TabIndex = 9;
            this.button4.Text = "确定选课";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(35, 22);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(135, 26);
            this.button5.TabIndex = 10;
            this.button5.Text = "所有课程";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(232, 22);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(135, 26);
            this.button6.TabIndex = 11;
            this.button6.Text = "推荐课程";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(430, 22);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(144, 26);
            this.button7.TabIndex = 12;
            this.button7.Text = "保存并查看已选课程";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.LightBlue;
            this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(633, 22);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 26);
            this.button8.TabIndex = 13;
            this.button8.Text = "查看课程表";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.Teal;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.PowderBlue;
            this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(677, 532);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(146, 27);
            this.button9.TabIndex = 14;
            this.button9.Text = "保存选课";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // CourseSelect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(874, 571);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtsubno);
            this.Controls.Add(this.txtcourseno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvcourse);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CourseSelect";
            this.Opacity = 0.9D;
            this.Text = "选课";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CourseSelect_FormClosed);
            this.Load += new System.EventHandler(this.CourseSelect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvcourse)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewCheckBoxColumn selection;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Teacher;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
        private System.Windows.Forms.DataGridViewTextBoxColumn audience;
        public System.Windows.Forms.DataGridView dgvcourse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtcourseno;
        private System.Windows.Forms.TextBox txtsubno;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 查看ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 选择ToolStripMenuItem;


    }
}