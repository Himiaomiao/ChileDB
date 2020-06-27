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
    public partial class Catering : Form
    {
        public Catering()
        {
            InitializeComponent();
            //获取厨师输入的姓名
            String Id = Program.id;
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
           
            String find = "SELECT *FROM CateringStaff WHERE cts_num='"+Id+"';";
            MySqlCommand mycom = new MySqlCommand(find, cnn);
            cnn.Open();
            MySqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
           num.Text = reader[0] + "";
            name.Text = reader[1] + "";
            telnum.Text = reader[2] + "";
            knowledge.Text = reader[3] + "";
            grade.Text = reader[4] + "";
            salsre.Text = reader[5] + "";
            cnn.Close();

           
        }

        //主页信息显示
        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //主页信息
            String Id = Program.id;
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);

            String find = "SELECT *FROM CateringStaff WHERE cts_num='" + Id + "';";
            MySqlCommand mycom = new MySqlCommand(find, cnn);
            cnn.Open();
            MySqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            num.Text = reader[0] + "";
            name.Text = reader[1] + "";
            telnum.Text = reader[2] + "";
            knowledge.Text = reader[3] + "";
            grade.Text = reader[4] + "";
            salsre.Text = reader[5] + "";
            cnn.Close();
        }

        private void Catering_Load(object sender, EventArgs e)
        {

        }

        private void 查询食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerachFood serfood = new SerachFood();
            serfood.Show();
        }

        private void 查看班级信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Class cl = new Class();
            cl.Show();
        }
    }
}
