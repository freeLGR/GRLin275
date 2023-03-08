using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
    class program4
    {
        //判断一个矩阵是不是托普利茨矩阵
        public static bool isPrime(int[][] data, int n, int m)
        {
            for (int i = 0; i < m; i++)
            {
                int temp = data[0][i];
                int k = 1;
                while (i + k < m && k < n)
                {
                    if(data[i+k][k]!=temp)return false;
                    k++;
                }
            }

            return true;
        }

        public static void Main()
        {
            int[][] data = new int[3][];
            for (int i = 0; i < data.Length; i++)
                data[i] = new int[3];  
            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    data[i][j] = 0;
                }
            }
            if (isPrime(data, 3, 3))
            {
                Console.WriteLine("是符合的数组");
            }
        }

    }
}
