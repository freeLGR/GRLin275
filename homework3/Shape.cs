using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
     public interface  Shape
    {
        //图形的面积
        public double Area{ get; }
        //图形的形状信息
        public string Info { get; }

        //判断图形是否有效的函数
        public bool IsValid();

    }
}
