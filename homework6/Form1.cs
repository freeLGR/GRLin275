namespace homework6
{
    public partial class Form1 : Form
    {
        OrderService orderService;
        OrderAddForm orderAddForm1;
        DeleteOrderForm deleteOrderForm1;
        OrderDetailsForm orderDetailsForm1;
        public Form1()
        {
            //初始化所有子窗体
            orderService = new OrderService();
            orderAddForm1 = new OrderAddForm();
            deleteOrderForm1 = new DeleteOrderForm();
            orderDetailsForm1 = new OrderDetailsForm();
            InitializeComponent();
            //添加订单
            orderService.AddOrder(new Order(1, new Customer(1, "li")));
            orderService.AddOrder(new Order(2, new Customer(2, "王")));
            //添加订单明细
            orderService.orders[0].AddDetail(new OrderDetails(1, 20, new Goods(1, 2, "egg")));

            orderBindingSource.DataSource = orderService.orders;
            //orderDataGridView.DataSource = orderService.orders;
            //添加订单
           orderAddForm1.addOrder+=orderService.AddOrder;
            //orderAddForm1.addOrder += OrderAddForm1_addOrder;
            //删除订单，事件，订阅子窗体
            deleteOrderForm1.DeleteOrder += orderService.DeleteOrder;

        }

        //创建新的的订单
        //private void OrderAddForm1_addOrder(Order obj)
        //{
        //    orderBindingSource.DataSource = null;
        //    orderBindingSource.DataSource = orderService.orders;
        //}

        //判断一个字符串是否都是数字
        public bool isNum(string st)
        {
            if(st=="")return false;
            foreach (char s in st)
            {
                if (s < '0' || s > '9')
                {
                    return false;
                }
            }
            return true;
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void orderBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void addOrderButton_Click(object sender, EventArgs e)
        {
            orderAddForm1.ShowDialog(); 
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource=orderService.orders;
        }

        private void viewOrderDetailsButton_Click(object sender, EventArgs e)
        {
            //查询订单 先判断 订单Id是否为整数，然后判断Id是否在里面
            if (isNum(findOrderIdTextBox.Text))
            {
                int orderId=Convert.ToInt32(findOrderIdTextBox.Text);
                //接着判断该Id是否存在在订单中
                bool isExist = false;
                int i = 0;
                for(i = 0; i < orderService.orders.Count(); i++)
                {
                    if(orderService.orders[i].OrderId == orderId)
                    {//存在
                        isExist = true;
                        break;
                    }
                }
                //存在在订单中
                if (isExist)
                {
                    //将其作为订单明细窗体中的dataGridView的数据源,并修改一个标签
                    orderDetailsForm1.setMyForm($"订单Id：{findOrderIdTextBox.Text}", orderService.orders[i].Details, orderService.orders[i]);
                    orderDetailsForm1.ShowDialog();
                    //更新数据源
                    //展缓=======================================================
                }
                else
                {
                    MessageBox.Show("该ID不存在！");
                }

            }
            else
            {
                //输入的字符串不是整数
                MessageBox.Show("您输入的订单ID不是整数!");
            }




        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            deleteOrderForm1.ShowDialog();
            orderBindingSource.DataSource = null;
            orderBindingSource.DataSource = orderService.orders;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (sortComboBox.SelectedIndex) {
                case -1:MessageBox.Show("排序方式不能为空！请选择排序方式!");
                    break;
                case 0:
                    orderService.SortByAmount();
                    orderBindingSource.DataSource = null;
                    orderBindingSource.DataSource = orderService.orders;
                    break;
                case 2:
                    orderService.SortByID();
                    orderBindingSource.DataSource = null;
                    orderBindingSource.DataSource = orderService.orders;
                    break;


            }


        }
    }
}