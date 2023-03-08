using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class program1
    {
       //求指定数的所有素数因子的函数
      public static List<int> findfactor(int data)
        {
            List<int> list = new List<int>();
            int iniData = data;
            //用连除法来求素数因子
            for(int i=2; i*i <= iniData; i++)
            {
                while (data % i == 0)
                {
                    //表明此时i为data的素数因子
                    list.Add(i);
                    data /= i;
                }
            } 
            
            return list;
        } 

        //main函数
        public static void Main()
        {
            string sData;
            int numberData;
            List<int> list = new List<int>();
            //从控制台获得输入的数据
            Console.WriteLine("请输入要求素数因子的数据");
            sData=Console.ReadLine();
            numberData = int.Parse(sData);
           list= findfactor(numberData);
           //输出list数组的所有函数
           for(int i=0; i<list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

        }



    }



}
