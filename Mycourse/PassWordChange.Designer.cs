namespace Mycourse
{
    partial class PassWordChange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PassWordChange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnsave = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtformerpwd = new System.Windows.Forms.TextBox();
            this.txtnewpwd = new System.Windows.Forms.TextBox();
            this.txtconfirm = new System.Windows.Forms.TextBox();
            this.lbwarning1 = new System.Windows.Forms.Label();
            this.lbwarning2 = new System.Windows.Forms.Label();
            this.lbwarning0 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "原密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认新密码";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(99, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "（密码不得少于6个字符）";
            // 
            // btnsave
            // 
            this.btnsave.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnsave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.btnsave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.btnsave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnsave.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.Image")));
            this.btnsave.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnsave.Location = new System.Drawing.Point(34, 287);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(72, 28);
            this.btnsave.TabIndex = 4;
            this.btnsave.Text = "确定";
            this.btnsave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumTurquoise;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(185, 287);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 28);
            this.button2.TabIndex = 5;
            this.button2.Text = "取消";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtformerpwd
            // 
            this.txtformerpwd.Location = new System.Drawing.Point(133, 35);
            this.txtformerpwd.Name = "txtformerpwd";
            this.txtformerpwd.PasswordChar = '*';
            this.txtformerpwd.Size = new System.Drawing.Size(109, 21);
            this.txtformerpwd.TabIndex = 6;
            this.txtformerpwd.TextChanged += new System.EventHandler(this.txtformerpwd_TextChanged);
            // 
            // txtnewpwd
            // 
            this.txtnewpwd.Location = new System.Drawing.Point(133, 99);
            this.txtnewpwd.Name = "txtnewpwd";
            this.txtnewpwd.PasswordChar = '*';
            this.txtnewpwd.Size = new System.Drawing.Size(109, 21);
            this.txtnewpwd.TabIndex = 7;
            this.txtnewpwd.TextChanged += new System.EventHandler(this.txtnewpwd_TextChanged);
            // 
            // txtconfirm
            // 
            this.txtconfirm.Location = new System.Drawing.Point(133, 168);
            this.txtconfirm.Name = "txtconfirm";
            this.txtconfirm.PasswordChar = '*';
            this.txtconfirm.Size = new System.Drawing.Size(109, 21);
            this.txtconfirm.TabIndex = 8;
            this.txtconfirm.TextChanged += new System.EventHandler(this.txtconfirm_TextChanged);
            // 
            // lbwarning1
            // 
            this.lbwarning1.AutoSize = true;
            this.lbwarning1.ForeColor = System.Drawing.Color.Red;
            this.lbwarning1.Location = new System.Drawing.Point(143, 137);
            this.lbwarning1.Name = "lbwarning1";
            this.lbwarning1.Size = new System.Drawing.Size(41, 12);
            this.lbwarning1.TabIndex = 9;
            this.lbwarning1.Text = "label5";
            // 
            // lbwarning2
            // 
            this.lbwarning2.AutoSize = true;
            this.lbwarning2.ForeColor = System.Drawing.Color.Red;
            this.lbwarning2.Location = new System.Drawing.Point(143, 207);
            this.lbwarning2.Name = "lbwarning2";
            this.lbwarning2.Size = new System.Drawing.Size(41, 12);
            this.lbwarning2.TabIndex = 10;
            this.lbwarning2.Text = "label6";
            // 
            // lbwarning0
            // 
            this.lbwarning0.AutoSize = true;
            this.lbwarning0.ForeColor = System.Drawing.Color.Red;
            this.lbwarning0.Location = new System.Drawing.Point(143, 68);
            this.lbwarning0.Name = "lbwarning0";
            this.lbwarning0.Size = new System.Drawing.Size(41, 12);
            this.lbwarning0.TabIndex = 11;
            this.lbwarning0.Text = "label5";
            // 
            // PassWordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.ClientSize = new System.Drawing.Size(313, 381);
            this.Controls.Add(this.lbwarning0);
            this.Controls.Add(this.lbwarning2);
            this.Controls.Add(this.lbwarning1);
            this.Controls.Add(this.txtconfirm);
            this.Controls.Add(this.txtnewpwd);
            this.Controls.Add(this.txtformerpwd);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PassWordChange";
            this.Text = "修改密码";
            this.Load += new System.EventHandler(this.PassWordChange_Load);
            this.TextChanged += new System.EventHandler(this.PassWordChange_TextChanged);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtformerpwd;
        private System.Windows.Forms.TextBox txtnewpwd;
        private System.Windows.Forms.TextBox txtconfirm;
        private System.Windows.Forms.Label lbwarning1;
        private System.Windows.Forms.Label lbwarning2;
        private System.Windows.Forms.Label lbwarning0;
    }
}