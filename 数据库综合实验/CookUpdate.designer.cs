namespace Mysqltest
{
    partial class CookUpdate
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.num = new System.Windows.Forms.TextBox();
            this.name = new System.Windows.Forms.TextBox();
            this.telnum = new System.Windows.Forms.TextBox();
            this.typeofwork = new System.Windows.Forms.ComboBox();
            this.grade = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(254, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 1;
            this.label1.Text = "更新信息";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(416, 407);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 63);
            this.button1.TabIndex = 3;
            this.button1.Text = "取消更新";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 10F);
            this.label2.Location = new System.Drawing.Point(90, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(189, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "更新者编号（必填）";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 10F);
            this.label3.Location = new System.Drawing.Point(212, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "手机号";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 10F);
            this.label5.Location = new System.Drawing.Point(212, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "工种";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 10F);
            this.label6.Location = new System.Drawing.Point(212, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 20);
            this.label6.TabIndex = 8;
            this.label6.Text = "等级";
            // 
            // num
            // 
            this.num.Font = new System.Drawing.Font("宋体", 10F);
            this.num.Location = new System.Drawing.Point(310, 102);
            this.num.Name = "num";
            this.num.Size = new System.Drawing.Size(177, 30);
            this.num.TabIndex = 9;
            // 
            // name
            // 
            this.name.Font = new System.Drawing.Font("宋体", 10F);
            this.name.Location = new System.Drawing.Point(310, 152);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(177, 30);
            this.name.TabIndex = 10;
            // 
            // telnum
            // 
            this.telnum.Font = new System.Drawing.Font("宋体", 10F);
            this.telnum.Location = new System.Drawing.Point(310, 203);
            this.telnum.Name = "telnum";
            this.telnum.Size = new System.Drawing.Size(177, 30);
            this.telnum.TabIndex = 11;
            // 
            // typeofwork
            // 
            this.typeofwork.Font = new System.Drawing.Font("宋体", 10F);
            this.typeofwork.FormattingEnabled = true;
            this.typeofwork.Items.AddRange(new object[] {
            "打荷",
            "蒸锅",
            "炉头",
            "上砧",
            "水台",
            "烧腊",
            "点心"});
            this.typeofwork.Location = new System.Drawing.Point(310, 261);
            this.typeofwork.Name = "typeofwork";
            this.typeofwork.Size = new System.Drawing.Size(177, 28);
            this.typeofwork.TabIndex = 12;
            // 
            // grade
            // 
            this.grade.Font = new System.Drawing.Font("宋体", 10F);
            this.grade.FormattingEnabled = true;
            this.grade.Items.AddRange(new object[] {
            "中级",
            "高级",
            "技师"});
            this.grade.Location = new System.Drawing.Point(310, 337);
            this.grade.Name = "grade";
            this.grade.Size = new System.Drawing.Size(177, 28);
            this.grade.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(112, 407);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 63);
            this.button2.TabIndex = 14;
            this.button2.Text = "确认更新";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CookUpdate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 529);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grade);
            this.Controls.Add(this.typeofwork);
            this.Controls.Add(this.telnum);
            this.Controls.Add(this.name);
            this.Controls.Add(this.num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "CookUpdate";
            this.Text = "更新厨师信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox num;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.TextBox telnum;
        private System.Windows.Forms.ComboBox typeofwork;
        private System.Windows.Forms.ComboBox grade;
        private System.Windows.Forms.Button button2;
    }
}