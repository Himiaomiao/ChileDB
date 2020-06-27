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
    public partial class MakeFood : Form
    {
        public MakeFood()
        {
            InitializeComponent();
        }

        //查看需要制作的食物信息

        private void button1_Click(object sender, EventArgs e)
        {
            String num = co_num.Text.Trim();
            String name = co_name.Text.Trim();

            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            cnn.Open();
            if (num.Length == 0 && name.Length == 0)
            {
                MessageBox.Show("请输入厨师的编号或者姓名!");
            }
            else
            {
                String find = "";
                if (num.Length != 0)
                {
                    //按编号查找需要制作的食物
                   find=" SELECT Food.food_num,food_name,food_type,food_description,food_suitablemeal,food_carft,food_texture FROM Food JOIN Food_Cook " +
                        "ON Food.food_num = Food_Cook.food_num WHERE Food_Cook.cook_num = '"+num+"'";
                }
                else if (name.Length != 0)
                {
                    //按姓名查找需要制作的食物
                    find= "SELECT Food.food_num,food_name,food_type,food_description,food_suitablemeal,food_carft,food_texture FROM Food " +
                        " JOIN (SELECT food_num FROM Food_Cook WHERE Food_Cook.cook_num = (SELECT Cook.cook_num FROM Cook WHERE Cook.cook_name = '"+name+"'))" +
                        " AS a ON a.food_num = Food.food_num";
                }
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
    }
}
