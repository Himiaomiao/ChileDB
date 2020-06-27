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
    public partial class FoodUpdate : Form
    {
        public FoodUpdate()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        //取消更新食物信息
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确定取消更新？？？");
            this.Close();
        }

        //更新食物信息
        private void button1_Click(object sender, EventArgs e)
        {
            //获取食物编号
            String fo_num = food_num.Text.Trim();
            //获取食物名
            String fo_name = food_name.Text.Trim();
            //获取食物特点
            String fo_induction = food_induction.Text.Trim();
            //获取食物适宜餐次
            String fo_time = food_time.Text.Trim();
            //获取食物类型
            String fo_type = food_type.Text.Trim();
            //获取食物工艺
            String fo_caft = food_caft.Text.Trim();
            //获取食物口感
            String fo_texture = food_texture.Text.Trim();
            //连接数据库
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);

            if (fo_num.Length == 0)
            {
                MessageBox.Show("请先输入编号！！！！！");
            }
            else if (fo_name.Length == 0 && fo_induction.Length == 0 && fo_type.Length
                == 0 && fo_caft.Length == 0 && fo_texture.Length != 0)
            {
                MessageBox.Show("请输入更新信息！！！！");
            }
            else
            {
                String str = "";
                if (fo_name.Length != 0)
                {
                    str = "UPDATE Food SET food_name='" + fo_name + "' WHERE food_num ='" + fo_num + "'";
                }
                if (fo_induction.Length != 0)
                {
                    str = "UPDATE Food SET food_description='" + fo_induction + "' WHERE food_num='" + fo_num + "'";
                }
                if (fo_time.Length != 0)
                {
                    str = "UPDATE Food SET food_suitablemeal='" + fo_time + "' WHERE food_num='" + fo_num + "'";
                }
                if (fo_type.Length != 0)
                {
                    str = "UPDATE Food SET food_type = '" + fo_type + "' WHERE food_num = '" + fo_num + "'";
                }
                if (fo_caft.Length != 0)
                {
                    str = "UPDATE Food SET food_carft='" + fo_caft + "' WHERE food_num='" + fo_num + "'";
                }
                if (fo_texture.Length != 0)
                {
                    str = "UPDATE Food SET food_texture='" + fo_texture + "' WHERE food_num='" + fo_num + "'";
                }
                MySqlCommand mysqlcmd = new MySqlCommand(str, cnn);
                cnn.Open();
                mysqlcmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("更新完成!!!!!");
                this.Close();
            }
        }

        private void food_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
