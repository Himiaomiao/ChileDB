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
    public partial class CookUpdate : Form
    {
        public CookUpdate()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            MessageBox.Show("确认取消更新！！！！！");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String co_num = num.Text.Trim();
            //获取厨师姓名
            String co_name = name.Text.Trim();
            //获取厨师电话
            String co_telnum = telnum.Text.Trim();
            //获取厨师工种
            String co_typeofwork = typeofwork.Text.Trim();
            //获取厨师等级
            String co_grade = grade.Text.Trim();
            
            //连接数据库
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);

            if (co_num.Length == 0)
            {
                MessageBox.Show("请先输入编号！！！！！");
            }
            else if (co_name.Length == 0 && co_telnum.Length == 0 && co_typeofwork.Length == 0 && co_grade.Length == 0)
            {
                MessageBox.Show("请输入更新信息！！！！");
            }
            else
            {
                String str = "";
                 if (co_name.Length != 0)
                {
                    str = "UPDATE Cook SET cook_name='"+co_name+"' WHERE cook_num ='"+co_num+"'";
                }
               if (co_telnum.Length != 0)
                {
                    str = "UPDATE Cook SET cook_telnum='" + co_telnum + "' WHERE cook_num='" + co_num + "'";
                }
                if (co_typeofwork.Length != 0)
                {
                    str = "UPDATE Cook SET cook_typeofwork = '" + co_typeofwork + "' WHERE cook_num = '" + co_num + "'";
                }
                if (co_grade.Length != 0)
                {
                    str = "UPDATE Cook SET cook_grade='" + co_grade + "' WHERE cook_num='" + co_num + "'";
                }
                    MySqlCommand mysqlcmd = new MySqlCommand(str, cnn);
                    cnn.Open();
                    mysqlcmd.ExecuteNonQuery();
                cnn.Close();
                MessageBox.Show("更新完成!!!!!");
                this.Close();

            }

        }
    }
}
