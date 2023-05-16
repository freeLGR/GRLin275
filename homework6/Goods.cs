using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    //这个类是描述货物的类
    public class Goods
    {
       private int id;
       private string name;
        double price;
        //属性
        public int Id { get { return id; }  }
        public string Name { get { return name; } set { name = value; } }
        public double Price { get { return price; } set { if (value < 0) { throw new Exception("单价不能为负数"); } else price = value; } }

        public Goods() { }
        public Goods(int id, double price,string name)
        {
            this.id= id;
            this.price = price;
            this.name = name;
        }

        //重写Tostring方法
        public override string ToString()
        {
            return $"goods id:{id}; name:{name}; price:{price} ";
        }
        
    }
}
