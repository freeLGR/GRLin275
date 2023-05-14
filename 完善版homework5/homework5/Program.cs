// See https://aka.ms/new-console-template for more information
using System;
namespace homework4
{
    public class Program
    {
        //控制台应用
        public static int Main(string[] args)
        {
            //固定客户 以及固定货物
            List<Customer> customers = new List<Customer>() { new Customer(0, "哈哈"),new Customer(1,"呵呵") };
            List<Goods> goods = new List<Goods>() { new Goods(0, 20, "梨"),new Goods(1, 25, "苹果") };
            //实例化一个OrderService对象
            OrderService orderService = new OrderService();
            //实例一个订单明细
            OrderDetails orderDetails1 = new OrderDetails(0, 250, goods[1]);
            //实现一个订单 将上诉明细添加到订单里面
            Order order1 = new Order(1, customers[0]);
            order1.AddDetail(orderDetails1);
            //将订单添加到订单服务里面
            orderService.AddOrder(order1);

            //死循环
            while (true)
            {
                //进行选择
                int choice = 0;
                //主菜单
                Console.WriteLine("=======请输选择你所进行的操作：========");
                Console.WriteLine(" 1.查看所有订单");
                Console.WriteLine(" 2.添加某个订单");
                Console.WriteLine(" 3.删除一个订单");
                Console.WriteLine(" 4.查看某个订单（序号索引）的明细");
                Console.WriteLine(" 5.在某个订单（序号索引）中，添加一个明细");
                Console.WriteLine(" 6.在某个订单中（序号索引）中，删除一个明细");
                Console.WriteLine(" 7.查询订单金额大于等于X的所有订单");
                Console.WriteLine(" 8.查询订单金额小于X的所有订单");
                Console.WriteLine(" 9.查询对应客户ID的订单");
                Console.WriteLine(" 10.将订单号按照从小到大并输出");
                Console.WriteLine(" 11.按照订单的总金额从小到大进行输出");
                Console.WriteLine(" 12.退出程序");
                choice= Convert.ToInt32(Console.ReadLine()) ;
                //switch语句
                switch (choice)
                {
                    //查看所有订单的信息
                    case 1:orderService.DispOrders();break;
                    
                    //添加订单
                    case 2://此时实现的是，添加订单  OrderID 选择客户
                        Console.WriteLine("===============添加订单===============");
                        Console.WriteLine("本次实现的是，创建一个空订单，只包含客户和订单ID；");
                        //输出客户信息
                        for(int i=0;i<customers.Count;i++)Console.WriteLine(customers[i].ToString());
                        Console.WriteLine("请选择客户序号：");
                        int customerChoice;
                        customerChoice = Convert.ToInt32(Console.ReadLine()) ;  
                     
                        //输入订单ID
                        Console.WriteLine("请输入订单ID");
                        int orderId;
                        orderId = Convert.ToInt32(Console.ReadLine()) ;
                        while (true)
                        {   
                            if (orderService.AddOrder(new Order(orderId, customers[customerChoice]))) break; ;
                            Console.WriteLine("该订单ID重复，请重新输入一个");
                            orderId = Convert.ToInt32(Console.ReadLine());
                        }
                        break;

                    //情况3 删除某个订单，以ID为目标
                    case 3:
                        Console.WriteLine("=============删除订单==============");
                        Console.WriteLine("请输入你想要删除的订单的序号:");
                        int deleteOrderId=Convert.ToInt32(Console.ReadLine()) ;
                        orderService.DeleteOrder(deleteOrderId);
                        break;

                     //情况4 查看某个订单的明细
                    case 4:
                        Console.WriteLine("============查看订单明细=============");
                        Console.WriteLine(" 请输入你所要查看的订单的ID:");
                        orderId=Convert.ToInt32(Console.ReadLine()) ;
                        bool isExist = false;
                        int orderIndex = 0;
                        for( orderIndex = 0; orderIndex < orderService.orders.Count; orderIndex++)
                        {
                            if (orderService.orders[orderIndex].Id == orderId) { isExist = true; break; }
                        }
                        //如果该ID存在，输出明细
                        if (isExist)
                        {
                            Console.WriteLine(orderService.orders[orderIndex].ToString());
                        }
                        else
                        {
                            Console.WriteLine("不存在ID为此的订单");
                        }

                        Console.WriteLine("====================================");
                        break;


                    //在某个订单中，添加一个明细
                    case 5:
                        Console.WriteLine("============添加订单明细=============");
                        Console.WriteLine(" 请输入你所要添加的订单的ID:");
                        orderId = Convert.ToInt32(Console.ReadLine());
                        isExist = false;
                        orderIndex = 0;
                        for (orderIndex = 0; orderIndex < orderService.orders.Count; orderIndex++)
                        {
                            if (orderService.orders[orderIndex].Id == orderId) { isExist = true; break; }
                        }
                        //如果该ID存在，在该订单中添加明细
                        if (isExist)
                        {
                            //先输出该订单原有的明细
                            Console.WriteLine("以下是该订单现有的明细:");
                            Console.WriteLine(orderService.orders[orderIndex].ToString());
                            Console.WriteLine("==============================");
                            //依次选择新添明细的 货物 总量 ID
                            //货物选择
                            for(int i=0;i<goods.Count;i++)Console.WriteLine(goods[i].ToString());
                            Console.WriteLine("上面是可供添加的货物选择，请选择您想要的货物:");
                            int goodsChoice = 0;
                            goodsChoice=Convert.ToInt32(Console.ReadLine());
                            while (true)
                            {
                                if (goodsChoice <= 1) break;
                                else
                                {
                                    Console.WriteLine("您输入的序号不合法！请重新输入:");
                                    goodsChoice=Convert.ToInt32(Console.ReadLine());
                                }
                            }

                            //总量选择
                            double Quantity;
                            Console.WriteLine("请输入货物所所对应的质量:");
                            Quantity = Convert.ToDouble(Console.ReadLine());
                            //请输入订单明细的ID
                            Console.WriteLine("请输入新创建的明细的Id");
                            int detailId=Convert.ToInt32(Console.ReadLine());

                            //订单明细选择
                            if (orderService.orders[orderIndex].AddDetail(new OrderDetails(detailId, Quantity, goods[goodsChoice])))
                                Console.WriteLine("添加成功");
                            else Console.WriteLine("由于输入的订单号重复，添加失败!");
                        }
                        else
                        {
                            Console.WriteLine("不存在ID为此的订单");
                        }

                        Console.WriteLine("====================================");
                        break;

                    //情况6 
                    case 6:
                        Console.WriteLine("===============删除明细==============");
                        Console.WriteLine(" 请输入你所要添加的订单的ID:");
                        orderId = Convert.ToInt32(Console.ReadLine());
                        isExist = false;
                        orderIndex = 0;
                        for (orderIndex = 0; orderIndex < orderService.orders.Count; orderIndex++)
                        {
                            if (orderService.orders[orderIndex].Id == orderId) { isExist = true; break; }
                        }
                        //如果该ID存在，在该订单中添加明细
                        if (isExist)
                        {
                            //先输出该订单原有的明细
                            Console.WriteLine("以下是该订单现有的明细:");
                            Console.WriteLine(orderService.orders[orderIndex].ToString());
                            Console.WriteLine("==============================");
                            Console.WriteLine("请输入您想要删除的订单明细序号：");
                            int deleteDetail=Convert.ToInt32(Console.ReadLine());
                            if (orderService.orders[orderIndex].DeleteDetail(deleteDetail))
                                Console.WriteLine("删除成功！");
                            else Console.WriteLine("不存在您输入的明细序号!");
                            Console.WriteLine("============================");
                        }
                        else
                        {
                            Console.WriteLine("不存在ID为此的订单");
                            Console.WriteLine("============================");
                        }


                        break;

                    //情况7 查询订单金额大于X的所有订单
                    case 7:
                        Console.WriteLine("==============查询订单金额大于X的所有订单=============");
                        Console.WriteLine("请输入边界金额!");
                        double boardAmount=Convert.ToDouble(Console.ReadLine());
                        List<Order> reslut=orderService.AmountGreatEqual(boardAmount);
                        if (reslut.Count == 0) Console.WriteLine("没有符合条件的订单！");
                        else
                        {
                            Console.WriteLine("下面是满足条件的订单!");
                            for (int i = 0; i < reslut.Count; i++)
                            {
                                Console.WriteLine(reslut[i].ToString());
                            }
                        }

                        break;


                    //情况8 查询订单金额小于X的所有订单；
                    case 8:
                        Console.WriteLine("=============查询订单金额小于X的所有订单=============");
                        Console.WriteLine("请输入边界金额：");
                        boardAmount=Convert.ToDouble(Console.ReadLine());
                         reslut = orderService.AmountLess(boardAmount);
                        if (reslut.Count == 0) Console.WriteLine("没有符合条件的订单！");
                        else
                        {
                            Console.WriteLine("下面是满足条件的订单!");
                            for (int i = 0; i < reslut.Count; i++)
                            {
                                Console.WriteLine(reslut[i].ToString());
                            }
                        }
                        break;

                    //情况9 查询客户ID对应的订单
                    case 9:
                        Console.WriteLine("===========查询客户ID对应的订单===========");
                        Console.WriteLine("请输入客户ID");
                        int customerId = Convert.ToInt32(Console.ReadLine());
                        reslut = orderService.QueryByCustomerId(customerId);
                        if (reslut.Count == 0) Console.WriteLine("没有符合条件的订单！");
                        else
                        {
                            Console.WriteLine("下面是满足条件的订单:");
                            for (int i = 0; i < reslut.Count; i++)
                            {
                                Console.WriteLine(reslut[i].ToString());
                            }
                        }
                        break;

                    case 10:
                        Console.WriteLine("========将订单号按照从小到大排序并输出=========");
                        orderService.SortByID();
                        orderService.DispOrders();
                        break;

                    case 11:
                        Console.WriteLine("=========按照订单的总金额从小到大并进行输出=========");
                        orderService.SortByAmount();
                        orderService.DispOrders();
                        break;
                    case 12:
                        Console.WriteLine("退出成功!");
                        return 1;

                }

            }


            return 0;
        }




        //测试功能时，用的main函数
        //public static int Main(string[] args)
        //{
        //    Goods good = new Goods(1,1.1,"a");
        //    Console.WriteLine(good.Id);
        //    Console.WriteLine(good.Name);
        //    Console.WriteLine(good.Price);
        //    Console.WriteLine(good.ToString());
        //    Console.WriteLine("================");
        //    //实例orderdetail
        //    OrderDetails orderDetail = new OrderDetails(1, 20.0, good);
        //    OrderDetails orderDetail2 = new OrderDetails(2, 30, good);
        //    Console.WriteLine(orderDetail.ToString());
        //    Console.WriteLine("=====================");
        //    //实例Custormer
        //    Customer customer = new Customer(1, "hahahahahaha");
        //    Console.WriteLine(customer.ToString());
        //    Console.WriteLine("======================");
        //    //实例化Order
        //    Order order = new Order(1, customer);
        //    order.AddDetail(orderDetail);
        //    order.AddDetail(orderDetail2);
        //    Console.WriteLine(order.ToString());
        //    Console.WriteLine("====================");
            
        //    Order order1 = new Order(2, customer);

        //    //实例化OrderService
        //    OrderService orderService = new OrderService();
        //    orderService.AddOrder(order1);
        //    orderService.AddOrder(order);
        //    orderService.DispOrders();
        //    Console.WriteLine("======================");
        //    //练习linq语句
        //    List<int> nums = new List<int> { 1, 2, 3, 4, 5, 6, };
        //    List<int> evenNums = (from num in nums
        //                          where num % 2 == 0 && num % 3 == 0
        //                          select num).ToList();
        //    for(int i = 0; i < evenNums.Count; i++)
        //    {
        //        Console.WriteLine(evenNums[i]);
        //    }
        //    Console.WriteLine("===============================");

        //    //测试查询语句
        //    //Id

        //    Order queryOrder= orderService.QueryById(1);
        //    Console.WriteLine(queryOrder.ToString());
        //    //钱大于等于
        //    List <Order> AmountGE= orderService.AmountGreatEqual(0);
        //    for(int i = 0; i < AmountGE.Count; i++)
        //    {
        //        Console.WriteLine(AmountGE[i].ToString());
        //    }

        //    Console.WriteLine("=============================");
        //    //客户ID为
        //    List<Order> CustomerID = orderService.QueryByCustomerId(0);
        //    for(int i=0;i<CustomerID.Count; i++)
        //    {
        //        Console.WriteLine(CustomerID[i].ToString());
        //    }
        //    Console.WriteLine("============================");
        //    //测试排序 以订单号从小到大
        //    List<Order> sortOrder = orderService.SortByID();
        //    for(int j = 0; j < sortOrder.Count; j++)
        //    {
        //        Console.WriteLine(sortOrder[j].ToString());
        //    }

        //    Console.WriteLine("=============================");

        //    //测试排序 以订单总金额从小到大进行排序
        //    List<Order> sortByAmount = orderService.SortByAmount();
        //    for(int j = 0; j < sortByAmount.Count; j++)
        //    {
        //       Console.WriteLine(sortByAmount[j].ToString());
        //    }

        //    return 0;
        //}

        
    }

}


