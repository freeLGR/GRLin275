using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework6
{
    //订单服务类用来管理所有的订单
    public class OrderService
    {
        //订单数组
        public List<Order> orders;//用来存储所有的订单

      
        //构造函数
        public OrderService()
        {
            orders = new List<Order>();
        }
        //添加订单
        public void AddOrder(Order order)
        {
            try
            {  //先判断是否存在订单序号相同的订单
                for (int i = 0; i < orders.Count; i++)
                {
                    if (orders[i].OrderId == order.OrderId) { throw new Exception("存在ID相同的订单"); }
                }
                orders.Add(order);
                return ;
                //均不同，则加
            }
            catch (Exception ex)
            {
                Console.WriteLine("存在ID相同的订单");
                return ;
            }
           
           
        }

        //删除订单 :根据订单序号ID
        public void DeleteOrder(int orderID)
        {
            for(int i = 0; i < orders.Count; i++)
            {
                if(orders[i].OrderId == orderID) { orders.RemoveAt(i);MessageBox.Show("删除成功!"); return; }
                MessageBox.Show("不存在该ID号的订单!");
            }
        }
        
        //修改订单 思路：判断ID，将原有的删除，赋值给新的
        public void UpdataOrder(Order UpdataOrder)
        {
            //判断原新的序号里面是否有对应的i，有则替换
            for(int i=0; i < orders.Count; i++)
            {
                if (orders[i].OrderId == UpdataOrder.OrderId)
                {
                    orders.RemoveAt(i);
                    orders.Insert(i, UpdataOrder);
                }
            }
            //若没有，则添加
            orders.Add(UpdataOrder);
        }


        //显示所有的订单
       public void DispOrders()
        {
            Console.WriteLine("订单");
            for(int i = 0; i < orders.Count; i++)
            {
                string result = $"订单{i + 1}:";
                Console.WriteLine(result);
                Console.WriteLine(orders[i].ToString());
            }
        }

        //查询方法 ID 订单金额大于等于多少 订单金额小于多少 用户名
        //orderID查询
        public Order QueryById(int id)
        {
            var temp = from order in orders
                         where order.OrderId == id
                         select order;
            foreach (Order order in temp)
            {
                return order;
            }
            return null;
        }

        //查询订单金额大于等于x
        public List<Order> AmountGreatEqual(double x)
        {
            return (from order in orders
                    where order.OrderAmount>=x
                    select order).ToList();
                    
        }

        //查询金额少于
        public List<Order> AmountLess(double x)
        {
            return(from order in orders
                   where (order.OrderAmount<x)
                   select order).ToList();
        }

        //查询按客户ID进行查询
        public List<Order> QueryByCustomerId(int id)
        {
            return (from order in orders
                    where order.customers.Id == id
                    select order).ToList();
        }

        //排序按照订单号进行排序
        public List<Order> SortByID()
        {
            int n=orders.Count;
            //使用冒泡排序对序号进行排序
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < n - 1 - i; j++)
                {
                    if (orders[j].OrderId > orders[j + 1].OrderId)
                    {
                        Order temp= orders[j];
                        orders[j] = orders[j + 1];  
                        orders[j + 1] = temp;
                    }
                }
            }

            return orders;
        }

        //排序按照订单的金额从大到小进行排序
        public List<Order> SortByAmount()
        {

            int n = orders.Count;
            //使用冒泡排序对序号进行排序
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (orders[j].OrderAmount < orders[j + 1].OrderAmount)
                    {
                        Order temp = orders[j];
                        orders[j] = orders[j + 1];
                        orders[j + 1] = temp;
                    }
                }
            }

            return orders;
        }


    }
}

   

