using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Order
    {

        //字段 ：id details数组 顾客
        int id;
        List<OrderDetails> details;//用来存储订单明细
        Customer customer;

        //属性
        public int OrderId { get { return id; } }
        public double OrderAmount { get { double sum = 0;for (int i = 0; i < details.Count; i++) sum += details[i].Amount;return sum; } } 
       public List<OrderDetails> Details { get { return details; } }
        public string CustomerName { get { return customer.Name; } }
        public Customer customers { get { return customer; } }
        //构造函数
        public Order(int id,Customer customer)
        {
            this.id = id;   
            this.customer=customer;
            details = new List<OrderDetails>();
        }

        
        //添加订单明细
        public bool AddDetail(OrderDetails addDetails)
        {
            try
            {
                //先判断该订单是否存在
                for (int i = 0; i < details.Count; i++)
                {
                    if (details[i].DetailsId == addDetails.DetailsId) throw new Exception("该Id已经存在，请输入新的Id");
                }
                //不存在，添加System.Exception:“该Id已经存在，请输入新的Id”
                details.Add(addDetails);
                return true;
            }
            catch (Exception ex) { 
            MessageBox.Show(ex.Message);
                return false;
            }
        }


        //删除订单明细
        //先找到对应ID的索引，若有，将其删除，若无，无事发生
        public bool DeleteDetail(int DetailId)
        {
            for(int i=0; i < details.Count; i++)
            {
                if(details[i].DetailsId == DetailId) { details.RemoveAt(i); MessageBox.Show("删除成功！"); return true ; }
            }
            MessageBox.Show("不存在该ID的订单！");
           return false;
        }

        //重写Equal函数
        public override bool Equals(object? obj)
        {
            var other = obj as Order;
            if (other == null) return false;
            if (other.id == id) return true;
            return false;
        }

        //重写ToString函数
        public override string ToString()
        {
            string result;
            result = $"order id:{id}; customer{customer.ToString()} orderAmount:{OrderAmount}\n";
            for(int i = 0; i < details.Count; i++)
            {
                result +=$"明细{i}: ";
                result+=details[i].ToString();
                result += "\n";
            }
            return result;
        }

    }
}
