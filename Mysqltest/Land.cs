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
    public partial class Land : Form
    {
        int errtime = 5;
        public Land()
        {
            InitializeComponent();
        }
        //切换注册窗口
        private void button3_Click(object sender, EventArgs e)
        {
            Zuce zuce = new Zuce();
            zuce.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //取消登陆
        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("您已选择取消登陆！！！！！！");
        }
        //登陆按钮，成功登陆将切换对应的用户功能页面
        private void button1_Click(object sender, EventArgs e)
        {

            //定义最多能有三次错误
            errtime = errtime - 1;
            //获取登陆的信息
           //用户名
            String num = userName.Text.Trim();
            //用户密码
            String password = usePassword.Text.Trim();
            //用户身份
            String identity = useIdentity.Text.Trim();

            

            if (num.Length == 0 || password.Length == 0 || identity.Length == 0)
            {
                MessageBox.Show("请输入完整的登陆信息！！！！");
                
            }
            //连接数据库
            string connetStr = "server=212.64.34.13;port=3306;user=moon;password=asd9032;database=mydbtest;Charset=utf8;";
            MySqlConnection cnn = new MySqlConnection(connetStr);
            //打开数据库
            cnn.Open();
            MySqlCommand mycom = cnn.CreateCommand();         //创建SQL命令执行对象
            string s1 = "select use_name,use_passward from User where use_num='" + num + "' and use_passward='" + password + "'" +
                "and use_identity='"+identity+"'";                                            //编写SQL命令
            mycom.CommandText = s1;                           //执行SQL命令
            MySqlDataAdapter myDA = new MySqlDataAdapter();       //实例化数据适配器
            myDA.SelectCommand = mycom;                       //让适配器执行SELECT命令
            DataSet myDS = new DataSet();                     //实例化结果数据集
            int n = myDA.Fill(myDS, "Landtable");              //将结果放入数据适配器，返回元祖个数
            if (n!=0)
            {
                MessageBox.Show("登陆成功！！！！");
                //保存账号信息
                Program.id = num;
                Program.iden = identity;
                if (useIdentity.Text == "厨师")
                {
                    Cook cook = new Cook();
                    cook.Show();
                }
                else if (useIdentity.Text == "配餐员")
                {
                    Catering car = new Catering();
                    car.Show();
                }
                
            }
            else
            {
                if (errtime>0 && errtime < 5)
                {
                    MessageBox.Show("用户名或密码有错，请重新输入，还剩" + errtime.ToString() + "次机会！");
                    //清空输入的信息
                    userName.Text = "";
                    usePassword.Text = "";
                    useIdentity.Text = "";
                    //光标定位在用户名处
                    userName.Focus();
                }
              if(errtime==0)
                {
                    MessageBox.Show("还有0次机会,请联系管理员找回登陆信息！！！");
                    this.Close();
                }
            }
        }

        private void Land_Load(object sender, EventArgs e)
        {

        }
    }
}
