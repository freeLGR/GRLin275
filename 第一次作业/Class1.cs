using System;

class HelloWorld
{
    public static void Main() {
        string SNumber1;
        string SNumber2;
        string SOperator;
        double Number1;
        double Number2;
        double Result;
        Console.WriteLine("请输入运算符号（add,sub,mutiply,div）；");
        SOperator = Console.ReadLine();

        Console.WriteLine("请输入第一个操作数");
        SNumber1 = Console.ReadLine();
        Number1 = double.Parse(SNumber1);
        Console.WriteLine("请输入第二个操作数");
        SNumber2 = Console.ReadLine();
        Number2 = double.Parse(SNumber2);
     
         if(SOperator == "add")
        { Result = Number2 + Number1;
            Console.WriteLine("运算结果是"+Result);
        }

        if (SOperator == "sub")
        {
            Result = Number2 - Number1;
            Console.WriteLine("运算结果是" + Result);
        }

        if (SOperator == "mutiply")
        {
            Result = Number2 * Number1;
            Console.WriteLine("运算结果是" + Result);
        }

        if (SOperator == "div")
        {
            Result = Number2 / Number1;
            Console.WriteLine("运算结果是" + Result);
        }

    }

}
