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
    public partial class Cook : Form
    {
        public Cook()
        {
            InitializeComponent();
        }

        private void 信息查询ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //个人信息查询
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        //姓名查询
        private void 姓名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取厨师输入的姓名
            String name = myname.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Cook WHERE cook_name='"+name+"'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "厨师编号";
            dataGridView1.Columns[1].HeaderText = "厨师姓名";
            dataGridView1.Columns[2].HeaderText = "厨师联系方式";
            dataGridView1.Columns[3].HeaderText = "厨师特长";
            dataGridView1.Columns[4].HeaderText = "厨师工种";
            dataGridView1.Columns[5].HeaderText = "厨师等级";
            dataGridView1.Columns[6].HeaderText = "厨师工资";

            //将厨师信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void 编号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取厨师输入的姓名
            String num = mynum.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Cook WHERE cook_name='" + num + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "厨师编号";
            dataGridView1.Columns[1].HeaderText = "厨师姓名";
            dataGridView1.Columns[2].HeaderText = "厨师联系方式";
            dataGridView1.Columns[3].HeaderText = "厨师特长";
            dataGridView1.Columns[4].HeaderText = "厨师工种";
            dataGridView1.Columns[5].HeaderText = "厨师等级";
            dataGridView1.Columns[6].HeaderText = "厨师工资";

            //将厨师信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void myname_Click(object sender, EventArgs e)
        {

        }

        
        //按食物名查看食物信息
        private void 食物名ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取食物输入名
            String name = food_name.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food WHERE food_name='" + name+ "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物编号";
            dataGridView1.Columns[1].HeaderText = "食物名";
            dataGridView1.Columns[2].HeaderText = "食物特点";
            dataGridView1.Columns[3].HeaderText = "食物类型";
            dataGridView1.Columns[4].HeaderText = "食物适宜时间";
            dataGridView1.Columns[5].HeaderText = "食物工艺";
            dataGridView1.Columns[6].HeaderText = "食物口感";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }
        
        //按食物类型查询
        private void 食物类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取食物输入名
            String type = food_type.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food WHERE food_type='" + type + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物编号";
            dataGridView1.Columns[1].HeaderText = "食物名";
            dataGridView1.Columns[2].HeaderText = "食物特点";
            dataGridView1.Columns[3].HeaderText = "食物类型";
            dataGridView1.Columns[4].HeaderText = "食物适宜时间";
            dataGridView1.Columns[5].HeaderText = "食物工艺";
            dataGridView1.Columns[6].HeaderText = "食物口感";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //按食物适宜餐次来查询
        private void 食物适宜餐次ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取食物输入名
            String time = food_time.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food WHERE food_suitablemeal='" + time + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物编号";
            dataGridView1.Columns[1].HeaderText = "食物名";
            dataGridView1.Columns[2].HeaderText = "食物特点";
            dataGridView1.Columns[3].HeaderText = "食物类型";
            dataGridView1.Columns[4].HeaderText = "食物适宜时间";
            dataGridView1.Columns[5].HeaderText = "食物工艺";
            dataGridView1.Columns[6].HeaderText = "食物口感";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //按食物口感查询
        private void 食物口感ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取食物输入名
            String texture = food_texture.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food WHERE food_texture='" + texture + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物编号";
            dataGridView1.Columns[1].HeaderText = "食物名";
            dataGridView1.Columns[2].HeaderText = "食物特点";
            dataGridView1.Columns[3].HeaderText = "食物类型";
            dataGridView1.Columns[4].HeaderText = "食物适宜时间";
            dataGridView1.Columns[5].HeaderText = "食物工艺";
            dataGridView1.Columns[6].HeaderText = "食物口感";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //按食物工艺来查询
        private void 食物工艺ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获取食物输入名
            String caft = food_caft.Text.Trim();
            if (caft.Length == 0)
            {
                MessageBox.Show("请输入查询信息！！！");
            }
            else
            {
                string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
                MySqlConnection cnn = new MySqlConnection(connetStr);
                cnn.Open();
                String find = "SELECT * FROM Food WHERE food_carft='" + caft + "'";
                MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
                DataSet DS = new DataSet();
                myDa.Fill(DS, "performtable");
                dataGridView1.DataSource = DS.Tables["performtable"];
                cnn.Close();
                dataGridView1.Columns[0].HeaderText = "食物编号";
                dataGridView1.Columns[1].HeaderText = "食物名";
                dataGridView1.Columns[2].HeaderText = "食物特点";
                dataGridView1.Columns[3].HeaderText = "食物类型";
                dataGridView1.Columns[4].HeaderText = "食物适宜时间";
                dataGridView1.Columns[5].HeaderText = "食物工艺";
                dataGridView1.Columns[6].HeaderText = "食物口感";

                //将食物信息显示
                for (int i = 0; i < dataGridView1.Columns.Count; i++)
                {
                    dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }
        //输入厨师编号，查看厨师需要做的对应的食物
        private void 厨师编号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            
        }

        //统计食物的总类
        private void 食物总类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            //合并同类型的食物，显示食物类型和食物数量
            String find = "SELECT food_type,COUNT(food_type) AS num FROM Food GROUP BY food_type;";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物类型";
            dataGridView1.Columns[1].HeaderText = "数量";
   

            //将统计信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void 修改个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CookUpdate coup = new CookUpdate();
            coup.Show();
        }

        private void 删除食物ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Delete fooddelete = new Delete();
            fooddelete.Show();
        }

        private void 修改食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodUpdate foodupdate = new FoodUpdate();
            foodupdate.Show();
        }

        private void 增加食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ADDFoodcs addfood = new ADDFoodcs();
            addfood.Show();
        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        //按编号查询
        private void 食物编号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String num = food_num.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food WHERE food_num='" + num + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物编号";
            dataGridView1.Columns[1].HeaderText = "食物名";
            dataGridView1.Columns[2].HeaderText = "食物特点";
            dataGridView1.Columns[3].HeaderText = "食物类型";
            dataGridView1.Columns[4].HeaderText = "食物适宜时间";
            dataGridView1.Columns[5].HeaderText = "食物工艺";
            dataGridView1.Columns[6].HeaderText = "食物口感";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void 其他ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 食材类型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String type = ing_type.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Ingredients WHERE ing_type='" + type + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食材编号";
            dataGridView1.Columns[1].HeaderText = "食材名称";
            dataGridView1.Columns[2].HeaderText = "食材特点";
            dataGridView1.Columns[3].HeaderText = "食材类型";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        //按食材编号查询
        private void 食材编号ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String num = ing_num.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Ingredients WHERE ing_num='" + num + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食材编号";
            dataGridView1.Columns[1].HeaderText = "食材名称";
            dataGridView1.Columns[2].HeaderText = "食材特点";
            dataGridView1.Columns[3].HeaderText = "食材类型";

            //将食物信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void 食材名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String name = ing_name.Text.Trim();
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Ingredients WHERE ing_name='" + name + "'";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食材编号";
            dataGridView1.Columns[1].HeaderText = "食材名称";
            dataGridView1.Columns[2].HeaderText = "食材特点";
            dataGridView1.Columns[3].HeaderText = "食材类型";

            //将食材信息显示
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                dataGridView1.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
        }

        private void 食材总类ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            //合并同类型的食物，显示食物类型和食物数量
            String find = "SELECT ing_type,COUNT(ing_type) AS num FROM Ingredients GROUP BY ing_type;";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食材类型";
            dataGridView1.Columns[1].HeaderText = "数量";
        }

        private void 食物库存量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            //合并同类型的食物，显示食物类型和食物数量
            String find = "SELECT COUNT(*) AS num FROM Food ;";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食物库存量";
        }

        private void 食材库存量ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            
            String find = "SELECT COUNT(*) AS num FROM Ingredients ;";
            MySqlDataAdapter myDa = new MySqlDataAdapter(find, cnn);
            DataSet DS = new DataSet();
            myDa.Fill(DS, "performtable");
            dataGridView1.DataSource = DS.Tables["performtable"];
            cnn.Close();
            dataGridView1.Columns[0].HeaderText = "食材库存量";
        }

        private void 需做食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MakeFood make = new MakeFood();
            make.Show();
        }

        private void 食物信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
