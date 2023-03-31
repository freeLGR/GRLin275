using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//闹钟类
public class Clock {
    //属性
    public int hour;
    public int minute;
    public int second;
    public int alarmHour;//响铃时间
    public int alarmMinute;
    public int alarmSecond;

    //委托类型
    public delegate void aTick();
    public delegate void aAlarm();

    //事件 还未赋值
    public event aAlarm Alarm;
    public event aTick Tick;

    //构造函数
    public Clock(int hour, int minnite, int second) {
        this.hour = hour;
        this.minute = minnite;
        this.second = second;
        alarmSecond = 0;
        alarmMinute = 0;
        alarmHour = 0;
    }

    //无参构造函数
    public Clock() {
        hour = 0;
        minute = 0;
        second = 0;
        alarmHour = 0;
        alarmMinute = 0;
        alarmSecond = 0;
    }

    //IsTick函数 IsAlarm函数
    public void IsTick()
    {
        Console.WriteLine("da da da da da da");
    }

    public void IsAlarm() {
        Console.WriteLine("响铃啦！");
        
    }

    //设置响铃时间
    public bool SetAlarm(int hour, int minnite, int second) {
        //判断修改时间的合法性
        if (hour >= 24 || hour < 0 || minnite < 0 || minnite >= 60 || second < 0 || second >= 60) return false;
        alarmHour = hour;
        alarmMinute = minute;
        alarmSecond = second;
        return true;
}


    //判断时钟的时间是否合法
    public bool IsValid() {
        if (hour >= 24 || hour < 0 || minute < 0 || minute >= 60 || second < 0 || second >= 60) return false;
        return true;
    }

    //时钟运行
    public void Run()
    {
        if (hour == alarmHour && minute == alarmMinute && second == alarmSecond) {
            Alarm();
        }
        second ++;
        //将此时的时间合法化,此时前提时，之前的时间是合法
        if (second >= 60)
        {
            second = 0;
            minute += 1;
            if(minute >= 60)
            {
                minute = 0;
                hour++;
                if(hour >= 24)
                {
                    hour = 0;
                }
            }
        }
        //响铃事件触发
        Tick();

    }

}


//程序运行类Main()函数

public class Program {
    public static void Main(string[] args) { 
        Clock clock = new Clock();
        clock.Alarm += clock.IsAlarm;
        clock.Tick += clock.IsTick;
        while (true) { 
        clock.Run();
        Thread.Sleep(1000);
        }
    
    }

    private static void Clock_Tick()
    {
        throw new NotImplementedException();
    }
}
