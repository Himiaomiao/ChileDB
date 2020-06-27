namespace Mysqltest
{
    partial class Zuce
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
            this.label2 = new System.Windows.Forms.Label();
            this.user_num = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.user_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.user_password = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.user_identity = new System.Windows.Forms.ComboBox();
            this.user_id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(305, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎注册";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(226, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "账号";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // user_num
            // 
            this.user_num.Font = new System.Drawing.Font("宋体", 15F);
            this.user_num.Location = new System.Drawing.Point(312, 86);
            this.user_num.Name = "user_num";
            this.user_num.Size = new System.Drawing.Size(223, 42);
            this.user_num.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(206, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "用户名";
            // 
            // user_name
            // 
            this.user_name.Font = new System.Drawing.Font("宋体", 15F);
            this.user_name.Location = new System.Drawing.Point(312, 201);
            this.user_name.Name = "user_name";
            this.user_name.Size = new System.Drawing.Size(223, 42);
            this.user_name.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(226, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 30);
            this.label4.TabIndex = 5;
            this.label4.Text = "密码";
            // 
            // user_password
            // 
            this.user_password.Font = new System.Drawing.Font("宋体", 15F);
            this.user_password.Location = new System.Drawing.Point(312, 137);
            this.user_password.Name = "user_password";
            this.user_password.Size = new System.Drawing.Size(223, 42);
            this.user_password.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button1.Location = new System.Drawing.Point(161, 391);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 62);
            this.button1.TabIndex = 7;
            this.button1.Text = "注册";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.button2.Location = new System.Drawing.Point(442, 391);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 61);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 15F);
            this.label5.Location = new System.Drawing.Point(206, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 30);
            this.label5.TabIndex = 9;
            this.label5.Text = "身  份";
            // 
            // user_identity
            // 
            this.user_identity.Font = new System.Drawing.Font("宋体", 15F);
            this.user_identity.FormattingEnabled = true;
            this.user_identity.Items.AddRange(new object[] {
            "管理员",
            "教师",
            "监护人",
            "厨师",
            "配餐员",
            "食材管理员"});
            this.user_identity.Location = new System.Drawing.Point(312, 320);
            this.user_identity.Name = "user_identity";
            this.user_identity.Size = new System.Drawing.Size(223, 38);
            this.user_identity.TabIndex = 10;
            // 
            // user_id
            // 
            this.user_id.Font = new System.Drawing.Font("宋体", 15F);
            this.user_id.Location = new System.Drawing.Point(312, 256);
            this.user_id.Name = "user_id";
            this.user_id.Size = new System.Drawing.Size(223, 42);
            this.user_id.TabIndex = 11;
            this.user_id.TextChanged += new System.EventHandler(this.user_id_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 15F);
            this.label6.Location = new System.Drawing.Point(176, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 30);
            this.label6.TabIndex = 12;
            this.label6.Text = "个人编号";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Zuce
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(889, 500);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.user_id);
            this.Controls.Add(this.user_identity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.user_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.user_name);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.user_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Name = "Zuce";
            this.Text = "注册";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox user_num;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox user_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox user_password;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox user_identity;
        private System.Windows.Forms.TextBox user_id;
        private System.Windows.Forms.Label label6;
    }
}