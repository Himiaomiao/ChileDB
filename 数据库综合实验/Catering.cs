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
            String num = Program.PersonId;
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
           
            String find = "SELECT * FROM CateringStaff WHERE cts_num ='" + num + "'";
            MySqlCommand mycom = new MySqlCommand(find, cnn);
            cnn.Open();
            MySqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
           ct_num.Text = reader[0] + "";
            ct_name.Text = reader[1] + "";
            ct_telnum.Text = reader[2] + "";
            ct_knowledge.Text = reader[3] + "";
            ct_grade.Text = reader[4] + "";
            ct_salsre.Text = reader[5] + "";
            cnn.Close();

           
        }

        //主页信息显示
        private void 主页ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //主页信息
            String num = Program.PersonId;
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);

            String find = "SELECT * FROM CateringStaff WHERE cts_num ='" + num + "'";
            MySqlCommand mycom = new MySqlCommand(find, cnn);
            cnn.Open();
            MySqlDataReader reader = mycom.ExecuteReader();
            reader.Read();
            ct_num.Text = reader[0] + "";
            ct_name.Text = reader[1] + "";
            ct_telnum.Text = reader[2] + "";
            ct_knowledge.Text = reader[3] + "";
            ct_grade.Text = reader[4] + "";
            ct_salsre.Text = reader[5] + "";
            cnn.Close();
        }

        private void Catering_Load(object sender, EventArgs e)
        {

        }

        private void 查询食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
