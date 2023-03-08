using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework2
{
   class program2
    {
        //求数组的最大值
        public static int findMax(int []data,int n)
        {
            if (n <= 0) throw new ArgumentException("请输入合法数据");
            int max=data[0];
            for (int i = 1; i < n; i++)
            {
                if (data[i] > max)  
                    max = data[i];
            }
            return max;
        }
        //求数组的最小值
        public static int findMin(int[]data,int n)
        {   if (n <= 0) throw new ArgumentException("请输入合法数据");
            int min=data[0];        
            for(int i = 1; i < n; i++)  
                if (data[i] < min)
                    min = data[i];
            return min;

        }
        //求数组的平均值
        public static int findAva(int []data,int n)
        {
            if (n <= 0) throw new ArgumentException("请输入合法数据");
            int sum = 0;
            for(int i = 1; i < n; i++)
                sum= sum + data[i];
            return sum / n;
        }

        //求数组的和
        public static int findSum(int []data,int n)
        {
            if (n <= 0) throw new ArgumentException();
            int sum = 0;
            for( int i = 1; i < n; i++)
                sum = sum + data[i];
            return sum ;
        }

    }
}
