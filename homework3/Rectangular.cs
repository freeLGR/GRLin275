using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Rectangular:Shape
    {

        public double width { get; set; }//宽
        public double height { get; set; }//长

        //构造函数
        public Rectangular(double height, double width)
        {
            this.height = height;
            this.width = width;
        }



        //面积Area属性
        public double Area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("形状不正确，不能计算面积");
                return width * height;
            }
        }


        public bool IsValid()
        {
            if (width <= 0 || height <= 0) return false;
            return true;
        }

        public string Info => $"该图形为矩形，长为{height}宽为{width}";
    }
}
