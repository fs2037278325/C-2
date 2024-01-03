
namespace Example_1
{
    partial class FormCourse
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
            this.texttime = new System.Windows.Forms.TextBox();
            this.textname = new System.Windows.Forms.TextBox();
            this.textcredit = new System.Windows.Forms.TextBox();
            this.textcapacity = new System.Windows.Forms.TextBox();
            this.textbianhao = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lstCourse = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cmbCourseTime = new System.Windows.Forms.ComboBox();
            this.cmbCourseType = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // texttime
            // 
            this.texttime.Location = new System.Drawing.Point(603, 102);
            this.texttime.Name = "texttime";
            this.texttime.Size = new System.Drawing.Size(122, 30);
            this.texttime.TabIndex = 15;
            // 
            // textname
            // 
            this.textname.Location = new System.Drawing.Point(372, 41);
            this.textname.Name = "textname";
            this.textname.Size = new System.Drawing.Size(119, 30);
            this.textname.TabIndex = 12;
            // 
            // textcredit
            // 
            this.textcredit.Location = new System.Drawing.Point(146, 165);
            this.textcredit.Name = "textcredit";
            this.textcredit.Size = new System.Drawing.Size(111, 30);
            this.textcredit.TabIndex = 11;
            // 
            // textcapacity
            // 
            this.textcapacity.Location = new System.Drawing.Point(146, 102);
            this.textcapacity.Name = "textcapacity";
            this.textcapacity.Size = new System.Drawing.Size(111, 30);
            this.textcapacity.TabIndex = 10;
            // 
            // textbianhao
            // 
            this.textbianhao.Location = new System.Drawing.Point(146, 38);
            this.textbianhao.Name = "textbianhao";
            this.textbianhao.Size = new System.Drawing.Size(111, 30);
            this.textbianhao.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(50, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "学分";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button4.Location = new System.Drawing.Point(678, 195);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(78, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "返回";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "时间";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button3.Location = new System.Drawing.Point(558, 195);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(81, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "更新";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(288, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "类型";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button2.Location = new System.Drawing.Point(444, 195);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "删除";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(50, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "容量";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.button1.Location = new System.Drawing.Point(339, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(80, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "添加";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "学期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "课程编号";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbCourseType);
            this.groupBox1.Controls.Add(this.cmbCourseTime);
            this.groupBox1.Controls.Add(this.texttime);
            this.groupBox1.Controls.Add(this.textname);
            this.groupBox1.Controls.Add(this.textcredit);
            this.groupBox1.Controls.Add(this.textcapacity);
            this.groupBox1.Controls.Add(this.textbianhao);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(6, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 235);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "课程信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(288, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "名称";
            // 
            // lstCourse
            // 
            this.lstCourse.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lstCourse.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader6,
            this.columnHeader7});
            this.lstCourse.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lstCourse.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lstCourse.HideSelection = false;
            this.lstCourse.Location = new System.Drawing.Point(6, 269);
            this.lstCourse.Name = "lstCourse";
            this.lstCourse.Size = new System.Drawing.Size(776, 294);
            this.lstCourse.TabIndex = 3;
            this.lstCourse.UseCompatibleStateImageBehavior = false;
            this.lstCourse.View = System.Windows.Forms.View.Details;
            this.lstCourse.SelectedIndexChanged += new System.EventHandler(this.lstCourse_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = " 名称";
            this.columnHeader1.Width = 77;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = " 容量";
            this.columnHeader2.Width = 84;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = " 学分";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "  类型";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = " 时间";
            this.columnHeader6.Width = 88;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "  学期";
            this.columnHeader7.Width = 80;
            // 
            // cmbCourseTime
            // 
            this.cmbCourseTime.FormattingEnabled = true;
            this.cmbCourseTime.Location = new System.Drawing.Point(603, 48);
            this.cmbCourseTime.Name = "cmbCourseTime";
            this.cmbCourseTime.Size = new System.Drawing.Size(121, 28);
            this.cmbCourseTime.TabIndex = 16;
            // 
            // cmbCourseType
            // 
            this.cmbCourseType.FormattingEnabled = true;
            this.cmbCourseType.Location = new System.Drawing.Point(370, 105);
            this.cmbCourseType.Name = "cmbCourseType";
            this.cmbCourseType.Size = new System.Drawing.Size(121, 28);
            this.cmbCourseType.TabIndex = 17;
            // 
            // FormCourse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 591);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCourse);
            this.Name = "FormCourse";
            this.Text = "课程管理";
            this.Load += new System.EventHandler(this.FormCourse_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox texttime;
        private System.Windows.Forms.TextBox textname;
        private System.Windows.Forms.TextBox textcredit;
        private System.Windows.Forms.TextBox textcapacity;
        private System.Windows.Forms.TextBox textbianhao;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView lstCourse;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ComboBox cmbCourseType;
        private System.Windows.Forms.ComboBox cmbCourseTime;
    }
}