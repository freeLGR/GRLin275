using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Triangular:Shape
    {
        //三角形的三条边
        double edge1;
        double edge2;
        double edge3;
     
        
        public string Info=> $"形状为三角形,a={edge1},b={edge2},c={edge3}"; 
        public Triangular(double edge1, double edge2, double edge3)
        {
            this.edge1 = edge1; this.edge2 = edge2; this.edge3 = edge3;//初始化三条边

        }

    
        //判断形状是否合理
        public bool IsValid()
        {
            if (edge1 <= 0 || edge2 <= 0 || edge3 <= 0) return false;
            return true;
        }

        //计算面积
        public double Area
        {
            get
            {
                if (!IsValid()) throw new InvalidOperationException("形状错误，无法计算面积");
                double p = (edge1 + edge2 + edge3) / 2;
                return Math.Sqrt(p * (p - edge1) * (p - edge2) * (p - edge3));
            }
        }
    }
}
