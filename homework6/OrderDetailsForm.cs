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
    public partial class OrderDetailsForm : Form
    {



        //记录来自Orders数组的序号的index
     
        private Order myOrder;
        //事件 删除明细 添添加明细
        public event Action<int, int> DeleteDetails;


        public OrderDetailsForm()
        {
            InitializeComponent();
        }

        //判断一个字符串是否都是数字
        public bool isNum(string st)
        {
            if (st == "") return false;
            foreach (char s in st)
            {
                if (s < '0' || s > '9')
                {
                    return false;
                }
            }
            return true;
        }

        //一个函数，，向外界提供修改我的数据源，以及标签的函数
        public void setMyForm(string st,List<OrderDetails> orderDetails,Order order)
        {
            
            //修改进入界面的标签
            label1.Text = st;   
            //修改数据源
            orderDetailsBindingSource.DataSource = orderDetails;
            myOrder = order;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void OrderDetailsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void orderDetailsBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void deleteDetailsButton_Click(object sender, EventArgs e)
        {
            //先判断输入的是否合法
            if (isNum(deleteDetailsIdTextBox.Text))
            {
                //合法 调用事件
                //删除，首先，知道了这个Detail的Id，直接调用,事件，参数，orders数组的index，以及detail的数组.
               myOrder.DeleteDetail(Convert.ToInt32(deleteDetailsIdTextBox.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("您输入的ID不合法!");
            }

           
        
        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            //添加明细，首先，先判断是否合法 货物 质量 ID
           if(GoodsNameComboBox.SelectedIndex == -1) { MessageBox.Show("请选择货物名称!"); }
            //质量
            if (isNum(quantityTextBox.Text))
            {
                //质量为数字 接着判断 输入的ID是否为数字
                if (isNum(addDetailIdTextBox1.Text))
                {
                    //此时质量,货物，ID均为合法输入
                    int newID=Convert.ToInt32(addDetailIdTextBox1.Text);
                    double myQuantity = Convert.ToDouble(quantityTextBox.Text);
                    bool addSuccess = false;
                    switch (GoodsNameComboBox.Text) {
                        case "egg":
                          addSuccess=myOrder.AddDetail(new OrderDetails(newID, myQuantity, new Goods(0,2.0, "eggs")));
                            break;
                        case "pear":
                           addSuccess=myOrder.AddDetail(new OrderDetails(newID, myQuantity, new Goods(1, 20.0, "pear")));
                            break;
                    }
                    if(addSuccess) MessageBox.Show("订单明细添加成功!");

                    orderDetailsBindingSource.DataSource = null;
                    orderDetailsBindingSource.DataSource = myOrder.Details;
                }

            }
        }
    }
}
