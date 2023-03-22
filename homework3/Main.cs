using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework3
{
    public class Program
    {
        //Main函数
        public static void Main()
        {
            try
            {
                //使用工厂模式创建对象，代码可以不依赖于具体类
                List<Shape> shapes = new List<Shape>();
                for (int i = 0; i < 10; i++)
                {
                    shapes.Add(Shapefactory.CreateRandomShape());
                }

                //使用多态，调用各个对象的Info和Area属性
                shapes.ForEach(s =>
                  Console.WriteLine($"{s.Info}, area={s.Area}"));

                double total = shapes.Sum(s => s.Area);
                Console.WriteLine($"total={total}");

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
