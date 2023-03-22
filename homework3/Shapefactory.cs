using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Shapefactory
    {
        //构造一个枚举类型
        public enum ShapeType { Square,Rectangular ,Triangular };
        public static readonly int[] edgeNumber = { 1, 2, 3 };
        public static readonly Random random = new Random();    

        //创建一个图形类
        public static Shape CreateShape(ShapeType type, double[] edges)
        {

            Shape result;
            if (edges == null) throw new ArgumentNullException("没有传入边的长度");
            if (edges.Length <= edgeNumber[(int)type]) throw new ArgumentException("传入的边的数目小于所需要的边的数目");
            //接着利用传入的边的数目来创建
            //如果为正方形
            if (type == ShapeType.Square)
            {
                //创建正方形实例
                result= new Square(edges[0]);
            }else if (type == ShapeType.Rectangular)
            {
                //如果为长方形
                result=new Rectangular(edges[0],edges[1]);  
            }
            else
            {
                result=new Triangular(edges[0],edges[1],edges[2]);  
            }
            return result;

        }

        //用来创建一个随机的图形
        public static Shape CreateRandomShape()
        {
            int index = random.Next(0, 2);
           
            double[] edges = new double[edgeNumber[index]];

            Shape result = null; ;
            do
            {
                try
                {
                    for (int i = 0; i < edgeNumber[index]; i++)
                    {
                        edges[i] = random.Next(200);
                    }
                    result = CreateShape((ShapeType)index, edges);
                }
                catch { }//忽略异常

            } while (result == null);

            return result;
        }
    }



}

