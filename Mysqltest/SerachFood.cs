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
    public partial class SerachFood : Form
    {
        public SerachFood()
        {
            InitializeComponent();
        
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "SELECT * FROM Food ";
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

        private void button3_Click(object sender, EventArgs e)
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

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("确认取消查询!!!!");
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
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
        //查询
        private void button1_Click(object sender, EventArgs e)
        {
            String num = food_num.Text.Trim();
            String name = food_name.Text.Trim();
            String time = food_time.Text.Trim();
            String type = food_type.Text.Trim();
            String texture = food_texture.Text.Trim();
            String carft = food_carft.Text.Trim();
           

            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            String find = "";
            if (num.Length == 0 && name.Length == 0 && time.Length == 0 && type.Length == 0 && texture.Length == 0 && carft.Length == 0)
            {
                find = "SELECT * FROM Food";
            }
            else
            {
                //实现随机查询
                find = "SELECT * FROM Food WHERE";
                   
                if (num.Length != 0)
                {
                    //if ( name.Length != 0 || time.Length != 0 || type.Length != 0 || texture.Length != 0 || carft.Length != 0)
                                
                      //  find += " AND food_num='" + num + "'";
                    //else
                        find += " food_num='" + num + "'";

                }
                if (name.Length!=0)
                {
                    if (num.Length != 0 || time.Length != 0 || type.Length != 0 || texture.Length != 0 || carft.Length != 0)
                        find += "AND food_name='" + name + "'";
                
                    else
                    {
                        find += " food_name='" + name + "'";
                    }

                }
                if (time.Length != 0)
                {
                    if (num.Length != 0 || name.Length != 0 || type.Length != 0 || texture.Length != 0 || carft.Length != 0)
                    {
                        find += "AND food_suitablemeal='"+ time+"'";
                    }
                    else

                    find += " food_suitablemeal='" + time+"'";

                }
                if (type.Length != 0)
                {
                    if (num.Length != 0 || name.Length != 0 || time.Length != 0 || texture.Length != 0 || carft.Length != 0)
                    {
                        find += "AND food_type='" + type+"'";
                    }
                    else
                    find += "  food_type='" + type+"'";

                }
                if (texture.Length != 0)
                {
                    if (num.Length != 0 || name.Length != 0 || time.Length != 0 || type.Length != 0 || carft.Length != 0)
                    {
                        find += "AND food_texture='" + texture+"'";
                    }
                    else
                        find += " food_texture='" + texture+"'";
                }
                if (carft.Length != 0)
                {
                    if (num.Length != 0 || name.Length != 0 || time.Length != 0 || texture.Length != 0 || type.Length != 0)
                    {
                        find += "AND food_carft='" + carft+"'";
                    }
                    else
                        find += " food_carft='" + carft+"'";

                }
            }
                //创建MysqlDataAdapter
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

        private void food_time_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
