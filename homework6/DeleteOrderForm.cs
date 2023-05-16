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
    public partial class DeleteOrderForm : Form
    {
        public event Action<int> DeleteOrder;

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

        public DeleteOrderForm()
        {
            InitializeComponent();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            if (isNum(deleteOrderIdtextBox.Text))
            {
                DeleteOrder(Convert.ToInt32(deleteOrderIdtextBox.Text));
                this.Close();
            }
            else
            {
                MessageBox.Show("请输入整数!");
            }

        }
    }
}
