# GRLin275
# homework1
实验要求：Write a console program that implements a calculator, which accepts two numbers and an operator as input,  and prints out the calculation result.
# WinFormsApp1
同样是第一次作业，只不过是，实现的是窗体应用
实验要求：Write a Windows Forms application that implements a calculator: Enter numbers in two textboxes, select the operator, click the “Calculate” button, then  the result of the calculation is displayed.
# homework2
实现内容:
(1)编写程序输出用户指定数据的所有素数因子。
(2)编程求一个整数数组的最大值、最小值、平均值和所有数组元素的和。
(3)用“埃氏筛法”求2~ 100以内的素数。2~ 100以内的数，先去掉2的倍数，再去掉3的倍数，再去掉4的倍数，以此类推...最后剩下的就是素数。
(4)如果矩阵上每一条由左上到右下的对角线上的元素都相同，那么这个矩阵是托普利茨矩阵 。给定一个 M x N 的矩阵，当且仅当它是托普利茨矩阵时返回 True。
# homework3
(1)编写面向对象程序实现长方形、正方形、三角形等形状的类。每个形状类都能计算面积、判断形状是否合法。 请尝试合理使用接口/抽象类、属性来实现。
(2)随机创建10个形状对象，计算这些对象的面积之和。 尝试使用简单工厂设计模式来创建对象。
# homework4
1、为示例中的泛型链表类添加类似于List<T>类的ForEach(Action<T> action)方法。通过调用这个方法打印链表元素，求最大值、最小值和求和（使用lambda表达式实现）。

 2、使用事件机制，模拟实现一个闹钟功能。闹钟可以有嘀嗒（Tick）事件和响铃（Alarm）两个事件。在闹钟走时时或者响铃时，在控制台显示提示信息。
# homework5
 写一个订单管理的控制台程序，能够实现添加订单、删除订单、修改订单、查询订单（按照订单号、商品名称、客户、订单金额等进行查询）功能。并对各个Public方法添加测试用例。

 提示：主要的类有Order（订单）、OrderDetails（订单明细），OrderService（订单服务），订单数据可以保存在OrderService中一个List中。在Program里面可以调用OrderService的方法完成各种订单操作。
 
要求：
（1）使用LINQ语言实现各种查询功能，查询结果按照订单总金额排序返回。
（2）在订单删除、修改失败时，能够产生异常并显示给客户错误信息。
（3）作业的订单和订单明细类需要重写Equals方法，确保添加的订单不重复，每个订单的订单明细不重复。
（4）订单、订单明细、客户、货物等类添加ToString方法，用来显示订单信息。
（5） OrderService提供排序方法对保存的订单进行排序。默认按照订单号排序，也可以使用Lambda表达式进行自定义排序。
# 完善版homework5
  实现的是homework5一样的要求，但就是更加完善了，比如，添加了操作成功和操作失败的提示，然后也添加了一些新的功能！使得功能更加完善，更加人性化，交互性更好了!
  
# homework6
  为订单管理的程序添加一个WinForm的界面。通过这个界面，调用OrderService的各个方法，实现创建订单、删除订单、修改订单、查询订单等功能。

 要求：
（1）WinForm的界面部分单独写一个项目，依赖于原来的项目。
（2）可以使用两个窗口。主窗口实现查询展示功能，以及放置各种功能按钮。新建/修改订单功能使用弹出窗口。
（3）注意窗口的布局，在窗口尺寸变化时，不出现错位挤压等情况。
（4）尽量通过数据绑定来实现功能。订单和订单明细各使用一个bindingsource，通过DataMember来实现主从对象绑定。

# homerwork7
  改进书上例子9-10的爬虫程序。
 （1）只爬取指定网站上的网页  
 （2）只有当爬取的是htm/html/aspx/php/jsp等网页时，才解析并爬取下一级URL。 
 （3）相对地址(test/page.html, ./test/page.html, ../test2/page2.html, /test3/page.html)转成完整地址进行爬取。
 （4） 尝试使用Winform来配置初始URL，启动爬虫，显示已经爬取的URL和错误的URL信息。




