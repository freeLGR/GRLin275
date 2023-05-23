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
    public partial class DetailsForm : Form
    {
        int orderId=0;
        /// <summary>
        /// 判断字符串是否为整数
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
        public void renewForm(int id)
        {
            //修改提示信息
            orderIdLabel.Text = "订单的ID号为:" + id;
            //接下来就要展示数据了
            this.orderId = id;

            using(homework8Entities1 db=new homework8Entities1())
            {
                //修改数据源
                var details= db.details.Where(s => s.orderId == id).ToList();//查询该id所对应的id
                dataGridView1.DataSource = details;
            }

        }

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            addGoodsComboBox.SelectedIndex = 1;
        }

        private void addDetailIdTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void addDetailButton_Click(object sender, EventArgs e)
        {
            //添加订单明细 先判断输入是否合法 id 质量
            try
            {
                Convert.ToInt32(addDetailIdTextBox.Text);
                Convert.ToDouble(quantityTextBox.Text);

                    }
            catch (Exception ex)
            {
                MessageBox.Show("请输入合法值！");
                return;
            }

            //说明以上值均为合法
            int id = Convert.ToInt32(addDetailIdTextBox.Text);
            double quantity = Convert.ToDouble(quantityTextBox.Text);
            //判断id是否重复
            using (homework8Entities1 db = new homework8Entities1())
            {
                //查询数据库
                var result= db.details.Where(s => s.detailId == id && s.orderId == this.orderId);
                if (result.Count()== 0){
                    //说明不存在该id，则可以创建对应记录 并更新service表中的总金额
                    if (addGoodsComboBox.Text == "egg")
                    {
                        //说明新增的是鸡蛋 2元一个
                        details newDetail =new details();
                        newDetail.detailId = id;
                        newDetail.goodsId = 0;
                        newDetail.goodsName = "egg";
                        newDetail.orderId = this.orderId;
                        newDetail.quantity = quantity;
                        newDetail.detailAoumt = 2 * quantity;
                        //新增数据项，并上传数据库
                        db.details.Add(newDetail);
                        db.SaveChanges();
                        //然后再更新数据库 service部分 就是总金额
                        
                        var odetails= db.details.Where(s => s.orderId == this.orderId).ToList();
                        double? sum = 0;
                        for(int i = 0; i < odetails.Count(); i++)
                        {
                            sum += odetails[i].detailAoumt;
                        }
                        //求出sum了，将其赋值个对应order
                        var order = db.orderservice.Where(s => s.orderId == this.orderId).FirstOrDefault();
                        order.orderAmount = sum;
                        db.SaveChanges();//更新数据库
                        //
                        MessageBox.Show("添加成功！");
                        //更新显示表
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = db.details.Where(s => s.orderId == this.orderId).ToList();
                    }
                    //添加梨
                    if (addGoodsComboBox.Text == "pear")
                    {
                        //说明新增的是鸡蛋 2元一个
                        details newDetail = new details();
                        newDetail.detailId = id;
                        newDetail.goodsId = 1;
                        newDetail.goodsName = "pear";
                        newDetail.orderId = this.orderId;
                        newDetail.quantity = quantity;
                        newDetail.detailAoumt = 20 * quantity;
                        //新增数据项，并上传数据库
                        db.details.Add(newDetail);
                        db.SaveChanges();
                        //然后再更新数据库 service部分 就是总金额

                        var odetails = db.details.Where(s => s.orderId == this.orderId).ToList();
                        double? sum = 0;
                        for (int i = 0; i < odetails.Count(); i++)
                        {
                            sum += odetails[i].detailAoumt;
                        }
                        //求出sum了，将其赋值个对应order
                        var order = db.orderservice.Where(s => s.orderId == this.orderId).FirstOrDefault();
                        order.orderAmount = sum;
                        db.SaveChanges();//更新数据库
                        //
                        MessageBox.Show("添加成功！");
                        //更新显示表
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = db.details.Where(s => s.orderId == this.orderId).ToList();
                    }

                }
                else
                {
                    //存在该id
                    MessageBox.Show("存在该ID的明细！");


                }

            }

        }

        private void deleteDetailButton_Click(object sender, EventArgs e)
        {
            if (isNum(deleteDetailIdTextBox.Text))
            {
                int ID = Convert.ToInt32(deleteDetailIdTextBox.Text);
                //接着判断该ID是否存在
                using(homework8Entities1 db=new homework8Entities1())
                {
                    //连接数据库 查询该id下的订单明细
                    var result= db.details.Where(s => s.orderId == this.orderId && s.detailId == ID);
                    if (result.Count() == 0)
                    {
                        MessageBox.Show("不存在该id的订单明细！");
                    }
                    else
                    {
                        //
                        details deleteDetails = result.FirstOrDefault();
                        db.details.Remove(deleteDetails);
                        db.SaveChanges();
                        //然后再更新数据库 service部分 就是总金额

                        var odetails = db.details.Where(s => s.orderId == this.orderId).ToList();
                        double? sum = 0;
                        for (int i = 0; i < odetails.Count(); i++)
                        {
                            sum += odetails[i].detailAoumt;
                        }
                        //求出sum了，将其赋值个对应order
                        var order = db.orderservice.Where(s => s.orderId == this.orderId).FirstOrDefault();
                        order.orderAmount = sum;
                        db.SaveChanges();//更新数据库
                        //
                        //更新显示表
                        dataGridView1.DataSource = null;
                        dataGridView1.DataSource = db.details.Where(s => s.orderId == this.orderId).ToList();
                        MessageBox.Show("删除成功！");
                    }
                }

            }
            else
            {
                MessageBox.Show("您输入的删除订单的ID值不合法！");
            }
        }
    }
}
