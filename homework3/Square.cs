using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Square:Shape
    {
        public double width { get; set; }

        //计算面积
        public double Area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("形状不正确，无法计算面积");
                return width * width;
            }

        }

        public Square(double width)
        {
            this.width = width;
        }

        public string Info => $"图形形状为正方形,其边长为{width}";

        //判断输入的参数是否合法性
        public bool IsValid()
        {
            if (width <= 0) return false;
            return true;
        }
    }
}
