using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework4
{    
     //节点类
    public class Node<T>
        {
            public T Data { get; set; }//每个节点存储的值
            public Node<T> Next { get; set; }//下一个节点
            public Node(T t)
            {
                Data = t;
                Next = null;
            }
        }
  
    

        //泛型链表类
        public class GenercList<T> { 
            private Node<T> head;
            private Node<T> tail;

            public GenercList()
            {
                tail = head = null;
            }

            public Node<T> Head { get { return head; } }

            public void Add(T t)
            {
                Node<T> n= new Node<T>(t);
                if(head == null)
                {
                    head =tail= n;
                }
                else
                {
                    tail.Next = n;
                    tail = n;
                }
            }
           

            public void ForEach(Action<T> action)
            {
               Node<T> node = head;//node指向头节点
                //遍历所有的节点，对其中的node的数据进行赋值
                while(node != null)
                {
                    action(node.Data);
                    node = node.Next;
                }
        }



    }



    //    //Main（)类
    //    public class Program { 
    //    //Main()方法
    //    public static void Main()
    //        {   //创建一个链表，其存放的数据为1，2，3，4
    //            GenercList<int> list = new GenercList<int>();
    //            list.Add(1);
    //            list.Add(5);
    //            list.Add(4);
    //            list.Add(9);
    //            //接着，将调用其ForEach函数，大英每一个值
    //            list.ForEach((a) => { Console.WriteLine(a); });
    //            //lambda表达式可以调用局部变量
    //            int sum = 0;
    //            int min = list.Head.Data;
    //            int max = list.Head.Data;
    //            list.ForEach((a) =>
    //            {
    //                min = (min < a) ? min : a;//改变最小值
    //                max = (max > a) ? max : a;//改变最大值
    //                sum += a;
    //            });


    //                Console.WriteLine($"max：{max} min:{min} sum：{sum}");
    //        }


    //    }


}
