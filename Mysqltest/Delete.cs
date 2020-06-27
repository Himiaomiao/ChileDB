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
    public partial class Delete : Form
    {
        public Delete()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您选择取消更新!");
            this.Close();

        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            /*
             删除食物信息，级联操作，需要先删除子表，在删除食物表的食物信息
            //对批量删除的操纵还不能实现
             */
            //输入删除的食物信息
            String num = food_num.Text.Trim();
            String name = food_name.Text.Trim();
            String type = food_type.Text.Trim();
            String texture = food_texture.Text.Trim();
            String carft = food_carft.Text.Trim();

            //数据库连接
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            //删除操作
            if (num.Length == 0 && name.Length == 0 && type.Length == 0 && texture.Length == 0 && carft.Length == 0)
            {
                MessageBox.Show("请输入删除对象相关信息");
            }
            String mysqlstr = "";
            String mysqlstr2 = "";
            if (num.Length != 0)
            {
                
                mysqlstr2 = "DELETE FROM Food_Cook WHERE food_num='" + num + "'";
                mysqlstr = "DELETE FROM Food WHERE food_num='" + num + "'";
            }
            if (name.Length != 0)
            {
                mysqlstr2 = "DELETE FROM Food_Cook WHERE (SELECT food_num FROM Food WHERE food_name='" + name + "')";
                mysqlstr = "DELETE FROM Food WHERE food_name='" + name + "'";
            }
            if (type.Length != 0)
            {
                mysqlstr2 = "DELETE FROM Food_Cook WHERE (SELECT food_num FROM Food WHERE food_type='" + type + "')";
                mysqlstr = "DELETE FROM Food WHERE food_type='" + type + "'";
            }
            if (texture.Length != 0)
            {
                mysqlstr2 = "DELETE FROM Food_Cook WHERE (SELECT food_num FROM Food WHERE food_texture='" + texture + "')";
                mysqlstr = "DELETE FROM Food WHERE food_texture='" + texture + "'";
            }
            if (carft.Length != 0)
            {
                mysqlstr2 = "DELETE FROM Food_Cook WHERE (SELECT food_num FROM Food WHERE food_carft='" + carft + "')";
                mysqlstr = "DELETE FROM Food WHERE food_carft='" + carft + "'";
            }
            cnn.Open();
            MySqlCommand mysqlcm = cnn.CreateCommand();
            MySqlCommand mysqlcm2 = cnn.CreateCommand();
            mysqlcm2.CommandText = mysqlstr2;
                mysqlcm2.ExecuteNonQuery();
                mysqlcm.ExecuteNonQuery();
                cnn.Close();
           
            MessageBox.Show("删除成功！！！！");
        }
    }
}
