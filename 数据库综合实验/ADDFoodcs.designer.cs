namespace Mysqltest
{
    partial class ADDFoodcs
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
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.food_num = new System.Windows.Forms.TextBox();
            this.food_name = new System.Windows.Forms.TextBox();
            this.food_induction = new System.Windows.Forms.TextBox();
            this.food_type = new System.Windows.Forms.ComboBox();
            this.food_time = new System.Windows.Forms.ComboBox();
            this.food_carft = new System.Windows.Forms.ComboBox();
            this.food_texture = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(276, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "增加新食物";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 12F);
            this.label2.Location = new System.Drawing.Point(186, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "食物编号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.Location = new System.Drawing.Point(186, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "食物名称";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.Location = new System.Drawing.Point(186, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 24);
            this.label4.TabIndex = 3;
            this.label4.Text = "食物类型";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.Location = new System.Drawing.Point(186, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 4;
            this.label5.Text = "食物特点";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(186, 262);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 24);
            this.label6.TabIndex = 5;
            this.label6.Text = "适宜餐次";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.Location = new System.Drawing.Point(186, 317);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 24);
            this.label7.TabIndex = 6;
            this.label7.Text = "食物工艺";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.Location = new System.Drawing.Point(186, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 24);
            this.label8.TabIndex = 7;
            this.label8.Text = "食物口感";
            // 
            // food_num
            // 
            this.food_num.Font = new System.Drawing.Font("宋体", 12F);
            this.food_num.Location = new System.Drawing.Point(329, 54);
            this.food_num.Name = "food_num";
            this.food_num.Size = new System.Drawing.Size(192, 35);
            this.food_num.TabIndex = 8;
            // 
            // food_name
            // 
            this.food_name.Font = new System.Drawing.Font("宋体", 12F);
            this.food_name.Location = new System.Drawing.Point(329, 109);
            this.food_name.Name = "food_name";
            this.food_name.Size = new System.Drawing.Size(192, 35);
            this.food_name.TabIndex = 9;
            // 
            // food_induction
            // 
            this.food_induction.Font = new System.Drawing.Font("宋体", 12F);
            this.food_induction.Location = new System.Drawing.Point(329, 214);
            this.food_induction.Name = "food_induction";
            this.food_induction.Size = new System.Drawing.Size(192, 35);
            this.food_induction.TabIndex = 10;
            // 
            // food_type
            // 
            this.food_type.Font = new System.Drawing.Font("宋体", 12F);
            this.food_type.FormattingEnabled = true;
            this.food_type.Items.AddRange(new object[] {
            "蔬菜类",
            "水果类",
            "鸡肉类",
            "鸭肉类",
            "猪肉类",
            "牛肉类",
            "羊肉类",
            "面类",
            "汤",
            "粗粮类"});
            this.food_type.Location = new System.Drawing.Point(329, 165);
            this.food_type.Name = "food_type";
            this.food_type.Size = new System.Drawing.Size(192, 32);
            this.food_type.TabIndex = 11;
            // 
            // food_time
            // 
            this.food_time.Font = new System.Drawing.Font("宋体", 12F);
            this.food_time.FormattingEnabled = true;
            this.food_time.Items.AddRange(new object[] {
            "任何餐次",
            "早餐",
            "午餐",
            "晚餐",
            "早餐午餐",
            "午餐晚餐",
            "早餐晚餐"});
            this.food_time.Location = new System.Drawing.Point(329, 262);
            this.food_time.Name = "food_time";
            this.food_time.Size = new System.Drawing.Size(192, 32);
            this.food_time.TabIndex = 12;
            // 
            // food_carft
            // 
            this.food_carft.Font = new System.Drawing.Font("宋体", 12F);
            this.food_carft.FormattingEnabled = true;
            this.food_carft.Items.AddRange(new object[] {
            "烧",
            "蒸",
            "煮",
            "拌",
            "炒",
            "卤",
            "炖"});
            this.food_carft.Location = new System.Drawing.Point(329, 320);
            this.food_carft.Name = "food_carft";
            this.food_carft.Size = new System.Drawing.Size(192, 32);
            this.food_carft.TabIndex = 13;
            // 
            // food_texture
            // 
            this.food_texture.Font = new System.Drawing.Font("宋体", 12F);
            this.food_texture.FormattingEnabled = true;
            this.food_texture.Items.AddRange(new object[] {
            "咸鲜",
            "香辣",
            "清淡",
            "原本味"});
            this.food_texture.Location = new System.Drawing.Point(329, 370);
            this.food_texture.Name = "food_texture";
            this.food_texture.Size = new System.Drawing.Size(192, 32);
            this.food_texture.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 12F);
            this.button1.Location = new System.Drawing.Point(161, 433);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 53);
            this.button1.TabIndex = 15;
            this.button1.Text = "确认增添";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("宋体", 12F);
            this.button2.Location = new System.Drawing.Point(413, 433);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 53);
            this.button2.TabIndex = 16;
            this.button2.Text = "取消";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ADDFoodcs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 527);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.food_texture);
            this.Controls.Add(this.food_carft);
            this.Controls.Add(this.food_time);
            this.Controls.Add(this.food_type);
            this.Controls.Add(this.food_induction);
            this.Controls.Add(this.food_name);
            this.Controls.Add(this.food_num);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ADDFoodcs";
            this.Text = "增加食物";
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox food_num;
        private System.Windows.Forms.TextBox food_name;
        private System.Windows.Forms.TextBox food_induction;
        private System.Windows.Forms.ComboBox food_type;
        private System.Windows.Forms.ComboBox food_time;
        private System.Windows.Forms.ComboBox food_carft;
        private System.Windows.Forms.ComboBox food_texture;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}