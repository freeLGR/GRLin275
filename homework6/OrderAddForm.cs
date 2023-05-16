using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace homework6
{
    public partial class OrderAddForm : Form
    {
        //事件，用来提醒orderService创建对象的
        public event Action<Order> addOrder;
        public OrderAddForm()
        {
            InitializeComponent();
        }
        //判断一个字符串是否都是数字
        public bool isNum(string st)
        {
            if(st == null) return false;
            foreach (char s in st)
            {
                if (s < '0' || s > '9')
                {
                    return false;
                }
            }
            return true;
        }


        private void OrderAddForm_Load(object sender, EventArgs e)
        {

        }

        private void orderAddButton_Click(object sender, EventArgs e)
        {
            //先判断是否合理
            if (isNum(orderIdTextBox.Text))
            {
                if (orderAddCustomerComboBox.Text == "li")
                {
                    addOrder(new Order(Convert.ToInt32(orderIdTextBox.Text), new Customer(0, "li")));
                }else if (orderAddCustomerComboBox.Text == "wang")
                {
                    addOrder(new Order(Convert.ToInt32(orderIdTextBox.Text), new Customer(1, "wang")));
                }
                else
                {
                   MessageBox.Show("输入的客户名错误!");
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("输入的ID错误!");
            }

            //用委托来创建
          

        }
    }
}

