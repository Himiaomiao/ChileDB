namespace Mysqltest
{
    partial class Land
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.userName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.usePassword = new System.Windows.Forms.TextBox();
            this.useIdentity = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F);
            this.label1.Location = new System.Drawing.Point(282, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "欢迎登陆";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 15F);
            this.label2.Location = new System.Drawing.Point(188, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "用户名";
            // 
            // userName
            // 
            this.userName.Font = new System.Drawing.Font("宋体", 15F);
            this.userName.Location = new System.Drawing.Point(340, 93);
            this.userName.Name = "userName";
            this.userName.Size = new System.Drawing.Size(202, 42);
            this.userName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(192, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 30);
            this.label3.TabIndex = 3;
            this.label3.Text = "密 码";
            // 
            // usePassword
            // 
            this.usePassword.Font = new System.Drawing.Font("宋体", 15F);
            this.usePassword.Location = new System.Drawing.Point(340, 178);
            this.usePassword.Name = "usePassword";
            this.usePassword.Size = new System.Drawing.Size(202, 42);
            this.usePassword.TabIndex = 4;
            // 
            // useIdentity
            // 
            this.useIdentity.Font = new System.Drawing.Font("宋体", 15F);
            this.useIdentity.FormattingEnabled = true;
            this.useIdentity.Items.AddRange(new object[] {
            "管理员",
            "学生监护人",
            "老师",
            "厨师",
            "配餐员",
            "食材管理员"});
            this.useIdentity.Location = new System.Drawing.Point(340, 264);
            this.useIdentity.Name = "useIdentity";
            this.useIdentity.Size = new System.Drawing.Size(202, 38);
            this.useIdentity.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(192, 264);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 30);
            this.label4.TabIndex = 6;
            this.label4.Text = "身 份";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(170, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 44);
            this.button1.TabIndex = 7;
            this.button1.Text = "登陆";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 15F);
            this.button2.Location = new System.Drawing.Point(488, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 44);
            this.button2.TabIndex = 8;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 15F);
            this.button3.Location = new System.Drawing.Point(340, 346);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(108, 44);
            this.button3.TabIndex = 9;
            this.button3.Text = "注册";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Land
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.useIdentity);
            this.Controls.Add(this.usePassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Land";
            this.Load += new System.EventHandler(this.Land_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox usePassword;
        private System.Windows.Forms.ComboBox useIdentity;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}

