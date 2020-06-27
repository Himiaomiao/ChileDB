namespace Mysqltest
{
    partial class Delete
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.food_num = new System.Windows.Forms.TextBox();
            this.food_name = new System.Windows.Forms.TextBox();
            this.food_type = new System.Windows.Forms.ComboBox();
            this.food_texture = new System.Windows.Forms.ComboBox();
            this.food_carft = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(283, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "输入删除的食物信息";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(137, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "食物编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(137, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "食物名称";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(137, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "食物类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(137, 240);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "食物口感";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(137, 299);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "食物工艺";
            // 
            // food_num
            // 
            this.food_num.Font = new System.Drawing.Font("宋体", 12F);
            this.food_num.Location = new System.Drawing.Point(301, 61);
            this.food_num.Name = "food_num";
            this.food_num.Size = new System.Drawing.Size(201, 35);
            this.food_num.TabIndex = 6;
            // 
            // food_name
            // 
            this.food_name.Font = new System.Drawing.Font("宋体", 12F);
            this.food_name.Location = new System.Drawing.Point(301, 116);
            this.food_name.Name = "food_name";
            this.food_name.Size = new System.Drawing.Size(201, 35);
            this.food_name.TabIndex = 7;
            // 
            // food_type
            // 
            this.food_type.Font = new System.Drawing.Font("宋体", 12F);
            this.food_type.FormattingEnabled = true;
            this.food_type.Location = new System.Drawing.Point(301, 176);
            this.food_type.Name = "food_type";
            this.food_type.Size = new System.Drawing.Size(201, 32);
            this.food_type.TabIndex = 8;
            // 
            // food_texture
            // 
            this.food_texture.Font = new System.Drawing.Font("宋体", 12F);
            this.food_texture.FormattingEnabled = true;
            this.food_texture.Location = new System.Drawing.Point(301, 240);
            this.food_texture.Name = "food_texture";
            this.food_texture.Size = new System.Drawing.Size(201, 32);
            this.food_texture.TabIndex = 9;
            // 
            // food_carft
            // 
            this.food_carft.Font = new System.Drawing.Font("宋体", 12F);
            this.food_carft.FormattingEnabled = true;
            this.food_carft.Location = new System.Drawing.Point(301, 299);
            this.food_carft.Name = "food_carft";
            this.food_carft.Size = new System.Drawing.Size(201, 32);
            this.food_carft.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(141, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 40);
            this.button1.TabIndex = 11;
            this.button1.Text = "确认删除";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(436, 365);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(141, 40);
            this.button2.TabIndex = 12;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Delete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.food_carft);
            this.Controls.Add(this.food_texture);
            this.Controls.Add(this.food_type);
            this.Controls.Add(this.food_name);
            this.Controls.Add(this.food_num);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Delete";
            this.Text = "删除食物信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox food_num;
        private System.Windows.Forms.TextBox food_name;
        private System.Windows.Forms.ComboBox food_type;
        private System.Windows.Forms.ComboBox food_texture;
        private System.Windows.Forms.ComboBox food_carft;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}