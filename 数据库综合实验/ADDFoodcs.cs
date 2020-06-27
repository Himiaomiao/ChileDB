using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace Mysqltest
{
    public partial class ADDFoodcs : Form
    {
        public ADDFoodcs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //获取添加的食物信息
            String num = food_num.Text.Trim();
            String name = food_name.Text.Trim();
            String type = food_type.Text.Trim();
            String time = food_time.Text.Trim();
            String induction = food_induction.Text.Trim();
            String carft = food_carft.Text.Trim();
            String texture = food_texture.Text.Trim();
            if (num.Length == 0 && name.Length == 0 &&time.Length==0&& type.Length == 0 && induction.Length == 0 && carft.Length == 0 && texture.Length == 0)
            {
                MessageBox.Show("不能获取你的增加信息，请输入食物信息！！！");
                this.Close();
            }
            else
            {
                if (num.Length == 0)
                {
                    MessageBox.Show("食物编号为必填!!!");
                    food_num.Focus();
                }
                else
                {
                    String str = "INSERT INTO Food VALUES('"+num+"','"+name+"','"+induction+"'," +
                        "'"+type+"','"+time+"','"+carft+"','"+texture+"')";
                    string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
                    MySqlConnection cnn = new MySqlConnection(connetStr);
                    MySqlCommand mysqlcmd = new MySqlCommand(str, cnn);
                    cnn.Open();
                    mysqlcmd.ExecuteNonQuery();
                    cnn.Close();
                    MessageBox.Show("添加成功！！！");
                    this.Close();
                }
            }
        }

        //取消操作
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认取消操作！！！");
            this.Close();

        }
    }
}
