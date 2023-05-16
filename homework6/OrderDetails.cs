using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class OrderDetails
    {   //字段
        private int id;
        private double quantity;
        private Goods good;

        //属性
        public int DetailsId { get { return id; }}
        public double Amount { get { return good.Price * quantity; }}

       
        public Goods goods { get { return good; }}

        public string GoodsName { get { return good.Name; }}
        public double Price { get { return good.Price; }}
        public double Quantity
        {
            get { return quantity; }
            set { if (value <= 0) throw new Exception("质量不能为负数");else quantity = value; }
        }

        //构造函数
        public OrderDetails(int id,double quantity,Goods good)
        {
            this.id = id;
            this.quantity = quantity;
            this.good = new Goods();
            this.good.Price = good.Price;
          
            this.good.Name = good.Name;
        }

        //equal方法，重写
        public override bool Equals(object obj)
        {
            var other = obj as OrderDetails;
            if(other == null) return false;
            if (this.id == other.DetailsId) return true;
            return false;
        }

        //tostring 方法重写
        public override string ToString()
        {
            return $"OrderdetailID:{id}; quantity:{quantity}; amount:{Amount}; good:'{good.ToString()}' ";
        }

        
    }
}
