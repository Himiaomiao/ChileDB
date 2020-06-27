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
    public partial class Zuce : Form
    {
        public Zuce()
        {
            InitializeComponent();
        }

        //确认注册
        private void button1_Click(object sender, EventArgs e)
        {
            //获取用户输入的注册信息
            //用户编号
            String num = user_num.Text.Trim();
            //用户名
            String name = user_name.Text.Trim();
            //用户密码
            String password = user_password.Text.Trim();
            //用户身份
            String identity = user_identity.Text.Trim();
            //个人编号
            String uid  = user_id.Text.Trim();
            Program.PersonId = uid;

            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            if (num.Length == 0 || name.Length == 0 || password.Length == 0 || identity.Length == 0 || uid.Length == 0)
            {
                MessageBox.Show("请输入用户信息后点击注册！！！！");
            }
            //添加信息mysql语句
            string sqlstr = "INSERT INTO User VALUES('" + num + "','" + name + "','" + password + "','" + identity + "','" + uid + "')";
            MySqlCommand mysqlcmd = new MySqlCommand(sqlstr, cnn);
           cnn.Open();
            mysqlcmd.ExecuteNonQuery();
            cnn.Close();
            //添加提示信息，提示输入成功
            MessageBox.Show("添加成功！！！！！");
            this.Close();
            Land land = new Land();
            land.Show();
        }

        //取消注册
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您已取消操作！！！！");
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void user_id_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
