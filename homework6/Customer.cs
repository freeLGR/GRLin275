using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    public class Customer
    {
        //字段
        int id;
        string name;

        //属性
        public int Id { get { return id; } }
        public string Name { get { return name; } set { name = value; } }

        //构造函数
        public Customer(int id,string name)
        {
           this.id = id;
            this.name = name;
        }

        //重写toString 函数
        public override string ToString()
        {
            return $"Customer id:{id}; name:{name} ";
        }

    }
}
