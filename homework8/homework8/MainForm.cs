using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework8
{
    public partial class MainForm : Form
    {
        private DetailsForm detailsForm = new DetailsForm();

        private event Action<int> openNewForm;

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 判断该字符串是否是数字
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public bool isNum(string s)
        {
            if (s == "") return false;
            foreach(char c in s)
            {
                if (c < '0' || c > '9') return false;
            }
            return true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            using( homework8Entities1 db=new homework8Entities1())
            {
                //创建实体类型 ,初始化显示器
                orderDataGridView.DataSource = db.orderservice.ToList();
            }
            openNewForm += detailsForm.renewForm;
        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {

            //先判断输入值是否合理化 先ID 后名字
            if (isNum(customerIdTextBox.Text))
            {
                //id合法
                if (customerNameTextBox.Text == "")
                {
                    //名字不合法
                    MessageBox.Show("名字不能为空！");

                }
                else
                {
                    try {
                        //全合法，但是Id还没有查重,,
                        using (homework8Entities1 db = new homework8Entities1())
                        {
                            //创建ef实例 创建一个订单对象
                            int id = Convert.ToInt32(customerIdTextBox.Text);//新建ID
                            orderservice newOrder = new orderservice();
                            newOrder.orderId = id;
                            newOrder.orderAmount = 0;
                            newOrder.custormerName = customerNameTextBox.Text;
                            db.orderservice.Add(newOrder);
                            db.SaveChanges();
                            MessageBox.Show("订单添加成功!");
                            orderDataGridView.DataSource = null;
                            orderDataGridView.DataSource = db.orderservice.ToList();
                        }
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("订单添加失败::" + ex.Message);
                    }

                }

            }
            else
            {
                //不是数字
                MessageBox.Show("新建订单ID请输入整数!");
            }


        }

        private void DeleteOrderbutton_Click(object sender, EventArgs e)
        {
            //点击次按钮就删除，对应ID,先判断输入的是否为整数
            if (isNum(deleteOrderIdTextBox.Text))
            {
                //为整数
                try
                {
                   //创建实体对象
                   using(homework8Entities1 db =new homework8Entities1())
                    {
                        int deleteId = Convert.ToInt32(deleteOrderIdTextBox.Text);
                        //查询ID 返回对应的结果
                        var result= db.orderservice.Where(s => s.orderId == deleteId).FirstOrDefault();
                        db.orderservice.Remove(result);
                        db.SaveChanges();
                        MessageBox.Show($"删除订单{deleteId}成功!");
                        orderDataGridView.DataSource = null;
                        orderDataGridView.DataSource = db.orderservice.ToList();
                    }
                   
                }
                catch(Exception ex)
                {
                    MessageBox.Show("删除失败,该订单不存在!");
                }

            }
            else
            {
                MessageBox.Show("请你输入整数！");
            }

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void queryButton_Click(object sender, EventArgs e)
        {
            if (isNum(queryIdTextBox.Text))
            {
                //判断输入的ID是否为整数
                //判断该id是否存在
                int id = Convert.ToInt32(queryIdTextBox.Text);
                using(homework8Entities1 db = new homework8Entities1())
                {
                    var result= db.orderservice.Where(s => s.orderId == id);
                    if (result.Count() == 0)
                    {
                        MessageBox.Show("不存在该ID的订单!");
                    }
                    else
                    {
                        //说明存在在订单，创建窗口,给那个初始化赋初值
                        openNewForm(id);
                        //打开明细窗口
                        detailsForm.ShowDialog();
                        //datagridview更新
                        orderDataGridView.DataSource = null;
                        orderDataGridView.DataSource = db.orderservice.ToList();
                    }

                }

            }
            else
            {
                MessageBox.Show("请输入整数！");  
            }
        }
    }
}
