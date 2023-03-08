using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class program3
    {
        //返回一个数组，里面是从2到100的所有素数
       public static List<int> factor()
        {
            List<int> result = new List<int>();
            int[] isFactor=new int[101];
            for(int i = 0; i < 101; i++)
            {
                isFactor[i] = 1;
            }
            isFactor[0] = 0;
            isFactor[1] = 0;
            for (int i = 2; i*i <= 100; i++)
            {
                for(int j = 1; i*j<=100; j++)
                {
                    isFactor[i*j] = 0;
                }
            }

            for(int k = 2; k <= 100; k++)
            {
                if(isFactor[k] == 1)result.Add(k);
            }
            return result;

        } 

        //Main函数
        public  static void Main()
        {
           List<int>list=new List<int>();
            list=factor();
            for(int i = 0; i < list.Count; i++) 
                Console.WriteLine(list[i]);
        }


    }
}
